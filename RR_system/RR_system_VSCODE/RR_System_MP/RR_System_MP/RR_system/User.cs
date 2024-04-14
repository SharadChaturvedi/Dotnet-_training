using System;
using System.Linq;
using System.Xml;

namespace RR_System_MP.RR_system
{
    public class User
    {
        static RR_systemEntities db = new RR_systemEntities();
        static Class_price cp = new Class_price();






        public static void CheckUserAndProceed()
        {
            Console.WriteLine("..........          Welcome To User Registration            ...........");

            Console.Write("-->Enter User ID: ");
            string userID = Console.ReadLine();

            // Check if user exists
            var existingUser = db.Userdetails.FirstOrDefault(u => u.userID == userID);

            if (existingUser != null)
            {
                Console.WriteLine(".....User already exists. Proceed for further process.....");
                checking(); // Call checking method directly if user exists
            }
            else
            {
                Console.WriteLine(".....User does not exist. Proceed for user Registration.....");
                RegisterUser();
                Console.WriteLine("User registered successfully. Proceed with------>");
                Ticket_Booking();
            }
        }








        public static void RegisterUser()
        {
            Console.WriteLine("-->Enter UserID");
            string userID = Console.ReadLine();

            Console.Write("-->Enter Password: ");
            string userPassword = Console.ReadLine();

            Console.Write("-->Enter Email: ");
            string userEmail = Console.ReadLine();

            var newUser = new Userdetail
            {
                userID = userID,
                userPassword = userPassword,
                userEmail = userEmail
            };

            db.Userdetails.Add(newUser);
            db.SaveChanges();

            Console.WriteLine("User registered successfully.");
        }







        public static void Ticket_Booking()
        {
            // Fetch train details from the database
            var trainDetails = db.Traindetails.ToList();
          

            // Display train details in tabular format
            Console.WriteLine("Train Details:");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("| Train ID | Train Name            | Departure City | Arrival City  | Status |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            foreach (var train in trainDetails)
            {
                Console.WriteLine($"| {train.Train_id,-9} | {train.Train_name,-20} | {train.City_of_Departure,-14} | {train.city_of_Arrival,-13} | {(train.Status_of_Train ? "Active" : "Inactive"),-6} |");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            // Prompt the user to enter the train ID for ticket booking
            Console.Write("Enter Train_Id(No.) for Ticket Booking: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the User ID: ");
            string U_ID = Console.ReadLine();


            Random Rn = new Random();

            Console.Write("Enter Class(1AC/2AC/SL): ");
            String CS = Console.ReadLine();
            Console.WriteLine($"Captcha=>{Rn.Next(10, 200)}");

            Console.Write("Enter the Given Captcha to Confirm The Ticket: ");
            int Rnd = Convert.ToInt32(Console.ReadLine());

           
            int T_id = Rnd + 69;

            var Booked = db.Traindetails.FirstOrDefault(Bid => Bid.Train_id == Id);
            var U_validate = db.Userdetails.FirstOrDefault(Ud => Ud.userID == U_ID);

            if (Booked != null && U_validate != null)
            {
                if (Booked.Status_of_Train == true)
                {
                    Ticket_Booking TB = new Ticket_Booking();
                    Console.Write("Enter Your Name: ");
                    string Name = Convert.ToString(Console.ReadLine() + "\n");




                    Console.Write("Enter Gender: ");
                    string Gn = Console.ReadLine() + "\n";

                    TB.Ticket_no = T_id;
                    TB.Train_id = Id;
                    TB.userID = U_ID;
                    TB.Class = CS;


                    db.Ticket_Booking.Add(TB);
                    db.SaveChanges();
                    Console.WriteLine(" YOUR TICKET HAS BEEN BOOKED SUCESSFULLY..............\n\n");

                    db.SeatAvl(Id, CS);

                    Random r = new Random();


                    var x = db.Class_price.FirstOrDefault(t => t.Train_no == Id);


                    Console.WriteLine("\t\t\t\t*Ticket Detail*\n\n");
                    Console.WriteLine($"Name:-->{Name}");
                    Console.WriteLine($"tGender:-->{Gn}");
                    Console.WriteLine($"Train_Id:-->{Id}\n");
                    Console.WriteLine($"Ticketno:-->{T_id}\n");
                    var clas = db.Seat_available.Where(t => t.Train_Id == Id);

                    if (x.Train_no == Id)
                    {
                        if (CS == "1AC")
                        {
                            Console.WriteLine($"TotalPrice:--> {x.C1AC}\n");
                        }
                        else if (CS == "2AC")
                        {
                            Console.WriteLine($"TotalPrice:--> {x.C2AC} \n");

                        }
                        else if (CS == "SL")
                        {
                            Console.WriteLine($"TotalPrice:--> {x.SL} \n");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Details\n");
                        }
                    }

                    Console.WriteLine($"PNR No:--> {r.Next(10000, 90000)} \n");
             }
                else
                {
                    Console.WriteLine("/n=>This train is not Active......Sorry Booking failed.");
                }
            }
            else
            {
                Console.WriteLine("\n\n\t\t\t\t INVALID DETAILS ........");
            }
        }





        public static void checking()
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Cancel Ticket");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Ticket_Booking();
                        break;
                    case "2":
                        Ticket_cancellation();
                        break;
                    case "3":
                        Console.WriteLine("Exiting booking options.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }






        public static void Ticket_cancellation()
        {
            Ticket_Cancellation Tc = new Ticket_Cancellation();
            Ticket_Booking tb = new Ticket_Booking();

            Console.WriteLine("Enter the Booking Id for Cancellation");
            Console.WriteLine("\t\t\t\t\t\t*Cancel Your Ticket*\n\n");
            Console.Write("Enter Train Id: ");
            int Id1 = Convert.ToInt32(Console.ReadLine() + "\n");
            Console.Write("Enter your Ticket_no: ");
            int Tn_1 = Convert.ToInt32(Console.ReadLine() + "\n");
            Random Rn = new Random();
            int a = Rn.Next(10000, 90000);
            String st = "Cancelled";

            var Cl_Ticket = db.Ticket_Booking.FirstOrDefault(Cd => Cd.Ticket_no == Tn_1);
            var Cl_Ticket1 = db.Ticket_Booking.FirstOrDefault(Cd1 => Cd1.Train_id == Id1);
            var Cl_Ticket2 = db.Ticket_Booking.Where(cd2 => cd2.Ticket_no == Tn_1).Select(t => t.Class).FirstOrDefault();

            if (Cl_Ticket1 != null && Cl_Ticket != null)
            {
                Tc.Cancellation_Id = a;
                Tc.Ticket_no = Tn_1;
                Tc.Train_id = Id1;
                Tc.C_status = st;
                db.Ticket_Cancellation.Add(Tc);

                // Calculate refund amount
                var ticketClass = Cl_Ticket2.ToUpper(); // Make sure class is in uppercase for comparison
                var classPrice = db.Class_price.FirstOrDefault(cp => cp.Train_no == Id1);

                int originalPrice = 0;
                switch (ticketClass)
                {
                    case "1AC":
                        originalPrice = (int)classPrice.C1AC;
                        break;
                    case "2AC":
                        originalPrice = (int)classPrice.C2AC;
                        break;
                    case "SL":
                        originalPrice = (int)classPrice.SL;
                        break;
                    default:
                        Console.WriteLine("Invalid class");
                        break;
                }

                int refundAmt = (int)(originalPrice * 0.7); // 30% less than the original price
                Tc.refundAmt = refundAmt;

                db.Ticket_Booking.Remove(Cl_Ticket1);

                db.SaveChanges();
                Console.WriteLine("\nTicket cancellation Sucessful...............");
                Console.WriteLine($"Refund Amount: {refundAmt}");

                db.Seatcancelled(Id1, Cl_Ticket2);
            }
            else
            {
                Console.Write("Invalid Details...............");
            }



        }

    }
}

using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*Create a class called Books with BookName and AuthorName as members.
 * Instantiate the class through constructor and also write a method Display() to display the details. 
 Create an Indexer of Books Object to store 5 books in a class called BookShelf. Using the indexer method assign values to the books and display the same.
Hint(use Aggregation/composition)*/

    public class Books
    {
        public string BookName;
        public string AuthorName;

        //creating constructors 
        public Books(string bookName, string AuthorName)
        {
            this.BookName = bookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine($"The name of the Book is: ---> {BookName} ");
            Console.WriteLine($" The name of the Author is:---> {AuthorName}");
            Console.ReadLine();
        }
    }
    class Bookself
    {

        //public void Addbook(Books book, int index)
        //{ }
             private Books[] books = new Books[5];

        public Books this[int index] //this[int index] allows accessing ind books in bs. array
        {                             //by index 
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    return books[index];
                }
                else
                {
                    Console.WriteLine("Index is out of range.");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
                else
                {
                    Console.WriteLine("Index is out of range.");
                    //    if ( index >= 0 && index < books.Length)
                    //    {
                    //        books[index] = book;
                    //    }
                    //     else
                    //    {
                    //        Console.WriteLine(" Index is out of range ");
                    //    }
                }
            }
        }
        class BookDets
        {
          public   static void Main(string[] args)
            {
                
                
                 Bookself bf = new Bookself();
                for (int i = 0; i < 5; i++)
                {


                    Console.WriteLine(" Enter the "+(i+1)+" Book Name : --->");
                    string bookName = Console.ReadLine();

                    Console.WriteLine(" Enter the  Author Name :");
                    string authorName = Console.ReadLine();

                    //creating a new book object with user input and assign  it to the bookself 
                    bf[i] = new Books(bookName, authorName);
                }
                for (int i = 0;i < 5; i++)
                {
                    Console.WriteLine("Details of Books" + (i+1) + "---->");
                    bf[i].Display();
                    Console.WriteLine();


                }
                // Books b1 = new Books(bookName, authorName);
                
                Console.ReadLine();
           }
        }
     }
  }





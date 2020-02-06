using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2._1
{
    class Program
    {
        public interface ILibraryUser
        {
            void AddBook()
            {

            }
            void RemoveBook()
            {

            }
            void BookInfo()
            {

            }
            void BooksCount()
            {

            }

        }
        public class LibraryUser
        {
            public string FirstName { get; }

            public string LastName { get; }

            public int ID { get; }

            public int Phone { get; set; }

            public int BookLimit { get; }

            public LibraryUser(string FirstName, string LastName, int ID, int Phone, int BookLimit)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.ID = ID;
                this.Phone = Phone;
                this.BookLimit = BookLimit;
            }

            private List<string> bookList = new List<string>();

            private string  this [int index]
            {
                get
                {
                    try
                    {
                        return bookList[index];
                    }
                    catch(Exception e)
                    {
                        return e.Message;
                    }
                }
                set
                {
                    try
                    {
                        bookList[index] = value;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            public void AddBook(string name)
            {
                bookList.Add(name);
                Console.WriteLine("{0} Succesfully added", name);
                Console.WriteLine("--------------------------------------------");
            }

            public void RemoveBook(int ind)
            {
                bookList.RemoveAt(ind);
                Console.WriteLine("{0} Succesfully removed", bookList[ind]);
                Console.WriteLine("--------------------------------------------");
            }

            public void RemoveBook(string bookName)
            {
                bookList.Remove(bookName);
                Console.WriteLine("{0} Succesfully removed", bookName);
                Console.WriteLine("--------------------------------------------");
            }

            public void BookInfo(int index)
            {
                Console.WriteLine(bookList[index]);
                Console.WriteLine("--------------------------------------------");
            }

            public void BooksCount()
            {
                Console.WriteLine("{0} - total number of books", bookList.Count);
                Console.WriteLine("--------------------------------------------");
            }

            public void PrintListOfBooks()
            {
                for(int i = 0; i<bookList.Count; i++)
                {
                    Console.WriteLine(bookList[i]);
                }
                Console.WriteLine("--------------------------------------------");

            }


        }

       
        
        static void Main(string[] args)
        {
            LibraryUser user1 = new LibraryUser("John", "Snow", 1, 0987654321, 8);
            LibraryUser user2 = new LibraryUser("Bob", "Marley", 2, 1234567890, 11);
            user1.AddBook("Harry Potter");
            user1.AddBook("House");
            user1.AddBook("Waves");
            user1.AddBook("Rat");
            user1.AddBook("Snack");
            user1.AddBook("Bang");
            user1.AddBook("Crack");
            user1.PrintListOfBooks();
            user1.RemoveBook(0);
            user1.PrintListOfBooks();
            user1.RemoveBook("Rat");
            user1.PrintListOfBooks();
            user1.BookInfo(2);
            user1.BooksCount();



        }
    }
}

using BookLibrary;
using System;
namespace BookLibrariy
{
    class Librariy
    { 
    
        static void Main(string[] args)
        {

            DateTime str=Books.CreateDate; // we use the static method it doesnt need the  instance; 

            Books book1 = new Books(); // we create the instance from the object constructor method 1 (New keyword, if you instance want create the from object must the use new keyword)
            Console.WriteLine($"Book Name:{book1.BookName} Arthur Name:{book1.ArthurName} Arthur Surname:{book1.ArthurSurname} Page Number:{book1.BookPageNumber} Publisher House:{book1.PublisherHouse} Record Create Date:{str}");   
            Books book2 = new Books("Sefiller","Victor","Hugo",1258,"Remzi Publish House");// we create the instance from the object constructor method 2
            Console.WriteLine($"Book name:{book2.BookName} Arthur Name:{book2.ArthurName} Arthur Surname:{book2.ArthurSurname} Page Number:{book2.BookPageNumber} Publisher House:{book2.PublisherHouse} Record Create Date:{str}");
        }

    
    }


}
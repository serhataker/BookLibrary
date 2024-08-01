using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Books // Class: it is Includes the all attributed for the object struct
    {
        private string bookName;
        private string arthurName;
        private string arthurSurName;
        private int bookPageNumber;
        private string publisherHouse;

         private static DateTime createDate;

        public string BookName { get { return bookName; } set { bookName = value; } } // properties: controls access to the field and specifies how to calculate and return the field if it exists
        public string ArthurName { get { return arthurName; } set { arthurName = value; } }
        public string ArthurSurname { get { return arthurSurName; } set { arthurSurName = value; } }
        public int BookPageNumber { get { return bookPageNumber; } set { bookPageNumber = value; } }
        public string PublisherHouse { get { return publisherHouse; } set { publisherHouse = value; } }   
        
        public static DateTime CreateDate { get { return createDate; } set { createDate = value; } }



      


        static Books()// if any variable main class attributes  to be want we can use this method.
        {
            CreateDate = DateTime.Now;
        }

        public Books()
        {
           
        }

        public Books(string bookname,string arthur,string arthursr,int bookpage,string publisher)//If you want to default value assign to the properties this value return there. it is may take the parameter or not
        {
           BookName = bookname;
            ArthurName = arthur;
            BookPageNumber = bookpage;
            PublisherHouse = publisher;
            ArthurSurname=arthursr;
    }


    }
}

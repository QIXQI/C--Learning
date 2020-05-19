using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("BookId: {0}", book_id);
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            Books book2 = new Books();

            book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6544343);
            book2.getValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 232322);

            book1.display();
            book2.display();

            Console.ReadKey();
        }
    }
}

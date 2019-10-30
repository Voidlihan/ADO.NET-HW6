using System;
using System.Data.SqlClient;

namespace ado.net_hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "war and piece",
                IsFree = true,
            };
            Author authors1 = new Author()
            {
                Name = "Pushkin",                 
            };
            Lib libs1 = new Lib()
            {
                Name = "Lib#1"
            };
            User users1 = new User()
            {
                Name = "Ivan",
                Debtor = 123,
            };
            using(var context = new Context())
            {
                context.Add(book1);
                context.Add(authors1);
                context.Add(libs1);
                context.Add(users1);
                context.SaveChanges();
            }
            using (var context = new Context())
            {
                foreach (var u in context.dbusers)
                {
                    Console.WriteLine("{0}", users1.Name, users1.Debtor);
                }
            }
            using(var context = new Context())
            {                
                foreach(var a in context.Authors)
                {
                    Console.WriteLine("{0} - {1}", authors1.Name, authors1.bookId);
                }
            }
            using(var context = new Context())
            {
                foreach (var a in context.Books)
                {          
                    Console.WriteLine("{0}", book1.IsFree);
                }
            }
            using (var context = new Context())
            {
                foreach (var a in context.Books)
                {                    
                    Console.WriteLine("{0} - {1}", book1.Name, book1.UserId);
                }
            }
            using(var context = new Context())
            {
                foreach (var d in context.dbusers)
                {
                    users1.Debtor = 0;
                    Console.WriteLine("{0}", users1.Debtor);
                }
            }
        }
    }
}

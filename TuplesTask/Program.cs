using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesTask
{
    public class Program
    {
        public (string, string, long) TupleReturnLiteral(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;
            if (id == 1000)
            {
                name = "Mahesh Chand";
                title = "ADO.NET Programming";
                year = 2003;
            }
            // tuple literal
            return (name, title, year);
        }

        static void Main(string[] args)
        {
            var author = new Tuple<string, string, int>("Mahesh Chand", "ADO.NET Programming", 2003);

            // Display author info
            Console.WriteLine("Author {0} wrote his first book titled {1} in {2}.", author.Item1, author.Item2, author.Item3);
           

            var pubAuthor = Tuple.Create("Mahesh Chand", "Graphics Programming with GDI+", "Addison Wesley", 2004, 49.95);
            Console.WriteLine("Author {0} wrote his fourth book titled {1} for {2} in {3}. Price: {4}",pubAuthor.Item1, pubAuthor.Item2, pubAuthor.Item3, pubAuthor.Item4, pubAuthor.Item5);


            Program ts = new Program();
            var author1 = ts.TupleReturnLiteral(1000);
            Console.WriteLine($"Author {author1.Item1} {author1.Item2} {author1.Item3} ");
            Console.ReadLine();

        }
    }
}

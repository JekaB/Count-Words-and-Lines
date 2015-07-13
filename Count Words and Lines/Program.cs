using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words_and_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\Jeka\Desktop\S&W.txt");
                List<string> words = text.Split(' ').ToList<string>();
                int lines = System.IO.File.ReadAllLines(@"C:\Users\Jeka\Desktop\S&W.txt").Length;
                Console.WriteLine("Слов в тексте {0}\nСтрок в тексте {1}", words.Count, lines);




                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

            
            
        }
    }
}

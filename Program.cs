using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int message = 1;
            while (i < 10)
            {
                Console.WriteLine($"Bonjour, je suis le message n° {message} !");
                i++;
                message++;
            }
        }
    }
}

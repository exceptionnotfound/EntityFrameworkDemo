using EntityFrameworkDemo.ModelFirst.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = 'b';
            while (input != 'q')
            {
                Console.Write("Select a test:");
                var testSelection = Console.ReadLine().ToLower().First();
                switch (testSelection)
                {
                    case 'l':
                        CustomerManager.LeavingContext(new List<string>() {"BLONP", "CHOPS", "LINOD"});
                        break;
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}

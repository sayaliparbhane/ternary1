using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terneary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
               else if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            }
        }
    }


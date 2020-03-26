using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        class Task
        {
            private string str;
            private string[] array_string;
            public Task()
            {
                Console.WriteLine("Enter string");
                str=Console.ReadLine();
                array_string = str.Split();
            }
            public void word_replacement()
            {
                str = "";
                for (int i = array_string.Length-1; i >=0 ; i--)
                {
                    str += array_string[i];
                    str += " ";
                }
            }
            public void print_str()
            {
                
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            Task task = new Task();
            Console.WriteLine("Old string");
            task.print_str();
            task.word_replacement();
            Console.WriteLine("New string");
            task.print_str();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        class Task1
        {
            private string str;
            private string[] array_string;
            public Task1()
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
        class Task2
        {
            private string str;
            private string str_glas;
            private string letters;
            public Task2()
            {
                Console.WriteLine("Enter string");
                str = Console.ReadLine();
                str_glas = "aeiou";
                letters = "abcdefghijklmnopqrstuvwxyz";
            }
            public void character_replacement()
            {
                string dop_str="";
                //Console.WriteLine(dop_str);
                for (int i = 0; i <str.Length ; i++)
                {
                    bool flag= true;
                    for (int j = 0; j < str_glas.Length; j++)
                    {
                        if (str[i] == str_glas[j])
                        {
                            j = str_glas.Length;
                            dop_str += str[i];
                            flag = false;
                            i++;
                            if (str[i] == 'z')
                                dop_str += "a";
                            else
                            {
                                int k = 0;
                                while (str[i] != letters[k])
                                {
                                    k++;
                                }
                                dop_str += letters[k + 1];
                                
                            }
                        }

                    }
                    if (flag == true)
                        dop_str += str[i];
                    else
                        flag = true;
                }
                str = "";
                for (int i = 0; i < dop_str.Length; i++)
                {
                    str += dop_str[i];
                }
            }
            public void print()
            {
                Console.WriteLine(str);
            }
        }
        class Task3
        {
            private string str;
            private string letters;            
            public Task3()
            {
                str = "";
                Random rand = new Random();
                letters = "abcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i < 4; i++)
                {
                    str += letters[rand.Next(0, letters.Length - 1)].ToString();
                }
            }
            public void print()
            {
                Console.WriteLine("new string");
                Console.WriteLine(str);
            }
        }   
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Console.WriteLine("Old string");
            task1.print_str();
            task1.word_replacement();
            Console.WriteLine("New string");
            task1.print_str();
            Task2 task2 = new Task2();
            Console.WriteLine("Old string");
            task2.print();
            task2.character_replacement();
            Console.WriteLine("New string");
            task2.print();
            Task3 task3 = new Task3();
            task3.print();
            Console.ReadKey();
        }
    }
}

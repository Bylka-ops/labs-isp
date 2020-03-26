using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        class People
        {
            private static int number = 0;
            private int id;
            protected string first_name;
            protected string last_name;
            public People(string First_name,string Last_name)
            {
                number++;
                id = number;
                first_name = First_name;
                last_name = Last_name;
            }
            public string get_first_name()
            {
                return first_name;
            }
            public string get_last_name()
            {
                return last_name;
            }
            public void set_first_name(string First_name)
            {
                first_name = First_name;
            }
            public void set_last_name(string Last_name)
            {
                last_name = Last_name;
            }
            public void print_people()
            {
                Console.Write(id.ToString()+" "+ get_first_name()+" "+ get_last_name());
            }
            public void set_people(string First_name, string Last_name)
            {
                set_first_name(First_name);
                set_last_name(Last_name);
            }
        }
        class Sportsman:People
        {
            protected string name_sport;
            public Sportsman(string First_name, string Last_name,string Name_sport) :base(First_name,Last_name)
            {
                name_sport = Name_sport;
            }
            public string get_name_sport()
            {
                return name_sport;
            }
            public void set_name_sport(string Name_sport)
            {
                name_sport = Name_sport;
            }
            public void print_sportsmen()
            {
                print_people();
                Console.Write(" "+get_name_sport());
            }
            public void set_people(string First_name, string Last_name,string Name_sport)
            {
                set_people(First_name, Last_name);
                set_name_sport(Name_sport);
            }
        }
        class Specialists_in_selected_sports:Sportsman
        {
            private string name_selected_sports;
            public Specialists_in_selected_sports(string First_name, string Last_name, string Name_sport,string Name_selected_sports) 
                :base(First_name,Last_name,Name_sport)
            {
                name_selected_sports = Name_selected_sports;
            }
            public string get_name_selected_sports()
            {
                return name_selected_sports;
            }
            public void set_name_selected_sports(string Name_selected_sports)
            {
                name_selected_sports = Name_selected_sports;
            }
            public void print_specialist()
            {
                print_sportsmen();
                Console.Write(" " + get_name_selected_sports());
            }
        }
        static void Main(string[] args)
        {
            People people = new People("Артем", "Ермаков");
            People people1 = new People("Виктория", "Панченко");
            people.print_people();
            Console.WriteLine();
            people1.print_people();
            Console.WriteLine();
            Sportsman sportsman = new Sportsman("Мария", "Кухарева", "Теннис");
            sportsman.print_sportsmen();
            Console.WriteLine();
            Specialists_in_selected_sports specialists_In_Selected_Sports = new Specialists_in_selected_sports("Константин", "Тишкевич", "Футбол", "Игровые");
            specialists_In_Selected_Sports.print_specialist();
            Console.WriteLine();
            sportsman.set_people("Тиханов", "Михаил");
            sportsman.print_sportsmen();
            Console.WriteLine();
            sportsman.set_people("Мария", "Кухарева","Шахматы");
            sportsman.print_sportsmen();
            Console.ReadKey();
        }
    }
}

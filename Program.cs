using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSystem
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please tell us a number of events you want to be sorted.");
            int numberOfEvents = int.Parse(Console.ReadLine());

            List<Event> events = new List<Event>();

            while (numberOfEvents > 0)
            {
                Console.WriteLine("Please enter the name of the event:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the city of the event:");
                string city = Console.ReadLine();
                Console.WriteLine("Please enter the date of the event in this order (yyyy-mm-dd):");
                string dateInput = Console.ReadLine();
                Console.WriteLine("Please enter the type of the event:");
                string type = Console.ReadLine();
                Console.WriteLine("Please enter the names of the lecturers (comma separated):");
                string[] lecturers = Console.ReadLine().Split(',');

                DateTime date;
                date = Convert.ToDateTime(dateInput);

                events.Add(new Event
                {
                    Name = name,
                    City = city,
                    Date = date,
                    Type = type,
                    Lecturers = lecturers
                });

                numberOfEvents--;
            }
            Console.WriteLine("Choose the way you want your events to be sorted! \n" +
                "You can choose from \"sort by name\", \"sort by date\", \"sort by type\", \"sort by city\" " +
                "or you can even make a mix between some, but make sure you separate them with comma (\",\")!");
            string[] commands = Console.ReadLine().Split(',');
            CheckSortByName(commands);
        }
        public void CheckSortByName(string[] commands)
        {
            foreach (string command in commands)
            {
                if (command == "sort by name") // idea to use regEx
                {
                    //SortByName() method needs to be invoked
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSystem
{
    public class EventSortingManager
    {
        public static void SortByName(List<Event> events)
        {
            List<Event> sortedEvents = events.OrderBy(e => e.Name).ToList();
            DisplayEvents(sortedEvents);
        }
        public static void SortByDate(List<Event> events)
        {
            List<Event> sortedEvents = events.OrderBy(e => e.Date).ToList();
            DisplayEvents(sortedEvents);
        }
        public static void SortByType(List<Event> events)
        {
            List<Event> sortedEvents = events.OrderBy(e => e.Type).ToList();
            DisplayEvents(sortedEvents);
        }
        public static void SortByCity(List<Event> events)
        {
            List<Event> sortedEvents = events.OrderBy(e => e.City).ToList();
            DisplayEvents(sortedEvents);
        }
        public static void SortByMultipleCriteria(List<Event> events, string[] commands)
        {
            //TO DO -> sort with then by
        }
        private static void DisplayEvents(List<Event> events)
        {
            foreach (List<Event> currentEvent in events)
            {
                Console.WriteLine(currentEvent);
            }
        }
    }
}
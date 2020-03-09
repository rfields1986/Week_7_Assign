using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_Assign1.Models
{
    class TicketFinder
    {
        public MasterTicketBook searchList { get; set; } = new MasterTicketBook();

        public void SearchByID()
        {


            int input;
            Console.WriteLine("What is the ticket number you want to search for?");
            Int32.TryParse(Console.ReadLine(), out input);
            searchList.ReadTicketFileForID();
            var ticketCheck = searchList.ticketBook.Any(t => t.ticketID.Equals(input));
            var ticketSearch = searchList.ticketBook.Where(t => t.ticketID.Equals(input));
            if (ticketCheck == true)
            {
                int x = 1;
                foreach (Ticket t in ticketSearch)
                {
                    Console.Clear();
                    Console.WriteLine($"Number {x++} of {ticketSearch.Count()} results\n\n");
                    t.Display();
                }
                searchList.ticketBook.Clear();

            }
            else if (ticketCheck == false)
            {
                Console.Clear();
                Console.WriteLine($"Search Term \"{input}\" does not match any records");
            }

            Console.WriteLine("\n Press Any Key");
            Console.ReadKey();

        }
        public void SearchBySubmitter()
        {


            string input;
            Console.WriteLine("Who submitted the ticket(s) you want to search for?");
            input = Console.ReadLine();
            searchList.ReadTicketFileForID();
            var ticketCheck = searchList.ticketBook.Any(t => t.submitedBy.Equals(input));
            var ticketSearch = searchList.ticketBook.Where(t => t.submitedBy.Equals(input));
            if (ticketCheck == true)
            {
                int x = 1;
                foreach (Ticket t in ticketSearch)
                {
                    Console.Clear();
                    Console.WriteLine($"Number {x++} of {ticketSearch.Count()} results\n\n");
                    t.Display();
                    Console.WriteLine("\n\nPress Any Key");
                    Console.ReadKey();
                }
                searchList.ticketBook.Clear();


            }
            else if (ticketCheck == false)
            {
                Console.Clear();
                Console.WriteLine($"Search Term \"{input}\" does not match any records");
            }



        }

    }
}

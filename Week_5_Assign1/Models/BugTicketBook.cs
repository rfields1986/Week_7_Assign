using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_7_Assign1.Models
{
    class BugTicketBook : ITicketBook
    {
        public string fileLocation { get; set; } = "../../Files/Tickets.csv";


        public void ReadTicketFile()
        {
            StreamReader ticketReader = new StreamReader(this.fileLocation);
            string line = ticketReader.ReadLine();
            string[] header = line.Split(',');
            if (ticketReader.EndOfStream)
            {
                Console.Clear();
                Console.WriteLine("Bug/Defect Ticket File\n");
                Console.WriteLine("No Tickets In This File\n");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bug/Defect Ticket File\n");
                while (!ticketReader.EndOfStream)
                {

                    string line1 = ticketReader.ReadLine();
                    string[] body = line1.Split(',');
                    for (int i = 0; i < body.Length; i++)
                    {
                        Console.Write("{0,-20}", header[i]);
                        Console.WriteLine(body[i]);

                    }
                    Console.WriteLine("\n");




                }
            }
            Console.WriteLine("Press Enter To Return To The Main Menu");
            Console.ReadKey();
            ticketReader.Close();

        }

        public void WriteNewTicket()
        {

            Console.Clear();
            Console.WriteLine($"The New Ticket Number Is --> {CountIDs()}\n\nPress Any Key");
            int ticketID = CountIDs();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Please enter a summary of the issue?");
            string ticketSummary = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What the status of this ticket?");
            string ticketStatus = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a priority: High, Medium, or Low?");
            string ticketPriority = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your name?");
            string submitedBy = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the ticket assigned too?");
            string assignedTo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who will be watching this ticket? Seperate multiple watchers with \"|\"");
            string watchedBy = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the severity of the Bug/Defect?");
            string severity = Console.ReadLine();
            string ticketInfo = $"{ticketID},{ticketSummary},{ticketStatus},{ticketPriority},{submitedBy},{assignedTo},{watchedBy},{severity}";
            StreamWriter ticketWriter = new StreamWriter("../../Files/Tickets.csv", append: true);
            ticketWriter.WriteLine(ticketInfo);
            ticketWriter.Close();
        }
        public int CountIDs()
        {
            int idCount = 0;
            MasterTicketBook masterTicketBook = new MasterTicketBook();
            

            if (masterTicketBook.CountTicketBookForID() == 1 )
            {
                idCount = 1;
            }
            else
            {
                idCount = masterTicketBook.ticketBook.Count() + 1;
            }
            return idCount;
        }



    }
}


using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Week_5_Assign1.Models
{
    class Tasks : Ticket
    {
        public string projectName { get; set; }
        public string DueDate { get; set; }

        public void ReadTicketFile()
        {


            string file = "../../Files/Tasks.csv";
            StreamReader rd = new StreamReader(file);
            string line = rd.ReadLine();
            string[] header = line.Split(',');
            if (rd.EndOfStream)
            {
                Console.Clear();
                Console.WriteLine("Task Ticket File\n");
                Console.WriteLine("No Tickets In This File\n");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Task Ticket File\n");
                while (!rd.EndOfStream)
                {

                    string line1 = rd.ReadLine();
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
            rd.Close();
        }
        public override void CreateNewTicket()
        {
            Console.Clear();
            Console.WriteLine($"The New Ticket Number Is --> {IDCount()}\n\nPress Any Key");
            ticketID = IDCount();
            Console.ReadKey();
            base.CreateNewTicket();
            Console.WriteLine("What is the project name?");
            projectName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("When is the Due Date?");
            DueDate = Console.ReadLine();
            string file = "../../Files/Tasks.csv";
            StreamWriter rd1 = new StreamWriter(file, append: true);
            rd1.WriteLine($"{ticketID},{ticketSummary},{ticketStatus},{ticketPriority},{submitedBy},{assignedTo},{watchedBy},{projectName},{DueDate}");
            rd1.Close();
            Console.WriteLine("Press Enter To Return To The Main Menu");
            Console.ReadKey();

        }


    }
}
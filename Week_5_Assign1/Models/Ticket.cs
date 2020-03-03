using System;
using System.Collections.Generic;
using System.IO;

namespace Week_7_Assign1.Models
{
    public abstract class Ticket
    {
        public int ticketID { get; set; }
        public string ticketSummary { get; set; }
        public string ticketStatus { get; set; }
        public string ticketPriority { get; set; }
        public string submitedBy { get; set; }
        public string assignedTo { get; set; }
        public string watchedBy { get; set; }

        public Ticket()
        {



            ticketID = 0;
            ticketSummary = "";
            ticketStatus = "";
            ticketPriority = "";
            submitedBy = "";
            assignedTo = "";
            watchedBy = "";

        }
        public virtual int IDCount()
        {
            List<string> idCount = new List<string>();
            StreamReader enhanceID = new StreamReader("../../Files/Tickets.csv");
            StreamReader taskID = new StreamReader("../../Files/Enhancements.csv");
            StreamReader bugID = new StreamReader("../../Files/Tasks.csv");
            do
            {
                while (!enhanceID.EndOfStream)
                {
                    string readoutHeader = enhanceID.ReadLine();
                    if (!enhanceID.EndOfStream)
                    {
                        string line = enhanceID.ReadLine();
                        string[] lineSplit = line.Split(',');
                        idCount.Add(lineSplit[0]);
                    }

                }

                while (!taskID.EndOfStream)
                {
                    string readoutHeader = taskID.ReadLine();
                    if (!taskID.EndOfStream)
                    {
                        string line = taskID.ReadLine();
                        string[] lineSplit = line.Split(',');
                        idCount.Add(lineSplit[0]);
                    }
                }

                while (!bugID.EndOfStream)
                {
                    string readoutHeader = bugID.ReadLine();
                    if (!bugID.EndOfStream)
                    {
                        string line = bugID.ReadLine();
                        string[] lineSplit = line.Split(',');
                        idCount.Add(lineSplit[0]);
                    }
                }

            } while (!enhanceID.EndOfStream & !taskID.EndOfStream & !bugID.EndOfStream);
            {
                enhanceID.Close();
                taskID.Close();
                bugID.Close();
                return idCount.Count + 1;
            }



        }
        public void ReadAllTickets()
        {
            int drop = 0;
            do
            {

                if (drop == 0)
                {

                    string file = "../../Files/Tickets.csv";
                    StreamReader rd = new StreamReader(file);
                    string line = rd.ReadLine();
                    string[] header = line.Split(',');
                    if (rd.EndOfStream)
                    {
                        Console.Clear();
                        Console.WriteLine("Bug/Defect Ticket File\n");
                        Console.WriteLine("No Tickets In This File\n");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Bug/Defect Ticket File\n");
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
                    Console.WriteLine("Press Enter To See Enhancement Tickets");
                    Console.ReadKey();
                    rd.Close();
                    drop++;

                }
                else if (drop == 1)
                {

                    string file = "../../Files/Enhancements.csv";
                    StreamReader rd = new StreamReader(file);
                    string line = rd.ReadLine();
                    string[] header = line.Split(',');
                    if (rd.EndOfStream)
                    {
                        Console.Clear();
                        Console.WriteLine("Enhancement Ticket File\n");
                        Console.WriteLine("No Tickets In This File\n");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Enhancement Ticket File\n");
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
                    Console.WriteLine("Press Enter To See Task Tickets");
                    Console.ReadKey();
                    rd.Close();
                    drop++;



                }
                else if (drop == 2)
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
                    drop++;



                }
            } while (drop < 3);


        }
        public virtual void CreateNewTicket()
        {

            Console.Clear();
            Console.WriteLine("Please enter a summary of the issue?");
            ticketSummary = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What the status of this ticket?");
            ticketStatus = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a priority: High, Medium, or Low?");
            ticketPriority = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your name?");
            submitedBy = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who is the ticket assigned too?");
            assignedTo = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Who will be watching this ticket? Seperate multiple watchers with \"|\"");
            watchedBy = Console.ReadLine();
            Console.Clear();

        }



    }
}
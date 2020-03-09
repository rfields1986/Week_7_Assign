using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;


namespace Week_7_Assign1.Models
{
    class MasterTicketBook : ITicketBook
    {
        public string fileLocation { get; set; }
        public List<Ticket> ticketBook = new List<Ticket>();

        public bool ReadTicketFileForID()
        {
            int drop = 0;
            bool fileEmpty = true;
            do
            {

                if (drop == 0)
                {

                    string file = "../../Files/Tickets.csv";
                    StreamReader ticketReader = new StreamReader(file);
                    string line = ticketReader.ReadLine();
                    string[] header = line.Split(',');
                    if (ticketReader.EndOfStream)
                    {

                        fileEmpty = true;

                    }
                    else
                    {

                        while (!ticketReader.EndOfStream)
                        {

                            string line1 = ticketReader.ReadLine();
                            string[] body = line1.Split(',');
                            BugsDefects ticketBD = new BugsDefects();
                            ticketBD.ticketID = Int32.Parse(body [0]);
                            ticketBD.ticketSummary = body[1];
                            ticketBD.ticketStatus = body[2];
                            ticketBD.ticketPriority = body[3];
                            ticketBD.submitedBy = body[4];
                            ticketBD.assignedTo = body[5];
                            ticketBD.watchedBy = body[6];
                            ticketBD.severity = body[7];
                            ticketBook.Add(ticketBD);
                            fileEmpty = false;




                        }
                    }

                    ticketReader.Close();
                    drop++;

                }
                else if (drop == 1)
                {

                    string file = "../../Files/Enhancements.csv";
                    StreamReader ticketReader = new StreamReader(file);
                    string line = ticketReader.ReadLine();
                    string[] header = line.Split(',');
                    if (ticketReader.EndOfStream)
                    {

                        

                    }
                    else
                    {

                        while (!ticketReader.EndOfStream)
                        {

                            string line1 = ticketReader.ReadLine();
                            string[] body = line1.Split(',');
                            Enhancements ticketEN = new Enhancements();
                            ticketEN.ticketID = Int32.Parse(body[0]);
                            ticketEN.ticketSummary = body[1];
                            ticketEN.ticketStatus = body[2];
                            ticketEN.ticketPriority = body[3];
                            ticketEN.submitedBy = body[4];
                            ticketEN.assignedTo = body[5];
                            ticketEN.watchedBy = body[6];
                            ticketEN.software = body[7];
                            ticketEN.cost = body[8];
                            ticketEN.reason = body[9];
                            ticketEN.estimate = body[10];
                            ticketBook.Add(ticketEN);
                            fileEmpty = false;




                        }
                    }

                    ticketReader.Close();
                    drop++;



                }
                else if (drop == 2)
                {

                    string file = "../../Files/Tasks.csv";
                    StreamReader ticketReader = new StreamReader(file);
                    string line = ticketReader.ReadLine();
                    string[] header = line.Split(',');

                    if (ticketReader.EndOfStream)
                    {

                        

                    }
                    else
                    {

                        while (!ticketReader.EndOfStream)
                        {

                            string line1 = ticketReader.ReadLine();
                            string[] body = line1.Split(',');
                            Tasks ticketTK = new Tasks();
                            ticketTK.ticketID = Int32.Parse(body[0]);
                            ticketTK.ticketSummary = body[1];
                            ticketTK.ticketStatus = body[2];
                            ticketTK.ticketPriority = body[3];
                            ticketTK.submitedBy = body[4];
                            ticketTK.assignedTo = body[5];
                            ticketTK.watchedBy = body[6];
                            ticketTK.projectName = body[7];
                            ticketTK.DueDate = body[8];
                            ticketBook.Add(ticketTK);
                            fileEmpty = false;



                        }
                    }

                    ticketReader.Close();
                    drop++;



                }
            } while (drop < 3);
            return fileEmpty;


        }

        public void WriteNewTicket()
        {
            
        }
        public int CountTicketBookForID()
        {
            
            int idCount = 0;
            if (ReadTicketFileForID() == true)
            {
                idCount = 1;
                
            }
            else
            {
                idCount = ticketBook.Count() +1;
            }
            return idCount;
        }

        public int CountIDs()
        {
            throw new NotImplementedException();
        }

        public void ReadTicketFile()
        {
            {
                int drop = 0;
                
                do
                {

                    if (drop == 0)
                    {

                        string file = "../../Files/Tickets.csv";
                        StreamReader ticketReader = new StreamReader(file);
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
                                BugsDefects ticketBD = new BugsDefects();
                                ticketBD.ticketID = Int32.Parse(body[0]);
                                ticketBD.ticketSummary = body[1];
                                ticketBD.ticketStatus = body[2];
                                ticketBD.ticketPriority = body[3];
                                ticketBD.submitedBy = body[4];
                                ticketBD.assignedTo = body[5];
                                ticketBD.watchedBy = body[6];
                                ticketBD.severity = body[7];
                                ticketBook.Add(ticketBD);
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
                        ticketReader.Close();
                        drop++;

                    }
                    else if (drop == 1)
                    {

                        string file = "../../Files/Enhancements.csv";
                        StreamReader ticketReader = new StreamReader(file);
                        string line = ticketReader.ReadLine();
                        string[] header = line.Split(',');
                        if (ticketReader.EndOfStream)
                        {
                            Console.Clear();
                            Console.WriteLine("Enhancement Ticket File\n");
                            Console.WriteLine("No Tickets In This File\n");
                            

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Enhancement Ticket File\n");
                            while (!ticketReader.EndOfStream)
                            {

                                string line1 = ticketReader.ReadLine();
                                string[] body = line1.Split(',');
                                Enhancements ticketEN = new Enhancements();
                                ticketEN.ticketID = Int32.Parse(body[0]);
                                ticketEN.ticketSummary = body[1];
                                ticketEN.ticketStatus = body[2];
                                ticketEN.ticketPriority = body[3];
                                ticketEN.submitedBy = body[4];
                                ticketEN.assignedTo = body[5];
                                ticketEN.watchedBy = body[6];
                                ticketEN.software = body[7];
                                ticketEN.cost = body[8];
                                ticketEN.reason = body[9];
                                ticketEN.estimate = body[10];
                                ticketBook.Add(ticketEN);
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
                        ticketReader.Close();
                        drop++;



                    }
                    else if (drop == 2)
                    {

                        string file = "../../Files/Tasks.csv";
                        StreamReader ticketReader = new StreamReader(file);
                        string line = ticketReader.ReadLine();
                        string[] header = line.Split(',');

                        if (ticketReader.EndOfStream)
                        {
                            Console.Clear();
                            Console.WriteLine("Task Ticket File\n");
                            Console.WriteLine("No Tickets In This File\n");
                            

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Task Ticket File\n");
                            while (!ticketReader.EndOfStream)
                            {

                                string line1 = ticketReader.ReadLine();
                                string[] body = line1.Split(',');
                                Tasks ticketTK = new Tasks();
                                ticketTK.ticketID = Int32.Parse(body[0]);
                                ticketTK.ticketSummary = body[1];
                                ticketTK.ticketStatus = body[2];
                                ticketTK.ticketPriority = body[3];
                                ticketTK.submitedBy = body[4];
                                ticketTK.assignedTo = body[5];
                                ticketTK.watchedBy = body[6];
                                ticketTK.projectName = body[7];
                                ticketTK.DueDate = body[8];
                                ticketBook.Add(ticketTK);
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
                        drop++;



                    }
                } while (drop < 3);
                


            }
        }


    }


}

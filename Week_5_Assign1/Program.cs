using System;
using System.Linq;
using Week_7_Assign1.Models;


namespace Week_7_Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0, input = 0;
            MasterTicketBook masterTicketBook = new MasterTicketBook();
            BugTicketBook bugTicketBook = new BugTicketBook();
            EnhancementTicketBook enhancementTicketBook = new EnhancementTicketBook();
            TaskTicketBook taskTicketBook = new TaskTicketBook();
            TicketFinder ticketFinder = new TicketFinder();



            do
            {
                
                Console.Clear();
                Console.Write("1. Read A TicketBook.\n2. Write A New Ticket In A Ticketbook.\n3. Search For A Ticket.\n4. Exit.\n\nEnter ----> ");
                Int32.TryParse(Console.ReadLine(), out input);
                Console.Clear();
                switch (input)
                {
                    case 1:
                        exit = 1;
                        int input1 = 0;
                        Console.Write("What Type Of Ticket? \n1.Bug/Defect, 2.Enhancement, 3.Task, 4.All\n\nEnter ----> ");
                        Int32.TryParse(Console.ReadLine(), out input1);
                        if (input1 == 1)
                            bugTicketBook.ReadTicketFile();
                        else if (input1 == 2)
                            enhancementTicketBook.ReadTicketFile();
                        else if (input1 == 3)
                            taskTicketBook.ReadTicketFile();
                        else if (input1 == 4)
                            masterTicketBook.ReadTicketFile();
                        else
                        {
                            Console.WriteLine("Wrong Input Try Again");
                            Console.ReadKey();
                        }



                        break;

                    case 2:
                        {
                            exit = 1;
                            int input2 = 0;
                            Console.Write("What Type Of Ticket? \n1.Bug/Defect, 2.Enhancement, 3.Task\n\nEnter ----> ");
                            Int32.TryParse(Console.ReadLine(), out input2);
                            if (input2 == 1)
                            {
                                bugTicketBook.WriteNewTicket();
                                
                            }
                            else if (input2 == 2)
                            {
                                enhancementTicketBook.WriteNewTicket();
                                
                            }
                            else if (input2 == 3)
                            {
                                taskTicketBook.WriteNewTicket();
                                
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input Try Again");
                                Console.ReadKey();
                            }




                        }
                        break;

                    case 3:
                        {
                            exit = 1;
                            int input2 = 0;
                            Console.Clear();
                            Console.Write("Search By:\n1. ID\n2. Submiter\nEnter Number----> ");
                            Int32.TryParse(Console.ReadLine(), out input2);

                            switch (input2)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        ticketFinder.SearchByID();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        ticketFinder.SearchBySubmitter();
                                    }
                                    break;


                            }
                                

                        }
                        break;
                    case 4:
                        {
                            exit = 0;
                            Console.WriteLine("Goodbye");
                        }
                        break;
                }
            } while (exit != 0);
        }

    }
}


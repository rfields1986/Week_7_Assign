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
            BugsDefects ticketBorD = new BugsDefects();
            Enhancements ticketEnhan = new Enhancements();
            Tasks ticketTask = new Tasks();
            Tasks ticketAll = new Tasks();
            TicketBook ticketBook = new TicketBook();



            do
            {
                
                Console.Clear();
                Console.Write("1. Read The File.\n2. Write a new ticket to file.\n3.Search For Ticket\n4. Exit\n\nEnter ----> ");
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
                            ticketBorD.ReadTicketFile();
                        else if (input1 == 2)
                            ticketEnhan.ReadTicketFile();
                        else if (input1 == 3)
                            ticketTask.ReadTicketFile();
                        else if (input1 == 4)
                            ticketAll.ReadAllTickets();
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
                                ticketBorD.CreateNewTicket();
                                ticketBook.ticketBook.Add(ticketBorD);
                            }
                            else if (input2 == 2)
                            {
                                ticketEnhan.CreateNewTicket();
                                ticketBook.ticketBook.Add(ticketEnhan);
                            }
                            else if (input2 == 3)
                            {
                                ticketTask.CreateNewTicket();
                                ticketBook.ticketBook.Add(ticketTask);
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
                        try
                        {
                            int input2;
                            Console.WriteLine("What is the ticket number you want to search for");
                            Int32.TryParse(Console.ReadLine(), out input2);
                            var TicketBook = ticketBook.ticketBook.Where(t => t.ticketID.Equals(input2));
                        }


                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("No Ticket Under That Number");
                            
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


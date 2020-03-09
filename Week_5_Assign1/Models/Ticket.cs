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
            ticketSummary = "Unassigned";
            ticketStatus = "Unassigned";
            ticketPriority = "Unassigned";
            submitedBy = "Unassigned";
            assignedTo = "Unassigned";
            watchedBy = "Unassigned";

        }

        public virtual void Display()
        {
            string[] header = { "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching" };
            string[] body = { $"{ticketID}", $"{ticketSummary}", $"{ticketStatus}", $"{ticketPriority}", $"{submitedBy}", $"{assignedTo}", $"{watchedBy}" };
            for (int i = 0; i < body.Length; i++)
            {
                Console.Write("{0,-20}", header[i]);
                Console.WriteLine(body[i]);

            }
            Console.WriteLine("\n");

        }
    
    }
}
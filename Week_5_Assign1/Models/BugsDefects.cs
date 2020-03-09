using System;
using System.IO;

namespace Week_7_Assign1.Models
{
    class BugsDefects : Ticket
    {
        public string severity { get; set; }
        public override void Display()
        {
            Console.Clear();
            Console.WriteLine("Bug/Defect Ticket File\n");
            string[] header = { "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "Severity" };
            string[] body = { $"{ticketID}", $"{ticketSummary}", $"{ticketStatus}", $"{ticketPriority}", $"{submitedBy}", $"{assignedTo}", $"{watchedBy}", $"{severity}" };
            for (int i = 0; i < body.Length; i++)
            {
                Console.Write("{0,-20}", header[i]);
                Console.WriteLine(body[i]);

            }
            

        }


    }
}
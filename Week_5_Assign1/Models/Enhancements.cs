using System;
using System.IO;

namespace Week_7_Assign1.Models
{
    class Enhancements : Ticket
    {
        public string software { get; set; }
        public string cost { get; set; }
        public string reason { get; set; }
        public string estimate { get; set; }
        public override void Display()
        {
            
            Console.WriteLine("Enhancement Ticket File\n");
            string[] header = { "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "Software", "Cost", "Reason", "Estimate" };
            string[] body = { $"{ticketID}", $"{ticketSummary}", $"{ticketStatus}", $"{ticketPriority}", $"{submitedBy}", $"{assignedTo}", $"{watchedBy}", $"{software}", $"{cost}", $"{reason}", $"{estimate}" };
            for (int i = 0; i < body.Length; i++)
            {
                Console.Write("{0,-20}", header[i]);
                Console.WriteLine(body[i]);

            }


        }



    }
}
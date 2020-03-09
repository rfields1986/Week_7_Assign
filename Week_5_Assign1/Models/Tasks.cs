using System;
using System.IO;

namespace Week_7_Assign1.Models
{
    class Tasks : Ticket
    {
        public string projectName { get; set; }
        public string DueDate { get; set; }
        public override void Display()
        {
            
            Console.WriteLine("Task Ticket File\n");
            string[] header = { "TicketID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watching", "Project Name", "Due Date" };
            string[] body = { $"{ticketID}", $"{ticketSummary}", $"{ticketStatus}", $"{ticketPriority}", $"{submitedBy}", $"{assignedTo}", $"{watchedBy}", $"{projectName}", $"{DueDate}" };
            for (int i = 0; i < body.Length; i++)
            {
                Console.Write("{0,-20}", header[i]);
                Console.WriteLine(body[i]);

            }


        }
    }




    
}
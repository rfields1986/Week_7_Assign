using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Week_7_Assign1.Models
{
    interface ITicketBook
    {
        string fileLocation { get; set; }
        void ReadTicketFile();
        void WriteNewTicket();
        int CountIDs();
    

        
    }
}

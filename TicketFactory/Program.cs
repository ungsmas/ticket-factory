using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFactory.Factories;
using Microsoft.Practices.Unity;
using Unity.Strategy;

namespace TicketFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITicketFactory ticketFactory = new Factories.TicketFactory();
            ITicketDetailsFactory ticketDetailsFactory = new MonthTicketDetails(TicketCategory.Vuxen, "Malmö");
            var ticket = ticketFactory.CreateTicket(ticketDetailsFactory);

            Console.WriteLine(ticket.ToString());
            ticket.ActivateTicket();
            Console.WriteLine(ticket.ToString());

            Console.ReadLine();
        }
    }
}

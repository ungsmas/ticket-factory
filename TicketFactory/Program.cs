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
        //private static UnityDependencyResolver _dependencyResolver;

        static void Main(string[] args)
        {
            //RegisterTypes();
            bool isPeriod = false;
            Ticket ticket;
            if (isPeriod)
            {
                ITicketFactory periodTicketFactory = new PeriodTicketFactory();
                ITicketDetailsFactory ticketDetailsFactory = new PeriodTicketDetails(TicketCategory.Vuxen, 24, "Malmö",
                    "Göteborg");
                ticket = periodTicketFactory.CreateTicket(ticketDetailsFactory);
            }
            else
            {
                ITicketFactory periodTicketFactory = new MonthTicketFactory();
                ITicketDetailsFactory ticketDetailsFactory = new MonthTicketDetails(TicketCategory.Vuxen, "Malmö");
                ticket = periodTicketFactory.CreateTicket(ticketDetailsFactory);
            }
            //else
            //{
            //    ITicketFactory periodTicketFactory = new SimpleTicketFactory();
            //    ITicketDetailsFactory ticketDetailsFactory = new SimpleTicketDetails(TicketCategory.Vuxen, "Malmö","Göteborg");
            //    ticket = periodTicketFactory.CreateTicket(ticketDetailsFactory);
            //}
            Console.WriteLine(ticket.ToString());
            ticket.ActivateTicket();
            Console.WriteLine(ticket.ToString());

            Console.ReadLine();
        }

        private static void RegisterTypes()
        {
            
        }
    }
}

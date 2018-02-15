using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory.Factories
{
    class MonthTicketFactory : ITicketFactory
    {
        public Ticket CreateTicket(ITicketDetailsFactory factory)
        {
            Ticket monthTicket = new MonthTicket(factory);
            monthTicket.CreateTicketDetails();
            return monthTicket;
        }
    }
}

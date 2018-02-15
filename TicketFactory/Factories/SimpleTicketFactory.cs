using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    class SimpleTicketFactory : ITicketFactory
    {
        private ITicketDetailsFactory _ticketDetailsFactory;
        private Ticket ticket;
        public Ticket CreateTicket(ITicketDetailsFactory factory)
        {
            _ticketDetailsFactory = factory;
            ticket = new SimpleTicket(_ticketDetailsFactory);
            ticket.CreateTicketDetails();
            return ticket;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    class PeriodTicketFactory : ITicketFactory
    {
        private ITicketDetailsFactory _ticketDetailsFactory;

        public Ticket CreateTicket(ITicketDetailsFactory detailFactory)
        {
            _ticketDetailsFactory = detailFactory;
            Ticket ticket = new PeriodTicket(_ticketDetailsFactory);
            ticket.CreateTicketDetails();
            return ticket;
        }
    }
}

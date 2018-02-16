using TicketFactory.Impl;

namespace TicketFactory.Factories
{
    class TicketFactory : ITicketFactory
    {
        public Ticket CreateTicket(ITicketDetailsFactory factory)
        {
            Ticket ticket = null;

            if (factory is MonthTicketDetails)
            {
                ticket = new MonthTicket(factory);
            }

            if (factory is SimpleTicketDetails)
            {
                ticket = new SimpleTicket(factory);
            }

            if (factory is PeriodTicketDetails)
            {
                ticket = new PeriodTicket(factory);
            }

            ticket.CreateTicketDetails();

            return ticket;
        }
    }
}

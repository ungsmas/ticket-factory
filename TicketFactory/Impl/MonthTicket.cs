using System;

namespace TicketFactory.Impl
{
    class MonthTicket : Ticket
    {
        private ITicketDetailsFactory monthTicketDetailsFactory;
        public MonthTicket(ITicketDetailsFactory factory)
        {
            monthTicketDetailsFactory = factory;
            TicketType = "Month Ticket";
            CreatedDate = DateTime.Now;
        }

        public override void ActivateTicket()
        {
            ActivatedDate = DateTime.Now;
            TicketDetailInfo.ValidUntilTime = ActivatedDate.AddMinutes(TicketDetailInfo.ValidTime);
        }

        public override void CreateTicketDetails()
        {
            TicketDetailInfo = new TicketDetails
            {
                ValidTime = monthTicketDetailsFactory.GetValidTime(),
                From = monthTicketDetailsFactory.SetFromStation(),
                Price = monthTicketDetailsFactory.SetPrice(),
                To = monthTicketDetailsFactory.SetToStation(),
                Category = monthTicketDetailsFactory.SetCategory()
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    class SimpleTicket : Ticket
    {
        private ITicketDetailsFactory _simpleTicketDetailsFactory;
        public SimpleTicket(ITicketDetailsFactory simpleTicketDetailsFactory)
        {
            _simpleTicketDetailsFactory = simpleTicketDetailsFactory;
            TicketType = "Simple Ticket";
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
                ValidTime = _simpleTicketDetailsFactory.GetValidTime(),
                From = _simpleTicketDetailsFactory.SetFromStation(),
                Price = _simpleTicketDetailsFactory.SetPrice(),
                To = _simpleTicketDetailsFactory.SetToStation(),
                Category = _simpleTicketDetailsFactory.SetCategory()
            };

        }
    }
}

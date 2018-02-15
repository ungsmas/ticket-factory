using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    class PeriodTicket : Ticket
    {
        ITicketDetailsFactory _detailsFactory;
        public PeriodTicket(ITicketDetailsFactory factory)
        {
            TicketType = "Period Ticket";
            CreatedDate = DateTime.Now;
            _detailsFactory = factory;
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
                ValidTime = _detailsFactory.GetValidTime(),
                From = _detailsFactory.SetFromStation(),
                Price = _detailsFactory.SetPrice(),
                To = _detailsFactory.SetToStation(),
                Category = _detailsFactory.SetCategory()
            };
            
        }
    }
}

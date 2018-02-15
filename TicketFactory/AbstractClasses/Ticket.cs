using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    abstract class Ticket
    {
        protected DateTime CreatedDate;
        protected string TicketType;
        protected DateTime ActivatedDate;
        protected TicketDetails TicketDetailInfo;
        public abstract void ActivateTicket();

        public abstract void CreateTicketDetails();

        public override string ToString()
        {
           return string.Format("Kategori: {0} - Typ:{1} - Skapad:{2} - Gilltig till:{3} - Pris:{4} ",
                TicketDetailInfo.Category, TicketType, CreatedDate, TicketDetailInfo.ValidUntilTime,
                TicketDetailInfo.Price);

        }
    }
}

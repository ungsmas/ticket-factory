using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory.Factories
{
    class PeriodTicketDetails : ITicketDetailsFactory
    {
        private TicketCategory _category;
        private int _validTime;
        private string _from, _to;

        public PeriodTicketDetails(TicketCategory category, int validTime, string from, string to)
        {
            _validTime = validTime;
            _from = from;
            _to = to;
            _category = category;
        }

        public string SetCategory()
        {
            return _category.ToString();
        }

        public int GetValidTime()
        {
           return _validTime;
        }

        public string SetFromStation()
        {
            return _from;
        }

        public string SetToStation()
        {
            return _to;            
        }

        public int SetPrice()
        {
            //dbLogic
            return 1;
        }
    }
}

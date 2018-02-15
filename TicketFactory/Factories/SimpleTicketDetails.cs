using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory.Factories
{
    class SimpleTicketDetails : ITicketDetailsFactory
    {
        private TicketCategory _category;        
        private string _from, _to;

        public SimpleTicketDetails(TicketCategory category, string from, string to)
        {
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
            return 60;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory.Factories
{
    class MonthTicketDetails : ITicketDetailsFactory
    {
        private string _city;
        private TicketCategory _category;
        public MonthTicketDetails(TicketCategory category, string city)
        {
            _city = city;
            _category = category;
        }

        public string SetCategory()
        {
            return _category.ToString();
        }

        public int GetValidTime()
        {
            return (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day) * 1440;
        }

        public string SetFromStation()
        {
            return _city;
        }

        public string SetToStation()
        {
            return _city;
        }

        public int SetPrice()
        {
            //dbLogic
            return 300;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketFactory
{
    interface ITicketDetailsFactory
    {
        string SetCategory();
        int GetValidTime();
        string SetFromStation();
        string SetToStation();
        int SetPrice();

    }
}

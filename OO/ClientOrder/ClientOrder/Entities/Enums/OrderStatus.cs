using System;
using System.Collections.Generic;
using System.Text;

namespace ClientOrder.Entities.Enums
{
    public enum OrderStatus
    {
        PENDIG_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}

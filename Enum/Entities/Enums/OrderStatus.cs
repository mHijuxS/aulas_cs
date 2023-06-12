using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Entities.Enums
{
    internal enum OrderStatus : int 
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}

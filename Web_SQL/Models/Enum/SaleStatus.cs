using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_SQL.Models.Enum
{
    public enum SaleStatus: int
    {
        PENDING = 0,
        BILLED = 1,
        CANCELED = 2,
    }
}

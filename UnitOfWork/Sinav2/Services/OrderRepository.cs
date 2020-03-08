using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Services
{
    public class OrderRepository : Repository<Models.Order>, Interfaces.IOrderRepository
    {
        public OrderRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}

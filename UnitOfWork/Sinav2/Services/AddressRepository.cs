using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Services
{
    public class AddressRepository : Repository<Models.Address>, Interfaces.IAddressRepository
    {
        public AddressRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}

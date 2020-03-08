using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; set; }
        IAddressRepository AddressRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IUserRepository UserRepository { get; set; }

        int Complete();
    }
}

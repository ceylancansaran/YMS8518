using Sinav2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            UserRepository = new Services.UserRepository(_dataContext);
            AddressRepository = new Services.AddressRepository(_dataContext);
            ProductRepository = new Services.ProductRepository(_dataContext);
            OrderRepository = new Services.OrderRepository(_dataContext);
        }

        public IProductRepository ProductRepository { get; set; }
        public IAddressRepository AddressRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}

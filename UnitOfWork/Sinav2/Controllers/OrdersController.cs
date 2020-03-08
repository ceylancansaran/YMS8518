using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sinav2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public OrdersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _unitOfWork.OrderRepository.GetAll();
            return new JsonResult(orders);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Order Order)
        {
            _unitOfWork.OrderRepository.Insert(Order);
            _unitOfWork.Complete();
            return new JsonResult(Order);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Order Order)
        {
            _unitOfWork.OrderRepository.Update(Order);
            _unitOfWork.Complete();
            return new JsonResult(Order);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.OrderRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var orders = _unitOfWork.OrderRepository.GetById(id);
            return new JsonResult(orders);
        }
    }
}
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
    public class ProductsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public ProductsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _unitOfWork.ProductRepository.GetAll();
            return new JsonResult(products);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Product Product)
        {
            _unitOfWork.ProductRepository.Insert(Product);
            _unitOfWork.Complete();
            return new JsonResult(Product);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Product Product)
        {
            _unitOfWork.ProductRepository.Update(Product);
            _unitOfWork.Complete();
            return new JsonResult(Product);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.ProductRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var products = _unitOfWork.ProductRepository.GetById(id);
            return new JsonResult(products);
        }
    }
}
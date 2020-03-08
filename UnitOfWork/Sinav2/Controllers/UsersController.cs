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
    public class UsersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public UsersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _unitOfWork.UserRepository.GetAll();
            return new JsonResult(users);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.User User)
        {
            _unitOfWork.UserRepository.Insert(User);
            _unitOfWork.Complete();
            return new JsonResult(User);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.User User)
        {
            _unitOfWork.UserRepository.Update(User);
            _unitOfWork.Complete();
            return new JsonResult(User);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _unitOfWork.UserRepository.GetById(id);
            return new JsonResult(users);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO.Users;
using BAL;
using BAL.Interfaces.Users;
using BAL.Services.Users;

namespace DotNetMVCWebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public UserController()
        {
            _usersRepository = new UsersRepository(); // Interface se work ho raha hai
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeDTO _userdto)
        {
            if(ModelState.IsValid)
            {
                _usersRepository.InsertEmployee(_userdto);
                return RedirectToAction("Index");
            }

            return View(_userdto);
        }
    }
}
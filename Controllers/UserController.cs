using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Sam",UserPwd="sam@123",UserEmail="Sam@gmail.com"},
             new User(){UserId=2,UserName="Simran",UserPwd="sim@123",UserEmail="Sim@gmail.com"},
              new User(){UserId=3,UserName="Amit",UserPwd="amit@123",UserEmail="Amit@gmail.com"},
               new User(){UserId=4,UserName="Ruhani",UserPwd="ruh@123",UserEmail="Ruhani@gmail.com"},
                new User(){UserId=5,UserName="Rahul",UserPwd="rahul@123",UserEmail="Rahul@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
            
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);
            }
            return RedirectToAction("Index");
        }
    }
}

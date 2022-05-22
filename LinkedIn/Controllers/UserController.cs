using Microsoft.AspNetCore.Mvc;
using LinkedIn.Models;
namespace LinkedIn.Controllers
{
    public class UserController : Controller
    {
        public ViewResult  Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(User u)
        {
            if (UserRepository.verifyCredentials(u))
            {
                return View("home",UserRepository.getUsers());
            }
            else
            {
                return View();
            }
            
        }
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(User user)
        {
            UserRepository.addUser(user);    
            return View("home",UserRepository.getUsers());
        }
    }
}

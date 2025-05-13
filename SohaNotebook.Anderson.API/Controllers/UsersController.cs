using Microsoft.AspNetCore.Mvc;
using SohaNotebook.Anderson.DataService.Data;
using SohaNotebook.Anderson.Entities.DbSet;
using SohaNotebook.Anderson.Entities.Dtos;

namespace SohaNotebook.Anderson.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private AppDbContext _context;
        public UsersController(AppDbContext context) { _context = context; }
        // Get
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.Where(x => x.Status == 1).ToList();
            return Ok(users);
        }
        // Post
        [HttpPost]
        public IActionResult AddUser(UserDto user)
        {
            var _user = new User();
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.DateOfBirth = Convert.ToDateTime(user.DateOfBirth);
            _user.Phone = user.Phone;
            _user.Email = user.Email;
            _user.Country = user.Country;
            _user.Status = 1;
            _context.Users.Add(_user);
            _context.SaveChanges();
            return Ok(); 
        }
        // Get All

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterBuilder.Models;
namespace CharacterBuilder.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private DBContext _context;

        public CharacterController(DBContext context)
        {
            _context = context; //Dependency Injection.
        }


        [HttpGet("[action]")]
        public Models.Character GetCharacter()
        {

            return new Character()
            {
                Id = 5,
                Name = "CABE"
            };
        }

    }
}

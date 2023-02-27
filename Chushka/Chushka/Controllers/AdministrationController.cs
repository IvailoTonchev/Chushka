using Chushka.Data.Models;
using Chushka.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Chushka.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public AdministrationController(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> CreateRole(CreateRoleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ApplicationRole role=new ApplicationRole {Name=model.RoleName, };
            var result = await roleManager.CreateAsync(role);//Add DataBase
            if (result.Succeeded)
            {
                return Redirect("/");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.ToString());
                }
            }
            return View();
        }
    }
}


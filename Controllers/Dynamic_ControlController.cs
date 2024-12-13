using EmployeeBiodataMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeBiodataMVC.Controllers
{
    public class Dynamic_ControlController : Controller
    {
        public IActionResult Dynamic_Control()
        {
            var viewModel = new Dynamic_Control
            {
                control_type = "textbox",
                control_no = 1     
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult GenerateControls(Dynamic_Control model)
        {
            if (ModelState.IsValid)
            {
                // Generate unique names for controls
                model.control_generated = Enumerable.Range(1, model.control_no)
                    .Select(i => $"{model.control_type} {i}")
                    .ToList();
            }
            return View("Dynamic_Control", model);
        }
    }
}

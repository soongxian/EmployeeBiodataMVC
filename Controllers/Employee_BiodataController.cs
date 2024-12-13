using EmployeeBiodataMVC.Data;
using EmployeeBiodataMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeBiodataMVC.Controllers
{
    public class Employee_BiodataController : Controller
    {
        private readonly Employee_Biodata__DBContext _context;

        public Employee_BiodataController(Employee_Biodata__DBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Employee_Biodata()
        {
            var employeeBiodata = await _context.Employee_Biodata
                .Where(e =>
                (
                e.employee_name.StartsWith("A") ||
                e.employee_name.StartsWith("G") ||
                e.employee_name.StartsWith("V") ||
                e.birth_date.Month >= 1 && e.birth_date.Month < 4
                )).ToListAsync();

            return View(employeeBiodata);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

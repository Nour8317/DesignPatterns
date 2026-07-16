using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers
{
    [ApiController]
    public class PayrollCalculatorController : Controller
    {
        [HttpPost]
        [Route("payroll-calculator")]
        public ActionResult <Decimal> Calculate([FromBody] Employee employee)
        {
            var payrollCalculator = new PayrollCalculator();
            var total = payrollCalculator.Calculate(employee);
            return Ok(total);
        }
    }
}

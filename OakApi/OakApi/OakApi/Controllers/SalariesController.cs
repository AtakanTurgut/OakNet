using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OakApi.DataAccess;
using OakApi.Model;

namespace OakApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SalariesController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetSalaries()
		{
			var context = new ApiDbContext();
			var list = context.Salaries.ToList();

			return Ok(list);
		}

		[HttpGet("{id}")]
		public IActionResult GetSalaryById(int id)
		{
			var context = new ApiDbContext();
			Salary salary = context.Salaries.Find(id);

			if (salary == null)
				return NotFound();

			return Ok(salary);
		}

		[HttpPost]
		public IActionResult CreateSalary(Salary salary)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				context.Salaries.Add(salary);
				context.SaveChanges();

				return Created("", salary);
			}
			else
				return BadRequest();
		}

		[HttpPut]
		public IActionResult UpdateSalary(Salary salary)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				Salary updateSalary = context.Salaries.Find(salary.SalaryId);
				updateSalary.Amount = salary.Amount;
				context.SaveChanges();

				return NoContent();
			}
			else return BadRequest();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteSalary(int id)
		{
			var context = new ApiDbContext();
			Salary salary = context.Salaries.Find(id);

			if (salary == null)
				return NotFound();

			else
			{
				context.Salaries.Remove(salary);
				context.SaveChanges();

				return NoContent();
			}
		}

	}
}

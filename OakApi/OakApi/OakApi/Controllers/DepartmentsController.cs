using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OakApi.DataAccess;
using OakApi.Model;

namespace OakApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentsController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetDepartments()
		{
			var context = new ApiDbContext();
			var list = context.Departments.ToList();

			return Ok(list);
		}

		[HttpGet("{id}")]
		public IActionResult GetDepartmentById(int id)
		{
			var context = new ApiDbContext();
			Department department = context.Departments.Find(id);

			if (department == null)
				return NotFound();
			
			return Ok(department);
		}

		[HttpPost]
		public IActionResult CreateDepartment(Department department)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				context.Departments.Add(department);
				context.SaveChanges();

				return Created("", department);
			}
			else
				return BadRequest();
		}

		[HttpPut]
		public IActionResult UpdateDepartment(Department department)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				Department updateDepartment = context.Departments.Find(department.DepartmentId);
				updateDepartment.DepartmentName = department.DepartmentName;
				context.SaveChanges();

				return NoContent();
			}
			else return BadRequest();
		}

	}
}

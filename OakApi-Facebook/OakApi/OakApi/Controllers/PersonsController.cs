using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OakApi.DataAccess;
using OakApi.Model;

namespace OakApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonsController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetPersons()
		{
			var context = new ApiDbContext();
			var list = context.Persons
					.Include(x => x.Salary)
					.Include(x => x.Position)
					.ThenInclude(x => x.Department)
					.Select(x => new PersonAll()
					{
						PersonAllId = x.PersonId,
						Name = x.Name,
						PositionName = x.Position.PositionName,
						Salary = x.Salary.Amount,
						PersonCity = x.PersonDetail.PersonCity,
						DepartmentName = x.Position.Department.DepartmentName,
					}).ToList();

			return Ok(list);
		}

		[HttpGet("{id}")]
		public IActionResult GetPersonById(int id)
		{
			var context = new ApiDbContext();
			Person person = context.Persons.FirstOrDefault(x => x.PersonId == id);

			if (person == null)
				return NotFound();

			return Ok(person);
		}

		[HttpPost]
		public IActionResult CreatePerson(Person person)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				context.Persons.Add(person);
				context.SaveChanges();

				return Created("", person);
			}
			else return BadRequest();
		}

		[HttpPut]
		public IActionResult UpdatePerson(Person person)
		{
			if (ModelState.IsValid)
			{
				var context = new ApiDbContext();
				Person updatePerson = context.Persons.Find(person.PersonId);
				updatePerson.Name = person.Name;
				updatePerson.Surname = person.Surname;
				updatePerson.Address = person.Address;
				updatePerson.Age = person.Age;
				updatePerson.Email = person.Email;
				updatePerson.Password = person.Password;
				updatePerson.PositionId = person.PositionId;
				updatePerson.SalaryId = person.SalaryId;
				context.SaveChanges();

				return NoContent();
			}
			else return BadRequest();
		}

	}
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OakApi.DataAccess;
using OakApi.Model;

namespace OakApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			using (ApiDbContext context = new ApiDbContext())
			{
				var list = context.Persons
					.Include(x => x.Salary)
					.Include(x => x.Position)
					.ThenInclude(x => x.Department)
					.Select(x => new PersonAll()
					{
						PersonAllId=x.PersonId,
						Name = x.Name,
						PositionName = x.Position.PositionName,
						Salary = x.Salary.Amount,
						PersonCity = x.PersonDetail.PersonCity,
						DepartmentName = x.Position.Department.DepartmentName,
					}).ToList();

				Person person = context.Persons.Find(1);

				/*
				// Department Update
				Department department = context.Departments.Find(1);
				department.DepartmentName = "AtDepartmentUpdate";
				context.SaveChanges();
				*/

				// Salary Delete
				Salary salary = context.Salaries.Find(2);
				context.Salaries.Remove(salary);
				context.SaveChanges();

				/*
				// Department Create
				Department department =new Department();
				department.DepartmentName = "AtDepartment2";

				context.Departments.Add(department);
				context.SaveChanges();
				*/
			}

			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}

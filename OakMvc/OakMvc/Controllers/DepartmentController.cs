using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OakMvc.Models;
using System.Text;

namespace OakMvc.Controllers
{
	public class DepartmentController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<Department> departmentList = new List<Department>();
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7017/api/Departments");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jstring = await responseMessage.Content.ReadAsStringAsync();
				departmentList = JsonConvert.DeserializeObject<List<Department>>(jstring);

				return View(departmentList);
            }

			return View(departmentList);
		}

		public IActionResult Create()
		{
			Department department = new Department();

			return View(department);
		}

		[HttpPost]
		public async Task<IActionResult> Create(Department department) 
		{
			if (ModelState.IsValid)
			{
				HttpClient client = new HttpClient();
				var jsonDepartment = JsonConvert.SerializeObject(department);

				StringContent content = new StringContent(jsonDepartment, Encoding.UTF8, "application/json");
				HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:7017/api/Departments", content);

				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index");
				}
				else
				{
                    ModelState.AddModelError("Error", "There is an API error!");

					return View(department);
                }
			}

			return View(department);
		}
		
		public async Task<IActionResult> Update(int id)
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7017/api/Departments/" + id);

			if (responseMessage.IsSuccessStatusCode)
			{
				var jstring = await responseMessage.Content.ReadAsStringAsync();
				Department department = JsonConvert.DeserializeObject<Department>(jstring);

				return View(department);
			}

			return RedirectToAction("Create");
		}

		[HttpPost]
		public async Task<IActionResult> Update(Department department)
		{
			if (ModelState.IsValid)
			{
				HttpClient client = new HttpClient();
				var jsonDepartment = JsonConvert.SerializeObject(department);

				StringContent content = new StringContent(jsonDepartment, Encoding.UTF8, "application/json");
				HttpResponseMessage responseMessage = await client.PutAsync("https://localhost:7017/api/Departments/", content);

				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index");
				}

				return View(department);
			}

			return View(department);
		}

    }
}

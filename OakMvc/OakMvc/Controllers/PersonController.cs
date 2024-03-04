using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OakMvc.Models;
using System.Text;

namespace OakMvc.Controllers
{
	public class PersonController : Controller
	{
		public async Task<IActionResult> Index()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7017/api/Persons");

			if (responseMessage.IsSuccessStatusCode) 
			{
				var jstring = await responseMessage.Content.ReadAsStringAsync();
				List<PersonAll> persons = JsonConvert.DeserializeObject<List<PersonAll>>(jstring);

				return View(persons);
			}

			return View(new List<PersonAll>());
		}

		public IActionResult Create()
		{
			Person person = new Person();

			return View(person);
		}

		[HttpPost]
		public async Task<IActionResult> Create(Person person)
		{
			if (ModelState.IsValid)
			{
				HttpClient client = new HttpClient();
				var jsonPerson = JsonConvert.SerializeObject(person); 

				StringContent content = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
				HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:7017/api/Persons", content);

				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index");
				}
				else
				{
					ModelState.AddModelError("Error", "There is an API error!");

					return View(person);
				}
			}
			else
			{
				return View(person);
			}
		}

		public async Task<IActionResult> Update(int id)
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7017/api/Persons/" + id);

			if (responseMessage.IsSuccessStatusCode)
			{
				var jstring = await responseMessage.Content.ReadAsStringAsync();
				Person person = JsonConvert.DeserializeObject<Person>(jstring);

				return View(person);
			}

			return RedirectToAction("Create");
		}

		[HttpPost]
		public async Task<IActionResult> Update(Person person)
		{
			if (ModelState.IsValid)
			{
				HttpClient client = new HttpClient();
				var jsonPerson = JsonConvert.SerializeObject(person);

				StringContent content = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
				HttpResponseMessage responseMessage = await client.PutAsync("https://localhost:7017/api/Persons", content);

				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index");
				}

				return View(person);
			}

			return View(person);
		}

    }
}

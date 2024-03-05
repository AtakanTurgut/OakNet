using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OakMvc.Models;

namespace OakMvc.Controllers
{
	public class SalaryController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<Salary> salaryList = new List<Salary>();
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync("https://localhost:7017/api/Salaries");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jstring = await responseMessage.Content.ReadAsStringAsync();
				salaryList = JsonConvert.DeserializeObject<List<Salary>>(jstring);

				return View(salaryList);
			}

			return View(salaryList);
		}

		public async Task<IActionResult> Delete(int id)
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.DeleteAsync("https://localhost:7017/api/Salaries/" + id);

			if (responseMessage.IsSuccessStatusCode)
				return RedirectToAction("Index");

			return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] IFormFile file)
        {
			HttpClient client = new HttpClient();
			var bytes = await System.IO.File.ReadAllBytesAsync(file.FileName);

			ByteArrayContent content = new ByteArrayContent(bytes);
			MultipartFormDataContent dataContent = new MultipartFormDataContent();
			dataContent.Add(content, "file", file.FileName);

			HttpResponseMessage responseMessage = await client.PostAsync("https://localhost:7017/api/Salaries/uploadfile", dataContent);

			if (responseMessage.IsSuccessStatusCode) 
				return RedirectToAction("Index");

            return View();
        }

    }
}

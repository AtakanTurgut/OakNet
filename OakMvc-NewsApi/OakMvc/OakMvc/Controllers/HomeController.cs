using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using OakMvc.Models;
using System.Diagnostics;

namespace OakMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GetNews()
        {
            Root root = new Root();

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("https://newsapi.org/v2/everything?q=tesla&from=2024-02-05&sortBy=publishedAt&apiKey=86dcefb866114d76a304c3f4c9f0e998");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jstring = await responseMessage.Content.ReadAsStringAsync();

                root = JsonConvert.DeserializeObject<Root>(jstring);

                return View(root);
            }

            return View(root);
        }

    }
}

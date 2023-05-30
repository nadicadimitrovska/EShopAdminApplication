using EShopAdminApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EShopAdminApplication.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            HttpClient client = new HttpClient();

            String URL = "https://localhost:44356/api/Admin/GetAllActiveOrders";

            HttpResponseMessage response = client.GetAsync(URL).Result;

            var data = response.Content.ReadAsAsync<List<Order>>().Result;
            
            return View(data);
        }

        public IActionResult Details(Guid orderId)
        {

            HttpClient client = new HttpClient();

            String URL = "https://localhost:44356/api/Admin/GetDetailsForOrder";

            var model = new
            {
                Id = orderId
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(URL,content).Result;

            var data = response.Content.ReadAsAsync<Order>().Result;

            return View(data);
        }
    }
}

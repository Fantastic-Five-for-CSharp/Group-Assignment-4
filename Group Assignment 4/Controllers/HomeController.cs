using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Group_Assignment_4.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Reflection;

namespace Federal_Election.Controllers
{
    public class HomeController : Controller
    {
        HttpClient? httpClient;

        static string BASE_URL = "https://developer.nps.gov/api/v1/";
        static string API_KEY = "mdBybOievMdeX3eYSC0MhFu3U7xRV18xHAPG04qb"; //Add your API key here inside ""

        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.htm

        public IActionResult Parks()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string NATIONAL_PARK_API_PATH = BASE_URL + "/parks?limit=6";
            string parksData = "";

            Parks parks = null;

            httpClient.BaseAddress = new Uri(NATIONAL_PARK_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NATIONAL_PARK_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    parksData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!parksData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    parks = JsonConvert.DeserializeObject<Parks>(parksData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(parks);
        }

        public IActionResult Tours()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string TOUR_API_PATH = BASE_URL + "/tours?limit=5";
            string toursData = "";

            Tours tours = null;

            httpClient.BaseAddress = new Uri(TOUR_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(TOUR_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    toursData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!toursData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    tours = JsonConvert.DeserializeObject<Tours>(toursData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(tours);
        }


   
        public IActionResult Camps()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string CAMPGROUND_API_PATH = BASE_URL + "/campgrounds?limit=5";
            string campsData = "";

            Camps camps = null;

            httpClient.BaseAddress = new Uri(CAMPGROUND_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(CAMPGROUND_API_PATH).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    campsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!campsData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    camps = JsonConvert.DeserializeObject<Camps>(campsData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(camps);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult TX()
        {
            return View();
        }
        public IActionResult NY()
        {
            return View();
        }
        public IActionResult OH()
        {
            return View();
        }
        public IActionResult DC()
        {
            return View();
        }
        public IActionResult VA()
        {
            return View();
        }
        public IActionResult ParkUpdate()
        {
            return View();
        }
        public IActionResult ParkDelete()
        {
            return View();
        }
    }
}
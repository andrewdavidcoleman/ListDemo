using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ListDemo.Models;
using Newtonsoft.Json;

namespace ListDemo.ViewComponents
{
    public class MovieDetail : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            string json = await Program.Data.GetStringAsync($"http://www.omdbapi.com/?apikey=3877efa0&i={id}");
            Movie movie = JsonConvert.DeserializeObject<Movie>(json);

            Detail model = new Detail();
            model.Id = movie.imdbId;
            model.Header = movie.Title;
            model.Detail1 = movie.Year.ToString();
            model.Detail2 = movie.Actors;
            model.Description = movie.Plot;
            return View("~/Views/Home/Components/Detail/Default.cshtml", model);
        }
    }
}
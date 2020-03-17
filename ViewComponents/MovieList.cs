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
    public class MovieList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string searchText)
        {
            if(searchText == null){
                searchText = "godfather";
            }
            string json = await Program.Data.GetStringAsync($"http://www.omdbapi.com/?apikey=3877efa0&s={searchText}");
            OmdbResponseObj omdb = JsonConvert.DeserializeObject<OmdbResponseObj>(json);

            List<ListItem> model = new List<ListItem>();
            foreach (Movie movie in omdb.Search)
            {
                model.Add(new ListItem(){
                    Id = movie.imdbId,
                    Text = movie.Title,
                    SubText = movie.Year.ToString(),
                    Url = "/Home/MovieDetail",
                    Element = "$('#detail')"
                });
            }

            return View("~/Views/Home/Components/List/Default.cshtml", model);
        }
    }
}
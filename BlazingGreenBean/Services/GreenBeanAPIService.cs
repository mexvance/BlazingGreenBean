using BlazingGreenBean.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingGreenBean.Services
{
    public class GreenBeanAPIService
    {
        public async Task<List<Recipe>> GetRecipesByName(string recipeName)
        {
            var GBAPI = RestService.For<IGreenBeanAPI>("https://api.greenbeancooking.com");
            var recipes = await GBAPI.GetRecipesByName(recipeName);
            return recipes;
        }
    }
}

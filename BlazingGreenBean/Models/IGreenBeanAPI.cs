using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace BlazingGreenBean.Models
{
    interface IGreenBeanAPI
    {
        [Get("/searchrecipebyname/{name}")]
        Task<List<Recipe>> GetRecipesByName(string name);
    }
}

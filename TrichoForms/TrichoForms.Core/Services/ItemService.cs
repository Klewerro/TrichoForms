using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrichoForms.Core.Interfaces;
using TrichoForms.Core.Models;

namespace TrichoForms.Core.Services
{
    public class ItemService : IItemService
    {
        private readonly IJsonService _jsonService = Xamarin.Forms.DependencyService.Get<IJsonService>();

        public async Task<IEnumerable<ListItem>> GetItemsAsync()
        {
            var json = await _jsonService.GetJsonAsync();
            var items = JsonConvert.DeserializeObject<IEnumerable<ListItem>>(json);
            return items;
        }
    }
}

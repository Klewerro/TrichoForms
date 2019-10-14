using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TrichoForms.Core.Interfaces;
using TrichoForms.Core.Models;

namespace TrichoForms.Core.Services
{
    public class ItemService : IItemService
    {
        private readonly IJsonService _jsonService = Xamarin.Forms.DependencyService.Get<IJsonService>();

        public IEnumerable<ListItem> GetItems()
        {
            var json = _jsonService.GetJson();
            var items = JsonConvert.DeserializeObject<IEnumerable<ListItem>>(json);
            return items;
        }
    }
}

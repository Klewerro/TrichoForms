using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrichoForms.Core.Models;

namespace TrichoForms.Core.Services
{
    public interface IItemService
    {
        Task<IEnumerable<ListItem>> GetItemsAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TrichoForms.Core.Models;

namespace TrichoForms.Core.Services
{
    public interface IItemService
    {
        IEnumerable<ListItem> GetItems();
    }
}

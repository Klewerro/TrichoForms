using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrichoForms.Core.Interfaces
{
    public interface IJsonService
    {
        Task<string> GetJsonAsync();
    }
}

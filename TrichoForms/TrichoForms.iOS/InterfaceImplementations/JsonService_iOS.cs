using System;
using System.IO;
using System.Threading.Tasks;
using TrichoForms.Core.Interfaces;
using TrichoForms.iOS.InterfaceImplementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(JsonService_iOS))]
namespace TrichoForms.iOS.InterfaceImplementations
{
    public class JsonService_iOS : IJsonService
    {
        public Task<string> GetJsonAsync()
        {
            try
            {
                return File.ReadAllTextAsync("TextFile.txt");
            }
            catch (Exception)
            {
                throw new IOException("File not found.");
            }
        }
    }
}
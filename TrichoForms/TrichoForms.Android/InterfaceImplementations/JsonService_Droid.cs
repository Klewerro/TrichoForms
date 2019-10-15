using System.IO;
using System.Threading.Tasks;
using TrichoForms.Core.Interfaces;
using TrichoForms.Droid.InterfaceImplementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(JsonService_Droid))]
namespace TrichoForms.Droid.InterfaceImplementations
{
    
    class JsonService_Droid : IJsonService
    {
        public async Task<string> GetJsonAsync()
        {
            try
            {
                var stream = Android.App.Application.Context.Assets.Open("TextFile.txt");

                using (StreamReader reader = new StreamReader(stream))
                {
                    return await reader.ReadToEndAsync().ConfigureAwait(false);
                }
            }
            catch (Java.IO.FileNotFoundException)
            {
                throw new IOException("File not found.");
            }
            
        }
    }
}
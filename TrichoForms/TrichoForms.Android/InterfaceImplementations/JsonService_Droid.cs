using System.IO;
using TrichoForms.Core.Interfaces;
using TrichoForms.Droid.InterfaceImplementations;
using Xamarin.Forms;

[assembly: Dependency(typeof(JsonService_Droid))]
namespace TrichoForms.Droid.InterfaceImplementations
{
    
    class JsonService_Droid : IJsonService
    {
        public string GetJson()
        {
            var stream = Android.App.Application.Context.Assets.Open("TextFile.txt");

            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
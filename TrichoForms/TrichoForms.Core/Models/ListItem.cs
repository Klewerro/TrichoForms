using System;
using System.Collections.Generic;
using System.Text;

namespace TrichoForms.Core.Models
{
    public class ListItem
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }


        //private ImageSource ConvertBase64ToImage(string text)
        //{
        //    var image = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(text)));
        //    return image;
        //}
    }
}

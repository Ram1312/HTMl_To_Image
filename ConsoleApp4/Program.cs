using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.HtmlConverter;
using System.Drawing;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using Aspose.Html;
using Aspose.Html.Rendering.Image;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Syncfusion (https://www.syncfusion.com/kb/9612/how-to-convert-html-to-image-using-c)
            HtmltoImageWithSyncfusion();

            // Aspose (https://products.aspose.com/html/net/conversion/html-to-image/)
            HtmltoImageWithSyncfusion();
        }


        static void HtmltoImageWithSyncfusion()
        {
            //Initialize HTML to PDF Converter 
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            //Convert URL to Image

            string html = System.IO.File.ReadAllText("BirthdayT.html");
            Image[] image = htmlConverter.ConvertToImage(html, "");

            //Save the image
            image[0].Save("Syncfusion.jpg");

            //This will open the image file so, the result will be seen in default image viewer
            Process.Start("Syncfusion.jpg");
        }

        static void HtmltoImageWithAspose()
        {
            using (var document = new HTMLDocument("BirthdayT.html"))
            {
                var options = new ImageSaveOptions(ImageFormat.Jpeg);
                Converter.ConvertHTML(document, options, "asposeoutput.jpg");
            }
        }
    }
}


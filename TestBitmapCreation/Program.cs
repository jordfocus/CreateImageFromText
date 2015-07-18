using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using ImageGenerator;

namespace TestBitmapCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageGenerator = new TextImageGenerator();
            imageGenerator.SaveAsJpg("imageJPEG.jpeg", "This is sample text");
            imageGenerator.SaveAsPng("imagePNG.png", "This is sample text");
            imageGenerator.SaveAsGif("imageGIF.gif", "This is sample text");
            imageGenerator.SaveAsBmp("imageBMP.bmp", "This is sample text");
            //var colorConverter = new ColorConverter();
            //Color color = (Color)colorConverter.ConvertFromString("#000000");
            // base64 strings, useful for REST services
            // Console.WriteLine("Base64 jpg: " + imageGenerator.CreateBase64Image("This is sample text", ImageFormat.Jpeg));
            // Console.WriteLine("Base64 png: " + imageGenerator.CreateBase64Image("This is sample text", ImageFormat.Png));
            // Console.WriteLine("Base64 bmp: " + imageGenerator.CreateBase64Image("This is sample text", ImageFormat.Bmp));
            // Console.WriteLine("Base64 gif: " + imageGenerator.CreateBase64Image("This is sample text", ImageFormat.Gif));
             
        }
    }
}

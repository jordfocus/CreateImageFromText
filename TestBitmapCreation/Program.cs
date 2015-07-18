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
            var imageGenerator = new TextImageGenerator(Color.Orange, Color.Black, "Algerian", 20, 55);
            // var imageText = "In dwelling, live close to the ground.\nIn thinking, keep to the simple.\nIn conflict, be fair and generous.\nIn governing, don't try to control.\nIn work, do what you enjoy.\nIn family life, be completely present.";
            var imageText = "Now you can create\nTEXT IMAGES WITH C#!";
            imageGenerator.SaveAsJpg("imageJPEG.jpeg", imageText);
            imageGenerator.SaveAsPng("imagePNG.png", imageText);
            imageGenerator.SaveAsGif("imageGIF.gif", imageText);
            imageGenerator.SaveAsBmp("imageBMP.bmp", imageText);
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

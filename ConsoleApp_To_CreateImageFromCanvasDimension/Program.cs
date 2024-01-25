// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");
// Example dimension data
int canvasWidth = 745;
int canvasHeight = 1018;

using (Bitmap canvas = new Bitmap(canvasWidth, canvasHeight))
{
    using (Graphics graphics = Graphics.FromImage(canvas))
    {
        // Set background color (optional)
        graphics.Clear(Color.White);

        // Example object dimension data
        int objectX = 100;
        int objectY = 200;
        int objectWidth = 50;
        int objectHeight = 50;
        int imageX = 0;
        int imageY = 0;
        // Example border dimension data
        int borderWidth = 2;
        Color borderColor = Color.Red;

        //Draw Actual Image
        using (System.Drawing.Image image = System.Drawing.Image.FromFile("1_01.JPG"))
        {
            // Draw the image on the canvas
            graphics.DrawImage(image, imageX, imageY,745,1018.5f);
          
        }
        //Draw 1 marks image
        using (System.Drawing.Image image = System.Drawing.Image.FromFile("1.png"))
        {
            // Draw the image on the canvas
            graphics.DrawImage(image, 109.453125f, 481, 40, 40);

        }
        // Draw rectangle border
        using (Pen borderPen = new Pen(borderColor, borderWidth))
        {
            graphics.DrawRectangle(borderPen, 109.453125f, 481, 40, 40);
        }
        //Draw 2 marks image
        using (System.Drawing.Image image = System.Drawing.Image.FromFile("2.png"))
        {
            // Draw the image on the canvas
            graphics.DrawImage(image, 480.609375f, 376, 40, 40);
        }
     

        // Draw rectangle border
        using (Pen borderPen = new Pen(borderColor, borderWidth))
        {
            graphics.DrawRectangle(borderPen, 480.609375f, 376, 40, 40);
        }
        // Draw a rectangle on the canvas
        using (Brush brush = new SolidBrush(Color.Blue))
        {
            graphics.FillRectangle(brush, objectX, objectY, objectWidth, objectHeight);
        }

        // You can add more drawing logic for other objects here
    }

    // Save the canvas to a file (you can return this file path as a response in a real server application)
    string outputPath = "output.png";
    canvas.Save(outputPath, ImageFormat.Png);

    Console.WriteLine($"Image saved to: {outputPath}");
}
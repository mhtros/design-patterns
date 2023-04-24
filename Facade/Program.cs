using Facade.Facades;

IImageProcessor processor = new ImageSharpProcessor();

const string imagePath = @"C:\Images\image.jpg";

const int width = 800;
const int height = 600;


processor.ResizeImage(imagePath, width, height);
Console.WriteLine("Image resized successfully!");
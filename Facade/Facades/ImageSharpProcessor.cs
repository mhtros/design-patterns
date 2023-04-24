using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Facade.Facades;

public class ImageSharpProcessor : IImageProcessor
{
    public void ResizeImage(string imagePath, int width, int height)
    {
        using var image = Image.Load(imagePath);
        image.Mutate(x => x.Resize(width, height));
        image.Save(imagePath);
    }

    public void CropImage(string imagePath, int startX, int startY, int width, int height)
    {
        using var image = Image.Load(imagePath);
        image.Mutate(x => x.Crop(new Rectangle(startX, startY, width, height)));
        image.Save(imagePath);
    }

    public void RotateImage(string imagePath, int degrees)
    {
        using var image = Image.Load(imagePath);
        image.Mutate(x => x.Rotate(degrees));
        image.Save(imagePath);
    }
}
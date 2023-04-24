namespace Facade.Facades;

public interface IImageProcessor
{
    void ResizeImage(string imagePath, int width, int height);
    void CropImage(string imagePath, int startX, int startY, int width, int height);
    void RotateImage(string imagePath, int degrees);
}
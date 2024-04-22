using OpenCvSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo for images transformation:");

        string fileName = "lena.jpg";
        Mat image = Cv2.ImRead(fileName, ImreadModes.Grayscale);
        Cv2.ImShow("lena", image);
        Cv2.ImWrite(@"../../../images/grayLena.jpg", image);
        Cv2.WaitKey();
        Cv2.DestroyAllWindows();
    }
}
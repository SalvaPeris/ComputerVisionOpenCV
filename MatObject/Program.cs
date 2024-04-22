using OpenCvSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo of Mat creation: ");
        Mat mat = new Mat(30, 40, MatType.CV_8UC3, new Scalar(0, 0, 255));
        Mat mat1 = new Mat(140, 130, MatType.CV_8UC3, new Scalar(0, 255, 0));
        Cv2.ImShow("m", mat);
        Cv2.ImShow("m1", mat1);
        Cv2.WaitKey();
        Cv2.DestroyAllWindows();
    }
}
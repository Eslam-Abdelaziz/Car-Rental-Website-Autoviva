using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdminPanel.Extenstions
{
    public static class ImageExtensions
    {
        public static Image Resize(this Image image, Size size)
        {
            Bitmap resizedImage = new Bitmap(size.Width, size.Height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                graphics.DrawImage(image, 0, 0, size.Width, size.Height);
            }
            return resizedImage;
            
        }
    
    }
}

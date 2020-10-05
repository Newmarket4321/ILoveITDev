using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_IT
{
    class CompressPicture
    {
        public CompressPicture(string[] args)
        {
            string suffix = "-compressed";
            string source = args[0];
            string destination = source.Replace(".jpg", suffix + ".jpg").Replace(".jpeg", suffix + ".jpeg").Replace(".png", suffix + ".png").Replace(".bmp", suffix + ".bmp");

            Image image = Image.FromFile(args[0]);

            for(int i = 100; i >= 0; i--)
            {
                SaveJpeg(destination, image, i);

                if ((new FileInfo(destination)).Length < 1048576) //If under 1MB
                {
                    MessageBox.Show("File saved as " + destination);
                    break;
                }
            }
        }

        public static void SaveJpeg(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(path, jpegCodec, encoderParams);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }
    }
}

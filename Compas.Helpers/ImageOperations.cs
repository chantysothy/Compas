using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Compas.Helpers
{
    public static class ImageOperations
    {
        public static byte[] ConvertImageToByteArray(string fileName)
        {
            if (File.Exists(fileName) == true)
            {
                Bitmap bitMap = new Bitmap(fileName);
                ImageFormat bmpFormat = bitMap.RawFormat;
                var imageToConvert = Image.FromFile(fileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, bmpFormat);
                    return ms.ToArray();
                }
            }

            else
                return null;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = null;
                if (ms != null)
                    returnImage = Image.FromStream(ms);
                return returnImage;
            }
            else
                return null;
        }
    }
}

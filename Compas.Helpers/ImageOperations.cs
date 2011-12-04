using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace Compas.Helpers
{
    public static class ImageOperations
    {
        public static byte[] ConvertImageToByteArray(string fileName)
        {
            if (File.Exists(fileName) == true)
            {
                //Bitmap bitMap = new Bitmap(fileName);
                //ImageFormat bmpFormat = bitMap.RawFormat;
                //var imageToConvert = Image.FromFile(fileName);

                //using (MemoryStream ms = new MemoryStream())
                //{
                //    imageToConvert.Save(ms, bmpFormat);
                //    return ms.ToArray();
                //}

                //Bitmap bitMap = new Bitmap(fileName);
                //bitMap.MakeTransparent();
                //ImageFormat bmpFormat = bitMap.RawFormat;
                //Image imageToConvert = Image.FromFile(fileName);
                //Image tempImage = imageToConvert;
                ////using (Graphics g = Graphics.FromImage(imageToConvert))
                ////{
                ////    g.Clear(Color.White);
                ////    g.DrawImageUnscaled(tempImage, 0, 0);
                ////}

                var img_old = new Bitmap(fileName);
                var img_new = new Bitmap(img_old.Width, img_old.Height);


                Graphics g = Graphics.FromImage(img_new);
                g.Clear(Color.White);
                g.DrawImage(img_old, 0, 0, img_old.Width, img_old.Height);



                using (MemoryStream ms = new MemoryStream())
                {
                    img_new.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }

            else
                return null;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
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

        //private static Image TransformImage(int width, int height, Image image
        //    )
        //{
        //    float scale = (float)width / image.Width;
        //    Bitmap thump = new Bitmap(width, height);
        //    Graphics graphics = Graphics.FromImage(thump);
        //    Matrix transform = new Matrix();

        //    transform.Scale(scale, scale, MatrixOrder.Append);
        //    graphics.SetClip(new Rectangle(0, 0, width, height));
        //    graphics.Transform = transform;
        //    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //    graphics.DrawImage(image, 0, 0, image.Width, image.Height);

        //    ImageCodecInfo[] Info = ImageCodecInfo.GetImageEncoders();
        //    EncoderParameters Params = new EncoderParameters(1);
        //    Params.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);            


        //    thump.Dispose();
        //    graphics.Dispose();
        //}
        public static Image ScaleImage(Image SourceImage, int? NewWidth, int? NewHeight)
        {
            int width = SourceImage.Width;
            int height = SourceImage.Height;
            float scale = (float)SourceImage.Width / (float)SourceImage.Height;
            if (NewWidth != null)
            {
                width = (int)NewWidth;
                height = (int)((float)width / scale);
            }

            if (NewHeight != null)
            {               
                height = (int)NewHeight;
                width = (int)((float)height * scale);
            }

            Bitmap newImage = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(newImage);

            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.DrawImage(SourceImage, new Rectangle(0, 0, width, height));

            Image result = (Image)newImage;
            return result;


        }
    }
}

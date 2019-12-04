using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Encoder = System.Drawing.Imaging.Encoder;
using System.IO;
namespace proyectoFinal.Classes
{
    public class Adapter
    {
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public string ImageToPath(Image img, string name)
        {
            
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = path.Substring(0, path.Length - 17);
            ImageCodecInfo encoderInfo = GetEncoderInfo("image/jpeg");

            Encoder encoder = Encoder.Quality;
            var parameters = new EncoderParameters(1);
            var parameter= new EncoderParameter(encoder, 100L);
            parameters.Param[0] = parameter;
            string p = path + name + ".jpg";
            try
            {
                img.Save(path + name + ".jpg", encoderInfo, parameters);
                return path + name + ".jpg";
            }
            catch (Exception e)
            {
                img.Save(path + name + "2.jpg", encoderInfo, parameters);
                return path + name + "2.jpg";
            }
            

        }

        public Image PathToImage(string path)
        {
            return Image.FromFile(@path);
        }
    }
}

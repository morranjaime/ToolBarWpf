using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ProjectToolBarScroll.Converter
{
    public class ConverterImageDrawingToImageControl : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.GetType() == typeof(Bitmap))
                {
                    Image imageDrawing = value as Bitmap;
                    System.Windows.Controls.Image imageControl = new System.Windows.Controls.Image();
                    imageControl.Source = ConvertBitMapToImageInMemory(imageDrawing);
                    return imageControl.Source;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Crea un objeto de tipo Image
        /// </summary>
        /// <param name="uri">String con la ruta de la imagen, ej: "/ViewUtil;component/Images/MailList.png"</param>
        /// <returns>Devuelve un BitmapImage</returns>
        private BitmapImage ConvertBitMapToImageInMemory(Image bitmap)
        {
            MemoryStream memory = new MemoryStream();
            bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            memory.Position = 0;
            BitmapImage bitmapimage = new BitmapImage();
            bitmapimage.BeginInit();
            bitmapimage.StreamSource = memory;
            bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapimage.EndInit();

            return bitmapimage;
        }
    }

}

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media.Imaging;

namespace facebook_windows_phone_sample.Image {
    public static class ConvertImage {

        public static byte[] ConvertToBytes(this BitmapImage bitmapImage) {
            bitmapImage.CreateOptions = BitmapCreateOptions.None;

            using (MemoryStream ms = new MemoryStream()) {
                WriteableBitmap btmMap = new WriteableBitmap(bitmapImage);
                btmMap.SaveJpeg(ms, bitmapImage.PixelWidth, bitmapImage.PixelHeight, 0, 100);

                return ms.ToArray();
            }
        }

        public static byte[] ConvertToBytes(this WriteableBitmap wbm) {

            using (MemoryStream ms = new MemoryStream()) {
                wbm.SaveJpeg(ms, wbm.PixelWidth, wbm.PixelHeight, 0, 100);
                return ms.ToArray();
            }
        }

    }
}

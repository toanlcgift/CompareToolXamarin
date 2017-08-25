using System;
using Xamarin.Forms;
namespace CompareImage
{
    public class CustomImage : Image
    {
        public void LoadFromStream(System.IO.Stream stream)
        {
            this.Source = FileImageSource.FromStream(() =>
            {
                return stream;
            });
        }
    }
}

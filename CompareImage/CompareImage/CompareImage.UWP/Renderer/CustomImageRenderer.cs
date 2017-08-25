using System;
using CompareImage;
using CompareImage.UWP.Renderer;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace CompareImage.UWP.Renderer
{
    public class CustomImageRenderer : ImageRenderer
    {

    }
}

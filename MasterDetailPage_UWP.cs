using MasterDetailPageNavigation;
using MasterDetailPageNavigation.UWP;
using System;

using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(MasterPage), typeof(MasterPageRenderer))]
namespace MasterDetailPageNavigation.UWP
{
    class MasterPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
                {
                    Windows.UI.Xaml.Media.AcrylicBrush myBrush = new Windows.UI.Xaml.Media.AcrylicBrush();
                    myBrush.BackgroundSource = Windows.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
                    myBrush.TintColor = Windows.UI.Color.FromArgb(255, 200, 200, 200);
                    myBrush.TintOpacity = 0.2;

                    Background = myBrush;
                }
                else
                {
                    SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 240, 240, 240));

                    Background = myBrush;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        protected override Windows.Foundation.Size ArrangeOverride(Windows.Foundation.Size finalSize)
        {
            return base.ArrangeOverride(finalSize);
        }

    }
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Toolkit
{
    // This will allow us to set any property of type Color by specifying values of hue, saturation, and luminosity, 
    // but in a manner much simpler than the use of the x:FactoryMethod tag
    public class HslColorExtension : IMarkupExtension
    {
        public HslColorExtension()
        {
            A = 1;
        }

        public double H { set; get; }

        public double S { set; get; }

        public double L { set; get; }

        public double A { set; get; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromHsla(H, S, L, A);
        }
    }
}

using System;

namespace Lelu
{
    class Program
    {
        static void Main(string[] args)
        {
            Lelu lelu1 = new Lelu("My little pony", 125);
            lelu1.TulostaTiedot();

            Vieteriauto vieteriauto = new Vieteriauto("rättäri", 150, 2, 1);
            vieteriauto.TulostaTiedot();
            vieteriauto.TulostaVieteriautonTiedot();
        }
    }
}

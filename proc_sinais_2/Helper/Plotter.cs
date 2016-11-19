using System;

namespace proc_sinais_2.Helper
{
    public class Plotter
    {
        public Plotter()
        {

        }

        public static double[] GetPlot(Complex[] data)
        {
            double[] amp = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                amp[i] = data[i].GetMagnitude();

            }
            return amp;
        }
    }
}

using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proc_sinais_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var furksValues = GetValuesByFreq(30).ToList();

            var chartValues = new ChartValues<double>();

            furksValues.ForEach(f => chartValues.Add(f));

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = chartValues
                }
            };




            DataContext = this;
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_generate(object sender, RoutedEventArgs e)
        {
            var freq = Convert.ToInt32(((Button)sender).Tag);

            //TODO: Generate result

            var furksValues = GetValuesByFreq(freq).ToList();

            var chartValues = new ChartValues<double>();

            furksValues.ForEach(f => chartValues.Add(f));

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = chartValues
                }
            };

            DataContext = this;

        }

        public double[] GetValuesByFreq(int freq)
        {
            return new double[] { 10, 20, 30 };
        }
    }
}

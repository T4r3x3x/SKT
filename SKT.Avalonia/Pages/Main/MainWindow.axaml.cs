using Avalonia.Controls;
using Avalonia.ReactiveUI;

using ScottPlot.Avalonia;

namespace SKT.Pages.Main
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            double[] dataX =
            {
                1, 2, 3, 4, 5
            };
            double[] dataY =
            {
                1, 4, 9, 16, 25
            };

            var avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
            avaPlot1.Plot.Add.Scatter(dataX, dataY);
            avaPlot1.Refresh();
        }
    }
}
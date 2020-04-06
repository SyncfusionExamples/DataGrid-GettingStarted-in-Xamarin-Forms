using System.Windows;
using Syncfusion.SfDataGrid.XForms.WPF;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace GettingStarted.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            SfDataGridRenderer.Init();
            LoadApplication(new GettingStarted.App());
        }
    }
}

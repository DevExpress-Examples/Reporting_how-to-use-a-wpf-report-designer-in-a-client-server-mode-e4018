using System.Windows;
using DevExpress.Xpf.Core;

namespace WpfReportDesignerDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ThemeManager.ApplicationThemeName = "Office2007Silver";
            InitializeComponent();
        }
    }
}

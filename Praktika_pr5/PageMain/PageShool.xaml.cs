using Praktika_pr5.Window1;
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

namespace Praktika_pr5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageShool.xaml
    /// </summary>
    public partial class PageShool : Page
    {
        public PageShool()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var myWindows = Window.GetWindow(this);
            WindowShool windowShool = new WindowShool();
            windowShool.Show();
            myWindows.Close();
        }
    }
}

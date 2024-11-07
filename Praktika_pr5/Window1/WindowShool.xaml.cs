using Praktika_pr5.ApplicationData;
using Praktika_pr5.PageMain;
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
using System.Windows.Shapes;

namespace Praktika_pr5.Window1
{
    /// <summary>
    /// Логика взаимодействия для WindowShool.xaml
    /// </summary>
    public partial class WindowShool : Window
    {
        public WindowShool()
        {
            InitializeComponent();
            AppConnect.modelOdb = new ChkolaEntities();
            AppFrame.FrameMain = myFrame;  //загрузка фрейма со стартом
            myFrame.Navigate(new Page());// страница PageA
        }

        private void Ysludi_Click(object sender, RoutedEventArgs e)
        {
         AppFrame.FrameMain.Navigate(new PageA());
        }
    }
}

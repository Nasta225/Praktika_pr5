using Praktika_pr5.ApplicationData;
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
    /// Логика взаимодействия для PageA.xaml
    /// </summary>
    public partial class PageA : Page
    {
        public PageA()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = ChkolaEntities.GetContext().Service.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ChkolaEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DtGridTovar.ItemsSource = ChkolaEntities.GetContext().Service.ToList();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemiving = DtGridTovar.SelectedItems.Cast<Service>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить текущее {tovarForRemiving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ChkolaEntities.GetContext().Service.RemoveRange(tovarForRemiving);
                    ChkolaEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DtGridTovar.ItemsSource = ChkolaEntities.GetContext().Service.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageShool());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageShool());
        }
    }
}

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

namespace LogBookWPFApplication
{
    /// <summary>
    /// Interaction logic for WeeklyLogbook.xaml
    /// </summary>
    public partial class WeeklyLogbook : Window
    {
        public WeeklyLogbook()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Activate();
            if (Learner.RoleIdentification == 1)
            {
                main.btnUserControl.IsEnabled = false;
            }

            main.Show();
            this.Close();
        }

      
    }
}

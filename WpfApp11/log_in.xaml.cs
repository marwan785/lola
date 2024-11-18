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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        ddfEntities2 db =new ddfEntities2();
        public log_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(user_tx.Text=="marwan dief" && pass.Password == "maro@123")
            {
                MessageBox.Show("admin is concted");
                data_grid d = new data_grid();
                NavigationService.Navigate(d);
            }
            else
            {
                MessageBox.Show("mesh haynf3 had ye5osh");
            }
            
        }
    }
}

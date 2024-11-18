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
    /// Interaction logic for data_grid.xaml
    /// </summary>
    public partial class data_grid : Page
    {
        ddfEntities2 db = new ddfEntities2();
        public data_grid()
        {
            InitializeComponent();
            d_g.ItemsSource = db.students.Select(x => new {x.id,x.names,x.grad,x.teacher.t_name,x.teacher.t_sybject}).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (search_tx.Text != "")
            {
                d_g.ItemsSource = db.students.Where(x => x.names.Contains(search_tx.Text)).Select(x => new  { x.id, x.names, x.grad, x.teacher.t_name, x.teacher.t_sybject }).ToList();

            }
            else
            {
                MessageBox.Show("el name mesh mawgod");
            }
            //s
        }

    }
}

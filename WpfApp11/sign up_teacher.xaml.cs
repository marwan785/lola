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
    /// Interaction logic for sign_up_teacher.xaml
    /// </summary>
    public partial class sign_up_teacher : Page
    {
        ddfEntities2 db = new ddfEntities2();
        public sign_up_teacher()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nt_tx.Text) && !string.IsNullOrEmpty(sb_tx.Text) &&!string.IsNullOrEmpty(p_t.Text)) 
            {
            teacher t=new teacher();
             t.t_name=nt_tx.Text;
             t.t_sybject=nt_tx.Text;
             int pas=int.Parse(p_t.Text);
                t.t_password=pas;
             db.teachers.Add(t);
             db.SaveChanges();
              MessageBox.Show("acount created");
             log_in n=new log_in();
             NavigationService.Navigate(n);

            }
            else
            {
                MessageBox.Show("enter data");
            }
        }
    }
}

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
    /// Interaction logic for sign_up_student.xaml
    /// </summary>
    public partial class sign_up_student : Page
          {
        ddfEntities2 db = new ddfEntities2();
        public sign_up_student()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             if(!string.IsNullOrEmpty(name_tx.Text)&&!string.IsNullOrEmpty(em_tx.Text)&&!string.IsNullOrEmpty(gr_tx.Text)&&!string.IsNullOrEmpty(p_tx.Text))
            {
                student s = new student();
                s.names = name_tx.Text;
                s.email = em_tx.Text;
                s.grad = gr_tx.Text;
               int p=int.Parse(p_tx.Text);
                db.students.Add(s);
                db.SaveChanges();
                MessageBox.Show("acount created");
                log_in l = new log_in();
                NavigationService.Navigate(l);
            }
            else
            {
                MessageBox.Show("enter data");
            }
        }
    }
}

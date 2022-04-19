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

namespace BankingSyestem.SignUp
{
    /// <summary>
    /// Interaction logic for SignUpForm.xaml
    /// </summary>
    public partial class SignUpForm : Window
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SignUpDO signUpDO = new SignUpDO();
            signUpDO.firstName = txtFirstName.Text;
            signUpDO.lastName = txtLastName.Text;
            signUpDO.userName = txtUserName.Text;
            signUpDO.email = txtEMail.Text;
            signUpDO.city = txtCity.Text;
            signUpDO.pincode = Convert.ToInt32(txtPincode.Text);
            signUpDO.password = txtPassword.Text;


        }
    }
}

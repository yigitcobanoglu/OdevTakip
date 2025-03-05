using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTakip
{
    public partial class Password : Form
    {
        
        public Password()
        {
            InitializeComponent();  
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Yiit" &&
               txtPassword.Text == "0000")
            {
                DialogResult = DialogResult.OK;//formu kapatır
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı yada parola!");
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}

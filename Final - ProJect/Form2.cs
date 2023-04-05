using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final___ProJect
{
    public partial class Form2 : Form
    {
        public UserInfo _newUserInfo;
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = tbFName.Text;
            string lastname = tbLName.Text;
            string idcard = tbIDCard.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            try
            {
                _newUserInfo = new UserInfo(firstname, lastname, idcard, phone, email);
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR");
                return;
            }

        }
        public UserInfo getUserInfo() { return _newUserInfo; }

        private void tbFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

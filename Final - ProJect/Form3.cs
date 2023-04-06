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
    public partial class Form3 : Form
    {
        public List<UserInfo> listInfo = new List<UserInfo>();
        UserInfo selectedUserInfo;


        public Form3()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addDatasUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (form2.DialogResult == DialogResult.OK)
            {
                UserInfo newUserinfo = form2.getUserInfo();
                listInfo.Add(newUserinfo);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listInfo;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectedUserInfo = (UserInfo)row.DataBoundItem;

                this.tbFName.HeaderText = selectedUserInfo.Name;
                this.tbLName.HeaderText = selectedUserInfo.Lname;
                this.tbIDCard.HeaderText = selectedUserInfo.Idcard;
                this.tbPhone.HeaderText = selectedUserInfo.Phone;
                this.tbEmail.HeaderText = selectedUserInfo.Email;
            }
            string firstname = selectedUserInfo.Name, lastname = selectedUserInfo.Lname, idcard = selectedUserInfo.Idcard, phone = selectedUserInfo.Phone, email = selectedUserInfo.Email;
            selectedUserInfo = new UserInfo(firstname, lastname, idcard, phone, email);
        }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 5)
                        {
                            UserInfo userInfos = new UserInfo(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                line[4]
                            );
                            listInfo.Add(userInfos);
                        }
                    }

                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listInfo;
            }

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (UserInfo item in listInfo)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                            item.Name,
                            item.Lname,
                            item.Idcard,
                            item.Phone,
                            item.Email
                            ));
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

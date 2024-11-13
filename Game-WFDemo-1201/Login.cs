using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_WFDemo_1201
{
    public partial class Login : Form
    {
        Creator form_creator = new Creator();
        public Login()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text == "cuonghd7" && tb_password.Text == "123")
            {
                if (cb_role.Text == "Game Creator")
                {
                    form_creator.ShowDialog();
                }
                if (cb_role.Text == "Game Player")
                {
                    Player form_player = new Player(form_creator.question_bank);
                    form_player.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username of password!");
            }
        }
    }
}

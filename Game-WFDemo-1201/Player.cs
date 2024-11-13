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
    public partial class Player : Form
    {
        List<Question> question_bank = new List<Question>();
        public Player(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if(question_bank.Count > 0)
            {
                rt_question.Text = question_bank[0].question;
            }
            else
            {
                MessageBox.Show("No question in question bank!");
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {

        }
    }
}

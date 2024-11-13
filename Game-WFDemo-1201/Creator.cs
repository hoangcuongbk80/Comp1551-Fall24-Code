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
    public partial class Creator : Form
    {
        public List<Question> question_bank = new List<Question>();
        public Creator()
        {
            InitializeComponent();
        }

        private void Creator_Load(object sender, EventArgs e)
        {

        }

        private void bt_add_question_Click(object sender, EventArgs e)
        {
            string question = "Question: " + rt_question.Text + "\n";
            string answer = "Answer: " + rt_answer.Text + "\n";
            Question new_question = new Question(question, answer);
            question_bank.Add(new_question);    
        }

        private void bt_display_all_Click(object sender, EventArgs e)
        {
            rt_all_question.Clear();
            foreach (Question question in question_bank)
            {
                rt_all_question.Text += question.question;
                rt_all_question.Text += question.answer;
            }
        }
    }
}

namespace Game_WFDemo_1201
{
    partial class Creator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_question = new System.Windows.Forms.RichTextBox();
            this.rt_answer = new System.Windows.Forms.RichTextBox();
            this.bt_add_question = new System.Windows.Forms.Button();
            this.rt_all_question = new System.Windows.Forms.RichTextBox();
            this.bt_display_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(12, 118);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(576, 87);
            this.rt_question.TabIndex = 0;
            this.rt_question.Text = "";
            // 
            // rt_answer
            // 
            this.rt_answer.Location = new System.Drawing.Point(18, 303);
            this.rt_answer.Name = "rt_answer";
            this.rt_answer.Size = new System.Drawing.Size(576, 87);
            this.rt_answer.TabIndex = 1;
            this.rt_answer.Text = "";
            // 
            // bt_add_question
            // 
            this.bt_add_question.Location = new System.Drawing.Point(18, 463);
            this.bt_add_question.Name = "bt_add_question";
            this.bt_add_question.Size = new System.Drawing.Size(328, 61);
            this.bt_add_question.TabIndex = 2;
            this.bt_add_question.Text = "Add Question";
            this.bt_add_question.UseVisualStyleBackColor = true;
            this.bt_add_question.Click += new System.EventHandler(this.bt_add_question_Click);
            // 
            // rt_all_question
            // 
            this.rt_all_question.Location = new System.Drawing.Point(656, 66);
            this.rt_all_question.Name = "rt_all_question";
            this.rt_all_question.Size = new System.Drawing.Size(756, 609);
            this.rt_all_question.TabIndex = 3;
            this.rt_all_question.Text = "";
            // 
            // bt_display_all
            // 
            this.bt_display_all.Location = new System.Drawing.Point(656, 697);
            this.bt_display_all.Name = "bt_display_all";
            this.bt_display_all.Size = new System.Drawing.Size(328, 61);
            this.bt_display_all.TabIndex = 4;
            this.bt_display_all.Text = "Display All Questions";
            this.bt_display_all.UseVisualStyleBackColor = true;
            this.bt_display_all.Click += new System.EventHandler(this.bt_display_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 784);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_display_all);
            this.Controls.Add(this.rt_all_question);
            this.Controls.Add(this.bt_add_question);
            this.Controls.Add(this.rt_answer);
            this.Controls.Add(this.rt_question);
            this.Name = "Creator";
            this.Text = "Game Creator";
            this.Load += new System.EventHandler(this.Creator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_question;
        private System.Windows.Forms.RichTextBox rt_answer;
        private System.Windows.Forms.Button bt_add_question;
        private System.Windows.Forms.RichTextBox rt_all_question;
        private System.Windows.Forms.Button bt_display_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
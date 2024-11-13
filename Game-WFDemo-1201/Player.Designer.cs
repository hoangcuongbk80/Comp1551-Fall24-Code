namespace Game_WFDemo_1201
{
    partial class Player
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_question
            // 
            this.rt_question.Location = new System.Drawing.Point(12, 90);
            this.rt_question.Name = "rt_question";
            this.rt_question.Size = new System.Drawing.Size(566, 488);
            this.rt_question.TabIndex = 0;
            this.rt_question.Text = "";
            // 
            // rt_answer
            // 
            this.rt_answer.Location = new System.Drawing.Point(627, 89);
            this.rt_answer.Name = "rt_answer";
            this.rt_answer.Size = new System.Drawing.Size(577, 488);
            this.rt_answer.TabIndex = 1;
            this.rt_answer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(524, 618);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(160, 59);
            this.bt_next.TabIndex = 5;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(303, 615);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(144, 62);
            this.bt_start.TabIndex = 6;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_finish
            // 
            this.bt_finish.Location = new System.Drawing.Point(780, 628);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(149, 49);
            this.bt_finish.TabIndex = 7;
            this.bt_finish.Text = "Finish";
            this.bt_finish.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 759);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_answer);
            this.Controls.Add(this.rt_question);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_question;
        private System.Windows.Forms.RichTextBox rt_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_finish;
    }
}
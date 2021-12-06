
namespace mathTrainer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelWrong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTBWrong = new System.Windows.Forms.RichTextBox();
            this.rTBCorrect = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 123);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "get question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(130, 141);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(181, 86);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelWrong
            // 
            this.LabelWrong.AutoSize = true;
            this.LabelWrong.BackColor = System.Drawing.Color.Red;
            this.LabelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWrong.Location = new System.Drawing.Point(20, 278);
            this.LabelWrong.Name = "LabelWrong";
            this.LabelWrong.Size = new System.Drawing.Size(81, 25);
            this.LabelWrong.TabIndex = 4;
            this.LabelWrong.Text = "Wrong ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correct";
            // 
            // rTBWrong
            // 
            this.rTBWrong.Location = new System.Drawing.Point(107, 278);
            this.rTBWrong.Name = "rTBWrong";
            this.rTBWrong.Size = new System.Drawing.Size(66, 25);
            this.rTBWrong.TabIndex = 6;
            this.rTBWrong.Text = "";
            this.rTBWrong.TextChanged += new System.EventHandler(this.rTBWrong_TextChanged);
            // 
            // rTBCorrect
            // 
            this.rTBCorrect.Location = new System.Drawing.Point(107, 326);
            this.rTBCorrect.Name = "rTBCorrect";
            this.rTBCorrect.Size = new System.Drawing.Size(66, 25);
            this.rTBCorrect.TabIndex = 7;
            this.rTBCorrect.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(505, 378);
            this.Controls.Add(this.rTBCorrect);
            this.Controls.Add(this.rTBWrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelWrong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "mathTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelWrong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTBWrong;
        private System.Windows.Forms.RichTextBox rTBCorrect;
    }
}


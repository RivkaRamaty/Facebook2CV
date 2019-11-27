namespace Facebook2CV.UI
{
    partial class EditAndSaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveDOC = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit and Save:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 27);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(477, 306);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // saveDOC
            // 
            this.saveDOC.Location = new System.Drawing.Point(292, 448);
            this.saveDOC.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.saveDOC.Name = "saveDOC";
            this.saveDOC.Size = new System.Drawing.Size(86, 36);
            this.saveDOC.TabIndex = 3;
            this.saveDOC.Text = "Save as DOC";
            this.saveDOC.UseVisualStyleBackColor = true;
            this.saveDOC.Click += new System.EventHandler(this.saveAsDocButton_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(399, 448);
            this.exit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 36);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email CV:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(12, 377);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(154, 20);
            this.fromTextBox.TabIndex = 7;
            this.fromTextBox.Text = "Sender email address";
            this.fromTextBox.Click += new System.EventHandler(this.fromTextBox_Click);
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(12, 422);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(154, 20);
            this.toTextBox.TabIndex = 7;
            this.toTextBox.Text = "Recipient email address";
            this.toTextBox.Click += new System.EventHandler(this.toTextBox_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(168, 377);
            this.Send.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(86, 51);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(12, 354);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(244, 20);
            this.subjectTextBox.TabIndex = 7;
            this.subjectTextBox.Text = "Subject";
            this.subjectTextBox.Click += new System.EventHandler(this.subjectTextBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 399);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // EditAndSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(502, 493);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.saveDOC);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "EditAndSaveForm";
            this.Text = "Edit Before Save";
            this.Load += new System.EventHandler(this.EditAndSaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveDOC;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}
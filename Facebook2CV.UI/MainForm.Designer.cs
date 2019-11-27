namespace Facebook2CV.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.login = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.RichTextBox();
            this.post = new System.Windows.Forms.Button();
            this.aboutMeTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.languagesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.educationCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.prevJobscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.editBeforeSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.designComboBox = new System.Windows.Forms.ComboBox();
            this.userInfoProxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoProxyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Azure;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.Location = new System.Drawing.Point(14, 1591);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(201, 80);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePic.Location = new System.Drawing.Point(30, 33);
            this.profilePic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(300, 298);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(33, 370);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(301, 56);
            this.uploadPic.TabIndex = 6;
            this.uploadPic.Text = "Change Pictrue";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.changePicture_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.Azure;
            this.textBoxStatus.Location = new System.Drawing.Point(422, 426);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(744, 82);
            this.textBoxStatus.TabIndex = 7;
            this.textBoxStatus.Text = "Hello Facebook friends! I am looking for a job in the field of";
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(1185, 426);
            this.post.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(166, 83);
            this.post.TabIndex = 8;
            this.post.Text = "Post";
            this.post.UseVisualStyleBackColor = true;
            this.post.Click += new System.EventHandler(this.post_Click);
            // 
            // aboutMeTextBox
            // 
            this.aboutMeTextBox.BackColor = System.Drawing.Color.Azure;
            this.aboutMeTextBox.Location = new System.Drawing.Point(422, 243);
            this.aboutMeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutMeTextBox.Name = "aboutMeTextBox";
            this.aboutMeTextBox.Size = new System.Drawing.Size(928, 145);
            this.aboutMeTextBox.TabIndex = 9;
            this.aboutMeTextBox.Text = "About Me (taken form Facebook, editable)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Previous Jobs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 816);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Education:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Post to Facebook:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Edit About Me:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(691, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(889, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(1255, 33);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(1080, 33);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Azure;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.Location = new System.Drawing.Point(1155, 1591);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(201, 80);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // languagesCheckedListBox
            // 
            this.languagesCheckedListBox.BackColor = System.Drawing.Color.Azure;
            this.languagesCheckedListBox.FormattingEnabled = true;
            this.languagesCheckedListBox.Location = new System.Drawing.Point(33, 1182);
            this.languagesCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.languagesCheckedListBox.Name = "languagesCheckedListBox";
            this.languagesCheckedListBox.Size = new System.Drawing.Size(1325, 184);
            this.languagesCheckedListBox.TabIndex = 3;
            // 
            // educationCheckedListBox
            // 
            this.educationCheckedListBox.BackColor = System.Drawing.Color.Azure;
            this.educationCheckedListBox.FormattingEnabled = true;
            this.educationCheckedListBox.Location = new System.Drawing.Point(33, 854);
            this.educationCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.educationCheckedListBox.Name = "educationCheckedListBox";
            this.educationCheckedListBox.Size = new System.Drawing.Size(1325, 184);
            this.educationCheckedListBox.TabIndex = 22;
            // 
            // prevJobscheckedListBox
            // 
            this.prevJobscheckedListBox.BackColor = System.Drawing.Color.Azure;
            this.prevJobscheckedListBox.FormattingEnabled = true;
            this.prevJobscheckedListBox.Location = new System.Drawing.Point(33, 538);
            this.prevJobscheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevJobscheckedListBox.Name = "prevJobscheckedListBox";
            this.prevJobscheckedListBox.Size = new System.Drawing.Size(1325, 184);
            this.prevJobscheckedListBox.TabIndex = 23;
            // 
            // editBeforeSave
            // 
            this.editBeforeSave.BackColor = System.Drawing.Color.Azure;
            this.editBeforeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editBeforeSave.FlatAppearance.BorderSize = 0;
            this.editBeforeSave.Location = new System.Drawing.Point(926, 1591);
            this.editBeforeSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBeforeSave.Name = "editBeforeSave";
            this.editBeforeSave.Size = new System.Drawing.Size(201, 80);
            this.editBeforeSave.TabIndex = 24;
            this.editBeforeSave.Text = "Edit Before Save";
            this.editBeforeSave.UseVisualStyleBackColor = false;
            this.editBeforeSave.Click += new System.EventHandler(this.editBeforeSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 1131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Languages:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 767);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1138, 35);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 1084);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1138, 35);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 1417);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1138, 35);
            this.textBox3.TabIndex = 27;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(1199, 767);
            this.add1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(154, 45);
            this.add1.TabIndex = 28;
            this.add1.Text = "Add";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(1199, 1084);
            this.add2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(154, 45);
            this.add2.TabIndex = 29;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(1199, 1412);
            this.add3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(154, 45);
            this.add3.TabIndex = 30;
            this.add3.Text = "Add";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 1461);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 36);
            this.label6.TabIndex = 33;
            this.label6.Text = "CV Design:";
            // 
            // designComboBox
            // 
            this.designComboBox.FormattingEnabled = true;
            this.designComboBox.Items.AddRange(new object[] {
            "Basic Design",
            "No Design"});
            this.designComboBox.Location = new System.Drawing.Point(35, 1512);
            this.designComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.designComboBox.Name = "designComboBox";
            this.designComboBox.Size = new System.Drawing.Size(468, 37);
            this.designComboBox.TabIndex = 36;
            // 
            // userInfoProxyBindingSource
            // 
            this.userInfoProxyBindingSource.DataSource = typeof(Facebook2CV.RemoteProxy.UserInfoProxy);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.userInfoProxyBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(348, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 33);
            this.listBox1.TabIndex = 37;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInfoProxyBindingSource, "About", true));
            this.aboutTextBox.Location = new System.Drawing.Point(348, 149);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(1003, 35);
            this.aboutTextBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 36);
            this.label7.TabIndex = 39;
            this.label7.Text = "Welcome Back";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.designComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editBeforeSave);
            this.Controls.Add(this.prevJobscheckedListBox);
            this.Controls.Add(this.educationCheckedListBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutMeTextBox);
            this.Controls.Add(this.post);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.languagesCheckedListBox);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Facebook2CV";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoProxyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.RichTextBox textBoxStatus;
        private System.Windows.Forms.Button post;
        private System.Windows.Forms.RichTextBox aboutMeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.CheckedListBox languagesCheckedListBox;
        private System.Windows.Forms.CheckedListBox educationCheckedListBox;
        private System.Windows.Forms.CheckedListBox prevJobscheckedListBox;
        private System.Windows.Forms.Button editBeforeSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox designComboBox;
        private System.Windows.Forms.BindingSource userInfoProxyBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.Label label7;
    }
}
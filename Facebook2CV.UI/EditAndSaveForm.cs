using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Facebook2CV.Logic;

namespace Facebook2CV.UI
{
    public partial class EditAndSaveForm : Form
    {
        private static EditAndSaveForm m_editAndSaveForm = null;

        private static string m_ChosenDesign = "Basic Design";

        private ChosenUserData m_UserInfo;

        private ICVFormat m_ChosenFormat = CVFactory.getCVFormat(m_ChosenDesign);

        public static EditAndSaveForm getEditAndSaveForm(ChosenUserData i_UserInfo, object i_ChosenDesign)
        {
            if (m_editAndSaveForm == null)
            {
                m_editAndSaveForm = new EditAndSaveForm(i_UserInfo, i_ChosenDesign);
            }
            else
            {
                m_editAndSaveForm.m_UserInfo = i_UserInfo;
                m_ChosenDesign = i_ChosenDesign.ToString();
            }

            return m_editAndSaveForm;
        }

        public void SetText(string i_Text)
        {
            richTextBox1.Text = i_Text;
        }

        private EditAndSaveForm(ChosenUserData i_UserInfo, object i_ChosenDesign)
        {
            m_UserInfo = i_UserInfo;
            m_ChosenDesign = i_ChosenDesign.ToString();
            InitializeComponent();
        }

        private void saveAsDocButton_Click(object sender, EventArgs e)
        {
            ICVFormat cvformat = CVFactory.getCVFormat(m_ChosenDesign);
            CVCreator cvDecorater = new CVCreator(cvformat);
            cvDecorater.createCV(m_UserInfo, "doc");
            MessageBox.Show("File Saved successfuly");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void EditAndSaveForm_Load(object sender, EventArgs e)
        {
            this.SetText(m_ChosenFormat.EditTextToCV(m_UserInfo));
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string fromaddr = fromTextBox.Text;
            string toaddr = toTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                MailMessage msg = new MailMessage();
                msg.Subject = subjectTextBox.Text;
                msg.From = new MailAddress(fromaddr);
                msg.Body = richTextBox1.Text;
                msg.To.Add(new MailAddress(toTextBox.Text));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential(fromaddr, password);
                smtp.Credentials = nc;
                smtp.Send(msg);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"Unable to send mail. 
Please make sure your all relevant fields are propely populated and try again.");
            }
        }

        private void subjectTextBox_Click(object sender, EventArgs e)
        {
            if (this.Text == "Subject")
            {
                this.Text = string.Empty;
            }
        }

        private void fromTextBox_Click(object sender, EventArgs e)
        {
            if (this.Text == "Sender email address")
            {
                this.Text = string.Empty;
            }
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (this.Text == "Password")
            {
                this.Text = string.Empty;
            }
        }

        private void toTextBox_Click(object sender, EventArgs e)
        {
            if (this.Text == "Recipient email address")
            {
                this.Text = string.Empty;
            }
        }
    }
}

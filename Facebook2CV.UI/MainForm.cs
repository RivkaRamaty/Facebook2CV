using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Facebook2CV.Logic;
using Facebook2CV.RemoteProxy;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook2CV.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private UserInfoProxy m_UserInfoProxy = new UserInfoProxy();
        private bool m_IsLoggedIn = false;
        private bool m_AllDataFetched = true;

        private void login_Click(object sender, EventArgs e)
        {
            if (!m_IsLoggedIn)
            {
                m_IsLoggedIn = true;
                loginAndInit();
                userInfoProxyBindingSource.DataSource = m_UserInfoProxy;
            }
            else
            {
                m_IsLoggedIn = false;
                logout();
            }
        }

        private void loginAndInit()
        {
            bool loginSuccessful = false;

            try
            {
                loginSuccessful = m_UserInfoProxy.Login();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Unable to connect to Facebook. 
Please try again later");
            }

            if (loginSuccessful)
            {
                login.Text = "Logout";
                designComboBox.SelectedIndex = 0;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(@"There has been a problem with the Facebook Access Token.
Please try again later");
            }
        }

        private void fetchUserInfo()
        {
            AbstractAboutMe aboutMeCreator = new AboutMeCreator1(m_UserInfoProxy);

            fetchProfilePic();
            fetchWorkExperiences();
            fetchEducations();
            fetchLanguages();
            aboutMeCreator.setAboutMe(aboutMeTextBox);

            if (m_AllDataFetched)
            {
                MessageBox.Show("One of the properties or more could not load correctly.");
            }
        }

        private void fetchProfilePic()
        {
            try
            {
                profilePic.Invoke(new Action(() => profilePic.LoadAsync(m_UserInfoProxy.Picture))); // fetch profile pic
            }
            catch (Exception)
            {
                m_AllDataFetched = false;
            }
        }

        private void fetchLanguages()
        {
            try
            {
                foreach (Page language in m_UserInfoProxy.Languages)
                {
                    languagesCheckedListBox.Invoke(new Action(() => languagesCheckedListBox.Items.Add(language.Name)));
                }

                languagesCheckedListBox.Refresh();
            }
            catch (Exception)
            {
                m_AllDataFetched = false;
            }
        }

        private void fetchEducations()
        {
            try
            {
                foreach (Education education in m_UserInfoProxy.Education)
                {
                    educationCheckedListBox.Invoke(new Action(() => educationCheckedListBox.Items.Add(education.ToString())));
                }

                educationCheckedListBox.Refresh();
            }
            catch (Exception)
            {
                m_AllDataFetched = false;
            }
        }

        private void fetchWorkExperiences()
        {
            try
            {
                foreach (WorkExperience prevJob in m_UserInfoProxy.WorkExperience)
                {
                    prevJobscheckedListBox.Invoke(new Action(() => prevJobscheckedListBox.Items.Add(prevJob.ToString())));
                }

                prevJobscheckedListBox.Refresh();
            }
            catch (Exception)
            {
                m_AllDataFetched = false;
            }
        }

        private void logoutAction()
        {
            MessageBox.Show("Logged out");
        }

        private string getTextFromCheckListBox(CheckedListBox i_CheckListBox)
        {
            StringBuilder textResult = new StringBuilder();

            foreach (string item in i_CheckListBox.CheckedItems)
            {
                textResult.Append(item);
                textResult.Append(Environment.NewLine);
            }

            return textResult.ToString();
        }

        private void logout()
        {
            FacebookService.Logout(logoutAction);
            login.Text = "Login";
        }

        private void changePicture_Click(object sender, EventArgs e)
        {
            if (m_IsLoggedIn)
            {
                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();

                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    profilePic.Image = new Bitmap(open.FileName);
                }
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
        }

        private void post_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_IsLoggedIn)
                {
                    Status postedStatus = m_UserInfoProxy.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                else
                {
                    MessageBox.Show("Please log in first.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Unable to post to Facebook.
Please change your permissions and try again.");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.alljobs.co.il");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.drushim.co.il");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.jobmaster.co.il");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com");
        }

        private void editBeforeSave_Click(object sender, EventArgs e)
        {
            if (m_IsLoggedIn)
            {
                ChosenUserData chosenUserData = new ChosenUserData(m_UserInfoProxy, aboutMeTextBox.Text, getTextFromCheckListBox(prevJobscheckedListBox), getTextFromCheckListBox(educationCheckedListBox), getTextFromCheckListBox(languagesCheckedListBox));
                Form editAndSaveForm = EditAndSaveForm.getEditAndSaveForm(chosenUserData, designComboBox.SelectedItem);

                editAndSaveForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
        }

        private void add1_Click(object sender, EventArgs e)
        {
            if (m_IsLoggedIn)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    prevJobscheckedListBox.Items.Add(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a value.");
                }
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
        }

        private void add2_Click(object sender, EventArgs e)
        {
            if (m_IsLoggedIn)
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    educationCheckedListBox.Items.Add(textBox2.Text);
                    textBox2.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a value.");
                }
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
        }

        private void add3_Click(object sender, EventArgs e)
        {
            if (m_IsLoggedIn)
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    languagesCheckedListBox.Items.Add(textBox3.Text);
                    textBox3.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a value.");
                }
            }
            else
            {
                MessageBox.Show("Please log in first.");
            }
        }
    }
}

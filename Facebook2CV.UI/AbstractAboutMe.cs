using System;
using System.Windows.Forms;

namespace Facebook2CV.UI
{
    public abstract class AbstractAboutMe
    {
        public void setAboutMe(RichTextBox i_AboutMeTextBox)
        {
            string aboutMe = formatAboutMe();

            i_AboutMeTextBox.Invoke(new Action(() => i_AboutMeTextBox.Text = aboutMe));
        }

        public abstract string formatAboutMe();
    }
}

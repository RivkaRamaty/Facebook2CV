using System.IO;

namespace Facebook2CV.Logic
{
    public class CVformat2 : ICVFormat
    {
        public string EditTextToCV(ChosenUserData i_User)
        {
            string text = string.Format(
@"
{0}
About me:
{4}
Previous Jobs:
{1}
Education:
{2}
Languages:
{3}",
           i_User.User.Name,
           i_User.PrevJobs,
           i_User.Education,
           i_User.Languages,
           i_User.AboutMe);
            return text;
        }
    }
}
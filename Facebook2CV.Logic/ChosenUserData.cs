using Facebook2CV.RemoteProxy;

namespace Facebook2CV.Logic
{
    public class ChosenUserData
    {
        public UserInfoProxy User { get; set; }

        public string AboutMe { get; set; }

        public string PrevJobs { get; set; }

        public string Education { get; set; }

        public string Languages { get; set; }

        public ChosenUserData()
        {
            User = null;
            AboutMe = string.Empty;
            PrevJobs = string.Empty;
            Education = string.Empty;
            Languages = string.Empty;
        }

        public ChosenUserData(UserInfoProxy i_user, string i_aboutMe, string i_prevJobs, string i_education, string i_languages)
        {
            User = i_user;
            AboutMe = i_aboutMe;
            PrevJobs = i_prevJobs;
            Education = i_education;
            Languages = i_languages;
        }
    }
}

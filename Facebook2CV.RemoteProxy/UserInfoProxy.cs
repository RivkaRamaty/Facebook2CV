using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Facebook2CV.RemoteProxy
{
    public class UserInfoProxy
    {
        private readonly string r_AppID = "2078460882483915";
        private readonly string[] r_Premissions =
            {
                                           "user_birthday",
                                           "user_friends",
                                           "user_events",
                                           "user_hometown",
                                           "user_likes",
                                           "user_location",
                                           "user_photos",
                                           "user_posts",
                                           "user_tagged_places",
                                           "user_videos",
                                           "user_status",
                                           "user_gender",
                                           "user_link",
                                           "user_age_range",
                                           "email",
                                           "publish_pages",
                                           "ads_management",
                                           "ads_read",
                                           "read_insights",
                                           "manage_pages",
                                           "read_page_mailboxes",
                                           "pages_show_list",
                                           "pages_manage_cta",
                                           "business_management",
                                           "pages_messaging",
                                           "pages_messaging_phone_number",
                                           "pages_messaging_subscriptions",
                                           "read_audience_network_insights",
                                           "pages_manage_instant_articles",
                                           "publish_video",
                                           "instagram_basic",
                                           "instagram_manage_comments",
                                           "instagram_manage_insights",
                                           "publish_to_groups",
                                           "groups_access_member_info",
                                           "leads_retrieval"
        };

        public User User { get; set; }

        public string About
        {
            get
            {
                return User.About;
            }

            set
            {
                User.About = value;
            }
        }

        public string Age
        {
            get
            {
                DateTime bDay = DateTime.Parse(User.Birthday);
                DateTime today = DateTime.Now;
                return ((int.Parse(today.ToString("yyyyMMdd")) - int.Parse(bDay.ToString("yyyyMMdd"))) / 10000).ToString();
            }
        }

        public string Location
        {
            get
            {
                string location = User.Location.ToString();
                location = location.Remove(location.Length - "(location: )".Length - 1);
                return location;
            }
        }

        public string Name
        {
            get
            {
                return User.Name;
            }
        }

        public Page[] Languages
        {
            get
            {
                return User.Languages;
            }
        }

        public Education[] Education
        {
            get
            {
                return User.Educations;
            }
        }

        public WorkExperience[] WorkExperience
        {
            get
            {
                return User.WorkExperiences;
            }
        }

        public string Picture
        {
            get
            {
                return User.PictureNormalURL;
            }
        }

        public bool Login()
        {
            LoginResult result = FacebookService.Login(r_AppID, r_Premissions);
            bool loginSuccessful = false;

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                loginSuccessful = true;
                this.User = result.LoggedInUser;
            }

            return loginSuccessful;
        }

        public UserInfoProxy()
        {
            User = null;
        }

        public UserInfoProxy(User i_User)
        {
            User = i_User;
        }

        public Status PostStatus(string i_Text)
        {
            return User.PostStatus(i_Text);
        }
    }
}

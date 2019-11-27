using System;
using Facebook2CV.RemoteProxy;

namespace Facebook2CV.UI
{
    public class AboutMeCreator1 : AbstractAboutMe
    {
        private UserInfoProxy m_UserInfoProxy;

        public AboutMeCreator1(UserInfoProxy i_UserInfoProxy)
        {
            m_UserInfoProxy = i_UserInfoProxy;
        }

        public override string formatAboutMe()
        {
            return string.Format("{0}\n{1} years old from {2}\nLooking for a position in", m_UserInfoProxy.Name, m_UserInfoProxy.Age, m_UserInfoProxy.Location);
        }
    }
}
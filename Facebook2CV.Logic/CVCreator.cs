using System.IO;

namespace Facebook2CV.Logic
{
    public class CVCreator : CreateCVDecorator
    {
        public CVCreator(ICVFormat i_Decorated) : base(i_Decorated)
        {
        }

        public override string EditTextToCV(ChosenUserData i_User)
        {
            return base.EditTextToCV(i_User);
        }

        public void createCV(ChosenUserData i_User, string i_Ending)
        {
            string text = EditTextToCV(i_User);
            string buildPath = string.Format(@".\CV.{0}", i_Ending);
            string path = buildPath.ToString();

            using (StreamWriter streamWriter = File.CreateText(path))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}

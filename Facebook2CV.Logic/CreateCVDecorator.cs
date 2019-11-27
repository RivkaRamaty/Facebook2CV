using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook2CV.Logic
{
    public abstract class CreateCVDecorator : ICVFormat
    {
        private ICVFormat m_Decorated;

        public CreateCVDecorator(ICVFormat i_Decorated)
        {
            m_Decorated = i_Decorated;
        }

        public virtual string EditTextToCV(ChosenUserData i_User)
        {
            return m_Decorated.EditTextToCV(i_User);
        }
    }
}

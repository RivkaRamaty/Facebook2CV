using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook2CV.Logic
{
    public class CVFactory
    {
        public static ICVFormat getCVFormat(string i_ChosenDesign)
        {
            switch (i_ChosenDesign)
            {
                case "Basic Design":
                    return new CVformat1();
                case "No Design":
                    return new CVformat2();
                default:
                    throw new Exception("Invalid CV format creation state.");
            }
        }
    }
}

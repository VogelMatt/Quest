using System;
namespace Quest
{
    public class Hat
    {
       

        public int ShininessLevel { get; set; }
        public string ShininessDescription()
        {
            int ShininessLevel = 0;
            
            if (ShininessLevel < 2)
            {
                return "dull hair";
            }
            else if (ShininessLevel >= 2 && ShininessLevel <= 5)
            {
                return "noticeable shininess";
            }
            else if (ShininessLevel >= 6 && ShininessLevel <= 9)
            {
                return "barely hanging on";
            }
            else if (ShininessLevel >= 9)
            {
                return "Blinding lights";
            }

            return "error";
        }
    }

};
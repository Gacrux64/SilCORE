using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SPF
{   
    [Serializable]
    public class Skill
    {

        public string info;
        public string value;

        public Skill()
        {

        }

        public Skill(string skillInfo, string skillValue)
        {
            info = skillInfo;
            value = skillValue;
        }

        public string getSkillInfo()
        {
            return info;
        }

        public string getSkillValue()
        {
            return value;
        }
    }

    [Serializable]
    public class Perk
    {
        public string info;
        public string value;

        public Perk()
        {

        }

        public Perk(string perkInfo, string perkValue)
        {
            info = perkInfo;
            value = perkValue;
        }

        public string getPerkInfo()
        {
            return info;
        }

        public string getPerkValue()
        {
            return value;
        }
    }

    [Serializable]
    public class Flaw
    {
        public string info;
        public string value;

        public Flaw()
        {

        }

        public Flaw(string flawInfo, string flawValue)
        {
            info = flawInfo;
            value = flawValue;
        }

        public string getFlawInfo()
        {
            return info;
        }

        public string getFlawValue()
        {
            return value;
        }
    }
}

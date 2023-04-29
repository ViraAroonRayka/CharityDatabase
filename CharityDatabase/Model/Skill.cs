using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityModelExample.Model
{
    public class Skill
    {
        public string Title
        {
            get;
            set;
        }
        public bool HasCertificate
        {
            get;
            set;
        }
        public SkillLevel skillLevel
        {
            get;
            set;
        }
    }
    public enum SkillLevel
    {
        POOR,
        INTERMEDIATE,
        HIGHT,
        EXCELLENT
    }
}

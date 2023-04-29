using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityModelExample.Model
{
    public class Initializer
    {
        /// <summary>
        /// جهت پرکردن تعدادی مهارت و برگرداندن لیستی از مهارت های پر شده است
        /// </summary>
        /// <returns></returns>
        public List<Skill> fillSkills()
        {
            List<Skill> skills = new List<Skill>();
            Skill skill = new Skill
            {
                Title = "C# programming",
                HasCertificate = true,
                skillLevel = SkillLevel.EXCELLENT
            };
            skills.Add(skill);

            skill = new Skill
            {
                Title = "C# Game Programming",
                HasCertificate = true,
                skillLevel = SkillLevel.EXCELLENT
            };
            skills.Add(skill);

            skill = new Skill
            {
                Title = "English Language",
                HasCertificate = true,
                skillLevel = SkillLevel.INTERMEDIATE
            };
            skills.Add(skill);

            skill = new Skill { Title = "ASP.NET Core", skillLevel = SkillLevel.EXCELLENT, HasCertificate = false };
            skills.Add(skill);
            return skills;
        }
        public Needee fillNeedee()
        {
            Needee needee = new Needee
            {
                FirstName = "Ali",
                LastName = "Ahmadi",
                skills = fillSkills(),
               
                NationalCode = "1234567890"
            };
            return needee;
        }

        public List<Needee> fillNeedees()
        {
            List<Needee> needees = new List<Needee>();
            Needee needee = new Needee
            {
                FirstName = "Ali",
                LastName = "Ahmadi",
                skills = fillSkills(),
                isWoman = false,
                NationalCode = "1234567890"
            };
            needees.Add(needee);

            needee = new Needee
            {
                FirstName = "Mohammad",
                LastName = "Rezayee",
                skills = fillSkills(),
                isWoman = false,
                NationalCode = "1234567890"
            };
            needees.Add(needee);

            needee = new Needee
            {
                FirstName = "Zahra",
                LastName = "Mohammadi",
                skills = fillSkills(),
                isWoman = true,
                NationalCode = "1234567890"
            };
            needees.Add(needee);
            return needees;
        }

    }
}

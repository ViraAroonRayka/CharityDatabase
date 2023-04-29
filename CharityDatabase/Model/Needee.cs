using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityModelExample.Model
{
    public class Needee
    {
        public int Id
        {
            get;
            set;
        }
        public bool isWoman
        {
            get;
            set;
        }
        // First Name
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Phone
        {
            get
            {
                return Phone;
            }
            set
            {
                if(value.Length == 11)
                {
                    Phone = value;
                }
            }
        }
        public string NationalCode
        {
            get;
            set;
        }
        public List<Skill> skills
        {
            get;
            set;
        }
        public string Graduation
        {
            get;
            set;
        }
        public Province province
        {
            get;
            set;
        }
        public City city
        {
            get;
            set;
        }
        
    }
}

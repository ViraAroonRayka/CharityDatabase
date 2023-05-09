using System;
using System.Collections.Generic;

#nullable disable

namespace CharityDatabase.Db
{
    public partial class Needee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Educations { get; set; }
        public bool? IsMarried { get; set; }
        public string Notes { get; set; }
        public string Job { get; set; }
        public decimal? Revenue { get; set; }
        public bool? HasHouse { get; set; }
    }
}

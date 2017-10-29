using System;
using System.Collections.Generic;
using System.Text;

namespace DentalPlan.Model.Business
{
    public class MedicalStaff : Person
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public Title Title { get; set; }

        public Schedule Schedule { get; set; }
    }
}

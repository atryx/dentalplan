using System;
using System.Collections.Generic;
using System.Text;

namespace DentalPlan.Model.Business
{
    public class Appointment : BaseClass
    {
        public List<MedicalStaff> Staff { get; set; }

        public Patient Patient { get; set; }

        public DateTime AppoinmentDate { get; set; }

        public List<Procedure> Procedures { get; set; }
    }
}

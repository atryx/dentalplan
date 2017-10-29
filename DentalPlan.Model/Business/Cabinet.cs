using DentalPlan.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalPlan.Model.Business
{
    public class Cabinet : BaseClass
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public Schedule Schedule { get; set; }

        public List<MedicalStaff> Staff { get; set; }
    }
}

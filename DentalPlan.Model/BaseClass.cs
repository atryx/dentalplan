using System;
using System.Collections.Generic;
using System.Text;

namespace DentalPlan.Model
{
    public abstract class BaseClass
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}

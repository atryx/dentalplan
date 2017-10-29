using DentalPlan.Model.Common;

namespace DentalPlan.Model.Business
{
    public class Organization : BaseClass
    {
        public string Name { get; set; }

        public Type OrganizationType { get; set; }

        public Address Address { get; set; }
    }
}

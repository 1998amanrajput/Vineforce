using Abp.Runtime.Validation;

namespace Vineforce.CandidateTest.Country.Dto
{
    public class CreateCountryDto : IShouldNormalize
    {
        public string Name { get; set; }
        public void Normalize()
        {
        }
    }
}

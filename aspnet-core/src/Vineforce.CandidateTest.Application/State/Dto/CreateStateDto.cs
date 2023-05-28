using Abp.Runtime.Validation;

namespace Vineforce.CandidateTest.State.Dto
{
    public class CreateStateDto : IShouldNormalize
    {
        public string Name { get; set; }
        public void Normalize()
        {
        }
    }
}

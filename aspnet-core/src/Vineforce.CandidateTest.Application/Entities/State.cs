namespace Vineforce.CandidateTest.Entities
{
    /// <summary>
    /// Represent a state in Country
    /// </summary>
    public class State : Base
    {
        /// <summary>
        /// Country Id whose state is this
        /// </summary>
        public int CountryId { get; set; }
        /// <summary>
        /// Country in which state exists
        /// </summary>
        public Country Country { get; set; }
    }
}

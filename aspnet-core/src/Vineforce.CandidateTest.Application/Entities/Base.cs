using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vineforce.CandidateTest.Entities
{
    /// <summary>
    /// Base Class properties which are common
    /// </summary>
    public class Base : FullAuditedEntity
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(60)]
        public string Name { get; set; }
    }
}

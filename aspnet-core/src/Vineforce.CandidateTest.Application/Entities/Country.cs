using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vineforce.CandidateTest.Entities
{
    /// <summary>
    /// Represent a Country
    /// </summary>
    public class Country : Base
    {
        public ICollection<State> States { get; set; }
        public void CreatedTimeStamp()
        {
            this.CreationTime = DateTime.Now;
            this.IsDeleted = false;
        }

        public void UpdatedTimeStamp()
        {
            this.LastModificationTime = DateTime.Now;
        }
    }
}

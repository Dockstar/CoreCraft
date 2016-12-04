using System;
using System.ComponentModel.DataAnnotations;

namespace CoreCraft.Models
{
    /// <summary>
    /// Timestamps is an abstract object
    /// used for inheriting creation/ update fields.
    /// </summary>
    public abstract class TimeStamps
    {

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [ConcurrencyCheck]
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;

    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCraft.Models
{
    /// <summary>
    /// Hosts are a short form serialization of
    /// Docker hosts and container the pertinent
    /// details to connect
    /// </summary>
    public class Host : TimeStamps
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required,MaxLength(length : 32, ErrorMessage = "Docker identifiers must be no longer than 32 characters")]
        [RegularExpression(@"/[a-zA-Z]{1,32}/")]
        public string Name { get; set; }

        public bool Active { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Port { get; set; }

        //TODO: Build Auth Type Model
        public long AuthTypeId { get; set; }

        public string AuthDetails { get; set; }
        public int CPUCount { get; set; }
        public int Memory { get; set; } //In GB


    }
}
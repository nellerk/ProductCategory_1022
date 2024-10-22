using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductCategory_1022.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }


        [MaxLength(500)]
        public string Description { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }

        [JsonIgnore]
        public ApplicationUser? User { get; set; }
    }
}

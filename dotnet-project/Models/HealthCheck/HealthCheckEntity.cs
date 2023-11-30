using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_project.Models.HealthCheck
{
    [Table("healthCheck", Schema = "dotnet_project")]
    public class HealthcheckEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]
        [Column("id")]
        public int id { get; set; }

        [Column("message")]
        public string? message { get; set; }
    }
}
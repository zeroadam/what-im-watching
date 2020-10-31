using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Production
{
    /// <summary>
    /// Gets or sets the production identifier.
    /// </summary>
    /// <value>The production identifier.</value>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(200)]
    public string ProductionId { get; set; }
    
    /// <summary>
    /// Gets or sets the production title.
    /// </summary>
    [Required]
    [StringLength(200)]
    public string Title { get; set; }
}
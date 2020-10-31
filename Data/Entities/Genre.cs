using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Genre
{
    /// <summary>
    /// Gets or sets the unique identity of the genre.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GenreId { get; set; }

    /// <summary>
    /// Gets or sets the genre name.
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    
}
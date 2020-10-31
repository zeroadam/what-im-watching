using System.Collections.Generic;

/// <summary>
/// This enum represents a production type within the application.
/// </summary>
public enum ProductionType
{
    Movie,

    Series
}

/// <summary>
/// This class represents a production within the application.
/// </summary>
public class ProductionModel
{
    /// <summary>
    /// Contains the title of the production.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Contains a <see cref="ProductionType" /> object. 
    /// </summary>
    public ProductionType Type { get; set; }

    /// <summary>
    /// Contains a list of <see cref="Genre" /> objects.
    /// </summary>
    public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
}
using System.ComponentModel.DataAnnotations;
using ToolKit.Core.Enum;

namespace ToolKit.Core.Models;

public class PageParam
{
    /// <summary>
    /// Page
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int? Page { get; set; }

    /// <summary>
    /// Limit (Page size)
    /// </summary>
    [Required]
    [Range(1, int.MaxValue)]
    public int? Limit { get; set; }

    /// <summary>
    /// The column name to sort
    /// </summary>
    public string? OrderBy { get; set; }

    /// <summary>
    /// Sort type, default: ascending
    /// </summary>
    public SortType SortType { get; set; } = SortType.Ascending;

    /// <summary>
    /// Validation errors
    /// </summary>
    public IList<string> ValidationErrors { get; set; } = new List<string>();

    /// <summary>
    /// Does the model has validation error
    /// </summary>
    public bool HasError
    {
        get
        {
            return this.ValidationErrors.Count > 0;
        }
    }
}
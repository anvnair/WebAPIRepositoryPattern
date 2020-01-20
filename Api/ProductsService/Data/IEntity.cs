#region Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

/// <summary>
/// Namespace to hold Product Item 
/// </summary>
namespace ProductService.Models
{
    /// <summary> To hold entity Item </summary>
    public interface IEntity
    {
        int Id { get; set; }
    }
}

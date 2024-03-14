using System.ComponentModel.DataAnnotations;
namespace ToolKit.Core.Database;

public abstract class BaseEntity<TId>
{
    public BaseEntity()
    {
    }

    public BaseEntity(TId id)
    {
        this.Id = id;
    }

    [Key]
    public virtual TId Id { get; protected set; }

    public virtual bool Active { get; set; } = true;

    public virtual DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;

    public virtual DateTimeOffset UpdatedOn { get; set; } = DateTimeOffset.UtcNow;
}
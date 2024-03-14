using System.Linq.Expressions;

namespace ToolKit.Core.Database;

public interface ISpecification<TEntity>
{
    /// <summary>
    /// Gets a SpecExpression
    /// </summary>
    Expression<Func<TEntity, bool>> SpecExpression { get; }

    /// <summary>
    /// IsSatisfied
    /// </summary>
    /// <param name="entity">TEntity</param>
    /// <returns>bool</returns>
    bool IsSatisfied(TEntity entity);
}
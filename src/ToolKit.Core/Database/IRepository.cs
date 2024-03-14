using ToolKit.Core.Models;

namespace ToolKit.Core.Database;

public interface IRepository<TEntity> where TEntity : class, IAggregateRoot
{
    /// <summary>
    /// Create
    /// </summary>
    /// <param name="entity">Entity</param>
    void Create(TEntity entity);

    /// <summary>
    /// Get all Entities with conditions
    /// </summary>
    /// <param name="spec">Conditions</param>
    /// <param name="pageParam">Page parameters</param>
    /// <returns>Entity list, Total count</returns>
    Tuple<IList<TEntity>, int> GetAll(ISpecification<TEntity> spec, PageParam? pageParam = null);

    /// <summary>
    /// Get all Entities with conditions, including its navigations
    /// </summary>
    /// <param name="spec">Conditions</param>
    /// <param name="navigations">Navigations</param>
    /// <param name="pageParam">Page parameters</param>
    /// <returns>Entity list, Total count</returns>
    Tuple<IList<TEntity>, int> GetAllWithNavigations(ISpecification<TEntity> spec, IEnumerable<string> navigations, PageParam? pageParam = null);

    /// <summary>
    /// Get all Entities with conditions and required fields
    /// </summary>
    /// <param name="spec">Conditions</param>
    /// <param name="fieldNames">Names of field</param>
    /// <param name="pageParam">Page parameters</param>
    /// <returns>Entity list, Total count</returns>
    Tuple<IList<TEntity>, int> GetAllWithRequiredFields(ISpecification<TEntity> spec, IEnumerable<string> fieldNames, PageParam? pageParam = null);

    /// <summary>
    /// Find one entity
    /// </summary>
    /// <param name="keyValues">keyValues</param>
    /// <returns>Entity</returns>
    TEntity? Find(params object[] keyValues);

    /// <summary>
    /// Find one entity asynchronously
    /// </summary>
    /// <param name="keyValues">keyValues</param>
    /// <returns>Entity</returns>
    Task<TEntity?> FindAsync(params object[] keyValues);

    /// <summary>
    /// Find first or default entity
    /// </summary>
    /// <param name="spec">Specification</param>
    /// <param name="navigations">Navigations</param>
    /// <returns>Entity</returns>
    Task<TEntity?> FirstOrDefaultAsync(ISpecification<TEntity> spec, IEnumerable<string>? navigations = null);

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="entity">Entity</param>
    void Update(TEntity entity);

    /// <summary>
    /// Update list of entities
    /// </summary>
    /// <param name="entities">Entities</param>
    void BulkUpdate(IEnumerable<TEntity> entities);

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="entity">Entity</param>
    void Delete(TEntity entity);

    /// <summary>
    /// Save Changes
    /// </summary>
    bool SaveChanges();
}
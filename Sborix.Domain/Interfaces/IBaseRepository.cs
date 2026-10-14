namespace Entities.Interfaces
{
    /// <summary>
    /// Базовый репозиторий — общий набор операций над любой сущностью.
    /// Реализация появится в слое Infrastructure (EF Core + PostgreSQL).
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности, унаследованный от BaseEntity.</typeparam>
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        /// <summary>Получить сущность по идентификатору (null — если не найдена).</summary>
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>Получить все сущности (без мягко удалённых — следит реализация).</summary>
        Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>Существует ли сущность с таким идентификатором.</summary>
        Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>Добавить новую сущность.</summary>
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>Обновить существующую сущность.</summary>
        void Update(TEntity entity);

        /// <summary>Мягкое удаление (IsDeleted = true, без физического удаления из БД).</summary>
        void SoftDelete(TEntity entity);

        /// <summary>Сохранить накопленные изменения в БД. Возвращает число затронутых строк.</summary>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
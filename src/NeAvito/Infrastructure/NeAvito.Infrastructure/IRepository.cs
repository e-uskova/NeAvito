namespace NeAvito.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Получение всех элементов сущности <see cref="TEntity"/>
        /// </summary>
        /// <returns>Все элементы сущности <see cref="TEntity"/></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Получение элементов сущности <see cref="TEntity"/> по условию
        /// </summary>
        /// <param name="predicate">Условие отбора</param>
        /// <returns>Элементы сущности <see cref="TEntity"/>, соответвующие условию отбора</returns>
        IEnumerable<TEntity> GetByPredicate(Func<TEntity, bool> predicate);

        /// <summary>
        /// Создание сущности <see cref="TEntity"/>
        /// </summary>
        /// <param name="entity">Модель сущности</param>
        /// <returns>Созданная сущность</returns>
        TEntity Add(TEntity entity);

        /// <summary>
        /// Изменение сущности <see cref="TEntity"/>
        /// </summary>
        /// <param name="entity">Модель сущности</param>
        /// <returns>Измененная сущность</returns>
        TEntity Update(TEntity entity);
        
        /// <summary>
        /// Удаление сущности 
        /// </summary>
        /// <param name="id">Идентификатор сущности</param>
        /// <returns></returns>
        bool Delete(Guid id);
    }
}

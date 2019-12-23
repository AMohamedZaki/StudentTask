namespace Student.Repository.interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int SaveChanges();

        /// <summary>
        /// Disposes the current object
        /// </summary>
        void Dispose();
    }
}

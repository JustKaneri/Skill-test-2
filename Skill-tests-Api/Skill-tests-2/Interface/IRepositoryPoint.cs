namespace Skill_tests_2.Interface
{
    public interface IRepositoryPoint<T>: ICreator<T>, IDelete<T>
    {
        public Task<List<T>> GetAll();
    }
}

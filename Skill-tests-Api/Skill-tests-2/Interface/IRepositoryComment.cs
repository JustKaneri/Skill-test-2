namespace Skill_tests_2.Interface
{
    public interface IRepositoryComment<T>: ICreator<T>, IDelete<T>
    {
        public Task<List<T>> GetCommentCurrentPoint(int idPoint);
    }
}

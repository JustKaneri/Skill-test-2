namespace Skill_tests_2.Interface
{
    public interface ICreator<T>
    {
        public Task<T> Create(T enity);
    }
}

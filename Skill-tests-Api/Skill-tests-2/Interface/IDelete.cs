namespace Skill_tests_2.Interface
{
    public interface IDelete<T>
    {
        public Task<T> Delete(int id);
    }
}

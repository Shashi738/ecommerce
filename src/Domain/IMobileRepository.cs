namespace Domain
{
    public interface IMobileRepository
    {
        Task<IEnumerable<Mobile>> GetAll();
    }
}

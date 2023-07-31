using Domain;

namespace Infastructure
{
    public class MobileRepository : IMobileRepository
    {
        public async Task<IEnumerable<Mobile>> GetAll()
        {
            IList<Mobile> list = new List<Mobile>
            {
                new Mobile()
                {
                    Id = 1,
                    Name = "test",
                    Model = "2023",
                    Price = (decimal)234561.45,
                    Brand = "Apple",
                    Manufacture = new Manufacture
                    {
                        Warranty = 1,
                        IMEI = Guid.NewGuid().ToString()
                    }
                }
            };

            return Task.FromResult(list).Result;
        }
    }
}

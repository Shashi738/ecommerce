using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class InventoryService : IInventoryService
    {
        private readonly IMobileRepository _mobileRepository;

        public InventoryService(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        public async Task<IEnumerable<Mobile>> GetMobilesAsync()
        {
            return await _mobileRepository.GetAll();
        }
    }
}

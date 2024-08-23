using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Services
{
    public interface ISpotService
    {
        public Task<List<Spot>> GetSpotAll();
        public Task<List<Spot>> GetByPeriod(int ay, int yil);
        public Task<int> GetByTotalCapacity(int ay, int yil);
    }
}

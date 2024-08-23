using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISpot
    {
        Task<List<Spot>> GetSpotAll();
        Task<List<Spot>> GetByPeriod(int ay,int yil);
        Task<int> GetByTotalCapacity(int ay, int yil);
    }
}

using Business.Abstract;
using Business.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class SpotRepository : ISpot
    {
        public async Task<List<Spot>> GetByPeriod(int ay,int yil)
        {
            using (var context = new SpotDBContext())
            {
                var period=context.Spot.Where(x =>x.yil ==yil && x.ay==ay).ToList();
                return period;
            }
        }

        public async Task<int> GetByTotalCapacity(int ay,int yil)
        {
            using (var context = new SpotDBContext())
            {
                var capacity = context.Spot.Where(x => x.yil == yil && x.ay==ay );
                return capacity.Sum(x => x.kapasite);
                
            }
        }

        public async Task<List<Spot>> GetSpotAll()
        {
        //using: Bu ifade, kaynakların düzgün bir şekilde serbest bırakılmasını sağlar. SpotDBContext nesnesi kullanıldıktan sonra otomatik olarak bellekten temizlenir.
            using (var context = new SpotDBContext()) 
            {
                //context: SpotDBContext nesnesinin örneği. Bu örnek, veri tabanında Spot tablolarına erişim sağlamak için kullanılır.
                
                var data = context.Spot.OrderByDescending(x => x.kapasite).ToList();
                return data;
            }
        }

        
    }
}

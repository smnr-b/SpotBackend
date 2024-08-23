using Business.Abstract;
using Business.Context;
using Domain.Entities;
using Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class FlowRepository : IFlow
    {
        public async Task<Invoice> createInvoice(int kurum_id, int ay, int yil)
        {
            using (var context = new SpotDBContext())
            {
                //spot db tablosundan ıdye göre verileri filtreler
                var capacityModel = context.Spot.Where(x => x.kurum_id == kurum_id).FirstOrDefault();
                var flowModel=context.Flow.Where(x=> x.kurum_id == kurum_id &&x.olcumzamani.Month==ay && x.olcumzamani.Year==yil).FirstOrDefault();
                

                Invoice invoice = new Invoice();
                invoice.TCapacity = capacityModel.kapasite;
                invoice.TFlow = (flowModel.enerji)/((flowModel.basinc) * (flowModel.sıcaklik));
                invoice.CFee=(invoice.TCapacity+invoice.TFlow)/100;

                return invoice;
                
            }
        }
    }
}

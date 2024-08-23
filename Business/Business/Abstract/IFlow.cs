using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFlow
    {
        Task<Invoice> createInvoice(int kurum_id, int ay, int yil);
    }
}

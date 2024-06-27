using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ISupplierService
    {
        Task<List<Supplier>> List();
        Task<Supplier> Add(Supplier entity);
        Task<Supplier> Edit(Supplier entity);
        Task<bool> Delete(int Id);
    }
}

//using BusinessLayer.Contracts;
//using DataAccessLayer.Entities;
//using DataAccessLayer.Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer.Services
//{
//    public class SupplierService : ISupplierService
//    {
//        public readonly IGenericRepository<SupplierService> _repository;
//        public SupplierService(IGenericRepository<SupplierService> repository)
//        {
//            _repository = repository;
//        }
//        public async Task<List<Supplier>> List()
//        {
//            IQueryable<Supplier> query = await _repository.Query();
//            return query.ToList();
//        }
//        public async Task<Supplier> Add(Supplier entity)
//        {
//            try
//            {
//                Supplier Supplier_created = await _repository.Add(entity);
//                if (Supplier_created.Id == 0)
//                    throw new TaskCanceledException("Supplier could not be created");

//                return Supplier_created;
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        public async Task<Supplier> Edit(Supplier entity)
//        {
//            try
//            {
//                Supplier Supplier_found = await _repository.Get(c => c.IdSupplier == entity.IdSupplier);

//                Supplier_found.Description = entity.Description;
//                Supplier_found.IsActive = entity.IsActive;

//                bool response = await _repository.Edit(Supplier_found);

//                if (!response)
//                    throw new TaskCanceledException("Supplier could not be changed.");

//                return Supplier_found;
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        public async Task<bool> Delete(int idSupplier)
//        {
//            try
//            {
//                Supplier Supplier_found = await _repository.Get(c => c.IdSupplier == idSupplier);

//                if (Supplier_found == null)
//                    throw new TaskCanceledException("The Supplier does not exist");


//                bool response = await _repository.Delete(Supplier_found);

//                return response;
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}

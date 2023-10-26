using Microsoft.EntityFrameworkCore;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace rad301_2023_week3_mauiApp.DataLayer
{
    public interface ICategory<T>
    {
        Task Add(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task<List<T>> Find(Expression<Func<T, bool>> predicate);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
        void UpdateProduct(Product productToUpdate); // added this to update products
    }

    public class CategoryDataService : ICategory<Category>
    {
        private readonly MauiProductContext _context;

        public CategoryDataService(MauiProductContext productContext)
        {
            _context = productContext;
        }

        public Task Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> Find(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAll()
        {
            return _context.Categories
             .Include(c => c.Products)
             .ThenInclude(p => p.Suppliers)
             .ToListAsync();
        }

        public Task Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product productToUpdate)
        {
            // Your logic to update the product will go here.
            // For example:
            // _context.Products.Update(productToUpdate);
            // _context.SaveChanges();
        }
    }
}

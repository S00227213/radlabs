using Microsoft.EntityFrameworkCore;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace rad301_2023_week3_mauiApp.DataLayer
{
    public class CategoryDataService : ICategory<Category>
    {
        private readonly MauiProductContext _context;

        public CategoryDataService(MauiProductContext productContext)
        {
            _context = productContext;
        }

        public async Task Add(Category entity)
        {
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRange(IEnumerable<Category> entities)
        {
            _context.Categories.AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> Find(Expression<Func<Category, bool>> predicate)
        {
            return await _context.Categories
                        .Include(c => c.Products)
                        .ThenInclude(p => p.Suppliers)
                        .Where(predicate)
                        .ToListAsync();
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categories
                        .Include(c => c.Products)
                        .ThenInclude(p => p.Suppliers)
                        .FirstOrDefaultAsync(c => c.CategoryID == id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories
                        .Include(c => c.Products)
                        .ThenInclude(p => p.Suppliers)
                        .ToListAsync();
        }

        public async Task Remove(Category entity)
        {
            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveRange(IEnumerable<Category> entities)
        {
            _context.Categories.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async void Update(Category entityToUpdate)
        {
            _context.Categories.Update(entityToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}

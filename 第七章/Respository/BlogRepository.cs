using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace 第七章.Respository
{
    public class BlogRepository:IBlogRepository
    {
        private BloggingContext _context;

        public BlogRepository(BloggingContext context)
        {
            _context = context;
        }

        public Task<Blog> GetByIdAsync(int Id)
        {
            return _context.Blogs.FirstOrDefaultAsync(a => a.BlogId == Id);
          
        }

        public Task<List<Blog>> ListAsync()
        {
            return _context.Blogs.ToListAsync();
        }

        public Task AddAsync(Blog blog)
        {
            _context.Blogs.Add(blog);
            return _context.SaveChangesAsync();

        }

        public Task EditAsync(Blog blog)
        {
            _context.Entry(blog).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        
    }
}

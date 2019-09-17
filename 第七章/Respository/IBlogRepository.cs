using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 第七章.Respository
{
    public interface IBlogRepository
    {
        Task<Blog> GetByIdAsync(int Id);
        Task<List<Blog>> ListAsync();
        Task AddAsync(Blog blog);
        Task EditAsync(Blog blog);
    }
}

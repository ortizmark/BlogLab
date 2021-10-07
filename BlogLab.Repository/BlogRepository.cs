using BlogLab.Models.Blog;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly IConfiguration _config;

        public BlogRepository(IConfiguration config)
        {
            _config = config;
        }

        public Task<int> DeleteAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<PageResults<Blog>> GetAllAsync(BlogPaging blogPaging)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllByUserIdAsync(int applicationUserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllFamousAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetAsync(int blogId)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> UpsertAsync(BlogCreate blogCreate, int applicationUserId)
        {
            throw new NotImplementedException();
        }
    }
}

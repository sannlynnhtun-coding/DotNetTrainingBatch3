using DotNetTrainingBatch3.ConsoleApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.ConsoleApp.RefitExamples
{
    public interface IBlogApi
    {
        [Get("/api/blog")]
        Task<List<BlogModel>> GetBlogs();

        [Get("/api/blog/{id}")]
        Task<BlogModel> GetBlog(int id);

        [Post("/api/blog")]
        Task<string> CreateBlog(BlogModel blog);

        [Put("/api/blog/{id}")]
        Task<string> UpdateBlog(int id, BlogModel blog);

        [Delete("/api/blog/{id}")]
        Task<string> DeleteBlog(int id);
    }
}

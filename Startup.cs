using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;

namespace TodoApi
{
    public class Startup
    {       
        public void ConfigureServices(IServiceCollection services)
        {
            // DbContextOptions<TodoContext> options;
            // var builder = new DbContextOptionsBuilder<TodoContext>();
            // builder.UseInMemoryDatabase("TodoList");
            // options = builder.Options;
            services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
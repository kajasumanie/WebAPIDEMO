using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebAPIDEMO.Models;

namespace WebAPIDEMO
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IAmKajasContext>(opt => opt.UseInMemoryDatabase("IAmKajas"));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app) => app.UseMvc();
    }
}

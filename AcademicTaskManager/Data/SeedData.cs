using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AcademicTaskManager.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Crear usuario de prueba si no existe
            var testUser = await userManager.FindByNameAsync("testuser");
            if (testUser == null)
            {
                var user = new IdentityUser { UserName = "testuser", Email = "testuser@example.com", EmailConfirmed = true };
                await userManager.CreateAsync(user, "Test1234!");
            }
        }
    }
}

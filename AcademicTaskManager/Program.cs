using AcademicTaskManager.Components;
using AcademicTaskManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found."); ;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurar DbContext con SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ApplicationDbContextConnection")));

// Agregar servicios de Identity
builder.Services.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

// Seed usuario de prueba
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await AcademicTaskManager.Data.SeedData.InitializeAsync(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

// Middleware de autenticación y autorización
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

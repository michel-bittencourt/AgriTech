using Microsoft.EntityFrameworkCore;
using AgriTech.Data;
using AgriTech.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AgriTechContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AgriTechContext") ?? throw new InvalidOperationException("Connection string 'AgriTechContext' not found.")));

// Add services to the container.
builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<AduboService>();
builder.Services.AddScoped<PlantaService>();
builder.Services.AddScoped<PlantacaoService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var dbContext = services.GetService<AgriTechContext>();
        var seedingService = services.GetService<SeedingService>();

        seedingService.Seed();
    }
}*/
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

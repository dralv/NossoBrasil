using NossoBrasil.Interfaces;
using NossoBrasil.Mappings;
using NossoBrasil.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(EnderecoProfile));
builder.Services.AddAutoMapper(typeof(DDDProfile));
builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<IDDDService, DDDService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Endereco}/{action=Index}/{id?}");

app.Run();

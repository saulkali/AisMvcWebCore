var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.MapControllerRoute(
    name: "calculadora",
    pattern: "{controller=Calculadora}/{action=Index}"

);
app.UseRouting();


app.UseAuthorization();

app.MapRazorPages();

app.Run();

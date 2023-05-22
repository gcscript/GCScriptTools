using GCScriptTools.Web.Shared.Models;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();

app.MapGet("api/Product/GetFromMinimal", () => new Product() { Id = Guid.NewGuid(), Name = "Minimal Product" });
app.MapGet("api/Product/GetFromMinimal2", () => new Product() { Id = Guid.NewGuid(), Name = "Minimal Product 2" });

app.MapFallbackToFile("index.html");

app.Run();

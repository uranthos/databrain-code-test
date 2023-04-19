using DataBrain.Common.Interfaces;
using DataBrain.PAYG;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPAYGService, PAYGService>();


// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();


using cnet_db_op.Domain.Data;
using cnet_db_op.Domain.Model;
using cnet_db_op.Service.ClearDbservise;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<Articl>();
builder.Services.AddScoped<Persons>();
builder.Services.AddScoped< Organiztion>();
builder.Services.AddScoped< Vocher>();
builder.Services.AddScoped< CommonGslandVocher>();
builder.Services.AddScoped<Common>();
builder.Services.AddTransient<Func<Tables, InterfceService>>(provider => Table=>
{
switch(Table)
    {
        case Tables.whatever:
            return provider.GetService<Articl>();
        case Tables.person:
            return provider.GetService<Persons>();
        case Tables.Organaitation:
            return provider.GetService<Organiztion>();
        case Tables.Vocher:
            return provider.GetService<Vocher>();
        case Tables.CommonglsandVocher:
            return provider.GetService<CommonGslandVocher>();
        case Tables.Common:
            return provider.GetService<Common>();
        default:
            return null;
    }
});
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Cnet2016Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

using MediatorHandlers;
using Wolverine;

var builder = WebApplication.CreateBuilder(args);

// Tried adding it here too
// No go.

#region Standard services setup
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region Wolverine setup

// builder.Host.UseWolverine(); // Doesn't work either
builder.Host.UseWolverine(opts =>
{
    opts.Discovery.IncludeAssembly(typeof(MediatorItemCreatedHandler).Assembly);
});
#endregion

#region Standard app setup

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
#endregion
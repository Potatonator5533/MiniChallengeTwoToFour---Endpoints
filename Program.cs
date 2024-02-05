using MiniChallengeTwoToFour___Endpoints.Services.Endpoint1;
using MiniChallengeTwoToFour___Endpoints.Services.Endpoint2;
using MiniChallengeTwoToFour___Endpoints.Services.Endpoint3;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(option =>
{
    option.AddPolicy("CorsPolicy",
                  builder =>
                  {
                      builder.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
                  });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICounting, Counting>();
builder.Services.AddScoped<ISentence, Sentence>();
builder.Services.AddScoped<IComparing, Comparing>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();

using BackgroundTaskDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IWorker, Worker>();
builder.Services.AddHostedService<BrackgroundPrinter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//public static IHostBuilder CreateHostBuilder(string[] args)=>
//    Host.CreateDefaultBuilder(args)
//    .ConfigureWebHostDefaults(webBuilder => 
//    { webBuilder.UseStartup<startup>(); 
//    }).ConfigureServices(services=>
//    services.AddHostedService<BrackgroundPrinter>())
//    ;
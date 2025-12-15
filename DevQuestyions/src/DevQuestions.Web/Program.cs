var builder = WebApplication.CreateBuilder(args); // с помощью билдера создается HOST

//добавляются сервисы
builder.Services.AddControllers(); 
builder.Services.AddOpenApi();

//собирается приложение
var app = builder.Build();

//настраиваются middleware
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapControllers();

//старт приложения
app.Run();
var builder = WebApplication.CreateBuilder(args); // с помощью билдера создается HOST

// добавляются сервисы

// эта строка подключает в приложение поддержку MVC-контроллеров API:
// ищутся классы-контроллеры
// подключается model binding ([FromBody], [FromRoute], [FromQuery])
// подключается работа с атрибутами типа [HttpGet], [HttpPost], [Route]
// подключается возврат IActionResult
builder.Services.AddControllers();

builder.Services.AddOpenApi();

// собирается приложение
var app = builder.Build();

// настраиваются middleware
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json/", "DevQuestions"));
}

// возьми найденные контроллеры и построй по ним эндпоинты
app.MapControllers();

// старт приложения
app.Run();
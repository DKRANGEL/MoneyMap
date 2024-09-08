var builder = WebApplication.CreateBuilder(args);

// Registra as dependencias do projeto
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura os utilitarios dentro do projeto
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

// Utiliza o redirecionamento https (remover caso houver problemas)
app.UseHttpsRedirection();

app.MapControllers();

app.Run();

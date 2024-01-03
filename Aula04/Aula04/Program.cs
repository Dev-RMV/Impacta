var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // adiciona controle de páginas Razor

var app = builder.Build();

app.UseHttpsRedirection(); //uso do http
app.UseRouting(); //habilitação do router
app.MapRazorPages();//mapeamento das páginas urls

//app.MapGet("/", () => "Hello World!");

app.Run();

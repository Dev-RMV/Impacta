var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // adiciona controle de p�ginas Razor

var app = builder.Build();

app.UseHttpsRedirection(); //uso do http
app.UseRouting(); //habilita��o do router
app.MapRazorPages();//mapeamento das p�ginas urls

//app.MapGet("/", () => "Hello World!");

app.Run();

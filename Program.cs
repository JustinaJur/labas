var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! hellsqo ffkkdwdwdsasasdlabasff");

app.Run();

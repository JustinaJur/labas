var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! hellwewreredwdqo fddfkkdwderewdsasasdlabasff");

app.Run();

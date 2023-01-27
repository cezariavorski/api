var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => new{Name="Cezar Iavorski", age=27});
app.MapPost("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("Test", "Cezar Iavorski");
    return new {Name="Cezar Iavorski", age=27};

} );
    


app.Run();

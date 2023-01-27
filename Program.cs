var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => new{Name="Cezar Iavorski", age=27});
app.MapGet("/AddHeader", (HttpResponse response) => {
    response.Headers.Add("Test", "Cezar Iavorski");
    return new {Name="Cezar Iavorski", age=27};

});

app.MapPost("/saveproduct", (Product product) => {
    return product.Code + "-" + product.Name;
});
    


app.Run();


public class Product{
    public string Code { get; set; }
    public string Name { get; set; }
}
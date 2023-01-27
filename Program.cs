using Microsoft.AspNetCore.Mvc;

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
    
app.MapGet("/getproduct", ([FromQuery] string dateStart, [FromQuery] string dateEnd) => {
    return dateStart + "-" + dateEnd;
});

app.MapGet("/getproduct/{code}", ([FromRoute] string code) => {
    return code;
});

app.MapGet("/getproductbyheader", (HttpRequest request) => {
    return request.Headers["product-code"].ToString();
});

app.Run();


public class Product{
    public string Code { get; set; }
    public string Name { get; set; }
}
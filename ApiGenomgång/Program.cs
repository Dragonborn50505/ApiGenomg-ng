WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost.3000");
app.Urls.Add("http://*:3000");

app.MapGet("/", Answer);

app.MapGet("/Superhero", () => 
{
    return "Superman";
});

app.Run();

static string Answer()
{
    return "Hello";
    //Acadmedia X profile
}
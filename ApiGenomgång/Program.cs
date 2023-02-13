WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3002");
app.Urls.Add("http://*:3002");

Pokemon Eevee = new Pokemon();
Eevee.Name = "Eevee";
Eevee.Looks = "Furry and cute";
Eevee.Strenght = 100;


app.MapGet("/", Answer);

app.MapGet("/Pokemon", () =>
{
    return Eevee;
});

app.Run();

static string Answer()
{
    return "Hello";
    //Acadmedia X profile
}
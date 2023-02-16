WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3002");
app.Urls.Add("http://*:3002");

List<Pokemon> poki = new();

poki.Add(new() { Name = "Eevee", Looks = "Furry and cure", Strenght = 100 });
poki.Add(new() { Name = "Charmander", Looks = "Firee Tail", Strenght = 300 });
poki.Add(new() { Name = "Blaziken", Looks = "Red?", Strenght = 1000 });

// Pokemon Eevee = new Pokemon();
// Eevee.Name = "Eevee";
// Eevee.Looks = "Furry and cute";
// Eevee.Strenght = 100;


app.MapGet("/", Answer);

app.MapGet("/Pokemon", () =>
{
    // return Eevee;
    return poki;

});

app.MapGet("/Pokemon/{num}", (int num) =>
{
    if (num >= 0 && num < poki.Count)
    {
        return Results.Ok(poki[num]);
    }

    return Results.NotFound();
});

app.MapPost("/Pokemon/", (Pokemon p) =>
    {
        Console.WriteLine("Added Pokemon" + p.Name);

        poki.Add(p);
    });

app.Run();

static string Answer()
{
    return "Hello";
    //Acadmedia X profile
}
using ClassWithParameters;
using ConnectionSQL;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PortfolioBlazor.Data;
using PortfolioBlazor.Interfaces;
using PortfolioBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// dodaj tê liniê do zarejestrowania us³ugi HttpClient
builder.Services.AddScoped<HttpClient>();
builder.Services.AddHttpClient<IProduct, ServiceProducts>
    (
        client =>
            {
                client.BaseAddress = new Uri("https://localhost:7051/");
            }
    );

//Transient mean this will create instance everytime we ask for one.
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IPplData, PplData>();


// ... reszta konfiguracji
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseRouting();


app.Run();

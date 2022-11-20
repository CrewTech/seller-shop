using seller_shop.Main.Extensions;
using seller_shop.Main.ProjectCfg;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

ProjectConfigurations projectConfigurations = new(builder.Configuration);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddClientPostgress(projectConfigurations);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseAuthorization();

app.MapGet("/hi", () => "Hello!");

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
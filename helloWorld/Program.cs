using Microsoft.AspNetCore.Routing.Template;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "blog",
    pattern: "myblog/{id:int}",
    defaults: new { controller = "Blog", action = "Story" }
);

app.MapControllerRoute(
    name: "default",
    // in the pattern wwriting merthod is used to define the route i.e goToHomeController and inside the HomeController there is series of action present but we had to select the actionName tobe index and if there is any id then it will be passed as a parameter
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

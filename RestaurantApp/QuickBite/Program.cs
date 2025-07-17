var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();

//app.MapGet("/", () => "Hello World!");
//This line adds a middleware to the pipeline that handles the routing of incoming requests to the appropriate controller
//and action based on the defined routes. 
app.MapDefaultControllerRoute();

app.Run();

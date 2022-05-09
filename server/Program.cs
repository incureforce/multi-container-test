var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(ep => {
    ep.MapGet("/", async (ctx) => {
        await ctx.Response.WriteAsJsonAsync(new TestModel {
          When = DateTime.UtcNow,
        });
    });
});

app.Run();

public class TestModel {
  public DateTime When {
    get; set;
  }
}

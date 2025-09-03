var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(options =>
{
    options.Conventions.Insert(0, new Microsoft.AspNetCore.Mvc.ApplicationModels.RouteTokenTransformerConvention(new ApiV1RoutePrefix()));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

// Add this class in the same file or a new file in the project
public class ApiV1RoutePrefix : Microsoft.AspNetCore.Mvc.ApplicationModels.IOutboundParameterTransformer
{
    public string TransformOutbound(object value)
    {
        return value == null ? null : $"api/v1/{value.ToString()}";
    }
}

using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.EntityFrameworkCore;
using services_app;
using services_app.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication(CertificateAuthenticationDefaults.AuthenticationScheme).AddCertificate();
builder.Services.AddSingleton<IServiceUser, ServiceUser>();
builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
        );
});
builder.Services.AddControllers();
var app = builder.Build();

app.UseAuthentication();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();

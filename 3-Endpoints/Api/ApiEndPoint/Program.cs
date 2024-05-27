using Mahface.Services.AppServices.Service;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using MAhface.Infrastructure.EfCore.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(options =>
{
    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        // Only show specific controller when expanded
        apiDesc.RelativePath = apiDesc.RelativePath.Replace("v1", "v1/SpecificController");
        return true;
    });
});

builder.Services.AddDbContext<AllamehPrroject>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultValue")));

//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddControllers();



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<User>();
builder.Services.AddIdentityApiEndpoints<User>(
    Options =>
    {
        Options.SignIn.RequireConfirmedAccount = false;
        Options.SignIn.RequireConfirmedEmail = false;
        Options.SignIn.RequireConfirmedPhoneNumber = false;
        Options.Password.RequireDigit = false;
        Options.Password.RequireLowercase = false;
        Options.Password.RequireNonAlphanumeric = false;
        Options.Password.RequireUppercase = false;
        Options.Password.RequiredLength = 5;
        Options.Password.RequiredUniqueChars = 1;


    })
    .AddEntityFrameworkStores<AllamehPrroject>();

//builder.Services.AddIdentityApiEndpoints<User>()
//    .AddEntityFrameworkStores<AllamehPrroject>();



// Other configurations...

var app = builder.Build();

builder.Services.AddAuthorization();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

//app.MapIdentityApi<User>();

app.MapControllers();

app.Run();
using Mahface.Services.AppServices.Service;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using MAhface.Infrastructure.EfCore.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Identity;
using MAhface.Domain.Core.Interface.IRipositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Mahface.Services.AppServices.AutoMapper;
using MAhface.Domain.Core.Interface.IServices;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        apiDesc.RelativePath = apiDesc.RelativePath.Replace("v1", "v1/SpecificController");
        return true;
    });
});

// Register DbContext
builder.Services.AddDbContext<AllamehPrroject>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultValue")));

//// Register repositories and services
//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IUserManagerService, UserManagerService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISeasonRipository, SeasonRepository>();
builder.Services.AddScoped<ISeasonService, SeasonService>();
builder.Services.AddScoped<ICourseripository,CoursesRepository>();
builder.Services.AddScoped<ICoursesService,CoursesService>();
builder.Services.AddScoped<IImageRepository,ImageRepository>();
builder.Services.AddScoped<IImageService,ImageService>();



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddIdentityApiEndpoints<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 5;
    options.Password.RequiredUniqueChars = 1;
})
.AddEntityFrameworkStores<AllamehPrroject>();

var app = builder.Build();
app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                                                        //.WithOrigins("https://localhost:44351")); // Allow only this origin can also have multiple origins separated with comma
                    .AllowCredentials()); // allow credentials
app.MapIdentityApi<User>();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

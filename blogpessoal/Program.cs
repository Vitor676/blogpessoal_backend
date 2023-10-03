<<<<<<< HEAD

using blogpessoal.Data;
using blogpessoal.Model;
using blogpessoal.Security;
using blogpessoal.Security.Implements;
using blogpessoal.Service;
using blogpessoal.Service.Implements;
using blogpessoal.Validator;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

=======
using blogpessoal.Data;
using blogpessoal.Model;
using blogpessoal.Validator;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using blogpessoal.Service;
using blogpessoal.Service.Implements;
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
namespace blogpessoal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD

            // Add services to the container.

            builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling =
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

            // Conexão com o banco de dados
            var connectionstring = builder.Configuration
               .GetConnectionString("DefaultConnection");
=======
            // Add services to the container.

            // Para não dar Loop Infinito 
            builder.Services.AddControllers()
           .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            //Conexão com o Banco de dados 

            var connectionstring = builder.Configuration
     .GetConnectionString("DefaultConnection");
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionstring)
            );
<<<<<<< HEAD

            // Registrar a validação das entidades

            builder.Services.AddTransient<IValidator<Postagem>, PostagemValidator>();
            builder.Services.AddTransient<IValidator<Tema>, TemaValidator>();
            builder.Services.AddTransient<IValidator<User>, UserValidator>();

            // Registrar as classes de Serviço (Service)
            builder.Services.AddScoped<IPostagemService, PostagemService>();
            builder.Services.AddScoped<ITemaService, TemaService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                var key = Encoding.UTF8.GetBytes(Settings.Secret);
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });
=======
            // Validação das Entidades
            builder.Services.AddTransient<IValidator<Postagem>, PostagemValidator>();
            builder.Services.AddTransient<IValidator<Tema>, TemaValidator>();

            // Registrar as Classes e Interfaces Service
            builder.Services.AddScoped<IPostagemService, PostagemService>();
            builder.Services.AddScoped<ITemaService, TemaService>();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

<<<<<<< HEAD
            // Configuração do CORS
            builder.Services.AddCors(options =>
            {
=======
            //Configuração do CORS
           
            builder.Services.AddCors(options => {
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
                options.AddPolicy(name: "MyPolicy",
                    policy =>
                    {
                        policy.AllowAnyOrigin()
<<<<<<< HEAD
                              .AllowAnyHeader()
                              .AllowAnyMethod();
=======
                        .AllowAnyHeader()
                        .AllowAnyMethod();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
                    });
            });

            var app = builder.Build();
<<<<<<< HEAD

            // Configuração para gerar o banco de dados automaticamente 
=======
            // Criar o Banco de dados e as tabelas Automaticamente
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.EnsureCreated();
            }

<<<<<<< HEAD
=======
            app.UseDeveloperExceptionPage();
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

<<<<<<< HEAD
            // O CORS é inicializado aqui
            app.UseCors("MyPolicy");

            app.UseAuthentication();

            app.UseAuthorization();

=======
    app.UseAuthorization();

            app.UseCors("MyPolicy");
>>>>>>> 2ef569dc9bddd5e68a878668df79ade0ede6dff5
            app.MapControllers();

            app.Run();
        }
    }
}
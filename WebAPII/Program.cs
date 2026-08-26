using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// 1. Autofac'i projenin varsayılan servis sağlayıcısı olarak ayarlıyoruz
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// 2. Eğitmenin yazdığı Autofac modülünü projeye tanıtıyoruz
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new AutofacBusinessModule());
});

// Add services to the container.
builder.Services.AddControllers();

// ÖNEMLİ NOT: AutofacBusinessModule'ü devreye soktuğumuz için,
// eğitmen muhtemelen aşağıdaki kayıt işlemlerini modülün içine taşıdı.
// Eğer öyle yaptıysa, aşağıdaki iki satırı silebilirsin (çakışma olmaması için yoruma aldım).
// builder.Services.AddSingleton<IProductService, ProductManager>();
// builder.Services.AddSingleton<IProductDal, EfProductDal>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
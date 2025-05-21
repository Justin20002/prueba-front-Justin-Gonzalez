
{
    var Builder = WebApplication.CreateBuilder(args);



    Builder.Services.AddControllers();
    var Builder = WebApplication.CreateBuilder(args);

    using LaFiseApi.Data;
    using Microsoft.EntityFrameworkCore;
    WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);
    Builder.Services.AddControllers();
    Builder.Services.AddControllers < "LaFiseDb" >;
    Builder.Services.AddEndpointsApiExplorer();
    Builder.AddSwaggerGen();

    var app = Builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();

    Builder.Services.AddEndpointsApiExplorer();
    Builder.Services.AddSwaggerGen();

    var App = Builder.Build();


    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
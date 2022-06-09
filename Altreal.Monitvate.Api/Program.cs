using System.Text.Json.Serialization;
using Altreal.Motivate.Bll.Interfaces;
using Altreal.Motivate.Bll.Services;
using Altreal.Motivate.Bus;
using Altreal.Motivate.Bus.Commands.ActionPlan;
using Altreal.Motivate.Bus.Mediator;
using Altreal.Motivate.Bus.Queries;
using Altreal.Motivate.Bus.Queries.ActionPlan;
using Altreal.Motivate.Data;
using Altreal.Motivate.Data.Repository;
using Altreal.Motivate.Shared.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MotivateContext>();
builder.Services.AddScoped<IRepository<Timezone>, TimezoneRepository>();
builder.Services.AddScoped<IRepository<Translation>, TranslationRepository>();
builder.Services.AddScoped<IRepository<ActionPlan>, ActionPlanRepository>();
builder.Services.AddScoped<IRepository<ActionStep>, Repository<ActionStep, MotivateContext>>();

builder.Services.AddMediatR(typeof(Query<ActionPlan>));

builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddScoped<IMediatorHandler, InMemoryBus>();
builder.Services.AddScoped<IActionPlanService, ActionPlanService>();
//builder.Services.AddScoped<IRequestHandler<GetActionPlanQuery, ActionPlan>, QueryHandler>();
//builder.Services.AddScoped<IRequestHandler<CreateActionPlanCommand, ActionPlan>, CommandHandler>();
//builder.Services.AddScoped<IRequestHandler<RemoveActionPlanBehaviorCommand, ActionPlan>, CommandHandler>();

//builder.Services.AddScoped<ServiceFactory>(context =>
//{
//    var c = context.GetService(typeof(IComponentContext))();
//    return t => c.Resolve(t);
//});

builder.Services.Configure<JsonOptions>(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

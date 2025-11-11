using VivaSphere.Api.Models;
using VivaSphere.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ContentRepository>();

var app = builder.Build();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var repo = app.Services.GetRequiredService<ContentRepository>();

app.MapGet("/api/home", () => repo.GetHome());
app.MapGet("/api/services", () => repo.GetServices());
app.MapGet("/api/services/{slug}", (string slug) => repo.GetService(slug));
app.MapGet("/api/products", () => repo.GetProducts());
app.MapGet("/api/products/{slug}", (string slug) => repo.GetProduct(slug));
app.MapGet("/api/techstack", () => repo.GetTechStack());
app.MapGet("/api/testimonials", () => repo.GetTestimonials());
app.MapGet("/api/industries", () => repo.GetIndustries());
app.MapGet("/api/faq", () => repo.GetFaq());
app.MapGet("/api/blog", () => repo.GetBlogPosts());
app.MapGet("/api/blog/{slug}", (string slug) => repo.GetBlogPost(slug));
app.MapGet("/api/careers", () => repo.GetCareers());
app.MapGet("/api/careers/{slug}", (string slug) => repo.GetCareer(slug));
app.MapPost("/api/contact", (ContactRequestDto request) => repo.CreateContactRequest(request));

app.Run();

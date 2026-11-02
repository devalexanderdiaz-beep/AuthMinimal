var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string ValidUser = "admin";
const string ValidPassword = "admin";

app.MapPost("/auth/login", (LoginRequest request) =>
{
    if (request.Username == ValidUser && request.Password == ValidPassword)
    {
        return Results.Ok(new
        {
            message = "Inicio de sesión exitoso",
            token = "fake-jwt-token-para-pruebas-12345"
        });
    }

    return Results.Unauthorized();
});

app.Run();

record LoginRequest(string Username, string Password);
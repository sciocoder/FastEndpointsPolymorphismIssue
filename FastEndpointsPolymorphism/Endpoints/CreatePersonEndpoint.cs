using FastEndpoints;
using FastEndpointsPolymorphism.Models;

namespace FastEndpointsPolymorphism.Endpoints;

public class CreatePersonEndpoint : Endpoint<Person, Person>
{
    public override void Configure()
    {
        Post("/api/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Person request, CancellationToken ct)
    {
        await SendAsync(request, cancellation: ct);
    }
}

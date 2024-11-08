using FastEndpoints;
using FastEndpointsPolymorphism.Models;

namespace FastEndpointsPolymorphism.Endpoints;

public class ReadPersonsEndpoint : EndpointWithoutRequest<Person[]>
{
    public override void Configure()
    {
        Get("/api/person");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var persons = new List<Person>();

        persons.Add(new Person("John", "Doe")
        {
            Animals = new List<Animal>
            {
                new Cat("Whiskers", "PhD"),
                new Dog("Fido", "Ball")
            }
        });

        await SendAsync(persons.ToArray(), cancellation: ct);
    }
}

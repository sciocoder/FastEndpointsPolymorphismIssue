using System.Text.Json.Serialization;

namespace FastEndpointsPolymorphism.Models;

[JsonDerivedType(typeof(Cat), typeDiscriminator: nameof(Cat))]
[JsonDerivedType(typeof(Dog), typeDiscriminator: nameof(Dog))]
public abstract class Animal
{
    protected Animal(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public abstract string Species { get; }
}

public class Cat : Animal
{
    public Cat(string name, string educationLevel)
        : base(name)
    {
        EducationLevel = educationLevel;
    }

    public string EducationLevel { get; set; }
    public override string Species => "Felis catus";
}

public class Dog : Animal
{
    public Dog(string name, string favoriteToy)
        : base(name)
    {
        FavoriteToy = favoriteToy;
    }

    public string FavoriteToy { get; set; }
    public override string Species => "Canis familiaris";
}

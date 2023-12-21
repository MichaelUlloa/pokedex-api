using pokedex_api.Entities;
using pokedex_api.Entities.Enums;

namespace pokedex_api.Models;

public class CreatePokemonModel
{
    public string? Name { get; set; }
    public PokemonGender? Gender { get; set; }
    public string? ImageUrl { get; set; }
    public PokemonElement? Type { get; set; }
    public decimal? Weight { get; set; }
    public List<string>? Abilities { get; set; }
    public List<PokemonElement>? Weaknesses { get; set; }

    internal Pokemon ToPokemon()
        => new()
        {
            Name = Name,
            Gender = Gender,
            ImageUrl = ImageUrl,
            Type = Type,
            Weight = Weight,
            Abilities = Abilities,
            Weaknesses = Weaknesses,
        };
}

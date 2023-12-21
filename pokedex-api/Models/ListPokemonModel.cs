using pokedex_api.Entities;
using pokedex_api.Entities.Enums;

namespace pokedex_api.Models;

public class ListPokemonModel
{
    public ListPokemonModel(Pokemon pokemon)
    {
        Id = pokemon.Id;
        Name = pokemon.Name;
        Gender = pokemon.Gender;
        ImageUrl = pokemon.ImageUrl;
        Type = pokemon.Type;
        Weight = pokemon.Weight;
        Abilities = pokemon.Abilities;
        Weaknesses = pokemon.Weaknesses;
    }

    public int? Id { get; set; }
    public string? Name { get; set; }
    public PokemonGender? Gender { get; set; }
    public string? ImageUrl { get; set; }
    public PokemonElement? Type { get; set; }
    public decimal? Weight { get; set; }

    public List<string>? Abilities { get; set; }
    public List<PokemonElement>? Weaknesses { get; set; }
}

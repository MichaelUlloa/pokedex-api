using pokedex_api.Entities.Enums;

namespace pokedex_api.Entities;

public class Pokemon
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public PokemonGender? Gender { get; set; }
    public string? ImageUrl { get; set; }
    public PokemonElement? Type { get; set; }
    public decimal? Weight { get; set; }

    public List<string>? Abilities { get; set; }
    public List<PokemonElement>? Weaknesses { get; set; }
}

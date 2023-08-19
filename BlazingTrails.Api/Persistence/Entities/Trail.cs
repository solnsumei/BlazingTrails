using System.ComponentModel.DataAnnotations;
using BlazingTrails.Client.Features.Home;

namespace BlazingTrails.Api.Persistence.Entities;

public class Trail
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = default!;
    [Required]
    public string Description { get; set; } = default!;
    public string? Image { get; set; }
    [Required]
    public string Location { get; set; } = default!;
    [Required]
    public int TimeInMinutes { get; set; }
    [Required]
    public int Length { get; set; }

    public ICollection<RouteInstruction> Route { get; set; } = default!;
}


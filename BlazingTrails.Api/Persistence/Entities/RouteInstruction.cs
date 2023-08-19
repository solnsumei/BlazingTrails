using System.ComponentModel.DataAnnotations;

namespace BlazingTrails.Api.Persistence.Entities;

public class RouteInstruction
{
    public int Id { get; set; }
    [Required]
    public int TrailId { get; set; }
    [Required]
    public int Stage { get; set; }
    [Required]
    public string Description { get; set; } = default!;

    public Trail Trail { get; set; } = default!;
}


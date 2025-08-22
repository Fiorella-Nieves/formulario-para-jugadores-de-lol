using System.ComponentModel.DataAnnotations;

namespace formulario_lol.Models;

public class Cliente
{
    public int Id { get; set; }
    [Required]
    public string? Nombre { get; set; }
    [Required]
    public string? Apellido { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Telefono { get; set; }
    [Required]
    public DateTime FechaRegistro { get; set; }
    
}
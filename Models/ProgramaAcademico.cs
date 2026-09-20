
using System.Text.Json.Serialization;

namespace ProgramacionV.Api.Models;

public class ProgramaAcademico
{
    public int Id { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string Nombre { get; set; } = string.Empty;


    [JsonIgnore]
    public List<Estudiante> Estudiantes { get; set; } = [];
}
// vamos a hacer otro cambio para agregarlo en un nuevo commit  
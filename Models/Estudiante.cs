namespace ProgramacionV.Api.Models;

public class Estudiante
{
    public int Id { get; set; }

    public string Documento { get; set; } = string.Empty;

    public string Nombre { get; set; } = string.Empty;

    public string Correo { get; set; } = string.Empty;

    public int ProgramaAcademicoId { get; set; }

    public ProgramaAcademico? ProgramaAcademico { get; set; }
}
// comentario para prueba del desafio #4, vamos a verificar que el commit se deshaga correctamente y que el archivo vuelva a su estado original.
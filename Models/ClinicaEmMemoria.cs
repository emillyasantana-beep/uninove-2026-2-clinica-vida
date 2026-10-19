namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Coração e vasos" },
        new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Saúde infantil" },
        new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Cuidados com a pele" },
        new Especialidade { Id = 4, Nome = "Ortopedia", Descricao = "Sistema ósseo" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Dra. Marta Lisboa", Crm = "55307", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Dr. Carlos Eduardo", Crm = "61204", EspecialidadeId = 1 },
        new Medico { Id = 3, Nome = "Dra. Ana Beatris", Crm = "72310", EspecialidadeId = 2 },
        new Medico { Id = 4, Nome = "Dr. Daniel Faria", Crm = "83411", EspecialidadeId = 2 },
        new Medico { Id = 5, Nome = "Dra. Elena Rostova", Crm = "94522", EspecialidadeId = 3 },
        new Medico { Id = 6, Nome = "Dr. Fernando Dias", Crm = "10533", EspecialidadeId = 4 }
    };
}
﻿namespace PacienteAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Endereco { get; set; }
        public string Observacao { get; set; }

    }
}

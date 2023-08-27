﻿using System.ComponentModel.DataAnnotations;

namespace filmes_api.Data.Dtos
{
    public class ReadFilmeDto
    {
        
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public DateTime DataDaConsulta { get; set; } = DateTime.Now;
    }
}
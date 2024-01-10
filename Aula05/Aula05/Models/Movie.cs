﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Aula05.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Título obrigatório")]
        [DisplayName("Título")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Ano lançamento")]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}

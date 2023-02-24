using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_MVC.Models
{
    [Table("CRUD_Repositorios")]
    public class RepositoriosModel
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Dono")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Column("Nome")]
        public string? Dono { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Column("Nome")]
        public string? NomeRepositorio { get; set; }

        [Display(Name = "Descrição")]
        [Column("Nome")]
        public string? Descricao { get; set; }

        [Display(Name = "Linguagem")]
        [Column("Nome")]
        public string? Linguagem { get; set; }

        [Display(Name = "Ultima Atualização")]
        [Column("Nome")]
        public DateTime UltimoUpdate { get; set; } = DateTime.Now;
    }
}

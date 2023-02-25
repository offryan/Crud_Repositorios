using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_MVC.Models
{
    [Table("CRUD_Repositorios")]
    public class RepositoriosModel
    {
        // ID
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        // Nome do criador do repositório
        [Display(Name = "Creador")]
        [Column("Dono")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Dono { get; set; }

        // Nome do Repositório
        [Display(Name = "Repositório")]
        [Column("Repositório")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Repositorio { get; set; }

        // Descrição do Repositório
        [Display(Name = "Descrição")]
        [Column("Descrição")]
        public string? Descricao { get; set; }

        // Linguagem do Repositório
        [Display(Name = "Linguagem")]
        [Column("Linguagem")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Linguagem { get; set; }

        // Última Atualização do Repositório
        [Display(Name = "Última Atualização")]
        [Column("Última Atualização")]
        public DateTime UltimoUpdate { get; set; } = DateTime.Now;
    }
}

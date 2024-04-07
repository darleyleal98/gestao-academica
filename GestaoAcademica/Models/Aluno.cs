using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGuide.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("RU")]
        [Required(ErrorMessage = "O RU do aluno deve ser informado!")]
        public int RU { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O nome deve ser informado!")]
        public string Nome { get; set; } = string.Empty;

        [DisplayName("Idade")]
        [Required(ErrorMessage = "O campo Idade é obrigatório!")]
        public int Idade { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "O endereço deve ser informado!")]
        public string Endereco { get; set; } = string.Empty;

        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido, verifique e tente novamente!")]
        [Required(ErrorMessage = "O e-mail deve ser informado!")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Curso")]
        [Required(ErrorMessage = "O curso deve ser informado!")]
        public string Curso { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Número de telefone inválido, verifique e tente novamente!")]
        public string Telefone { get; set; } = string.Empty;
    }
}
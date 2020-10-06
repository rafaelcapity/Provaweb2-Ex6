using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Provaweb2_Ex6.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Curso: ")]
        public string Curso { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Filiação: ")]
        public string Filiacao { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "E-mail: ")]
        [EmailAddress(ErrorMessage = "E-mail Invalido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }

    }
}
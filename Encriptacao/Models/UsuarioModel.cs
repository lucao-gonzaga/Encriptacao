using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Encriptacao.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o Email para login")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe Senha")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength =3, 
            ErrorMessage ="Senha mínima 3 caracteres")]
        public string Senha { get; set; }

        //[NotMapped]//A propriedade não se torna atributo na tabela
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage ="Senha não confere")]
        public string ConfirmaSenha { get; set; }

        [Required(ErrorMessage ="Informe o Nível")]
        public string Nivel { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System;


namespace TPLOCAL1_base.Models
{
    public class FormulaireModel
    {
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Merci de vérifier le Nom")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Merci de vérifier le Prénom")]
        public string Prenom { get; set; }
        [Display(Name = "Sexe")]
        [Required]
        public string Sexe { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Merci de vérifier l'Adresse")]
        public string Adresse { get; set; }

        [Display(Name = "Code Postal")]
        [Required(ErrorMessage = "Merci de vérifier le Code Postal")]
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Code Postal doit être sur 5 caractères numériques ")]
        public string Codepostal { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Merci de vérifier la Ville")]
        public string Ville { get; set; }

        [Display(Name = "Adresse Mail")]
        [Required(ErrorMessage = "Merci de rensegné une adresse email valide")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$")]
        public string Email { get; set; }


        [Display(Name = "Date début formation")]
        [Required(ErrorMessage = "La date doit être inférieure au  01 / 01 / 2021")]
        [Range(typeof(DateTime), "1/1/2011", "1/1/2021")]
        public string DateFormation { get; set; }

        [Display(Name = "Formation Suivie")]
        [Required]
        public string TypeFormation { get; set; }




        [Display(Name = "Formation Cobol")]
        public string Formationcobol { get; set; }

        [Display(Name = "Formation C#")]
        public string FormationC { get; set; }

    }
}
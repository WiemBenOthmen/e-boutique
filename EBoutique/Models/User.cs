//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBoutique.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int idUser { get; set; }
        public string login { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string mdp { get; set; }
        public string tel { get; set; }
        public string adresse { get; set; }
        public Nullable<int> codePostal { get; set; }
        public string ville { get; set; }
        public Nullable<System.DateTime> datenaissance { get; set; }
    }
}
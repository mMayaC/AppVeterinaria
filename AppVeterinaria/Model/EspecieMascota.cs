using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppVeterinaria.Model
{
    public class EspecieMascota
    {
        public EspecieMascota() { }

        [PrimaryKey]
        public int Idespecie { get; set; }
        [MaxLength(50)]
        public string especie { get; set; }
    }



}
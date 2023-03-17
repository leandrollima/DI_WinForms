using System;
using System.Collections.Generic;

namespace POC.EFCore.Model;

public partial class Categorie
{
    public long IdCategorie { get; set; }

    public string Identification { get; set; } = null!;


    public override string ToString()
    {
        return $"{IdCategorie} - {Identification}";
    }
}

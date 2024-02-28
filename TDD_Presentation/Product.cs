using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Presentation_domain
{
    public enum Categories { Lebensmittel, Elektronik, Getränk }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Categorie { get; set; }

        public int Price { get; set; }

    }
}

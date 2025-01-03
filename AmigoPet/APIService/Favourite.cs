using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoPet.APIService
{
    public class Favourite
    {
        public int Id { get; set; }
        public string Image_Id { get; set; }
        public BreedImage Image { get; set; }
    }

    public class BreedImage
    {
        public string Url { get; set; }
    }
}

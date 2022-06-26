using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnarLink_Blazor.Shared
{
    public class Gear
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Size { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}

using ssp7wq_gyak08.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssp7wq_gyak08.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color BoxColor { get; set; }
        public Color RibbonColor { get; set; }
        public Toy Createnew()
        {
            return new Present(BoxColor, RibbonColor);
        }
    }
}

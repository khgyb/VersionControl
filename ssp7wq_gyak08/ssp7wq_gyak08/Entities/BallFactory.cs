using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssp7wq_gyak08.Entities
{
    class BallFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}

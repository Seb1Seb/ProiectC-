using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModel
{
    [Flags]
    public enum atributeIndivizi
    {
        none = 0,
        Inalt = 1,
        Scund = 2,
        Slab = 4,
        Gras = 8,
        Sanatos = 16,
        Bolnav = 32
    }

}

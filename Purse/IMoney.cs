using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    public interface IMoney
    {
        void SetCash(double a);
        double GetCash();
    }
}

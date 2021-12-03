using Abztrakciok.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abztrakciok.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}

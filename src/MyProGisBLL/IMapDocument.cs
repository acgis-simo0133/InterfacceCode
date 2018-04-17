using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public interface IMapDocument
    {
        IMap FocusMap {get;}
        List<IMap> Maps {get;}
        IMap GetMap(string name);
    }
}

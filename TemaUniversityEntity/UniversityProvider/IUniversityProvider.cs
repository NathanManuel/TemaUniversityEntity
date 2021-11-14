using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaUniversityEntity.UniversityProvider
{
    interface IUniversityProvider
    {
        IEnumerable<string> GetUniversityContent();
    }
}

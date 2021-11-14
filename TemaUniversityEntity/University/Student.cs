using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaUniversityEntity.UniversityProvider;

namespace TemaUniversityEntity.University
{
    class Student : IUniversity
    {

        private readonly IUniversityProvider _contentProvider;

        public Student(IUniversityProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }
        public void Information()
        {
            IEnumerable<string> bookContent = _contentProvider.GetUniversityContent();
            Console.WriteLine("Succesfully uploaded student information");
        }
    }
}

using System;
using TemaUniversityEntity.University;
using TemaUniversityEntity.UniversityProvider;

namespace TemaUniversityEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUniversityProvider contentProvider1 = new PersonnelProvider();
            AditionalPersonnel personnel1 = new AditionalPersonnel(contentProvider1);
            personnel1.Information();

            IUniversityProvider contentProvider2 = new ProfessorProvider();
            Professor professor1 = new Professor(contentProvider2);
            professor1.Information();

            IUniversityProvider contentProvider3 = new StudentProvider();
            Student student1 = new Student(contentProvider3);
            student1.Information();
        }
    }
}

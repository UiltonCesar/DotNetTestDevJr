using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() 
        {
            var repositorio = new Repository();

            return  repositorio.Students.Where(stu => stu.Birth.Year == 2020).ToList();
        }
    }
}

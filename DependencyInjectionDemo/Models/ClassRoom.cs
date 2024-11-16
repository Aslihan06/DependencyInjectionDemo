using DependencyInjectionDemo.Interfaces;

namespace DependencyInjectionDemo.Models
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        // Constructor Injection
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}


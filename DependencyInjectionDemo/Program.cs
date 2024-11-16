using DependencyInjectionDemo.Interfaces;
using DependencyInjectionDemo.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Dependency Injection ayarları
        var serviceProvider = new ServiceCollection()
            .AddScoped<ITeacher, Teacher>() // ITeacher interface'ini Teacher implementasyonu ile eşleştir
            .BuildServiceProvider();

        // Öğretmen nesnesi oluştur
        var teacher = serviceProvider.GetService<ITeacher>();
        teacher.FirstName = "Ahmet";
        teacher.LastName = "Yılmaz";

        // ClassRoom nesnesini Teacher ile oluştur
        var classRoom = new ClassRoom(teacher);

        // Öğretmen bilgilerini ekrana yazdır
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}

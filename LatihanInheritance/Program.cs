using System;
namespace TugasInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person orang = new Person("Rizqi", 28);
            orang.GetNameAndAge();

            Teacher guru = new Teacher("Bio", 34, "3001", "Math");
            guru.GetNameAndAge();

            Student siswa = new Student("Janhefi", 19, "2889", "rbjanhefi22@gmail.com");
            siswa.GetNameAndAge();
        }
    }
}
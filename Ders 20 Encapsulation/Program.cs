using System;

namespace Ders_20_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student = new Student("Murat", "XX", 123, 5);
            student.GetStudentInfo();
            Console.WriteLine("*******");
            student.ClassToUp();
            student.GetStudentInfo();
            Student student2 = new Student("Deniz Arda", "XX", 123, 1);
            student2.ClassToDown();
            student2.ClassToDown();

            student2.GetStudentInfo();

        }
    }

    class Student
    {
        private string name;
        private string lastName;
        private int studentNo;

        private int classNo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string LastName { get => lastName; set => lastName = value; }
        public int ClassNo
        {
            get => classNo;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    classNo = 1;
                }
                else
                {
                    classNo = value;

                }

            }
        }
        public int StudentNo { get => studentNo; set => studentNo = value; }

        public Student()
        {

        }
        public Student(string name, string lastName, int studentNo, int classNo)
        {
            this.Name = name;
            this.LastName = lastName;
            this.StudentNo = studentNo;
            this.ClassNo = classNo;
        }
        public void GetStudentInfo()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Name: {0} LastName: {1} Student No: {2} Class No: {3}", this.Name, this.LastName, this.StudentNo, this.ClassNo);

        }
        public void ClassToUp()
        {
            this.ClassNo = this.ClassNo + 1;
        }
        public void ClassToDown()
        {
            this.ClassNo = this.ClassNo - 1;

        }
    }
}

Student student = new Student();
student.Name = "Melih";
student.Surname = "Özaslan";
student.StudentNo = 477;
student.ClassNo = 12;

Student student1 = new Student("Ahmet","Akıllıoğlu",356,1);
student1.ClassDown();
student1.getStudentİnfo();

student.getStudentİnfo();

student.ClassUp();
student.getStudentİnfo();



class Student
{
    private string name;
    private string surname;
    private int studentNo;
    private int classNo;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int ClassNo
    {
        get => classNo;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir !!");
                classNo = 1;
            }
            else
            {
                classNo = value;
            }
        }
    }

    public Student(string name, string surname, int studentNo, int classNo)
    {
        Name = name;
        Surname = surname;
        StudentNo = studentNo;
        ClassNo = classNo;
    }

    public Student() { }

    public void getStudentİnfo()
    {
        Console.WriteLine("********************** Öğrenci Bilgileri ***************");
        Console.WriteLine("Öğrenci Adı          :{0}", this.Name);
        Console.WriteLine("Öğrenci Soyadı       :{0}", this.surname);
        Console.WriteLine("Öğrenci Numarası     :{0}", this.StudentNo);
        Console.WriteLine("Öğrenci Sınıfı       :{0}", this.ClassNo);

    }

    public void ClassUp()
    {
        this.ClassNo = ClassNo + 1;

    }

    public void ClassDown()
    {
        this.ClassNo = ClassNo - 1;

    }


}
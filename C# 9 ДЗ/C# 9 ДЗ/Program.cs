using System.Net;

class PersonalInfo
{
  public string? FirstName { get; set; }
  public string? Surname { get; set; }
  public string? Lastname { get; set; }

  public int BirthDay { get; set; }
  public int BirthMonth { get; set; }
  public int BirthYear { get; set; }

  public string? ZnakZodiaka { get; set; }
}

class Info_Residence
{
  public string? Region { get; set; }
  public string? City { get; set; }
  public string? Street { get; set; }
  public int HouseNumber { get; set; }
  public char Korpus { get; set; }
  public short PostalCode { get; set; }
}




class StudyInfo
{
  public int StartDay { get; set; }
  public int StartMonth { get; set; }
  public int StartYear { get; set; }
  public int Course { get; set; }
  public string? GroupName { get; set; }
  public string? Specialization { get; set; }
  public int StudentsCount { get; set; }
}

class Attendance
{
  public int LessonsVisited { get; set; }
  public int LessonsLate { get; set; }
}

class Grades_DZ
{
  public int[] DzRates { get; set; } = new int[0];
  public float DzAverageRate
  {
    get
    {
      if (DzRates.Length == 0)
        return 0;
      int sum = 0;
      for (int i = 0; i < DzRates.Length; i++)
      {
        sum += DzRates[i];
      }
      return (float)sum / DzRates.Length;
    }
  }
}

class Practice_Grades
{
  public int[]? PracticeRates { get; set; }
  public float PracticeAverageRate
  {
    get
    {
      if (PracticeRates.Length == 0)
        return 0;
      int sum = 0;
      for (int i = 0; i < PracticeRates.Length; i++)
      {
        sum += PracticeRates[i];
      }
      return (float)(sum / PracticeRates.Length);
    }
  }
}

class Exam_Grades
{
  public int[]? ExamRates { get; set; }
  public float ExamAverageRate { get {
      if(ExamRates.Length == 0)
      {
        return 0;
      }
      int sum = 0;
      for(int i = 0;i < ExamRates.Length; i++)
      {
        sum += ExamRates[i];
      }
      return sum / ExamRates.Length;
    } }
}

class Zachet
{
  public int[]? ZachetRates { get; set; }
  public int ZachetCount
  {
    get
    {
      return ZachetRates.Length;
    }
  }

  public float ZachetAverageRate
  {
    get
    {

      if (ZachetRates.Length == 0)
        return 0;
      int sum = 0;
      for (int i = 0; i < ZachetRates.Length; i++)
      {
        sum += ZachetRates[i];
      }
      return (float)(sum / ZachetRates.Length);
    }
  }
}




class Student
{
  public PersonalInfo Personal { get; set; } = new();


  public Info_Residence Address { get; set; } = new();
  public StudyInfo Study { get; set; } = new();
  public Attendance Attendance { get; set; } = new();
  public Grades_DZ DzRates { get; set; } = new();
  public Practice_Grades Practice { get; set; } = new();
  public Exam_Grades Exam { get; set; } = new();
  public Zachet Zachet { get; set; } = new();


  public double TotalAverageRate { get; set; }
  public float ZachetAverageRate { get; set; }
}
class Program
{
  static void Main()
  {
    Student student = new Student();

    student.Personal.FirstName = "Maksym";
    student.Personal.Surname = "Zaluga";

    student.Address.City = "Uzhhorod";
    student.Address.Street = "Main street";
    student.Address.HouseNumber = 10;

    student.Study.Course = 2;
    student.Study.GroupName = "IT-21";
    student.Study.Specialization = "Programming";

    student.Attendance.LessonsVisited = 120;
    student.Attendance.LessonsLate = 3;

    student.DzRates.DzRates = new int[] { 10, 11, 12 };


    student.Practice.PracticeRates = new int[] { 9, 10 };


    student.Exam.ExamRates = new int[] { 10 };
    

    student.Zachet.ZachetRates = new int[] { 1, 1, 1 };



    student.TotalAverageRate = 10.2;
  }
}



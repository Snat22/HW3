namespace task2;

public class Student
{
string _fullname;
int _age;
int _grade;

public Student()
{
    
}
public Student(string name,int age)
{
    _fullname = name;
    _age = age;
}

public Student(string name,int age ,int grade)
{
    _fullname = name;
    _age = age;
    _grade = grade;
}
        public void Study()
        {
            System.Console.WriteLine($"{_fullname} is studying.\nBut {_fullname} grade today {_grade} is so bad");
        }

        public void SetGrade(int newGrade)
        {
            _grade = newGrade;
        }
        public int GetGrade(){
            return _grade;
        }
}

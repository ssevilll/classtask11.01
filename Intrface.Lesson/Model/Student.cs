namespace Intrface.Lesson.Model
{
    internal class Student
    {
        private string _name;
        public string Name 
        { 
            get { return _name; } 
        }
        private string _surname;
        public string Surname 
        { 
            get { return _surname; }
        }
        private string _fullname;
        public string FullName 
        {
            get { return _fullname; } 
            set { 
                var names = value.Split(' ');
                if (names.Length == 2)
                {
                    _name = names[0];
                    _surname = names[1];
                    _fullname = value;
                }
                else
                {
                    Console.WriteLine("FullName must contain exactly one space separating first name and last name.");
                }
            }
        }
        public int Age { get; set; }
        private string _groupno;
        public string GroupNo 
        { 
            get { return _groupno; }
            set {if (value.Length == 4 && char.IsUpper(value[0]) && char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]))
                {
                    _groupno = value;
                }
                else
                {
                    Console.WriteLine("GroupNo must be 4 characters long, starting with an uppercase letter followed by three digits.");
                }
            }
        }

        public Student(string FullName, string GroupNo, int Age)
        {
            FullName= FullName;
            GroupNo= GroupNo;
            Age= Age;

        }

        public static bool CheckGroupNo(string groupNo)
        {
            return groupNo.Length == 4 && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]);
        }

        public static bool CheckFullName(string fullName)
        {
            var names = fullName.Split(' ');
            return names.Length == 2;
        }

    }
}

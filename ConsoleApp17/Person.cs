using System;

namespace ConsoleApp17
{
    class Person
    {
        private string _name;
        private string _surname;
        private System.DateTime _dateofbirth;
        public Person(string a, string b, System.DateTime c)
        {
            _name = a;
            _surname = b;
            _dateofbirth = c;
        }
        public Person()
        {
            _name = "Имя";
            _surname = "Фамилия";
            _dateofbirth = DateTime.Parse("2000/01/01");
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surame
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public System.DateTime DateOfBirth
        {
            get
            {
                return _dateofbirth;
            }
            set
            {
                _dateofbirth = value;
            }
        }
        public int IntDateOfBirth
        {
            get
            {
                return Int32.Parse(_dateofbirth.Year.ToString());
            }
            set
            {
                _dateofbirth = new DateTime(value, _dateofbirth.Month, _dateofbirth.Day);
            }
        }
        public override string ToString()
        {
            return $"Имя: {_name.ToString()}\nФамилия: {_surname.ToString()}\nДата рождения: {DateOfBirth.Day.ToString()}.{DateOfBirth.Month.ToString()}.{DateOfBirth.Year.ToString()}\n";
        }
        public virtual string ToShortString()
        {
            return $"Имя: {_name.ToString()}\nФамилия: {_surname.ToString()}\n";
        }
    }
}

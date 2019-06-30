namespace Code_Academy_HR_System
{


    class Student
    {
        private static int ID;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Educ_Info { get; set; }

        private float _bill { get; set; }

        public float Bill
        {
            get {
                return _bill;
            }
            set {
                if (value >= 0) {
                    _bill = value;
                }

            }
        }

        public GroupType Type;

        public Student(string name,string surname,string email,string educ_info, GroupType type) {
            ID++;
            Name = name;
            Surname = surname;
            Email = email;
            Educ_Info = educ_info;
            Type = type;
        }


    }

}

namespace baiTapOopLopBegin2
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public double DiemToan {get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemTB { get; set; }
        public string HocLuc { get; set; }

        public Student(int id, string name, string sex, int age, double diemToan, double diemLy, double diemHoa)
        {
            ID = id;
            Name = name;
            Sex = sex;
            Age = age;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DiemTB = (diemHoa + diemToan + diemLy) / 3;
        }
    }
}
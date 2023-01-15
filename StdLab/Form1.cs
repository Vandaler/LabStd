namespace StdLab
{
    public partial class Form1 : Form
    {
        List<string> liststudents = new List<string>();
        List<double> Grades = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), textBox6.Text);
            liststudents.Add(student._Name);
            Grades.Add(student._GPAX);

            dataGridView1.Rows.Add(
                student._Name,
                student._IdS,
                student._BYear,
                student._Tall,
                student._GPAX,
                student._Offset);

            Grades.Sort();
            MinGrade.Text = Grades.First().ToString();
            MaxGrade.Text = Grades.Last().ToString();
            AllStudents.Text = liststudents.Count.ToString();
            dataGridView1.Sort(dataGridView1.Columns[4], System.ComponentModel.ListSortDirection.Descending);
        }
    }
    public class Student
    {
        public string _Name;
        public string _IdS;
        public int _BYear;
        public double _Tall;
        public double _GPAX;
        public string _Offset;
        public Student(string name, string idS, int bYear, double tall, double gPAX, string offset)
        {
            _Name = name;
            _IdS = idS;
            _BYear = bYear;
            _Tall = tall;
            _GPAX = gPAX;
            _Offset = offset;
        }
    }
}
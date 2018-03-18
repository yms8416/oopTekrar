namespace BilgeAdam.OOP.WindowsApp
{
    class Exam
    {
        public string FullName { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public double Avg
        {
            get
            {
                return Exam1 * 0.4 + Exam2 * 0.6;
            }
        }
    }
}

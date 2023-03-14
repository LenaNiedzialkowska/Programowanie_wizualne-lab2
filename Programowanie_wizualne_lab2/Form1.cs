namespace Programowanie_wizualne_lab2
{
    public partial class Form1 : Form
    {
        //public string Value { get; set; }
        public string Value = "0";
        int cena = 0;
        Form2 newform2;
        Form3 newform3;
        public Form1()
        {
            InitializeComponent();
            newform2 = new Form2();
            newform3 = new Form3();
        }

        private void buttonKomputer_Click(object sender, EventArgs e)
        {
            
            newform2.Show();
        }

        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            
            newform3.Show();
        }

        private void labelCena_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Sum += int.Parse(Value);
            //labelCena.Text = Sum.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cena = newform2.getCena() + newform3.getCena();
            labelCena.Text = cena.ToString();
        }
    }
}
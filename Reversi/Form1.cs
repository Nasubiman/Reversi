namespace Reversi
{
    public partial class Form1 : Form
    {
        public class Hoge
        {
            public string poyo
            {
                get; set;
            }

            public string tofu
            {
                get;
            }

            public void change_tofu(string line)
            {
                this.tofu = line;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
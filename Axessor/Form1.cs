namespace Axessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int size))
            {
                if (size > 0 && size < 500)
                {
                    pictureBox1.Size = new Size(size, size);
                }
                else
                {
                    MessageBox.Show("Доступные значения меньше 500");
                }

            }
        }
        public class Square
        {
            private int size;
            private int Size
            {
                get { return size; }
                set
                {
                    if (value > 0 && value < 500)
                    {
                        size = value;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
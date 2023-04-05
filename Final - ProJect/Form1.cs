namespace Final___ProJect
{
    public partial class Form1 : Form
    {
        List<TypeBook> typeBooks;
        TypeBook selectedTypeBook;
        public Form1()
        {
            InitializeComponent();
            typeBooks = new List<TypeBook>();
            typeBooks.Add(new Manga());
            typeBooks.Add(new LightNovel());
            typeBooks.Add(new Learning());
            typeBooks.Add(new Traveling());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedTypeBook = typeBooks[0];
            this.pictureBox1.Image = selectedTypeBook.getImage();
            this.tbName.Text = selectedTypeBook.getName();
            this.tbType.Text = selectedTypeBook.getType();
            this.tbIdBook.Text = selectedTypeBook.getIdbook().ToString();
            this.tbPayment.Text = selectedTypeBook.getPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedTypeBook = typeBooks[1];
            this.pictureBox1.Image = selectedTypeBook.getImage();
            this.tbName.Text = selectedTypeBook.getName();
            this.tbType.Text = selectedTypeBook.getType();
            this.tbIdBook.Text = selectedTypeBook.getIdbook().ToString();
            this.tbPayment.Text = selectedTypeBook.getPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedTypeBook = typeBooks[2];
            this.pictureBox1.Image = selectedTypeBook.getImage();
            this.tbName.Text = selectedTypeBook.getName();
            this.tbType.Text = selectedTypeBook.getType();
            this.tbIdBook.Text = selectedTypeBook.getIdbook().ToString();
            this.tbPayment.Text = selectedTypeBook.getPayment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedTypeBook = typeBooks[3];
            this.pictureBox1.Image = selectedTypeBook.getImage();
            this.tbName.Text = selectedTypeBook.getName();
            this.tbType.Text = selectedTypeBook.getType();
            this.tbIdBook.Text = selectedTypeBook.getIdbook().ToString();
            this.tbPayment.Text = selectedTypeBook.getPayment();
        }
    }
}
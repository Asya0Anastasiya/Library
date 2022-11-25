namespace Library
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuForm Menu = new();
            Menu.Show();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
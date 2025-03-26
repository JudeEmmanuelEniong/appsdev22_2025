namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string language = textBoxLanguage.Text.Trim();
            if (!string.IsNullOrEmpty(language))
            {
                listBoxLanguages.Items.Add(language);
                textBoxLanguage.Clear();  // Clear the TextBox after adding
            }
            else
                MessageBox.Show("Enter a valid language.");

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxLanguages.SelectedItem != null)
                listBoxLanguages.Items.Remove(listBoxLanguages.SelectedItem);
            else
                MessageBox.Show("Select a language to remove.");
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {

            listBoxLanguages.Items.Clear();
        }
    }
}

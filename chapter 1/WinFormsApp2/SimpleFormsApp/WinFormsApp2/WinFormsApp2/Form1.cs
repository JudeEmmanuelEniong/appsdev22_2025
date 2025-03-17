namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] movies = { "Titanic", "Avengers End  Game", "Spider Man Far away From Home" };
            checkBox.Items.AddRange(movies );

            checkBox.CheckOnClick = true;
        }

        private void checkBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movie in checkBox.Items)
            {
                bool isSelected = checkBox.GetItemChecked(checkBox.Items.IndexOf(movie));
                if (isSelected && !listBox.Items.Contains(movie))
                {
                    listBox.Items.Add(movie);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

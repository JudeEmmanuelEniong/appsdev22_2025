namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with cuisine types
            comboBoxCuisine.Items.Add("Italian");
            comboBoxCuisine.Items.Add("Chinese");
            comboBoxCuisine.Items.Add("Indian");
            comboBoxCuisine.Items.Add("Mexican");
            comboBoxCuisine.Items.Add("American");
            comboBoxCuisine.SelectedIndex = 0; // Default selection

            // Populate CheckedListBox with favorite foods
            checkedListBoxFoods.Items.Add("Pizza");
            checkedListBoxFoods.Items.Add("Pasta");
            checkedListBoxFoods.Items.Add("Burger");
            checkedListBoxFoods.Items.Add("Sushi");
            checkedListBoxFoods.Items.Add("Tacos");
            checkedListBoxFoods.Items.Add("Noodles");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFoods.CheckedItems)
            {
                // Avoid adding duplicate items to the ListBox
                if (!listBoxSelectedFoods.Items.Contains(item))
                {
                    listBoxSelectedFoods.Items.Add(item);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (listBoxSelectedFoods.SelectedItems.Count > 0)
            {
                listBoxSelectedFoods.Items.Remove(listBoxSelectedFoods.SelectedItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            listBoxSelectedFoods.Items.Clear();
        }

        private void btnSelectCuisine_Click(object sender, EventArgs e)
        {

            string selectedCuisine = comboBoxCuisine.SelectedItem.ToString();


            lblSelectedCuisine.Text = "Selected Cuisine: " + selectedCuisine;


            comboBoxCuisine.Enabled = false;


            checkedListBoxFoods.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void lblSelectedCuisine_Click(object sender, EventArgs e)
        {

        }
    }
}


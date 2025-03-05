namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNamevalue = firstname.Text;
            string lnameValue = middlename.Text;
            string middlenameValue = lastname.Text;
            string suffixValue = suffix.Text;

            DialogResult result = MessageBox.Show(
             "Are you sure you want to Submit?",
             "Press Sumbit to confirm",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes) {
                MessageBox.Show($"Welcome! :) {fNamevalue} {middlenameValue} {lnameValue} {suffixValue}",
         "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {

                MessageBox.Show("Submission was canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

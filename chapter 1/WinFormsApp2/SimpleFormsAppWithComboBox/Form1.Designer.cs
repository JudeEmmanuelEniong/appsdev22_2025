namespace SimpleFormsAppWithComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            comboBoxCuisine = new ComboBox();
            lblSelectedCuisine = new Label();
            btnSelectCuisine = new Button();
            label3 = new Label();
            checkedListBoxFoods = new CheckedListBox();
            btnAdd = new Button();
            label4 = new Label();
            listBoxSelectedFoods = new ListBox();
            btnRemove = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 22);
            label1.Name = "label1";
            label1.Size = new Size(302, 21);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Food Picker-App";
            // 
            // comboBoxCuisine
            // 
            comboBoxCuisine.FormattingEnabled = true;
            comboBoxCuisine.Location = new Point(57, 122);
            comboBoxCuisine.Name = "comboBoxCuisine";
            comboBoxCuisine.Size = new Size(151, 28);
            comboBoxCuisine.TabIndex = 1;
            // 
            // lblSelectedCuisine
            // 
            lblSelectedCuisine.AutoSize = true;
            lblSelectedCuisine.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedCuisine.Location = new Point(35, 76);
            lblSelectedCuisine.Name = "lblSelectedCuisine";
            lblSelectedCuisine.Size = new Size(76, 19);
            lblSelectedCuisine.TabIndex = 2;
            lblSelectedCuisine.Text = "Cuisine";
            lblSelectedCuisine.Click += lblSelectedCuisine_Click;
            // 
            // btnSelectCuisine
            // 
            btnSelectCuisine.Font = new Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectCuisine.Location = new Point(57, 205);
            btnSelectCuisine.Name = "btnSelectCuisine";
            btnSelectCuisine.Size = new Size(151, 40);
            btnSelectCuisine.TabIndex = 3;
            btnSelectCuisine.Text = "Select";
            btnSelectCuisine.UseVisualStyleBackColor = true;
            btnSelectCuisine.Click += btnSelectCuisine_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(314, 75);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 4;
            label3.Text = "Food List";
            // 
            // checkedListBoxFoods
            // 
            checkedListBoxFoods.BackColor = SystemColors.HighlightText;
            checkedListBoxFoods.FormattingEnabled = true;
            checkedListBoxFoods.Location = new Point(286, 122);
            checkedListBoxFoods.Name = "checkedListBoxFoods";
            checkedListBoxFoods.Size = new Size(173, 180);
            checkedListBoxFoods.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(314, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 39);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(547, 76);
            label4.Name = "label4";
            label4.Size = new Size(174, 18);
            label4.TabIndex = 8;
            label4.Text = "Favorite Food List";
            // 
            // listBoxSelectedFoods
            // 
            listBoxSelectedFoods.FormattingEnabled = true;
            listBoxSelectedFoods.Location = new Point(524, 122);
            listBoxSelectedFoods.Name = "listBoxSelectedFoods";
            listBoxSelectedFoods.Size = new Size(283, 184);
            listBoxSelectedFoods.TabIndex = 9;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(823, 177);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(101, 42);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(823, 241);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 45);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 475);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(listBoxSelectedFoods);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(checkedListBoxFoods);
            Controls.Add(label3);
            Controls.Add(btnSelectCuisine);
            Controls.Add(lblSelectedCuisine);
            Controls.Add(comboBoxCuisine);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCuisine;
        private Label lblSelectedCuisine;
        private Button btnSelectCuisine;
        private Label label3;
        private CheckedListBox checkedListBoxFoods;
        private Button btnAdd;
        private Label label4;
        private ListBox listBoxSelectedFoods;
        private Button btnRemove;
        private Button btnClear;
    }
}

namespace SimpleFormsAppWithListBox
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
            listBoxLanguages = new ListBox();
            textBoxLanguage = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonClearAll = new Button();
            SuspendLayout();
            // 
            // listBoxLanguages
            // 
            listBoxLanguages.FormattingEnabled = true;
            listBoxLanguages.Location = new Point(395, 78);
            listBoxLanguages.Name = "listBoxLanguages";
            listBoxLanguages.Size = new Size(194, 164);
            listBoxLanguages.TabIndex = 0;
            // 
            // textBoxLanguage
            // 
            textBoxLanguage.Location = new Point(120, 106);
            textBoxLanguage.Multiline = true;
            textBoxLanguage.Name = "textBoxLanguage";
            textBoxLanguage.Size = new Size(163, 30);
            textBoxLanguage.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(104, 230);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 39);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(221, 230);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 39);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.Location = new Point(158, 301);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(94, 43);
            buttonClearAll.TabIndex = 4;
            buttonClearAll.Text = "Clear All";
            buttonClearAll.UseVisualStyleBackColor = true;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 474);
            Controls.Add(buttonClearAll);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxLanguage);
            Controls.Add(listBoxLanguages);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLanguages;
        private TextBox textBoxLanguage;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonClearAll;
    }
}

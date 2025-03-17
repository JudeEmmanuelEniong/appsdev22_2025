namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox = new CheckedListBox();
            listBox = new ListBox();
            addBtn = new Button();
            delBtn = new Button();
            clrBtn = new Button();
            loadingLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 120);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Movie/Series List";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 120);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "My Movie/Series List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Harlow Solid Italic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 47);
            label3.Name = "label3";
            label3.Size = new Size(465, 36);
            label3.TabIndex = 2;
            label3.Text = "Simple Favorite Movie Picker App";
            // 
            // checkBox
            // 
            checkBox.FormattingEnabled = true;
            checkBox.Location = new Point(108, 150);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(231, 184);
            checkBox.TabIndex = 3;
            checkBox.SelectedIndexChanged += checkBox_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(360, 150);
            listBox.Name = "listBox";
            listBox.Size = new Size(230, 184);
            listBox.TabIndex = 4;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(108, 362);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 28);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(638, 168);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(75, 23);
            delBtn.TabIndex = 6;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(638, 222);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(75, 23);
            clrBtn.TabIndex = 7;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.BackColor = SystemColors.ButtonFace;
            loadingLabel.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadingLabel.Location = new Point(360, 248);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(0, 30);
            loadingLabel.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 466);
            Controls.Add(loadingLabel);
            Controls.Add(clrBtn);
            Controls.Add(delBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox);
            Controls.Add(checkBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkBox;
        private ListBox listBox;
        private Button addBtn;
        private Button delBtn;
        private Button clrBtn;
        private Label loadingLabel;
    }
}

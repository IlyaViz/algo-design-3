namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastComparisons = new TextBox();
            randomCount = new TextBox();
            randomAddButton = new Button();
            cleanButton = new Button();
            resultTextBox = new TextBox();
            searchButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            pkTextBox = new TextBox();
            dataTextBox = new TextBox();
            editButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            newPkTextBox = new TextBox();
            SuspendLayout();
            // 
            // lastComparisons
            // 
            lastComparisons.BackColor = SystemColors.ButtonHighlight;
            lastComparisons.BorderStyle = BorderStyle.None;
            lastComparisons.Location = new Point(21, 76);
            lastComparisons.Name = "lastComparisons";
            lastComparisons.ReadOnly = true;
            lastComparisons.Size = new Size(125, 20);
            lastComparisons.TabIndex = 40;
            lastComparisons.TextAlign = HorizontalAlignment.Center;
            // 
            // randomCount
            // 
            randomCount.Location = new Point(646, 390);
            randomCount.Name = "randomCount";
            randomCount.Size = new Size(125, 27);
            randomCount.TabIndex = 39;
            // 
            // randomAddButton
            // 
            randomAddButton.BackColor = Color.DimGray;
            randomAddButton.Location = new Point(632, 355);
            randomAddButton.Name = "randomAddButton";
            randomAddButton.Size = new Size(156, 29);
            randomAddButton.TabIndex = 38;
            randomAddButton.Text = "Додати рандомні";
            randomAddButton.UseVisualStyleBackColor = false;
            randomAddButton.Click += randomAddButton_Click;
            // 
            // cleanButton
            // 
            cleanButton.BackColor = Color.Brown;
            cleanButton.Location = new Point(12, 395);
            cleanButton.Name = "cleanButton";
            cleanButton.Size = new Size(94, 29);
            cleanButton.TabIndex = 37;
            cleanButton.Text = "Очистити";
            cleanButton.UseVisualStyleBackColor = false;
            cleanButton.Click += cleanButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = SystemColors.Highlight;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Location = new Point(279, 248);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(251, 20);
            resultTextBox.TabIndex = 36;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(210, 10);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 35;
            searchButton.Text = "Знайти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(510, 12);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 34;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(310, 10);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 33;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // pkTextBox
            // 
            pkTextBox.Location = new Point(246, 94);
            pkTextBox.Name = "pkTextBox";
            pkTextBox.Size = new Size(125, 27);
            pkTextBox.TabIndex = 32;
            // 
            // dataTextBox
            // 
            dataTextBox.Location = new Point(425, 94);
            dataTextBox.Name = "dataTextBox";
            dataTextBox.Size = new Size(125, 27);
            dataTextBox.TabIndex = 41;
            // 
            // editButton
            // 
            editButton.Location = new Point(410, 12);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 42;
            editButton.Text = "Змінити";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(425, 68);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 43;
            textBox2.Text = "Дані";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(246, 68);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 44;
            textBox3.Text = "Ключ";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(343, 222);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 45;
            textBox4.Text = "Результат";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ButtonHighlight;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(12, 51);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(148, 20);
            textBox5.TabIndex = 46;
            textBox5.Text = "Останні порівняння";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(246, 127);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 48;
            textBox1.Text = "Новый ключ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // newPkTextBox
            // 
            newPkTextBox.Location = new Point(246, 153);
            newPkTextBox.Name = "newPkTextBox";
            newPkTextBox.Size = new Size(125, 27);
            newPkTextBox.TabIndex = 47;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(newPkTextBox);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(editButton);
            Controls.Add(dataTextBox);
            Controls.Add(lastComparisons);
            Controls.Add(randomCount);
            Controls.Add(randomAddButton);
            Controls.Add(cleanButton);
            Controls.Add(resultTextBox);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(pkTextBox);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastComparisons;
        private TextBox randomCount;
        private Button randomAddButton;
        private Button cleanButton;
        private TextBox resultTextBox;
        private Button searchButton;
        private Button deleteButton;
        private Button addButton;
        private TextBox pkTextBox;
        private TextBox dataTextBox;
        private Button editButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox newPkTextBox;
    }
}
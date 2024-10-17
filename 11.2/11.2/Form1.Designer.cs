namespace _11._2
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
            btnGenerate = new Button();
            btnRead = new Button();
            txtMonth = new TextBox();
            btnSearch = new Button();
            listBoxAll = new ListBox();
            listBoxFiltered = new ListBox();
            lblMessage = new Label();
            btnClear = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(177, 300);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(150, 23);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Генерация";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(21, 300);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 23);
            btnRead.TabIndex = 1;
            btnRead.Text = "Открыть";
            btnRead.Click += btnRead_Click;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(470, 300);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(50, 27);
            txtMonth.TabIndex = 3;
            txtMonth.TextChanged += txtMonth_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(676, 300);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Фильтрация";
            btnSearch.Click += btnSearch_Click;
            // 
            // listBoxAll
            // 
            listBoxAll.Location = new Point(30, 30);
            listBoxAll.Name = "listBoxAll";
            listBoxAll.Size = new Size(304, 244);
            listBoxAll.TabIndex = 6;
            // 
            // listBoxFiltered
            // 
            listBoxFiltered.Location = new Point(470, 30);
            listBoxFiltered.Name = "listBoxFiltered";
            listBoxFiltered.Size = new Size(293, 244);
            listBoxFiltered.TabIndex = 7;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(30, 420);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(700, 20);
            lblMessage.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(97, 329);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Очистить";
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(526, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerate);
            Controls.Add(btnRead);
            Controls.Add(btnClear);
            Controls.Add(txtMonth);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(listBoxAll);
            Controls.Add(listBoxFiltered);
            Controls.Add(lblMessage);
            Name = "Form1";
            Text = "Записи Знаков Зодиака";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.ListBox listBoxFiltered;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

namespace _10._1
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
            this.txtNotebookPrice = new System.Windows.Forms.TextBox();
            this.txtCoverPrice = new System.Windows.Forms.TextBox();
            this.txtNotebookCount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtNotebookPrice
            // 
            this.txtNotebookPrice.Location = new System.Drawing.Point(160, 30);
            this.txtNotebookPrice.Name = "txtNotebookPrice";
            this.txtNotebookPrice.Size = new System.Drawing.Size(100, 20);

            // 
            // txtCoverPrice
            // 
            this.txtCoverPrice.Location = new System.Drawing.Point(160, 70);
            this.txtCoverPrice.Name = "txtCoverPrice";
            this.txtCoverPrice.Size = new System.Drawing.Size(100, 20);

            // 
            // txtNotebookCount
            // 
            this.txtNotebookCount.Location = new System.Drawing.Point(160, 110);
            this.txtNotebookCount.Name = "txtNotebookCount";
            this.txtNotebookCount.Size = new System.Drawing.Size(100, 20);

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 23);
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 190);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Цена одной тетради:";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Text = "Цена одной обложки:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Text = "Количество тетрадей:";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtNotebookPrice);
            this.Controls.Add(this.txtCoverPrice);
            this.Controls.Add(this.txtNotebookCount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "MainForm";
            this.Text = "Калькулятор покупки тетрадей";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNotebookPrice;
        private System.Windows.Forms.TextBox txtCoverPrice;
        private System.Windows.Forms.TextBox txtNotebookCount;
        private System.Windows.Forms.Label lblResult;
    }
}

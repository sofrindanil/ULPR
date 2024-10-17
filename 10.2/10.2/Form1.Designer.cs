namespace _10._2
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.rbFormula = new System.Windows.Forms.RadioButton();
            this.rbLoop = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(150, 30);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);

            // 
            // rbFormula
            // 
            this.rbFormula.AutoSize = true;
            this.rbFormula.Location = new System.Drawing.Point(30, 70);
            this.rbFormula.Name = "rbFormula";
            this.rbFormula.Size = new System.Drawing.Size(87, 17);
            this.rbFormula.TabIndex = 1;
            this.rbFormula.TabStop = true;
            this.rbFormula.Text = "По формуле";

            // 
            // rbLoop
            // 
            this.rbLoop.AutoSize = true;
            this.rbLoop.Location = new System.Drawing.Point(30, 100);
            this.rbLoop.Name = "rbLoop";
            this.rbLoop.Size = new System.Drawing.Size(130, 17);
            this.rbLoop.TabIndex = 2;
            this.rbLoop.TabStop = true;
            this.rbLoop.Text = "Суммирование в цикле";

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 130);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 23);
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 170);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Text = "Введите значение n:";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.rbFormula);
            this.Controls.Add(this.rbLoop);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Сумма кубов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RadioButton rbFormula;
        private System.Windows.Forms.RadioButton rbLoop;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;

    }
}

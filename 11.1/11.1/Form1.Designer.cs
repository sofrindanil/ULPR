namespace _11._1
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
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.rbFormula = new System.Windows.Forms.RadioButton();
            this.rbLoop = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNValue = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(30, 30);
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(250, 45);
            this.trackBarN.Scroll += new System.EventHandler(this.trackBarN_Scroll);

            // 
            // rbFormula
            // 
            this.rbFormula.AutoSize = true;
            this.rbFormula.Location = new System.Drawing.Point(30, 80);
            this.rbFormula.Name = "rbFormula";
            this.rbFormula.Size = new System.Drawing.Size(87, 17);
            this.rbFormula.TabIndex = 1;
            this.rbFormula.TabStop = true;
            this.rbFormula.Text = "По формуле";

            // 
            // rbLoop
            // 
            this.rbLoop.AutoSize = true;
            this.rbLoop.Location = new System.Drawing.Point(30, 110);
            this.rbLoop.Name = "rbLoop";
            this.rbLoop.Size = new System.Drawing.Size(130, 17);
            this.rbLoop.TabIndex = 2;
            this.rbLoop.TabStop = true;
            this.rbLoop.Text = "Суммирование в цикле";

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(250, 23);
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 180);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Text = "Выберите значение n:";

            // 
            // lblNValue
            // 
            this.lblNValue.AutoSize = true;
            this.lblNValue.Location = new System.Drawing.Point(290, 30);
            this.lblNValue.Text = "n: 0"; // начальное значение

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.trackBarN);
            this.Controls.Add(this.rbFormula);
            this.Controls.Add(this.rbLoop);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNValue);
            this.Name = "MainForm";
            this.Text = "Сумма нечётных чисел";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.RadioButton rbFormula;
        private System.Windows.Forms.RadioButton rbLoop;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNValue;
    }
}

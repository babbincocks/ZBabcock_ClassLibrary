namespace ZBabcockLibrary
{
    partial class TemperatureGauge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTemp = new System.Windows.Forms.TrackBar();
            this.txtFahr = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFahr = new System.Windows.Forms.RadioButton();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTemp
            // 
            this.tbTemp.LargeChange = 10;
            this.tbTemp.Location = new System.Drawing.Point(75, 5);
            this.tbTemp.Maximum = 100;
            this.tbTemp.Minimum = -273;
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbTemp.Size = new System.Drawing.Size(42, 256);
            this.tbTemp.TabIndex = 0;
            this.tbTemp.Scroll += new System.EventHandler(this.tbTemp_Scroll);
            // 
            // txtFahr
            // 
            this.txtFahr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFahr.Location = new System.Drawing.Point(10, 178);
            this.txtFahr.Name = "txtFahr";
            this.txtFahr.ReadOnly = true;
            this.txtFahr.Size = new System.Drawing.Size(59, 20);
            this.txtFahr.TabIndex = 1;
            // 
            // txtCelsius
            // 
            this.txtCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelsius.Location = new System.Drawing.Point(10, 93);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ReadOnly = true;
            this.txtCelsius.Size = new System.Drawing.Size(59, 20);
            this.txtCelsius.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celsius";
            // 
            // rbFahr
            // 
            this.rbFahr.AutoSize = true;
            this.rbFahr.Location = new System.Drawing.Point(111, 153);
            this.rbFahr.Name = "rbFahr";
            this.rbFahr.Size = new System.Drawing.Size(78, 30);
            this.rbFahr.TabIndex = 5;
            this.rbFahr.Text = "Fahrenheit \r\nFocused";
            this.rbFahr.UseVisualStyleBackColor = true;
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Checked = true;
            this.rbCelsius.Location = new System.Drawing.Point(111, 83);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(66, 30);
            this.rbCelsius.TabIndex = 6;
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius \r\nFocused";
            this.rbCelsius.UseVisualStyleBackColor = true;
            // 
            // TemperatureGauge
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.rbCelsius);
            this.Controls.Add(this.rbFahr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahr);
            this.Controls.Add(this.tbTemp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TemperatureGauge";
            this.Size = new System.Drawing.Size(213, 264);
            ((System.ComponentModel.ISupportInitialize)(this.tbTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbTemp;
        private System.Windows.Forms.TextBox txtFahr;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFahr;
        private System.Windows.Forms.RadioButton rbCelsius;
    }
}

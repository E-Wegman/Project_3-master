namespace data
{
    partial class Form11
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 40);
            this.button3.TabIndex = 71;
            this.button3.Text = "Weersomstandigheden";
            this.toolTip1.SetToolTip(this.button3, "Navigeer naar weersomstandigheden deelvraag");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 70;
            this.button2.Text = "Werkzoekenden";
            this.toolTip1.SetToolTip(this.button2, "Navigeer naar werkzoekenden deelvraag");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 69;
            this.button1.Text = "Huizenprijzen";
            this.toolTip1.SetToolTip(this.button1, "Navigeer naar huizenprijzen deelvraag");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(480, 12);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(1318, 729);
            this.pieChart1.TabIndex = 77;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 202);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 30);
            this.button8.TabIndex = 82;
            this.button8.Text = "1/7/2012 t/m 31/12/2012";
            this.toolTip1.SetToolTip(this.button8, "Klik om naar een overzicht van periode 4 te gaan");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 30);
            this.button7.TabIndex = 81;
            this.button7.Text = "1/1/2012 t/m 30/6/2012";
            this.toolTip1.SetToolTip(this.button7, "Klik om naar een overzicht van periode 3 te gaan");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 30);
            this.button6.TabIndex = 80;
            this.button6.Text = "1/7/2011 t/m 31/12/2011";
            this.toolTip1.SetToolTip(this.button6, "Klik om naar een overzicht van periode 2 te gaan");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 30);
            this.button5.TabIndex = 79;
            this.button5.Text = "Wissel naar maandzicht";
            this.toolTip1.SetToolTip(this.button5, "Klik hier om de gegevens per maand te bekijken (6 maanden per periode)");
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 30);
            this.button4.TabIndex = 78;
            this.button4.Text = "1/1/2011 t/m 30/6/2011";
            this.toolTip1.SetToolTip(this.button4, "Klik om naar een overzicht van periode 1 te gaan");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 30);
            this.button9.TabIndex = 83;
            this.button9.Text = "Jaaroverzicht";
            this.toolTip1.SetToolTip(this.button9, "Klik om terug te gaan naar jaaroverzicht");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
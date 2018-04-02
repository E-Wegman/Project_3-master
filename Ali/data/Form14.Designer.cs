namespace data
{
    partial class Form14
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGraphiek = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(361, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(255, 30);
            this.button6.TabIndex = 58;
            this.button6.Text = "Huizenprijzen boven de 400.000 euro";
            this.toolTip1.SetToolTip(this.button6, "Klik om alleen huizenprijzen boven de 400.000 euro te tonen");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(285, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 30);
            this.button5.TabIndex = 57;
            this.button5.Text = "Totaal";
            this.toolTip1.SetToolTip(this.button5, "Klik om terug te gaan naar de totaal overzicht");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 30);
            this.button4.TabIndex = 56;
            this.button4.Text = "Huizenprijzen onder de 200.000 euro";
            this.toolTip1.SetToolTip(this.button4, "Klik om alleen huizenprijzen onder de 200.000 euro te tonen");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGraphiek
            // 
            this.btnGraphiek.Location = new System.Drawing.Point(130, 106);
            this.btnGraphiek.Name = "btnGraphiek";
            this.btnGraphiek.Size = new System.Drawing.Size(111, 30);
            this.btnGraphiek.TabIndex = 55;
            this.btnGraphiek.Text = "Grafiek";
            this.toolTip1.SetToolTip(this.btnGraphiek, "Klik om de staafdiagram om te zetten in een grafiek");
            this.btnGraphiek.UseVisualStyleBackColor = true;
            this.btnGraphiek.Click += new System.EventHandler(this.btnGraphiek_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(14, 106);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(110, 30);
            this.btnZoom.TabIndex = 54;
            this.btnZoom.Text = "Zoom uit";
            this.toolTip1.SetToolTip(this.btnZoom, "Na het inzoomen, klik om uit te zoomen");
            this.btnZoom.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 40);
            this.button3.TabIndex = 47;
            this.button3.Text = "Weersomstandigheden";
            this.toolTip1.SetToolTip(this.button3, "Navigeer naar weersomstandigheden deelvraag");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 46;
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
            this.button1.TabIndex = 45;
            this.button1.Text = "Huizenprijzen";
            this.toolTip1.SetToolTip(this.button1, "Navigeer naar huizenprijzen deelvraag");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(13, 178);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1759, 563);
            this.cartesianChart1.TabIndex = 44;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnGraphiek);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGraphiek;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
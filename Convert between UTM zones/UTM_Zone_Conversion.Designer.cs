namespace Convert_between_UTM_zones
{
    partial class UTM_Zone_Conversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UTM_Zone_Conversion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindCoords = new System.Windows.Forms.Button();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUTMZone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUTMY = new System.Windows.Forms.TextBox();
            this.txtUTMX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_North_or_South = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Lat/Long to UTM Coordinates";
            // 
            // btnFindCoords
            // 
            this.btnFindCoords.Location = new System.Drawing.Point(271, 110);
            this.btnFindCoords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindCoords.Name = "btnFindCoords";
            this.btnFindCoords.Size = new System.Drawing.Size(109, 53);
            this.btnFindCoords.TabIndex = 1;
            this.btnFindCoords.Text = "Find UTM Coordinates";
            this.btnFindCoords.UseVisualStyleBackColor = true;
            this.btnFindCoords.Click += new System.EventHandler(this.btnFindCoords_Click);
            // 
            // txtLat
            // 
            this.txtLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(166, 99);
            this.txtLat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(81, 24);
            this.txtLat.TabIndex = 2;
            // 
            // txtLong
            // 
            this.txtLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLong.Location = new System.Drawing.Point(166, 133);
            this.txtLong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(81, 24);
            this.txtLong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Latitude (decimals) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longitude (decimals) :";
            // 
            // txtUTMZone
            // 
            this.txtUTMZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTMZone.Location = new System.Drawing.Point(166, 175);
            this.txtUTMZone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUTMZone.Name = "txtUTMZone";
            this.txtUTMZone.Size = new System.Drawing.Size(68, 24);
            this.txtUTMZone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "UTM Zone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "UTM Y :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "UTM X :";
            // 
            // txtUTMY
            // 
            this.txtUTMY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTMY.Location = new System.Drawing.Point(89, 249);
            this.txtUTMY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUTMY.Name = "txtUTMY";
            this.txtUTMY.ReadOnly = true;
            this.txtUTMY.Size = new System.Drawing.Size(105, 24);
            this.txtUTMY.TabIndex = 10;
            // 
            // txtUTMX
            // 
            this.txtUTMX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTMX.Location = new System.Drawing.Point(87, 216);
            this.txtUTMX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUTMX.Name = "txtUTMX";
            this.txtUTMX.ReadOnly = true;
            this.txtUTMX.Size = new System.Drawing.Size(106, 24);
            this.txtUTMX.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hemisphere :";
            // 
            // cbo_North_or_South
            // 
            this.cbo_North_or_South.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_North_or_South.FormattingEnabled = true;
            this.cbo_North_or_South.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbo_North_or_South.Location = new System.Drawing.Point(116, 289);
            this.cbo_North_or_South.Name = "cbo_North_or_South";
            this.cbo_North_or_South.Size = new System.Drawing.Size(78, 24);
            this.cbo_North_or_South.TabIndex = 14;
            // 
            // UTM_Zone_Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 345);
            this.Controls.Add(this.cbo_North_or_South);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUTMY);
            this.Controls.Add(this.txtUTMX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUTMZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.btnFindCoords);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UTM_Zone_Conversion";
            this.Text = "Converting between UTM zones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindCoords;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUTMZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUTMY;
        private System.Windows.Forms.TextBox txtUTMX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_North_or_South;
    }
}


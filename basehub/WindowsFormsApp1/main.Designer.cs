
namespace basehub
{
    partial class main
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
            this.pictureBox_Map = new System.Windows.Forms.PictureBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.TextBox_Location = new System.Windows.Forms.TextBox();
            this.groupBox_MapData = new System.Windows.Forms.GroupBox();
            this.groupBox_MapControls = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Telemetry = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).BeginInit();
            this.groupBox_MapData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Map
            // 
            this.pictureBox_Map.Location = new System.Drawing.Point(6, 22);
            this.pictureBox_Map.Name = "pictureBox_Map";
            this.pictureBox_Map.Size = new System.Drawing.Size(1128, 832);
            this.pictureBox_Map.TabIndex = 0;
            this.pictureBox_Map.TabStop = false;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(387, 22);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 29);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "Suchen";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // TextBox_Location
            // 
            this.TextBox_Location.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Location.Location = new System.Drawing.Point(6, 22);
            this.TextBox_Location.Name = "TextBox_Location";
            this.TextBox_Location.Size = new System.Drawing.Size(375, 29);
            this.TextBox_Location.TabIndex = 2;
            // 
            // groupBox_MapData
            // 
            this.groupBox_MapData.Controls.Add(this.Button_Search);
            this.groupBox_MapData.Controls.Add(this.TextBox_Location);
            this.groupBox_MapData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_MapData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_MapData.Location = new System.Drawing.Point(12, 878);
            this.groupBox_MapData.Name = "groupBox_MapData";
            this.groupBox_MapData.Size = new System.Drawing.Size(1140, 151);
            this.groupBox_MapData.TabIndex = 4;
            this.groupBox_MapData.TabStop = false;
            this.groupBox_MapData.Text = "Map Data Controls";
            // 
            // groupBox_MapControls
            // 
            this.groupBox_MapControls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_MapControls.Location = new System.Drawing.Point(1158, 12);
            this.groupBox_MapControls.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox_MapControls.Name = "groupBox_MapControls";
            this.groupBox_MapControls.Size = new System.Drawing.Size(94, 535);
            this.groupBox_MapControls.TabIndex = 5;
            this.groupBox_MapControls.TabStop = false;
            this.groupBox_MapControls.Text = "Map Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox_Map);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 860);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // groupBox_Telemetry
            // 
            this.groupBox_Telemetry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Telemetry.Location = new System.Drawing.Point(1258, 12);
            this.groupBox_Telemetry.Name = "groupBox_Telemetry";
            this.groupBox_Telemetry.Size = new System.Drawing.Size(634, 535);
            this.groupBox_Telemetry.TabIndex = 7;
            this.groupBox_Telemetry.TabStop = false;
            this.groupBox_Telemetry.Text = "UAS Telemetry";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(1159, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 476);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UAS Camera Feed";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_Telemetry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_MapControls);
            this.Controls.Add(this.groupBox_MapData);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "main";
            this.Text = "BaseHub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).EndInit();
            this.groupBox_MapData.ResumeLayout(false);
            this.groupBox_MapData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Map;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.TextBox TextBox_Location;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.GroupBox groupBox_MapData;
        private System.Windows.Forms.GroupBox groupBox_MapControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Telemetry;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}



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
            this.pictureBox_map = new System.Windows.Forms.PictureBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.groupBox_MapData = new System.Windows.Forms.GroupBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_mapType = new System.Windows.Forms.ComboBox();
            this.groupBox_MapControls = new System.Windows.Forms.GroupBox();
            this.numericUpDown_mapSize = new System.Windows.Forms.NumericUpDown();
            this.trackBar_mapZoom = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Telemetry = new System.Windows.Forms.GroupBox();
            this.comboBox_selectDorne = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_longitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_heading = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_velocity = new System.Windows.Forms.TextBox();
            this.textBox_battery = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).BeginInit();
            this.groupBox_MapData.SuspendLayout();
            this.groupBox_MapControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mapSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mapZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Telemetry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_map
            // 
            this.pictureBox_map.Location = new System.Drawing.Point(6, 15);
            this.pictureBox_map.Name = "pictureBox_map";
            this.pictureBox_map.Size = new System.Drawing.Size(1128, 909);
            this.pictureBox_map.TabIndex = 0;
            this.pictureBox_map.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.Enabled = false;
            this.button_search.Location = new System.Drawing.Point(514, 36);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(81, 33);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Search Map";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // textBox_location
            // 
            this.textBox_location.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_location.Location = new System.Drawing.Point(6, 37);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(375, 31);
            this.textBox_location.TabIndex = 2;
            this.textBox_location.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_location_KeyPress);
            // 
            // groupBox_MapData
            // 
            this.groupBox_MapData.Controls.Add(this.button_load);
            this.groupBox_MapData.Controls.Add(this.button_save);
            this.groupBox_MapData.Controls.Add(this.label2);
            this.groupBox_MapData.Controls.Add(this.label1);
            this.groupBox_MapData.Controls.Add(this.comboBox_mapType);
            this.groupBox_MapData.Controls.Add(this.button_search);
            this.groupBox_MapData.Controls.Add(this.textBox_location);
            this.groupBox_MapData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_MapData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_MapData.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox_MapData.Location = new System.Drawing.Point(12, 948);
            this.groupBox_MapData.Name = "groupBox_MapData";
            this.groupBox_MapData.Size = new System.Drawing.Size(1140, 81);
            this.groupBox_MapData.TabIndex = 4;
            this.groupBox_MapData.TabStop = false;
            this.groupBox_MapData.Text = "Map Data Controls";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(863, 37);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(81, 31);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(776, 37);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(81, 31);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loaction";
            // 
            // comboBox_mapType
            // 
            this.comboBox_mapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mapType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_mapType.FormattingEnabled = true;
            this.comboBox_mapType.ItemHeight = 23;
            this.comboBox_mapType.Items.AddRange(new object[] {
            "roadmap",
            "satellite",
            "terrain",
            "hybrid"});
            this.comboBox_mapType.Location = new System.Drawing.Point(387, 37);
            this.comboBox_mapType.Name = "comboBox_mapType";
            this.comboBox_mapType.Size = new System.Drawing.Size(121, 31);
            this.comboBox_mapType.TabIndex = 0;
            this.comboBox_mapType.SelectedIndexChanged += new System.EventHandler(this.comboBox_MapType_SelectedIndexChanged);
            // 
            // groupBox_MapControls
            // 
            this.groupBox_MapControls.Controls.Add(this.numericUpDown_mapSize);
            this.groupBox_MapControls.Controls.Add(this.trackBar_mapZoom);
            this.groupBox_MapControls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_MapControls.Location = new System.Drawing.Point(1158, 12);
            this.groupBox_MapControls.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox_MapControls.Name = "groupBox_MapControls";
            this.groupBox_MapControls.Size = new System.Drawing.Size(94, 535);
            this.groupBox_MapControls.TabIndex = 5;
            this.groupBox_MapControls.TabStop = false;
            this.groupBox_MapControls.Text = "Map Controls";
            // 
            // numericUpDown_mapSize
            // 
            this.numericUpDown_mapSize.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_mapSize.Location = new System.Drawing.Point(25, 498);
            this.numericUpDown_mapSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_mapSize.Name = "numericUpDown_mapSize";
            this.numericUpDown_mapSize.Size = new System.Drawing.Size(45, 31);
            this.numericUpDown_mapSize.TabIndex = 2;
            this.numericUpDown_mapSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_mapSize.ValueChanged += new System.EventHandler(this.numericUpDown_MapSize_ValueChanged);
            // 
            // trackBar_mapZoom
            // 
            this.trackBar_mapZoom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar_mapZoom.LargeChange = 3;
            this.trackBar_mapZoom.Location = new System.Drawing.Point(25, 22);
            this.trackBar_mapZoom.Maximum = 20;
            this.trackBar_mapZoom.Name = "trackBar_mapZoom";
            this.trackBar_mapZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_mapZoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_mapZoom.Size = new System.Drawing.Size(45, 470);
            this.trackBar_mapZoom.TabIndex = 1;
            this.trackBar_mapZoom.Value = 15;
            this.trackBar_mapZoom.ValueChanged += new System.EventHandler(this.trackBar_MapZoom_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox_map);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1140, 930);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // groupBox_Telemetry
            // 
            this.groupBox_Telemetry.Controls.Add(this.label10);
            this.groupBox_Telemetry.Controls.Add(this.label9);
            this.groupBox_Telemetry.Controls.Add(this.textBox_battery);
            this.groupBox_Telemetry.Controls.Add(this.textBox_velocity);
            this.groupBox_Telemetry.Controls.Add(this.label8);
            this.groupBox_Telemetry.Controls.Add(this.textBox_heading);
            this.groupBox_Telemetry.Controls.Add(this.label7);
            this.groupBox_Telemetry.Controls.Add(this.textBox_distance);
            this.groupBox_Telemetry.Controls.Add(this.label6);
            this.groupBox_Telemetry.Controls.Add(this.textBox_height);
            this.groupBox_Telemetry.Controls.Add(this.label5);
            this.groupBox_Telemetry.Controls.Add(this.textBox_longitude);
            this.groupBox_Telemetry.Controls.Add(this.label4);
            this.groupBox_Telemetry.Controls.Add(this.label3);
            this.groupBox_Telemetry.Controls.Add(this.textBox_latitude);
            this.groupBox_Telemetry.Controls.Add(this.comboBox_selectDorne);
            this.groupBox_Telemetry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Telemetry.Location = new System.Drawing.Point(1258, 12);
            this.groupBox_Telemetry.Name = "groupBox_Telemetry";
            this.groupBox_Telemetry.Size = new System.Drawing.Size(634, 535);
            this.groupBox_Telemetry.TabIndex = 7;
            this.groupBox_Telemetry.TabStop = false;
            this.groupBox_Telemetry.Text = "Telemetry";
            // 
            // comboBox_selectDorne
            // 
            this.comboBox_selectDorne.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_selectDorne.FormattingEnabled = true;
            this.comboBox_selectDorne.Location = new System.Drawing.Point(6, 50);
            this.comboBox_selectDorne.Name = "comboBox_selectDorne";
            this.comboBox_selectDorne.Size = new System.Drawing.Size(198, 31);
            this.comboBox_selectDorne.TabIndex = 1;
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
            // textBox_latitude
            // 
            this.textBox_latitude.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_latitude.Location = new System.Drawing.Point(6, 112);
            this.textBox_latitude.Name = "textBox_latitude";
            this.textBox_latitude.Size = new System.Drawing.Size(326, 33);
            this.textBox_latitude.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Longitude";
            // 
            // textBox_longitude
            // 
            this.textBox_longitude.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_longitude.Location = new System.Drawing.Point(6, 176);
            this.textBox_longitude.Name = "textBox_longitude";
            this.textBox_longitude.Size = new System.Drawing.Size(326, 33);
            this.textBox_longitude.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height";
            // 
            // textBox_height
            // 
            this.textBox_height.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_height.Location = new System.Drawing.Point(6, 240);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(326, 33);
            this.textBox_height.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distance";
            // 
            // textBox_distance
            // 
            this.textBox_distance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_distance.Location = new System.Drawing.Point(6, 304);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(326, 33);
            this.textBox_distance.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Heading";
            // 
            // textBox_heading
            // 
            this.textBox_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_heading.Location = new System.Drawing.Point(5, 368);
            this.textBox_heading.Name = "textBox_heading";
            this.textBox_heading.Size = new System.Drawing.Size(326, 33);
            this.textBox_heading.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Velocity";
            // 
            // textBox_velocity
            // 
            this.textBox_velocity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_velocity.Location = new System.Drawing.Point(5, 432);
            this.textBox_velocity.Name = "textBox_velocity";
            this.textBox_velocity.Size = new System.Drawing.Size(326, 33);
            this.textBox_velocity.TabIndex = 13;
            // 
            // textBox_battery
            // 
            this.textBox_battery.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_battery.Location = new System.Drawing.Point(5, 497);
            this.textBox_battery.Name = "textBox_battery";
            this.textBox_battery.Size = new System.Drawing.Size(326, 33);
            this.textBox_battery.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Battery";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Dronename";
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
            this.Shown += new System.EventHandler(this.main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_map)).EndInit();
            this.groupBox_MapData.ResumeLayout(false);
            this.groupBox_MapData.PerformLayout();
            this.groupBox_MapControls.ResumeLayout(false);
            this.groupBox_MapControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mapSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mapZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Telemetry.ResumeLayout(false);
            this.groupBox_Telemetry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_map;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.GroupBox groupBox_MapData;
        private System.Windows.Forms.GroupBox groupBox_MapControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Telemetry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar_mapZoom;
        private System.Windows.Forms.NumericUpDown numericUpDown_mapSize;
        private System.Windows.Forms.ComboBox comboBox_mapType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.ComboBox comboBox_selectDorne;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_longitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_battery;
        private System.Windows.Forms.TextBox textBox_velocity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_heading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_distance;
    }
}


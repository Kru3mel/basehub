
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_MapType = new System.Windows.Forms.ComboBox();
            this.groupBox_MapControls = new System.Windows.Forms.GroupBox();
            this.numericUpDown_MapSize = new System.Windows.Forms.NumericUpDown();
            this.trackBar_MapZoom = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Telemetry = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).BeginInit();
            this.groupBox_MapData.SuspendLayout();
            this.groupBox_MapControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MapSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MapZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Telemetry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Map
            // 
            this.pictureBox_Map.Location = new System.Drawing.Point(6, 15);
            this.pictureBox_Map.Name = "pictureBox_Map";
            this.pictureBox_Map.Size = new System.Drawing.Size(1128, 909);
            this.pictureBox_Map.TabIndex = 0;
            this.pictureBox_Map.TabStop = false;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(514, 37);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(81, 31);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "Search Map";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // TextBox_Location
            // 
            this.TextBox_Location.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Location.Location = new System.Drawing.Point(6, 37);
            this.TextBox_Location.Multiline = true;
            this.TextBox_Location.Name = "TextBox_Location";
            this.TextBox_Location.Size = new System.Drawing.Size(375, 31);
            this.TextBox_Location.TabIndex = 2;
            // 
            // groupBox_MapData
            // 
            this.groupBox_MapData.Controls.Add(this.label2);
            this.groupBox_MapData.Controls.Add(this.label1);
            this.groupBox_MapData.Controls.Add(this.comboBox_MapType);
            this.groupBox_MapData.Controls.Add(this.Button_Search);
            this.groupBox_MapData.Controls.Add(this.TextBox_Location);
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
            // comboBox_MapType
            // 
            this.comboBox_MapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MapType.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_MapType.FormattingEnabled = true;
            this.comboBox_MapType.ItemHeight = 23;
            this.comboBox_MapType.Items.AddRange(new object[] {
            "roadmap",
            "satelllite",
            "terrain",
            "hybrid"});
            this.comboBox_MapType.Location = new System.Drawing.Point(387, 37);
            this.comboBox_MapType.Name = "comboBox_MapType";
            this.comboBox_MapType.Size = new System.Drawing.Size(121, 31);
            this.comboBox_MapType.TabIndex = 0;
            // 
            // groupBox_MapControls
            // 
            this.groupBox_MapControls.Controls.Add(this.numericUpDown_MapSize);
            this.groupBox_MapControls.Controls.Add(this.trackBar_MapZoom);
            this.groupBox_MapControls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_MapControls.Location = new System.Drawing.Point(1158, 12);
            this.groupBox_MapControls.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox_MapControls.Name = "groupBox_MapControls";
            this.groupBox_MapControls.Size = new System.Drawing.Size(94, 535);
            this.groupBox_MapControls.TabIndex = 5;
            this.groupBox_MapControls.TabStop = false;
            this.groupBox_MapControls.Text = "Map Controls";
            // 
            // numericUpDown_MapSize
            // 
            this.numericUpDown_MapSize.Location = new System.Drawing.Point(25, 506);
            this.numericUpDown_MapSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_MapSize.Name = "numericUpDown_MapSize";
            this.numericUpDown_MapSize.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown_MapSize.TabIndex = 2;
            this.numericUpDown_MapSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_MapSize.ValueChanged += new System.EventHandler(this.numericUpDown_MapSize_ValueChanged);
            // 
            // trackBar_MapZoom
            // 
            this.trackBar_MapZoom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar_MapZoom.LargeChange = 3;
            this.trackBar_MapZoom.Location = new System.Drawing.Point(25, 22);
            this.trackBar_MapZoom.Maximum = 20;
            this.trackBar_MapZoom.Name = "trackBar_MapZoom";
            this.trackBar_MapZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_MapZoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_MapZoom.Size = new System.Drawing.Size(45, 478);
            this.trackBar_MapZoom.TabIndex = 1;
            this.trackBar_MapZoom.Value = 15;
            this.trackBar_MapZoom.ValueChanged += new System.EventHandler(this.trackBar_MapZoom_ValueChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(1140, 930);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // groupBox_Telemetry
            // 
            this.groupBox_Telemetry.Controls.Add(this.dataGridView1);
            this.groupBox_Telemetry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Telemetry.Location = new System.Drawing.Point(1258, 12);
            this.groupBox_Telemetry.Name = "groupBox_Telemetry";
            this.groupBox_Telemetry.Size = new System.Drawing.Size(634, 535);
            this.groupBox_Telemetry.TabIndex = 7;
            this.groupBox_Telemetry.TabStop = false;
            this.groupBox_Telemetry.Text = "UAS Telemetry";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(622, 462);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBox_MapControls.ResumeLayout(false);
            this.groupBox_MapControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MapSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_MapZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Telemetry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar_MapZoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown_MapSize;
        private System.Windows.Forms.ComboBox comboBox_MapType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


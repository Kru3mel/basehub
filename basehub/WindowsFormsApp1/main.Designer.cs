
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox_Map = new System.Windows.Forms.PictureBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.TextBox_Location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Map
            // 
            this.pictureBox_Map.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Map.Image")));
            this.pictureBox_Map.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Map.Name = "pictureBox_Map";
            this.pictureBox_Map.Size = new System.Drawing.Size(640, 640);
            this.pictureBox_Map.TabIndex = 0;
            this.pictureBox_Map.TabStop = false;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(357, 658);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 23);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "Suchen";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // TextBox_Location
            // 
            this.TextBox_Location.Location = new System.Drawing.Point(12, 658);
            this.TextBox_Location.Name = "TextBox_Location";
            this.TextBox_Location.Size = new System.Drawing.Size(339, 23);
            this.TextBox_Location.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.TextBox_Location);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.pictureBox_Map);
            this.Name = "main";
            this.Text = "Hub";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Map;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.TextBox TextBox_Location;
    }
}


namespace Rosell_Flag
{
    partial class Form1
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
            this.FlagViewerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleCheckbox = new System.Windows.Forms.CheckBox();
            this.CountryNameCheckbox = new System.Windows.Forms.CheckBox();
            this.ProgrammerCheckbox = new System.Windows.Forms.CheckBox();
            this.CountryImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.ColumbiaRadioButton = new System.Windows.Forms.RadioButton();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.FranceRadioButton = new System.Windows.Forms.RadioButton();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlagViewerLabel
            // 
            this.FlagViewerLabel.AutoSize = true;
            this.FlagViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagViewerLabel.Location = new System.Drawing.Point(415, 81);
            this.FlagViewerLabel.Name = "FlagViewerLabel";
            this.FlagViewerLabel.Size = new System.Drawing.Size(210, 39);
            this.FlagViewerLabel.TabIndex = 0;
            this.FlagViewerLabel.Text = "Flag Viewer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProgrammerCheckbox);
            this.groupBox1.Controls.Add(this.CountryNameCheckbox);
            this.groupBox1.Controls.Add(this.TitleCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(805, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // TitleCheckbox
            // 
            this.TitleCheckbox.AutoSize = true;
            this.TitleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCheckbox.Location = new System.Drawing.Point(29, 60);
            this.TitleCheckbox.Name = "TitleCheckbox";
            this.TitleCheckbox.Size = new System.Drawing.Size(72, 29);
            this.TitleCheckbox.TabIndex = 0;
            this.TitleCheckbox.Text = "Title";
            this.TitleCheckbox.UseVisualStyleBackColor = true;
            this.TitleCheckbox.CheckedChanged += new System.EventHandler(this.TitleCheckbox_CheckedChanged);
            // 
            // CountryNameCheckbox
            // 
            this.CountryNameCheckbox.AutoSize = true;
            this.CountryNameCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameCheckbox.Location = new System.Drawing.Point(29, 113);
            this.CountryNameCheckbox.Name = "CountryNameCheckbox";
            this.CountryNameCheckbox.Size = new System.Drawing.Size(168, 29);
            this.CountryNameCheckbox.TabIndex = 0;
            this.CountryNameCheckbox.Text = "Country Name";
            this.CountryNameCheckbox.UseVisualStyleBackColor = true;
            this.CountryNameCheckbox.CheckedChanged += new System.EventHandler(this.CountryNameCheckbox_CheckedChanged);
            // 
            // ProgrammerCheckbox
            // 
            this.ProgrammerCheckbox.AutoSize = true;
            this.ProgrammerCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerCheckbox.Location = new System.Drawing.Point(29, 166);
            this.ProgrammerCheckbox.Name = "ProgrammerCheckbox";
            this.ProgrammerCheckbox.Size = new System.Drawing.Size(148, 29);
            this.ProgrammerCheckbox.TabIndex = 0;
            this.ProgrammerCheckbox.Text = "Programmer";
            this.ProgrammerCheckbox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckbox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckbox_CheckedChanged);
            // 
            // CountryImage
            // 
            this.CountryImage.Location = new System.Drawing.Point(352, 157);
            this.CountryImage.Name = "CountryImage";
            this.CountryImage.Size = new System.Drawing.Size(350, 194);
            this.CountryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountryImage.TabIndex = 3;
            this.CountryImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FranceRadioButton);
            this.groupBox2.Controls.Add(this.USARadioButton);
            this.groupBox2.Controls.Add(this.ColumbiaRadioButton);
            this.groupBox2.Controls.Add(this.PhilippinesRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 273);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country";
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(38, 60);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(135, 29);
            this.PhilippinesRadioButton.TabIndex = 0;
            this.PhilippinesRadioButton.TabStop = true;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.PhilippinesRadioButton_CheckedChanged);
            // 
            // ColumbiaRadioButton
            // 
            this.ColumbiaRadioButton.AutoSize = true;
            this.ColumbiaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumbiaRadioButton.Location = new System.Drawing.Point(38, 113);
            this.ColumbiaRadioButton.Name = "ColumbiaRadioButton";
            this.ColumbiaRadioButton.Size = new System.Drawing.Size(120, 29);
            this.ColumbiaRadioButton.TabIndex = 1;
            this.ColumbiaRadioButton.TabStop = true;
            this.ColumbiaRadioButton.Text = "Columbia";
            this.ColumbiaRadioButton.UseVisualStyleBackColor = true;
            this.ColumbiaRadioButton.CheckedChanged += new System.EventHandler(this.ColumbiaRadioButton_CheckedChanged);
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USARadioButton.Location = new System.Drawing.Point(38, 169);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(73, 29);
            this.USARadioButton.TabIndex = 2;
            this.USARadioButton.TabStop = true;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.USARadioButton_CheckedChanged);
            // 
            // FranceRadioButton
            // 
            this.FranceRadioButton.AutoSize = true;
            this.FranceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranceRadioButton.Location = new System.Drawing.Point(38, 214);
            this.FranceRadioButton.Name = "FranceRadioButton";
            this.FranceRadioButton.Size = new System.Drawing.Size(97, 29);
            this.FranceRadioButton.TabIndex = 3;
            this.FranceRadioButton.TabStop = true;
            this.FranceRadioButton.Text = "France";
            this.FranceRadioButton.UseVisualStyleBackColor = true;
            this.FranceRadioButton.CheckedChanged += new System.EventHandler(this.FranceRadioButton_CheckedChanged);
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameLabel.Location = new System.Drawing.Point(473, 384);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 37);
            this.CountryNameLabel.TabIndex = 5;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(37, 476);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(158, 29);
            this.ProgrammerLabel.TabIndex = 6;
            this.ProgrammerLabel.Text = "Programmer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 613);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CountryImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FlagViewerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlagViewerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ProgrammerCheckbox;
        private System.Windows.Forms.CheckBox CountryNameCheckbox;
        private System.Windows.Forms.CheckBox TitleCheckbox;
        private System.Windows.Forms.PictureBox CountryImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FranceRadioButton;
        private System.Windows.Forms.RadioButton USARadioButton;
        private System.Windows.Forms.RadioButton ColumbiaRadioButton;
        private System.Windows.Forms.RadioButton PhilippinesRadioButton;
        private System.Windows.Forms.Label CountryNameLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
    }
}



namespace Praktikum_Offlen_1
{
    partial class formPraktikum
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelHasilOutput = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(13, 13);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(52, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data : ";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(12, 48);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(63, 20);
            this.labelKoleksi.TabIndex = 1;
            this.labelKoleksi.Text = "Koleksi :";
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(381, 99);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(118, 24);
            this.radioButtonMerah.TabIndex = 3;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(381, 129);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(102, 24);
            this.radioButtonBiru.TabIndex = 4;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(694, 13);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(454, 74);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.checkBoxAktif.TabIndex = 6;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(381, 75);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(67, 20);
            this.labelSetting.TabIndex = 7;
            this.labelSetting.Text = "Setting : ";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(72, 13);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(616, 27);
            this.textBoxData.TabIndex = 8;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(381, 231);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(66, 20);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output : ";
            // 
            // labelHasilOutput
            // 
            this.labelHasilOutput.AutoSize = true;
            this.labelHasilOutput.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHasilOutput.Location = new System.Drawing.Point(519, 283);
            this.labelHasilOutput.Name = "labelHasilOutput";
            this.labelHasilOutput.Size = new System.Drawing.Size(74, 81);
            this.labelHasilOutput.TabIndex = 10;
            this.labelHasilOutput.Text = "...";
            this.labelHasilOutput.Click += new System.EventHandler(this.labelHasilOutput_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(353, 405);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(435, 29);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 20;
            this.listBoxKoleksi.Location = new System.Drawing.Point(12, 75);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(335, 364);
            this.listBoxKoleksi.TabIndex = 12;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // formPraktikum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelHasilOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelData);
            this.Name = "formPraktikum";
            this.Text = "Form Praktikum Oflen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelHasilOutput;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxKoleksi;
    }
}


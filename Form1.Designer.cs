namespace Licznik_Bilansu
{
    partial class kalkulatorBilansuPlynow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kalkulatorBilansuPlynow));
            szybkoscKroplowki = new NumericUpDown();
            labelSzybkoscKroplowki = new Label();
            labelPlyny2 = new Label();
            plyny1 = new NumericUpDown();
            oblicz = new Button();
            labelWynik = new Label();
            margines = new CheckBox();
            labelPlyny1 = new Label();
            plyny4 = new NumericUpDown();
            wymioty = new NumericUpDown();
            labelWymioty = new Label();
            typBilansu = new ComboBox();
            labelBilans = new Label();
            plyny2 = new NumericUpDown();
            plyny3 = new NumericUpDown();
            copyright = new Label();
            ((System.ComponentModel.ISupportInitialize)szybkoscKroplowki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plyny1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plyny4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wymioty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plyny2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plyny3).BeginInit();
            SuspendLayout();
            // 
            // szybkoscKroplowki
            // 
            szybkoscKroplowki.Font = new Font("Segoe UI", 12F);
            szybkoscKroplowki.Location = new Point(12, 143);
            szybkoscKroplowki.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            szybkoscKroplowki.Name = "szybkoscKroplowki";
            szybkoscKroplowki.Size = new Size(210, 45);
            szybkoscKroplowki.TabIndex = 0;
            // 
            // labelSzybkoscKroplowki
            // 
            labelSzybkoscKroplowki.AutoSize = true;
            labelSzybkoscKroplowki.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSzybkoscKroplowki.Location = new Point(9, 100);
            labelSzybkoscKroplowki.Margin = new Padding(0);
            labelSzybkoscKroplowki.Name = "labelSzybkoscKroplowki";
            labelSzybkoscKroplowki.Size = new Size(654, 40);
            labelSzybkoscKroplowki.TabIndex = 1;
            labelSzybkoscKroplowki.Text = "Szybkość podawania kroplówki (ml/h)";
            // 
            // labelPlyny2
            // 
            labelPlyny2.AutoSize = true;
            labelPlyny2.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPlyny2.Location = new Point(9, 300);
            labelPlyny2.Margin = new Padding(0);
            labelPlyny2.Name = "labelPlyny2";
            labelPlyny2.Size = new Size(466, 40);
            labelPlyny2.TabIndex = 3;
            labelPlyny2.Text = "Ilość wypitych płynów (ml)";
            labelPlyny2.Click += label2_Click;
            // 
            // plyny1
            // 
            plyny1.Font = new Font("Segoe UI", 12F);
            plyny1.Location = new Point(12, 243);
            plyny1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            plyny1.Name = "plyny1";
            plyny1.Size = new Size(210, 45);
            plyny1.TabIndex = 2;
            plyny1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // oblicz
            // 
            oblicz.AutoSize = true;
            oblicz.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            oblicz.Location = new Point(12, 562);
            oblicz.Name = "oblicz";
            oblicz.Size = new Size(131, 50);
            oblicz.TabIndex = 4;
            oblicz.Text = "Oblicz";
            oblicz.UseVisualStyleBackColor = true;
            oblicz.Click += oblicz_Click;
            // 
            // labelWynik
            // 
            labelWynik.AutoSize = true;
            labelWynik.Font = new Font("Verdana", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWynik.Location = new Point(9, 652);
            labelWynik.Name = "labelWynik";
            labelWynik.Size = new Size(845, 40);
            labelWynik.TabIndex = 5;
            labelWynik.Text = "Podaj dane i wćiśnij oblicz aby poznać wynik";
            // 
            // margines
            // 
            margines.AutoSize = true;
            margines.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            margines.Location = new Point(12, 512);
            margines.Name = "margines";
            margines.Size = new Size(455, 44);
            margines.TabIndex = 6;
            margines.Text = "Margines błędu (200 ml)";
            margines.UseVisualStyleBackColor = true;
            // 
            // labelPlyny1
            // 
            labelPlyny1.AutoSize = true;
            labelPlyny1.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPlyny1.Location = new Point(9, 200);
            labelPlyny1.Margin = new Padding(0);
            labelPlyny1.Name = "labelPlyny1";
            labelPlyny1.Size = new Size(356, 40);
            labelPlyny1.TabIndex = 8;
            labelPlyny1.Text = "Dodatkowe leki (ml)";
            // 
            // plyny4
            // 
            plyny4.Font = new Font("Segoe UI", 12F);
            plyny4.Location = new Point(12, 343);
            plyny4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            plyny4.Name = "plyny4";
            plyny4.Size = new Size(210, 45);
            plyny4.TabIndex = 7;
            // 
            // wymioty
            // 
            wymioty.Font = new Font("Segoe UI", 12F);
            wymioty.Location = new Point(12, 443);
            wymioty.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            wymioty.Name = "wymioty";
            wymioty.Size = new Size(210, 45);
            wymioty.TabIndex = 10;
            wymioty.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // labelWymioty
            // 
            labelWymioty.AutoSize = true;
            labelWymioty.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWymioty.Location = new Point(9, 400);
            labelWymioty.Margin = new Padding(0);
            labelWymioty.Name = "labelWymioty";
            labelWymioty.Size = new Size(246, 40);
            labelWymioty.TabIndex = 9;
            labelWymioty.Text = "Wymioty (ml)";
            // 
            // typBilansu
            // 
            typBilansu.DropDownStyle = ComboBoxStyle.DropDownList;
            typBilansu.Font = new Font("Verdana", 12F);
            typBilansu.FormattingEnabled = true;
            typBilansu.Items.AddRange(new object[] { "Bilans 6h", "Bilans 12h", "Bilans 24h" });
            typBilansu.Location = new Point(12, 52);
            typBilansu.Name = "typBilansu";
            typBilansu.Size = new Size(250, 42);
            typBilansu.TabIndex = 11;
            typBilansu.SelectedIndexChanged += bilans_SelectedIndexChanged;
            // 
            // labelBilans
            // 
            labelBilans.AutoSize = true;
            labelBilans.Font = new Font("Verdana", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelBilans.Location = new Point(9, 9);
            labelBilans.Margin = new Padding(0);
            labelBilans.Name = "labelBilans";
            labelBilans.Size = new Size(205, 40);
            labelBilans.TabIndex = 12;
            labelBilans.Text = "Typ bilansu";
            // 
            // plyny2
            // 
            plyny2.Font = new Font("Segoe UI", 12F);
            plyny2.Location = new Point(228, 243);
            plyny2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            plyny2.Name = "plyny2";
            plyny2.Size = new Size(210, 45);
            plyny2.TabIndex = 13;
            // 
            // plyny3
            // 
            plyny3.Font = new Font("Segoe UI", 12F);
            plyny3.Location = new Point(444, 243);
            plyny3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            plyny3.Name = "plyny3";
            plyny3.Size = new Size(210, 45);
            plyny3.TabIndex = 14;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Dock = DockStyle.Bottom;
            copyright.Font = new Font("Verdana", 8.142858F, FontStyle.Italic, GraphicsUnit.Point, 238);
            copyright.Location = new Point(0, 701);
            copyright.Name = "copyright";
            copyright.Padding = new Padding(5);
            copyright.Size = new Size(291, 35);
            copyright.TabIndex = 15;
            copyright.Text = "©2025 Grzegorz Kurowski";
            // 
            // kalkulatorBilansuPlynow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 736);
            Controls.Add(copyright);
            Controls.Add(plyny3);
            Controls.Add(plyny2);
            Controls.Add(labelBilans);
            Controls.Add(typBilansu);
            Controls.Add(wymioty);
            Controls.Add(labelWymioty);
            Controls.Add(labelPlyny1);
            Controls.Add(plyny4);
            Controls.Add(margines);
            Controls.Add(labelWynik);
            Controls.Add(oblicz);
            Controls.Add(labelPlyny2);
            Controls.Add(plyny1);
            Controls.Add(labelSzybkoscKroplowki);
            Controls.Add(szybkoscKroplowki);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "kalkulatorBilansuPlynow";
            Text = "Kalkulator bilansu płynów";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)szybkoscKroplowki).EndInit();
            ((System.ComponentModel.ISupportInitialize)plyny1).EndInit();
            ((System.ComponentModel.ISupportInitialize)plyny4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wymioty).EndInit();
            ((System.ComponentModel.ISupportInitialize)plyny2).EndInit();
            ((System.ComponentModel.ISupportInitialize)plyny3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown szybkoscKroplowki;
        private Label labelSzybkoscKroplowki;
        private Label labelPlyny2;
        private NumericUpDown plyny1;
        private Button oblicz;
        private Label labelWynik;
        private CheckBox margines;
        private Label labelPlyny1;
        private NumericUpDown plyny4;
        private NumericUpDown wymioty;
        private Label labelWymioty;
        private ComboBox typBilansu;
        private Label labelBilans;
        private NumericUpDown plyny2;
        private NumericUpDown plyny3;
        private Label copyright;
    }
}

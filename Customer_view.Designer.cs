namespace Otel_Otomasyonuu
{
    partial class Customer_view
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otelSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otelGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otelListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Bilgileri Görüntüleme Ekranı";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(282, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 111);
            this.button1.TabIndex = 1;
            this.button1.Text = "GÖRÜNTÜLEYİNİZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listbox1
            // 
            this.listbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 25;
            this.listbox1.Location = new System.Drawing.Point(12, 356);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(776, 229);
            this.listbox1.TabIndex = 2;
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otelİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otelİşlemleriToolStripMenuItem
            // 
            this.otelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otelEklemeToolStripMenuItem,
            this.otelSilmeToolStripMenuItem,
            this.otelGüncellemeToolStripMenuItem,
            this.otelListelemeToolStripMenuItem});
            this.otelİşlemleriToolStripMenuItem.Name = "otelİşlemleriToolStripMenuItem";
            this.otelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.otelİşlemleriToolStripMenuItem.Text = "Otel İşlemleri";
            // 
            // otelEklemeToolStripMenuItem
            // 
            this.otelEklemeToolStripMenuItem.Name = "otelEklemeToolStripMenuItem";
            this.otelEklemeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.otelEklemeToolStripMenuItem.Text = "Otel Ekleme";
            this.otelEklemeToolStripMenuItem.Click += new System.EventHandler(this.otelEklemeToolStripMenuItem_Click);
            // 
            // otelSilmeToolStripMenuItem
            // 
            this.otelSilmeToolStripMenuItem.Name = "otelSilmeToolStripMenuItem";
            this.otelSilmeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.otelSilmeToolStripMenuItem.Text = "Otel Silme";
            this.otelSilmeToolStripMenuItem.Click += new System.EventHandler(this.otelSilmeToolStripMenuItem_Click);
            // 
            // otelGüncellemeToolStripMenuItem
            // 
            this.otelGüncellemeToolStripMenuItem.Name = "otelGüncellemeToolStripMenuItem";
            this.otelGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.otelGüncellemeToolStripMenuItem.Text = "Otel Güncelleme";
            this.otelGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.otelGüncellemeToolStripMenuItem_Click);
            // 
            // otelListelemeToolStripMenuItem
            // 
            this.otelListelemeToolStripMenuItem.Name = "otelListelemeToolStripMenuItem";
            this.otelListelemeToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.otelListelemeToolStripMenuItem.Text = "Otel Listeleme";
            this.otelListelemeToolStripMenuItem.Click += new System.EventHandler(this.otelListelemeToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelSilmeToolStripMenuItem,
            this.personelGörüntülemeToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelSilmeToolStripMenuItem
            // 
            this.personelSilmeToolStripMenuItem.Name = "personelSilmeToolStripMenuItem";
            this.personelSilmeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.personelSilmeToolStripMenuItem.Text = "Personel Silme";
            this.personelSilmeToolStripMenuItem.Click += new System.EventHandler(this.personelSilmeToolStripMenuItem_Click);
            // 
            // personelGörüntülemeToolStripMenuItem
            // 
            this.personelGörüntülemeToolStripMenuItem.Name = "personelGörüntülemeToolStripMenuItem";
            this.personelGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.personelGörüntülemeToolStripMenuItem.Text = "Personel Görüntüleme";
            this.personelGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.personelGörüntülemeToolStripMenuItem_Click);
            // 
            // Customer_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 622);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Customer_view";
            this.Text = "Customer_view";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otelEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otelSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otelGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otelListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGörüntülemeToolStripMenuItem;
    }
}
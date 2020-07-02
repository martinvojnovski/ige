namespace Garage_Ige
{
    partial class home
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
            this.info = new System.Windows.Forms.GroupBox();
            this.t_datum_vlez = new System.Windows.Forms.TextBox();
            this.t_registracija = new System.Windows.Forms.TextBox();
            this.t_vozilo = new System.Windows.Forms.TextBox();
            this.t_tel_broj = new System.Windows.Forms.TextBox();
            this.t_prezime = new System.Windows.Forms.TextBox();
            this.t_ime = new System.Windows.Forms.TextBox();
            this.datum_vlez = new System.Windows.Forms.Label();
            this.registracija = new System.Windows.Forms.Label();
            this.vozilo = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.opcija = new System.Windows.Forms.GroupBox();
            this.prikazi = new System.Windows.Forms.Button();
            this.izbrisi = new System.Windows.Forms.Button();
            this.izmeni = new System.Windows.Forms.Button();
            this.zacuvaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.info.SuspendLayout();
            this.opcija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Controls.Add(this.t_datum_vlez);
            this.info.Controls.Add(this.t_registracija);
            this.info.Controls.Add(this.t_vozilo);
            this.info.Controls.Add(this.t_tel_broj);
            this.info.Controls.Add(this.t_prezime);
            this.info.Controls.Add(this.t_ime);
            this.info.Controls.Add(this.datum_vlez);
            this.info.Controls.Add(this.registracija);
            this.info.Controls.Add(this.vozilo);
            this.info.Controls.Add(this.telefon);
            this.info.Controls.Add(this.prezime);
            this.info.Controls.Add(this.ime);
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.info.Location = new System.Drawing.Point(77, 113);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(666, 492);
            this.info.TabIndex = 0;
            this.info.TabStop = false;
            this.info.Text = "Лични Податоци";
            this.info.Enter += new System.EventHandler(this.info_Enter);
            // 
            // t_datum_vlez
            // 
            this.t_datum_vlez.Location = new System.Drawing.Point(417, 392);
            this.t_datum_vlez.Name = "t_datum_vlez";
            this.t_datum_vlez.Size = new System.Drawing.Size(227, 37);
            this.t_datum_vlez.TabIndex = 11;
            // 
            // t_registracija
            // 
            this.t_registracija.Location = new System.Drawing.Point(417, 328);
            this.t_registracija.Name = "t_registracija";
            this.t_registracija.Size = new System.Drawing.Size(227, 37);
            this.t_registracija.TabIndex = 10;
            // 
            // t_vozilo
            // 
            this.t_vozilo.Location = new System.Drawing.Point(417, 264);
            this.t_vozilo.Name = "t_vozilo";
            this.t_vozilo.Size = new System.Drawing.Size(227, 37);
            this.t_vozilo.TabIndex = 9;
            // 
            // t_tel_broj
            // 
            this.t_tel_broj.Location = new System.Drawing.Point(417, 200);
            this.t_tel_broj.Name = "t_tel_broj";
            this.t_tel_broj.Size = new System.Drawing.Size(227, 37);
            this.t_tel_broj.TabIndex = 8;
            // 
            // t_prezime
            // 
            this.t_prezime.Location = new System.Drawing.Point(417, 136);
            this.t_prezime.Name = "t_prezime";
            this.t_prezime.Size = new System.Drawing.Size(227, 37);
            this.t_prezime.TabIndex = 7;
            // 
            // t_ime
            // 
            this.t_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.t_ime.Location = new System.Drawing.Point(417, 72);
            this.t_ime.Name = "t_ime";
            this.t_ime.Size = new System.Drawing.Size(227, 37);
            this.t_ime.TabIndex = 6;
            this.t_ime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // datum_vlez
            // 
            this.datum_vlez.AutoSize = true;
            this.datum_vlez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.datum_vlez.Location = new System.Drawing.Point(47, 394);
            this.datum_vlez.Name = "datum_vlez";
            this.datum_vlez.Size = new System.Drawing.Size(164, 25);
            this.datum_vlez.TabIndex = 5;
            this.datum_vlez.Text = "Датум На Влез";
            this.datum_vlez.Click += new System.EventHandler(this.datum_vlez_Click);
            // 
            // registracija
            // 
            this.registracija.AutoSize = true;
            this.registracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.registracija.Location = new System.Drawing.Point(47, 332);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(238, 25);
            this.registracija.TabIndex = 4;
            this.registracija.Text = "Регистарски Таблички";
            // 
            // vozilo
            // 
            this.vozilo.AutoSize = true;
            this.vozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.vozilo.Location = new System.Drawing.Point(47, 270);
            this.vozilo.Name = "vozilo";
            this.vozilo.Size = new System.Drawing.Size(85, 25);
            this.vozilo.TabIndex = 3;
            this.vozilo.Text = "Возило";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.telefon.Location = new System.Drawing.Point(47, 208);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(185, 25);
            this.telefon.TabIndex = 2;
            this.telefon.Text = "Телефонски Број";
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.prezime.Location = new System.Drawing.Point(47, 146);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(101, 25);
            this.prezime.TabIndex = 1;
            this.prezime.Text = "Презиме";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ime.Location = new System.Drawing.Point(47, 84);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(54, 25);
            this.ime.TabIndex = 0;
            this.ime.Text = "Име";
            this.ime.Click += new System.EventHandler(this.ime_Click);
            // 
            // opcija
            // 
            this.opcija.Controls.Add(this.prikazi);
            this.opcija.Controls.Add(this.izbrisi);
            this.opcija.Controls.Add(this.izmeni);
            this.opcija.Controls.Add(this.zacuvaj);
            this.opcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.opcija.Location = new System.Drawing.Point(77, 608);
            this.opcija.Name = "opcija";
            this.opcija.Size = new System.Drawing.Size(1436, 98);
            this.opcija.TabIndex = 1;
            this.opcija.TabStop = false;
            this.opcija.Text = "Опции";
            // 
            // prikazi
            // 
            this.prikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.prikazi.Location = new System.Drawing.Point(765, 36);
            this.prikazi.Name = "prikazi";
            this.prikazi.Size = new System.Drawing.Size(128, 31);
            this.prikazi.TabIndex = 4;
            this.prikazi.Text = "Прикажи";
            this.prikazi.UseVisualStyleBackColor = true;
            // 
            // izbrisi
            // 
            this.izbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.izbrisi.Location = new System.Drawing.Point(1243, 36);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(128, 31);
            this.izbrisi.TabIndex = 2;
            this.izbrisi.Text = "Избриши";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // izmeni
            // 
            this.izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.izmeni.Location = new System.Drawing.Point(1004, 36);
            this.izmeni.Name = "izmeni";
            this.izmeni.Size = new System.Drawing.Size(128, 31);
            this.izmeni.TabIndex = 1;
            this.izmeni.Text = "Измени";
            this.izmeni.UseVisualStyleBackColor = true;
            this.izmeni.Click += new System.EventHandler(this.button2_Click);
            // 
            // zacuvaj
            // 
            this.zacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.zacuvaj.Location = new System.Drawing.Point(224, 25);
            this.zacuvaj.Name = "zacuvaj";
            this.zacuvaj.Size = new System.Drawing.Size(191, 52);
            this.zacuvaj.TabIndex = 0;
            this.zacuvaj.Text = "Зачувај";
            this.zacuvaj.UseVisualStyleBackColor = true;
            this.zacuvaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(761, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 474);
            this.dataGridView1.TabIndex = 2;
            // 
            // home
            // 
            this.ClientSize = new System.Drawing.Size(1538, 743);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.opcija);
            this.Controls.Add(this.info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F);
            this.Name = "home";
            this.Text = "Мото Гаража Иге";
            this.Load += new System.EventHandler(this.home_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.opcija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox informacii;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Label datum_vlez;
        private System.Windows.Forms.Label registracija;
        private System.Windows.Forms.Label vozilo;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.TextBox t_datum_vlez;
        private System.Windows.Forms.TextBox t_registracija;
        private System.Windows.Forms.TextBox t_vozilo;
        private System.Windows.Forms.TextBox t_tel_broj;
        private System.Windows.Forms.TextBox t_prezime;
        private System.Windows.Forms.TextBox t_ime;
        private System.Windows.Forms.GroupBox opcija;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button izmeni;
        private System.Windows.Forms.Button zacuvaj;
        private System.Windows.Forms.Button prikazi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


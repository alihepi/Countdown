namespace CountdownTool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dakika = new System.Windows.Forms.TextBox();
            this.baslat = new System.Windows.Forms.Button();
            this.dakikaCd = new System.Windows.Forms.Label();
            this.saniyeCd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Button();
            this.turCd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dakika
            // 
            this.dakika.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.Location = new System.Drawing.Point(80, 67);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(115, 30);
            this.dakika.TabIndex = 1;
            this.dakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dakika.TextChanged += new System.EventHandler(this.dakika_TextChanged);
            // 
            // baslat
            // 
            this.baslat.BackColor = System.Drawing.Color.Honeydew;
            this.baslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baslat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat.Location = new System.Drawing.Point(201, 66);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(92, 31);
            this.baslat.TabIndex = 2;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // dakikaCd
            // 
            this.dakikaCd.AutoSize = true;
            this.dakikaCd.Font = new System.Drawing.Font("NSimSun", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dakikaCd.Location = new System.Drawing.Point(78, 142);
            this.dakikaCd.Name = "dakikaCd";
            this.dakikaCd.Size = new System.Drawing.Size(114, 80);
            this.dakikaCd.TabIndex = 3;
            this.dakikaCd.Text = "--";
            // 
            // saniyeCd
            // 
            this.saniyeCd.AutoSize = true;
            this.saniyeCd.Font = new System.Drawing.Font("NSimSun", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saniyeCd.Location = new System.Drawing.Point(277, 142);
            this.saniyeCd.Name = "saniyeCd";
            this.saniyeCd.Size = new System.Drawing.Size(114, 80);
            this.saniyeCd.TabIndex = 4;
            this.saniyeCd.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 80);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Snow;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.Location = new System.Drawing.Point(299, 66);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(92, 31);
            this.stop.TabIndex = 6;
            this.stop.Text = "Durdur";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // turCd
            // 
            this.turCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turCd.Location = new System.Drawing.Point(80, 243);
            this.turCd.Name = "turCd";
            this.turCd.Size = new System.Drawing.Size(311, 26);
            this.turCd.TabIndex = 7;
            this.turCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(474, 300);
            this.Controls.Add(this.turCd);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saniyeCd);
            this.Controls.Add(this.dakikaCd);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.dakika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dakika;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Label dakikaCd;
        private System.Windows.Forms.Label saniyeCd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label turCd;
    }
}


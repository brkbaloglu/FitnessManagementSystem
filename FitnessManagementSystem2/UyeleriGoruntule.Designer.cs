namespace FitnessManagementSystem2
{
    partial class UyeleriGoruntule
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUyeleriGoruntule = new System.Windows.Forms.DataGridView();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeleriGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(218, -7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fitness Center";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(304, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Üyeleri Görüntüle";
            // 
            // dataGridViewUyeleriGoruntule
            // 
            this.dataGridViewUyeleriGoruntule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUyeleriGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUyeleriGoruntule.Location = new System.Drawing.Point(35, 173);
            this.dataGridViewUyeleriGoruntule.Name = "dataGridViewUyeleriGoruntule";
            this.dataGridViewUyeleriGoruntule.RowHeadersWidth = 51;
            this.dataGridViewUyeleriGoruntule.RowTemplate.Height = 24;
            this.dataGridViewUyeleriGoruntule.Size = new System.Drawing.Size(731, 254);
            this.dataGridViewUyeleriGoruntule.TabIndex = 8;
            this.dataGridViewUyeleriGoruntule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUyeleriGoruntule_CellContentClick);
            // 
            // textBoxAra
            // 
            this.textBoxAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAra.Location = new System.Drawing.Point(209, 112);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(237, 38);
            this.textBoxAra.TabIndex = 9;
            this.textBoxAra.TextChanged += new System.EventHandler(this.textBoxAra_TextChanged);
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAra.FlatAppearance.BorderSize = 0;
            this.buttonAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAra.ForeColor = System.Drawing.Color.White;
            this.buttonAra.Location = new System.Drawing.Point(464, 112);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(100, 38);
            this.buttonAra.TabIndex = 10;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(728, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(30, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Geri";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // UyeleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.dataGridViewUyeleriGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeleriGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeleriGoruntule";
            this.Load += new System.EventHandler(this.UyeleriGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeleriGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUyeleriGoruntule;
        private System.Windows.Forms.TextBox textBoxAra;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}
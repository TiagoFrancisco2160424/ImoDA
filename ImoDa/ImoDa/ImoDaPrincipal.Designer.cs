namespace ImoDa
{
    partial class ImoDaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImoDaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFormImoDa = new System.Windows.Forms.Label();
            this.btgerircasas = new System.Windows.Forms.Button();
            this.btgerirclientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(267, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 97);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbFormImoDa
            // 
            this.lbFormImoDa.AutoSize = true;
            this.lbFormImoDa.Font = new System.Drawing.Font("Monotype Corsiva", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormImoDa.Location = new System.Drawing.Point(258, 91);
            this.lbFormImoDa.Name = "lbFormImoDa";
            this.lbFormImoDa.Size = new System.Drawing.Size(140, 52);
            this.lbFormImoDa.TabIndex = 6;
            this.lbFormImoDa.Text = "Imo Da";
            // 
            // btgerircasas
            // 
            this.btgerircasas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btgerircasas.BackgroundImage")));
            this.btgerircasas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btgerircasas.Location = new System.Drawing.Point(370, 166);
            this.btgerircasas.Name = "btgerircasas";
            this.btgerircasas.Size = new System.Drawing.Size(191, 206);
            this.btgerircasas.TabIndex = 5;
            this.btgerircasas.Text = "Gerir Casas";
            this.btgerircasas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btgerircasas.UseVisualStyleBackColor = true;
            // 
            // btgerirclientes
            // 
            this.btgerirclientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btgerirclientes.BackgroundImage")));
            this.btgerirclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btgerirclientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btgerirclientes.Location = new System.Drawing.Point(101, 166);
            this.btgerirclientes.Name = "btgerirclientes";
            this.btgerirclientes.Size = new System.Drawing.Size(191, 206);
            this.btgerirclientes.TabIndex = 4;
            this.btgerirclientes.Text = "Gerir Clientes";
            this.btgerirclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btgerirclientes.UseVisualStyleBackColor = true;
            // 
            // ImoDaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbFormImoDa);
            this.Controls.Add(this.btgerircasas);
            this.Controls.Add(this.btgerirclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ImoDaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImoDa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbFormImoDa;
        private System.Windows.Forms.Button btgerircasas;
        private System.Windows.Forms.Button btgerirclientes;
    }
}
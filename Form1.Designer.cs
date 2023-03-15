namespace SimonGame
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.picG = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            this.picY = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // picG
            // 
            this.picG.BackColor = System.Drawing.Color.Green;
            this.picG.Location = new System.Drawing.Point(256, 124);
            this.picG.Name = "picG";
            this.picG.Size = new System.Drawing.Size(100, 50);
            this.picG.TabIndex = 0;
            this.picG.TabStop = false;
            // 
            // picR
            // 
            this.picR.BackColor = System.Drawing.Color.Red;
            this.picR.Location = new System.Drawing.Point(408, 124);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(100, 50);
            this.picR.TabIndex = 1;
            this.picR.TabStop = false;
            // 
            // picY
            // 
            this.picY.BackColor = System.Drawing.Color.Yellow;
            this.picY.Location = new System.Drawing.Point(256, 215);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(100, 50);
            this.picY.TabIndex = 2;
            this.picY.TabStop = false;
            // 
            // picB
            // 
            this.picB.BackColor = System.Drawing.Color.Blue;
            this.picB.Location = new System.Drawing.Point(408, 215);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(100, 50);
            this.picB.TabIndex = 3;
            this.picB.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(329, 317);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 28);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.picY);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.picG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picG;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.PictureBox picY;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.Button btnStart;
    }
}


namespace AppProfesores
{
    partial class frmBuscar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(189, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 368);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(325, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(107, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 31);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Buscar Profesor";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(713, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(105)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProfesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnVolver;
    }
}
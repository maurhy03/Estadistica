namespace Estadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSerie = new System.Windows.Forms.Label();
            this.BtnMedia_Aritmetica = new System.Windows.Forms.Button();
            this.LblRespuesta_Serie = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSerie
            // 
            this.LblSerie.AutoSize = true;
            this.LblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSerie.Location = new System.Drawing.Point(29, 24);
            this.LblSerie.Name = "LblSerie";
            this.LblSerie.Size = new System.Drawing.Size(49, 16);
            this.LblSerie.TabIndex = 0;
            this.LblSerie.Text = "Serie:";
            // 
            // BtnMedia_Aritmetica
            // 
            this.BtnMedia_Aritmetica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMedia_Aritmetica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedia_Aritmetica.Location = new System.Drawing.Point(32, 122);
            this.BtnMedia_Aritmetica.Name = "BtnMedia_Aritmetica";
            this.BtnMedia_Aritmetica.Size = new System.Drawing.Size(87, 29);
            this.BtnMedia_Aritmetica.TabIndex = 1;
            this.BtnMedia_Aritmetica.Text = "Calcular X";
            this.BtnMedia_Aritmetica.UseVisualStyleBackColor = false;
            // 
            // LblRespuesta_Serie
            // 
            this.LblRespuesta_Serie.AutoSize = true;
            this.LblRespuesta_Serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta_Serie.Location = new System.Drawing.Point(29, 74);
            this.LblRespuesta_Serie.Name = "LblRespuesta_Serie";
            this.LblRespuesta_Serie.Size = new System.Drawing.Size(17, 16);
            this.LblRespuesta_Serie.TabIndex = 2;
            this.LblRespuesta_Serie.Text = "X";
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(98, 24);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(100, 20);
            this.TxtSerie.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(332, 214);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.LblRespuesta_Serie);
            this.Controls.Add(this.BtnMedia_Aritmetica);
            this.Controls.Add(this.LblSerie);
            this.Name = "Form1";
            this.Text = "Calculos basicos de estadistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSerie;
        private System.Windows.Forms.Button BtnMedia_Aritmetica;
        private System.Windows.Forms.Label LblRespuesta_Serie;
        private System.Windows.Forms.TextBox TxtSerie;
    }
}


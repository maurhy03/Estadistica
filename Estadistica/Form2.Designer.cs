namespace Estadistica
{
    partial class Form2
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
            this.LblDe = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.CbxDe = new System.Windows.Forms.ComboBox();
            this.CbxA = new System.Windows.Forms.ComboBox();
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // LblDe
            // 
            this.LblDe.AutoSize = true;
            this.LblDe.Location = new System.Drawing.Point(14, 73);
            this.LblDe.Name = "LblDe";
            this.LblDe.Size = new System.Drawing.Size(21, 13);
            this.LblDe.TabIndex = 1;
            this.LblDe.Text = "De";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(216, 68);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(14, 13);
            this.LblA.TabIndex = 2;
            this.LblA.Text = "A";
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "Divisa"});
            this.CbxTipo.Location = new System.Drawing.Point(48, 19);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(121, 21);
            this.CbxTipo.TabIndex = 3;
            // 
            // CbxDe
            // 
            this.CbxDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDe.FormattingEnabled = true;
            this.CbxDe.Location = new System.Drawing.Point(55, 65);
            this.CbxDe.Name = "CbxDe";
            this.CbxDe.Size = new System.Drawing.Size(121, 21);
            this.CbxDe.TabIndex = 4;
            // 
            // CbxA
            // 
            this.CbxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxA.FormattingEnabled = true;
            this.CbxA.Location = new System.Drawing.Point(257, 65);
            this.CbxA.Name = "CbxA";
            this.CbxA.Size = new System.Drawing.Size(129, 21);
            this.CbxA.TabIndex = 5;
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Location = new System.Drawing.Point(92, 221);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(84, 30);
            this.BtnConvertir.TabIndex = 6;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Location = new System.Drawing.Point(108, 180);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(19, 13);
            this.LblRespuesta.TabIndex = 7;
            this.LblRespuesta.Text = "¿?";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(126, 121);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 8;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(52, 128);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(49, 13);
            this.LblCantidad.TabIndex = 9;
            this.LblCantidad.Text = "Cantidad";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 315);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.CbxA);
            this.Controls.Add(this.CbxDe);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblDe);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDe;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.ComboBox CbxDe;
        private System.Windows.Forms.ComboBox CbxA;
        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
    }
}
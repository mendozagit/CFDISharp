
namespace CFDISharp.Winforms
{
    partial class Form1
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
            this.BtnFactura = new System.Windows.Forms.Button();
            this.BtnNC = new System.Windows.Forms.Button();
            this.BtnCompInd = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCompGrup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFactura
            // 
            this.BtnFactura.Location = new System.Drawing.Point(12, 53);
            this.BtnFactura.Name = "BtnFactura";
            this.BtnFactura.Size = new System.Drawing.Size(164, 146);
            this.BtnFactura.TabIndex = 0;
            this.BtnFactura.Text = "GENERAR Y TIMBRAR FACTURA";
            this.BtnFactura.UseVisualStyleBackColor = true;
            // 
            // BtnNC
            // 
            this.BtnNC.Location = new System.Drawing.Point(182, 53);
            this.BtnNC.Name = "BtnNC";
            this.BtnNC.Size = new System.Drawing.Size(160, 146);
            this.BtnNC.TabIndex = 1;
            this.BtnNC.Text = "GENERAR Y TIMBRAR NOTA DE CREDITO";
            this.BtnNC.UseVisualStyleBackColor = true;
            // 
            // BtnCompInd
            // 
            this.BtnCompInd.Location = new System.Drawing.Point(7, 205);
            this.BtnCompInd.Name = "BtnCompInd";
            this.BtnCompInd.Size = new System.Drawing.Size(169, 146);
            this.BtnCompInd.TabIndex = 2;
            this.BtnCompInd.Text = "GENERAR Y TIMBRAR COMPLEMENTO PAGO INDIVIDUAL";
            this.BtnCompInd.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(348, 53);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 146);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "CANCELAR CUALQUIER TIPO DE  FACTURA";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnCompGrup
            // 
            this.BtnCompGrup.Location = new System.Drawing.Point(182, 205);
            this.BtnCompGrup.Name = "BtnCompGrup";
            this.BtnCompGrup.Size = new System.Drawing.Size(169, 146);
            this.BtnCompGrup.TabIndex = 4;
            this.BtnCompGrup.Text = "GENERAR Y TIMBRAR COMPLEMENTO PAGO GLOBAL";
            this.BtnCompGrup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 422);
            this.Controls.Add(this.BtnCompGrup);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCompInd);
            this.Controls.Add(this.BtnNC);
            this.Controls.Add(this.BtnFactura);
            this.Name = "Form1";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFactura;
        private System.Windows.Forms.Button BtnNC;
        private System.Windows.Forms.Button BtnCompInd;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCompGrup;
    }
}


﻿
namespace GestionProyectosSoftware
{
    partial class Memorama
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
            this.components = new System.ComponentModel.Container();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblmilisegundos = new System.Windows.Forms.Label();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(22, 12);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(522, 426);
            this.PanelJuego.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(638, 49);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 20);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblmilisegundos
            // 
            this.lblmilisegundos.AutoSize = true;
            this.lblmilisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmilisegundos.Location = new System.Drawing.Point(690, 83);
            this.lblmilisegundos.Name = "lblmilisegundos";
            this.lblmilisegundos.Size = new System.Drawing.Size(39, 20);
            this.lblmilisegundos.TabIndex = 2;
            this.lblmilisegundos.Text = "000";
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(655, 83);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(29, 20);
            this.lblSegundos.TabIndex = 3;
            this.lblSegundos.Text = "00";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(620, 83);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(29, 20);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puntaje";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(638, 273);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(70, 20);
            this.lblPuntos.TabIndex = 8;
            this.lblPuntos.Text = "Puntaje";
            this.lblPuntos.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(624, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Memorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblmilisegundos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.label2);
            this.Name = "Memorama";
            this.Text = "Memorama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblmilisegundos;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Button btnReset;
    }
}
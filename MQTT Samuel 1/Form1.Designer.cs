namespace MQTT_Samuel_1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEventos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPorta = new System.Windows.Forms.PictureBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.Timer_Varredura = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(46, 230);
            this.txtEnviar.Multiline = true;
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(226, 33);
            this.txtEnviar.TabIndex = 0;
            this.txtEnviar.TextChanged += new System.EventHandler(this.txtEnviar_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(278, 230);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 33);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConectar.Location = new System.Drawing.Point(371, 230);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(87, 33);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEventos
            // 
            this.txtEventos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEventos.Enabled = false;
            this.txtEventos.Location = new System.Drawing.Point(46, 269);
            this.txtEventos.Multiline = true;
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.Size = new System.Drawing.Size(424, 148);
            this.txtEventos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Publicar texto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTROLE DE ACESSO";
            // 
            // pbPorta
            // 
            this.pbPorta.BackColor = System.Drawing.Color.IndianRed;
            this.pbPorta.Location = new System.Drawing.Point(90, 96);
            this.pbPorta.Name = "pbPorta";
            this.pbPorta.Size = new System.Drawing.Size(60, 46);
            this.pbPorta.TabIndex = 8;
            this.pbPorta.TabStop = false;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorta.Location = new System.Drawing.Point(156, 108);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(155, 20);
            this.lblPorta.TabIndex = 9;
            this.lblPorta.Text = "PORTA TRANCADA";
            // 
            // Timer_Varredura
            // 
            this.Timer_Varredura.Enabled = true;
            this.Timer_Varredura.Tick += new System.EventHandler(this.Timer_Varredura_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.pbPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventos);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Timer Timer_Varredura;
    }
}


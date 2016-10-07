namespace Server
{
    partial class frmCozinha
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brnEnviarBalcao = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // brnEnviarBalcao
            // 
            this.brnEnviarBalcao.Location = new System.Drawing.Point(12, 32);
            this.brnEnviarBalcao.Name = "brnEnviarBalcao";
            this.brnEnviarBalcao.Size = new System.Drawing.Size(116, 23);
            this.brnEnviarBalcao.TabIndex = 12;
            this.brnEnviarBalcao.Text = "Enviar para Balcão";
            this.brnEnviarBalcao.UseVisualStyleBackColor = true;
            this.brnEnviarBalcao.Click += new System.EventHandler(this.brnEnviarBalcao_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 511);
            this.listBox1.TabIndex = 13;
            // 
            // frmCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 584);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.brnEnviarBalcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCozinha";
            this.Text = "Cozinha";
            this.Load += new System.EventHandler(this.frmCozinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button brnEnviarBalcao;
        private System.Windows.Forms.ListBox listBox1;
    }
}
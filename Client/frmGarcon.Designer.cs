namespace Client
{
	partial class frmGarcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGarcon));
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.ltbPedido = new System.Windows.Forms.ListBox();
            this.ltbProdutos = new System.Windows.Forms.ListBox();
            this.txtNumeroMesa = new System.Windows.Forms.TextBox();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.btnEnviarPedido = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConfiguararIPDoServidor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            resources.ApplyResources(this.btnRemover, "btnRemover");
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(this.btnAdicionar, "btnAdicionar");
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // ltbPedido
            // 
            this.ltbPedido.FormattingEnabled = true;
            resources.ApplyResources(this.ltbPedido, "ltbPedido");
            this.ltbPedido.Name = "ltbPedido";
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.FormattingEnabled = true;
            resources.ApplyResources(this.ltbProdutos, "ltbProdutos");
            this.ltbProdutos.Name = "ltbProdutos";
            // 
            // txtNumeroMesa
            // 
            resources.ApplyResources(this.txtNumeroMesa, "txtNumeroMesa");
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            // 
            // lblNumMesa
            // 
            resources.ApplyResources(this.lblNumMesa, "lblNumMesa");
            this.lblNumMesa.Name = "lblNumMesa";
            // 
            // btnEnviarPedido
            // 
            resources.ApplyResources(this.btnEnviarPedido, "btnEnviarPedido");
            this.btnEnviarPedido.Name = "btnEnviarPedido";
            this.btnEnviarPedido.UseVisualStyleBackColor = true;
            this.btnEnviarPedido.Click += new System.EventHandler(this.btnEnviarPedido_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspOpcoes});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tspOpcoes
            // 
            this.tspOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiConfiguararIPDoServidor});
            this.tspOpcoes.Name = "tspOpcoes";
            resources.ApplyResources(this.tspOpcoes, "tspOpcoes");
            // 
            // tsiConfiguararIPDoServidor
            // 
            this.tsiConfiguararIPDoServidor.Name = "tsiConfiguararIPDoServidor";
            resources.ApplyResources(this.tsiConfiguararIPDoServidor, "tsiConfiguararIPDoServidor");
            this.tsiConfiguararIPDoServidor.Click += new System.EventHandler(this.tsiConfiguararIPDoServidor_Click);
            // 
            // frmGarcon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEnviarPedido);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ltbPedido);
            this.Controls.Add(this.ltbProdutos);
            this.Controls.Add(this.txtNumeroMesa);
            this.Controls.Add(this.lblNumMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGarcon";
            this.Load += new System.EventHandler(this.frmGarcon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.ListBox ltbPedido;
		private System.Windows.Forms.ListBox ltbProdutos;
		private System.Windows.Forms.TextBox txtNumeroMesa;
		private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Button btnEnviarPedido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tsiConfiguararIPDoServidor;
    }
}


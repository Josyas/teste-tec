namespace ShoppingCar.Views
{
    partial class PageInicial
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
            Menu = new MenuStrip();
            paginaInicialToolStripMenuItem = new ToolStripMenuItem();
            veiculosCadastroToolStripMenuItem = new ToolStripMenuItem();
            listaDeVeiculosToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { paginaInicialToolStripMenuItem, veiculosCadastroToolStripMenuItem, listaDeVeiculosToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1015, 24);
            Menu.TabIndex = 0;
            // 
            // paginaInicialToolStripMenuItem
            // 
            paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            paginaInicialToolStripMenuItem.Size = new Size(89, 20);
            paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            paginaInicialToolStripMenuItem.Click += PaginaInicialToolStripMenuItem_Click;
            // 
            // veiculosCadastroToolStripMenuItem
            // 
            veiculosCadastroToolStripMenuItem.Name = "veiculosCadastroToolStripMenuItem";
            veiculosCadastroToolStripMenuItem.Size = new Size(112, 20);
            veiculosCadastroToolStripMenuItem.Text = "Veiculos Cadastro";
            veiculosCadastroToolStripMenuItem.Click += VeiculosCadastroToolStripMenuItem_Click;
            // 
            // listaDeVeiculosToolStripMenuItem
            // 
            listaDeVeiculosToolStripMenuItem.Name = "listaDeVeiculosToolStripMenuItem";
            listaDeVeiculosToolStripMenuItem.Size = new Size(105, 20);
            listaDeVeiculosToolStripMenuItem.Text = "Lista de Veiculos";
            listaDeVeiculosToolStripMenuItem.Click += ListaDeVeiculosToolStripMenuItem_Click;
            // 
            // PageInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 546);
            Controls.Add(Menu);
            Name = "PageInicial";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem paginaInicialToolStripMenuItem;
        private ToolStripMenuItem veiculosCadastroToolStripMenuItem;
        private ToolStripMenuItem listaDeVeiculosToolStripMenuItem;
    }
}
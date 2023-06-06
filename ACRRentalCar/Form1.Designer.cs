namespace ACRRentalCar
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            veiculoToolStripMenuItem = new ToolStripMenuItem();
            movimentaçãoToolStripMenuItem = new ToolStripMenuItem();
            locaçãoToolStripMenuItem = new ToolStripMenuItem();
            devoluçãoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, movimentaçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(770, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, veiculoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // veiculoToolStripMenuItem
            // 
            veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            veiculoToolStripMenuItem.Size = new Size(180, 22);
            veiculoToolStripMenuItem.Text = "Veiculo";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locaçãoToolStripMenuItem, devoluçãoToolStripMenuItem });
            movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            movimentaçãoToolStripMenuItem.Size = new Size(99, 20);
            movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // locaçãoToolStripMenuItem
            // 
            locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            locaçãoToolStripMenuItem.Size = new Size(180, 22);
            locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // devoluçãoToolStripMenuItem
            // 
            devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            devoluçãoToolStripMenuItem.Size = new Size(180, 22);
            devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 488);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "ACR Rental Car";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem veiculoToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private ToolStripMenuItem locaçãoToolStripMenuItem;
        private ToolStripMenuItem devoluçãoToolStripMenuItem;
    }
}
namespace Projeto1LTI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacesWirelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.interfacesBridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasEstáticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçosIpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidoresDHCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regrasDeFirewallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.interfacesWirelessToolStripMenuItem,
            this.interfacesBridgeToolStripMenuItem,
            this.rotasEstáticasToolStripMenuItem,
            this.endereçosIpsToolStripMenuItem,
            this.servidoresDHCPToolStripMenuItem,
            this.regrasDeFirewallToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "Listar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.listarToolStripMenuItem.Text = "Interfaces do dispositivo";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // interfacesWirelessToolStripMenuItem
            // 
            this.interfacesWirelessToolStripMenuItem.Name = "interfacesWirelessToolStripMenuItem";
            this.interfacesWirelessToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.interfacesWirelessToolStripMenuItem.Text = "Interfaces Wireless";
            this.interfacesWirelessToolStripMenuItem.Click += new System.EventHandler(this.interfacesWirelessToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 308);
            this.listBox1.TabIndex = 2;
            // 
            // interfacesBridgeToolStripMenuItem
            // 
            this.interfacesBridgeToolStripMenuItem.Name = "interfacesBridgeToolStripMenuItem";
            this.interfacesBridgeToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.interfacesBridgeToolStripMenuItem.Text = "Interfaces Bridge";
            this.interfacesBridgeToolStripMenuItem.Click += new System.EventHandler(this.interfacesBridgeToolStripMenuItem_Click);
            // 
            // rotasEstáticasToolStripMenuItem
            // 
            this.rotasEstáticasToolStripMenuItem.Name = "rotasEstáticasToolStripMenuItem";
            this.rotasEstáticasToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.rotasEstáticasToolStripMenuItem.Text = "Rotas Estáticas";
            this.rotasEstáticasToolStripMenuItem.Click += new System.EventHandler(this.rotasEstáticasToolStripMenuItem_Click);
            // 
            // endereçosIpsToolStripMenuItem
            // 
            this.endereçosIpsToolStripMenuItem.Name = "endereçosIpsToolStripMenuItem";
            this.endereçosIpsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.endereçosIpsToolStripMenuItem.Text = "Endereços Ips";
            this.endereçosIpsToolStripMenuItem.Click += new System.EventHandler(this.endereçosIpsToolStripMenuItem_Click);
            // 
            // servidoresDHCPToolStripMenuItem
            // 
            this.servidoresDHCPToolStripMenuItem.Name = "servidoresDHCPToolStripMenuItem";
            this.servidoresDHCPToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.servidoresDHCPToolStripMenuItem.Text = "Servidores DHCP";
            this.servidoresDHCPToolStripMenuItem.Click += new System.EventHandler(this.servidoresDHCPToolStripMenuItem_Click);
            // 
            // regrasDeFirewallToolStripMenuItem
            // 
            this.regrasDeFirewallToolStripMenuItem.Name = "regrasDeFirewallToolStripMenuItem";
            this.regrasDeFirewallToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.regrasDeFirewallToolStripMenuItem.Text = "Regras de Firewall";
            this.regrasDeFirewallToolStripMenuItem.Click += new System.EventHandler(this.regrasDeFirewallToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 413);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem interfacesWirelessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfacesBridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasEstáticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endereçosIpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidoresDHCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regrasDeFirewallToolStripMenuItem;
    }
}


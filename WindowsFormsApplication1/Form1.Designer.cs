namespace WindowsFormsApplication1
{
    partial class IRCSharp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.groupBoxServeur = new System.Windows.Forms.GroupBox();
            this.labelClientHote = new System.Windows.Forms.Label();
            this.labelClientPort = new System.Windows.Forms.Label();
            this.labelServeurServeur = new System.Windows.Forms.Label();
            this.labelServeurPort = new System.Windows.Forms.Label();
            this.textBoxClientHote = new System.Windows.Forms.TextBox();
            this.textBoxClientPort = new System.Windows.Forms.TextBox();
            this.textBoxServeurHote = new System.Windows.Forms.TextBox();
            this.textBoxServeurPort = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxServeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxClientPort);
            this.groupBoxClient.Controls.Add(this.textBoxClientHote);
            this.groupBoxClient.Controls.Add(this.labelClientPort);
            this.groupBoxClient.Controls.Add(this.labelClientHote);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 38);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(174, 100);
            this.groupBoxClient.TabIndex = 1;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // groupBoxServeur
            // 
            this.groupBoxServeur.Controls.Add(this.textBoxServeurPort);
            this.groupBoxServeur.Controls.Add(this.textBoxServeurHote);
            this.groupBoxServeur.Controls.Add(this.labelServeurPort);
            this.groupBoxServeur.Controls.Add(this.labelServeurServeur);
            this.groupBoxServeur.Location = new System.Drawing.Point(231, 38);
            this.groupBoxServeur.Name = "groupBoxServeur";
            this.groupBoxServeur.Size = new System.Drawing.Size(174, 100);
            this.groupBoxServeur.TabIndex = 2;
            this.groupBoxServeur.TabStop = false;
            this.groupBoxServeur.Text = "Serveur";
            // 
            // labelClientHote
            // 
            this.labelClientHote.AutoSize = true;
            this.labelClientHote.Location = new System.Drawing.Point(6, 29);
            this.labelClientHote.Name = "labelClientHote";
            this.labelClientHote.Size = new System.Drawing.Size(30, 13);
            this.labelClientHote.TabIndex = 0;
            this.labelClientHote.Text = "Hôte";
            this.labelClientHote.Click += new System.EventHandler(this.labelClientHote_Click);
            // 
            // labelClientPort
            // 
            this.labelClientPort.AutoSize = true;
            this.labelClientPort.Location = new System.Drawing.Point(6, 57);
            this.labelClientPort.Name = "labelClientPort";
            this.labelClientPort.Size = new System.Drawing.Size(26, 13);
            this.labelClientPort.TabIndex = 1;
            this.labelClientPort.Text = "Port";
            // 
            // labelServeurServeur
            // 
            this.labelServeurServeur.AutoSize = true;
            this.labelServeurServeur.Location = new System.Drawing.Point(6, 29);
            this.labelServeurServeur.Name = "labelServeurServeur";
            this.labelServeurServeur.Size = new System.Drawing.Size(30, 13);
            this.labelServeurServeur.TabIndex = 2;
            this.labelServeurServeur.Text = "Hôte";
            // 
            // labelServeurPort
            // 
            this.labelServeurPort.AutoSize = true;
            this.labelServeurPort.Location = new System.Drawing.Point(6, 57);
            this.labelServeurPort.Name = "labelServeurPort";
            this.labelServeurPort.Size = new System.Drawing.Size(26, 13);
            this.labelServeurPort.TabIndex = 2;
            this.labelServeurPort.Text = "Port";
            // 
            // textBoxClientHote
            // 
            this.textBoxClientHote.Location = new System.Drawing.Point(42, 26);
            this.textBoxClientHote.Name = "textBoxClientHote";
            this.textBoxClientHote.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientHote.TabIndex = 2;
            // 
            // textBoxClientPort
            // 
            this.textBoxClientPort.Location = new System.Drawing.Point(42, 54);
            this.textBoxClientPort.Name = "textBoxClientPort";
            this.textBoxClientPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientPort.TabIndex = 3;
            // 
            // textBoxServeurHote
            // 
            this.textBoxServeurHote.Location = new System.Drawing.Point(42, 26);
            this.textBoxServeurHote.Name = "textBoxServeurHote";
            this.textBoxServeurHote.Size = new System.Drawing.Size(100, 20);
            this.textBoxServeurHote.TabIndex = 4;
            // 
            // textBoxServeurPort
            // 
            this.textBoxServeurPort.Location = new System.Drawing.Point(42, 54);
            this.textBoxServeurPort.Name = "textBoxServeurPort";
            this.textBoxServeurPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxServeurPort.TabIndex = 5;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(427, 67);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(93, 45);
            this.buttonConnexion.TabIndex = 3;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Location = new System.Drawing.Point(12, 163);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(393, 186);
            this.listMessages.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(13, 365);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(392, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.Location = new System.Drawing.Point(427, 365);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(93, 23);
            this.buttonEnvoyer.TabIndex = 6;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            // 
            // IRCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 402);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.groupBoxServeur);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IRCE";
            this.Text = "IRCE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxServeur.ResumeLayout(false);
            this.groupBoxServeur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.GroupBox groupBoxServeur;
        private System.Windows.Forms.TextBox textBoxClientHote;
        private System.Windows.Forms.Label labelClientPort;
        private System.Windows.Forms.Label labelClientHote;
        private System.Windows.Forms.Label labelServeurPort;
        private System.Windows.Forms.Label labelServeurServeur;
        private System.Windows.Forms.TextBox textBoxClientPort;
        private System.Windows.Forms.TextBox textBoxServeurPort;
        private System.Windows.Forms.TextBox textBoxServeurHote;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonEnvoyer;
    }
}


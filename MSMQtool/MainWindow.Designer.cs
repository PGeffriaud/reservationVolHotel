namespace MSMQtool
{
    partial class MainWindow
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
            this.buttonReceiveOne = new System.Windows.Forms.Button();
            this.buttonReceiveAll = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReceiveOne
            // 
            this.buttonReceiveOne.Location = new System.Drawing.Point(12, 227);
            this.buttonReceiveOne.Name = "buttonReceiveOne";
            this.buttonReceiveOne.Size = new System.Drawing.Size(79, 23);
            this.buttonReceiveOne.TabIndex = 0;
            this.buttonReceiveOne.Text = "Receive One";
            this.buttonReceiveOne.UseVisualStyleBackColor = true;
            this.buttonReceiveOne.Click += new System.EventHandler(this.buttonReceiveOne_Click);
            // 
            // buttonReceiveAll
            // 
            this.buttonReceiveAll.Location = new System.Drawing.Point(97, 227);
            this.buttonReceiveAll.Name = "buttonReceiveAll";
            this.buttonReceiveAll.Size = new System.Drawing.Size(79, 23);
            this.buttonReceiveAll.TabIndex = 1;
            this.buttonReceiveAll.Text = "Receive All";
            this.buttonReceiveAll.UseVisualStyleBackColor = true;
            this.buttonReceiveAll.Click += new System.EventHandler(this.buttonReceiveAll_Click);
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(12, 12);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(662, 199);
            this.itemsList.TabIndex = 2;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(182, 227);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(79, 23);
            this.buttonClearAll.TabIndex = 3;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 262);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.buttonReceiveAll);
            this.Controls.Add(this.buttonReceiveOne);
            this.Name = "MainWindow";
            this.Text = "MSMQtool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReceiveOne;
        private System.Windows.Forms.Button buttonReceiveAll;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Button buttonClearAll;
    }
}


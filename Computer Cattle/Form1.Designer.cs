namespace Computer_Cattle
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpBreedingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewHerdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allLiveCattleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breedingAnimalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maleOnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleOnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maleOnlyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleOnlyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(353, 313);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Up Breeding";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpBreedingToolStripMenuItem,
            this.generateNewHerdToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // setUpBreedingToolStripMenuItem
            // 
            this.setUpBreedingToolStripMenuItem.Name = "setUpBreedingToolStripMenuItem";
            this.setUpBreedingToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setUpBreedingToolStripMenuItem.Text = "Set Up Breeding";
            // 
            // generateNewHerdToolStripMenuItem
            // 
            this.generateNewHerdToolStripMenuItem.Name = "generateNewHerdToolStripMenuItem";
            this.generateNewHerdToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.generateNewHerdToolStripMenuItem.Text = "Generate New Herd";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allLiveCattleToolStripMenuItem,
            this.breedingAnimalsToolStripMenuItem,
            this.calvesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allLiveCattleToolStripMenuItem
            // 
            this.allLiveCattleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.maleOnlyToolStripMenuItem,
            this.femaleOnlyToolStripMenuItem});
            this.allLiveCattleToolStripMenuItem.Name = "allLiveCattleToolStripMenuItem";
            this.allLiveCattleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.allLiveCattleToolStripMenuItem.Text = "All Live Cattle";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // maleOnlyToolStripMenuItem
            // 
            this.maleOnlyToolStripMenuItem.Name = "maleOnlyToolStripMenuItem";
            this.maleOnlyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.maleOnlyToolStripMenuItem.Text = "Male Only";
            // 
            // femaleOnlyToolStripMenuItem
            // 
            this.femaleOnlyToolStripMenuItem.Name = "femaleOnlyToolStripMenuItem";
            this.femaleOnlyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.femaleOnlyToolStripMenuItem.Text = "Female Only";
            // 
            // breedingAnimalsToolStripMenuItem
            // 
            this.breedingAnimalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem1,
            this.maleOnlyToolStripMenuItem1,
            this.femaleOnlyToolStripMenuItem1});
            this.breedingAnimalsToolStripMenuItem.Name = "breedingAnimalsToolStripMenuItem";
            this.breedingAnimalsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.breedingAnimalsToolStripMenuItem.Text = "Breeding Animals";
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.allToolStripMenuItem1.Text = "All";
            // 
            // maleOnlyToolStripMenuItem1
            // 
            this.maleOnlyToolStripMenuItem1.Name = "maleOnlyToolStripMenuItem1";
            this.maleOnlyToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.maleOnlyToolStripMenuItem1.Text = "Male Only";
            // 
            // femaleOnlyToolStripMenuItem1
            // 
            this.femaleOnlyToolStripMenuItem1.Name = "femaleOnlyToolStripMenuItem1";
            this.femaleOnlyToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.femaleOnlyToolStripMenuItem1.Text = "Female Only";
            // 
            // calvesToolStripMenuItem
            // 
            this.calvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem2,
            this.maleOnlyToolStripMenuItem2,
            this.femaleOnlyToolStripMenuItem2});
            this.calvesToolStripMenuItem.Name = "calvesToolStripMenuItem";
            this.calvesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.calvesToolStripMenuItem.Text = "Calves";
            // 
            // allToolStripMenuItem2
            // 
            this.allToolStripMenuItem2.Name = "allToolStripMenuItem2";
            this.allToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.allToolStripMenuItem2.Text = "All";
            // 
            // maleOnlyToolStripMenuItem2
            // 
            this.maleOnlyToolStripMenuItem2.Name = "maleOnlyToolStripMenuItem2";
            this.maleOnlyToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.maleOnlyToolStripMenuItem2.Text = "Male Only";
            // 
            // femaleOnlyToolStripMenuItem2
            // 
            this.femaleOnlyToolStripMenuItem2.Name = "femaleOnlyToolStripMenuItem2";
            this.femaleOnlyToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.femaleOnlyToolStripMenuItem2.Text = "Female Only";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(Computer_Cattle.Form1.Animal);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(Computer_Cattle.Form1.Animal);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Computer_Cattle.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allLiveCattleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breedingAnimalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maleOnlyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem femaleOnlyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem maleOnlyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem femaleOnlyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpBreedingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewHerdToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}


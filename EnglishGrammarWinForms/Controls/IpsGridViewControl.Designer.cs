namespace EnglishGrammarWinForms.Controls
{
    partial class IpsGridViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(635, 331);
            this.gridView.TabIndex = 0;
            this.gridView.ThemeName = "Office2013Light";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(3, 4);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(349, 21);
            this.radTextBox1.TabIndex = 1;
            this.radTextBox1.ThemeName = "Office2013Light";
            // 
            // radPanel1
            // 
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 359);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(635, 28);
            this.radPanel1.TabIndex = 2;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radTextBox1);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(635, 28);
            this.radPanel2.TabIndex = 3;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.gridView);
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Location = new System.Drawing.Point(0, 28);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(635, 331);
            this.radPanel3.TabIndex = 3;
            // 
            // IpsGridViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "IpsGridViewControl";
            this.Size = new System.Drawing.Size(635, 387);
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridView;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
    }
}

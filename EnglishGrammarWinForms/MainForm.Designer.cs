namespace EnglishGrammarWinForms
{
    partial class MainForm
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
            this.office2013LightTheme = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.pvSimple = new Telerik.WinControls.UI.RadPageViewPage();
            this.pvContinuous = new Telerik.WinControls.UI.RadPageViewPage();
            this.pvPerfect = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.pvSimple);
            this.radPageView1.Controls.Add(this.pvContinuous);
            this.radPageView1.Controls.Add(this.pvPerfect);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.pvSimple;
            this.radPageView1.Size = new System.Drawing.Size(871, 403);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.ThemeName = "Office2013Light";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Horizontal;
            // 
            // pvSimple
            // 
            this.pvSimple.ItemSize = new System.Drawing.SizeF(152F, 27F);
            this.pvSimple.Location = new System.Drawing.Point(156, 5);
            this.pvSimple.Name = "pvSimple";
            this.pvSimple.Size = new System.Drawing.Size(710, 393);
            this.pvSimple.Text = "Simple (Indefinite) tenses";
            // 
            // pvContinuous
            // 
            this.pvContinuous.ItemSize = new System.Drawing.SizeF(152F, 27F);
            this.pvContinuous.Location = new System.Drawing.Point(156, 5);
            this.pvContinuous.Name = "pvContinuous";
            this.pvContinuous.Size = new System.Drawing.Size(710, 393);
            this.pvContinuous.Text = "Continuous tenses";
            // 
            // pvPerfect
            // 
            this.pvPerfect.ItemSize = new System.Drawing.SizeF(152F, 27F);
            this.pvPerfect.Location = new System.Drawing.Point(156, 5);
            this.pvPerfect.Name = "pvPerfect";
            this.pvPerfect.Size = new System.Drawing.Size(710, 393);
            this.pvPerfect.Text = "Perfect tenses";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 403);
            this.Controls.Add(this.radPageView1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Англійська граматика";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage pvSimple;
        private Telerik.WinControls.UI.RadPageViewPage pvContinuous;
        private Telerik.WinControls.UI.RadPageViewPage pvPerfect;
    }
}
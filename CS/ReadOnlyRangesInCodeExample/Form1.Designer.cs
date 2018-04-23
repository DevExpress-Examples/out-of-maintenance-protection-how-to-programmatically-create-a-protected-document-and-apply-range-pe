namespace ReadOnlyRangesInCodeExample
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
            if (disposing && (components != null)) {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.checkSpellingItem1 = new DevExpress.XtraRichEdit.UI.CheckSpellingItem();
            this.protectDocumentItem1 = new DevExpress.XtraRichEdit.UI.ProtectDocumentItem();
            this.changeRangeEditingPermissionsItem1 = new DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem();
            this.unprotectDocumentItem1 = new DevExpress.XtraRichEdit.UI.UnprotectDocumentItem();
            this.reviewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReviewRibbonPage();
            this.documentProofingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup();
            this.documentProtectionRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbUserName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 146);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 38);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Log in as:";
            // 
            // cmbUserName
            // 
            this.cmbUserName.EditValue = "";
            this.cmbUserName.Location = new System.Drawing.Point(64, 9);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUserName.Properties.Appearance.Options.UseFont = true;
            this.cmbUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserName.Properties.Items.AddRange(new object[] {
            "Admin@somecompany.com",
            "Employee@somecompany.com",
            "Everyone"});
            this.cmbUserName.Properties.Sorted = true;
            this.cmbUserName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUserName.Size = new System.Drawing.Size(169, 20);
            this.cmbUserName.TabIndex = 0;
            this.cmbUserName.SelectedValueChanged += new System.EventHandler(this.cmbUserName_SelectedValueChanged);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.checkSpellingItem1,
            this.protectDocumentItem1,
            this.changeRangeEditingPermissionsItem1,
            this.unprotectDocumentItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.undoItem1,
            this.redoItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fileRibbonPage1,
            this.reviewRibbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(784, 146);
            // 
            // checkSpellingItem1
            // 
            this.checkSpellingItem1.Id = 1;
            this.checkSpellingItem1.Name = "checkSpellingItem1";
            // 
            // protectDocumentItem1
            // 
            this.protectDocumentItem1.Id = 2;
            this.protectDocumentItem1.Name = "protectDocumentItem1";
            // 
            // changeRangeEditingPermissionsItem1
            // 
            this.changeRangeEditingPermissionsItem1.Id = 3;
            this.changeRangeEditingPermissionsItem1.Name = "changeRangeEditingPermissionsItem1";
            // 
            // unprotectDocumentItem1
            // 
            this.unprotectDocumentItem1.Id = 4;
            this.unprotectDocumentItem1.Name = "unprotectDocumentItem1";
            // 
            // reviewRibbonPage1
            // 
            this.reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.documentProofingRibbonPageGroup1,
            this.documentProtectionRibbonPageGroup1});
            this.reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // documentProofingRibbonPageGroup1
            // 
            this.documentProofingRibbonPageGroup1.ItemLinks.Add(this.checkSpellingItem1);
            this.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1";
            // 
            // documentProtectionRibbonPageGroup1
            // 
            this.documentProtectionRibbonPageGroup1.ItemLinks.Add(this.protectDocumentItem1);
            this.documentProtectionRibbonPageGroup1.ItemLinks.Add(this.changeRangeEditingPermissionsItem1);
            this.documentProtectionRibbonPageGroup1.ItemLinks.Add(this.unprotectDocumentItem1);
            this.documentProtectionRibbonPageGroup1.Name = "documentProtectionRibbonPageGroup1";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.checkSpellingItem1);
            this.richEditBarController1.BarItems.Add(this.protectDocumentItem1);
            this.richEditBarController1.BarItems.Add(this.changeRangeEditingPermissionsItem1);
            this.richEditBarController1.BarItems.Add(this.unprotectDocumentItem1);
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.quickPrintItem1);
            this.richEditBarController1.BarItems.Add(this.printItem1);
            this.richEditBarController1.BarItems.Add(this.printPreviewItem1);
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.Control = this.richEditControl1;
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 184);
            this.richEditControl1.MenuManager = this.ribbonControl1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richEditControl1.Options.MailMerge.KeepLastParagraph = false;
            this.richEditControl1.Size = new System.Drawing.Size(784, 377);
            this.richEditControl1.TabIndex = 3;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileNewItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileOpenItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.fileSaveAsItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.quickPrintItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.printPreviewItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.undoItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.redoItem1);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 5;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 6;
            this.fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 7;
            this.fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 8;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 9;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 10;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 11;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 12;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 13;
            this.redoItem1.Name = "redoItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraRichEdit.UI.CheckSpellingItem checkSpellingItem1;
        private DevExpress.XtraRichEdit.UI.ProtectDocumentItem protectDocumentItem1;
        private DevExpress.XtraRichEdit.UI.ChangeRangeEditingPermissionsItem changeRangeEditingPermissionsItem1;
        private DevExpress.XtraRichEdit.UI.UnprotectDocumentItem unprotectDocumentItem1;
        private DevExpress.XtraRichEdit.UI.ReviewRibbonPage reviewRibbonPage1;
        private DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup documentProofingRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.DocumentProtectionRibbonPageGroup documentProtectionRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
    }
}


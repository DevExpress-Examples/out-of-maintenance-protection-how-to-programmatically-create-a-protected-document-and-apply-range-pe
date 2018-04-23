Imports Microsoft.VisualBasic
Imports System
Namespace ReadOnlyRangesInCodeExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 35)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(672, 351)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.comboBoxEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(672, 35)
			Me.panelControl1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(31, 12)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(46, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Log in as:"
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.EditValue = ""
			Me.comboBoxEdit1.Location = New System.Drawing.Point(94, 9)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { " ", "Admin@somecompany.com", "Employee@somecompany.com"})
			Me.comboBoxEdit1.Properties.Sorted = True
			Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEdit1.Size = New System.Drawing.Size(169, 20)
			Me.comboBoxEdit1.TabIndex = 0
'			Me.comboBoxEdit1.SelectedValueChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(672, 386)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace


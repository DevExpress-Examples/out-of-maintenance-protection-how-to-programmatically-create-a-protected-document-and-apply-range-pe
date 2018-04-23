Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
#End Region ' #usings

Namespace ReadOnlyRangesInCodeExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.Options.Authentication.EMail = comboBoxEdit1.SelectedItem.ToString()
			richEditControl1.Options.RangePermissions.Visibility = RichEditRangePermissionVisibility.Visible

			richEditControl1.CreateNewDocument()

			Dim rangeEditable As DocumentRange = AppendDocument("Documents\editable.docx")
			Dim rangeBody As DocumentRange = AppendDocument("Documents\body.docx")
			Dim rangeSignature As DocumentRange = AppendDocument("Documents\signature.docx")

			Dim rangePermissions As RangePermissionCollection = richEditControl1.Document.BeginUpdateRangePermissions()
			rangePermissions.AddRange(CreateRangeWithPermissions(rangeEditable, String.Empty,"Employee@somecompany.com", "Admin@somecompany.com"))
			rangePermissions.AddRange(CreateRangeWithPermissions(rangeBody, "Everyone", String.Empty))
			rangePermissions.AddRange(CreateRangeWithPermissions(rangeSignature, String.Empty, "Employee@somecompany.com"))
			richEditControl1.Document.EndUpdateRangePermissions(rangePermissions)

			Dim cmd As New ProtectDocumentCommand(richEditControl1)
			cmd.Execute()
		End Sub
		#Region "#appenddocument"
		Private Function AppendDocument(ByVal filename As String) As DocumentRange
			richEditControl1.Document.InsertParagraph(richEditControl1.Document.Range.End)
			Dim pos As DocumentPosition = richEditControl1.Document.CreatePosition(richEditControl1.Document.Range.End.ToInt() - 2)
			Dim range As DocumentRange = richEditControl1.Document.InsertDocumentContent(pos, filename, DocumentFormat.OpenXml)
			Return range
		End Function
		#End Region ' #appenddocument
		Private Shared Function CreateRangeWithPermissions(ByVal range As DocumentRange, ByVal userGroup As String, ParamArray ByVal emails() As String) As List(Of RangePermission)
			Dim rangeList As New List(Of RangePermission)()
			For Each email As String In emails
				Dim rp As New RangePermission(range)
				rp.Group = userGroup
				rp.UserName = email
				rangeList.Add(rp)
			Next email
			Return rangeList
		End Function

		Private Sub comboBoxEdit1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedValueChanged
			richEditControl1.Options.Authentication.EMail = comboBoxEdit1.SelectedItem.ToString()
		End Sub
	End Class
End Namespace
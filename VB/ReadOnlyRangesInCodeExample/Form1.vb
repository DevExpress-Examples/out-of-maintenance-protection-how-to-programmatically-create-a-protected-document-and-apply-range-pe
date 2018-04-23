Imports System
Imports System.Collections.Generic
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Services
#End Region ' #usings

Namespace ReadOnlyRangesInCodeExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public myUserList As New List(Of MyUser)()

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = ribbonControl1.Pages(1)
            myUserList.AddRange(New MyUser(){ _
                New MyUser("Nancy Skywalker","Skywalkers"), _
                New MyUser("Andrew Nihlus","Nihlus"), _
                New MyUser("Janet Skywalker", "Skywalkers"), _
                New MyUser("Margaret","Editors") _
            })

'            #Region "#RegisterUserListService"
            richEditControl1.ReplaceService(Of IUserListService)(New MyUserListService(myUserList))
'            #End Region ' #RegisterUserListService
'            #Region "#RegisterGroupListService"
            richEditControl1.ReplaceService(Of IUserGroupListService)(New MyGroupListService())
'            #End Region ' #RegisterGroupListService

            AddHandler richEditControl1.DocumentLoaded, AddressOf richEditControl1_DocumentLoaded

            richEditControl1.CreateNewDocument()
'            #Region "#AddPermissionsToRanges"
            ' Create document ranges.
            Dim rangeAdmin As DocumentRange = AppendDocument("Documents\administrator.docx")
            Dim rangeBody As DocumentRange = AppendDocument("Documents\body.docx")
            Dim rangeSignature As DocumentRange = AppendDocument("Documents\signature.docx")

            ' Protect document ranges.
            Dim rangePermissions As RangePermissionCollection = richEditControl1.Document.BeginUpdateRangePermissions()
            rangePermissions.AddRange(CreateRangePermissions(rangeAdmin, String.Empty, "Admin@somecompany.com", "Nancy Skywalker"))
            rangePermissions.AddRange(CreateRangePermissions(rangeBody, "Everyone", String.Empty))
            rangePermissions.AddRange(CreateRangePermissions(rangeSignature, "Skywalkers", String.Empty))
            richEditControl1.Document.EndUpdateRangePermissions(rangePermissions)
            ' Enforce protection and set password.
            richEditControl1.Document.Protect("123")
'            #End Region ' #AddPermissionsToRanges

            UpdateUserNameLoginCombo()
        End Sub

        #Region "#AppendDocument"
        Private Function AppendDocument(ByVal filename As String) As DocumentRange
            richEditControl1.Document.Paragraphs.Insert(richEditControl1.Document.Range.End)
            Dim pos As DocumentPosition = richEditControl1.Document.CreatePosition(richEditControl1.Document.Range.End.ToInt() - 2)
            Dim range As DocumentRange = richEditControl1.Document.InsertDocumentContent(pos, filename, DocumentFormat.OpenXml)
            Return range
        End Function
        #End Region ' #AppendDocument
        #Region "#CreatePermissions"
        Private Shared Function CreateRangePermissions(ByVal range As DocumentRange, ByVal userGroup As String, ParamArray ByVal usernames() As String) As List(Of RangePermission)
            Dim rangeList As New List(Of RangePermission)()
            For Each username As String In usernames
                Dim rp As New RangePermission(range)
                rp.Group = userGroup
                rp.UserName = username
                rangeList.Add(rp)
            Next username
            Return rangeList
        End Function
        #End Region ' #CreatePermissions

        #Region "#FetchUsers"
        Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            UpdateUserNameLoginCombo()
            richEditControl1.Options.Authentication.UserName = String.Empty
        End Sub
        Private Sub UpdateUserNameLoginCombo()
            RemoveHandler cmbUserName.SelectedValueChanged, AddressOf cmbUserName_SelectedValueChanged
            Dim rangePermissions As RangePermissionCollection = richEditControl1.Document.BeginUpdateRangePermissions()
            richEditControl1.Document.CancelUpdateRangePermissions(rangePermissions)
            Dim users As New List(Of String)()
            For Each rangePermission As RangePermission In rangePermissions
                Dim userName As String = rangePermission.UserName
                If users.Contains(userName) Then
                    Continue For
                End If
                If Not String.IsNullOrEmpty(userName) Then
                    users.Add(userName)
                End If
            Next rangePermission
            cmbUserName.Properties.BeginUpdate()
            cmbUserName.Properties.Items.Clear()
            cmbUserName.Properties.Items.Add(String.Empty)
            cmbUserName.Properties.Items.AddRange(users)
            For Each user As MyUser In myUserList
                If Not users.Contains(user.UserName) Then
                    cmbUserName.Properties.Items.Add(user.UserName)
                End If
            Next user
            cmbUserName.SelectedIndex = 0
            cmbUserName.Properties.EndUpdate()
            AddHandler cmbUserName.SelectedValueChanged, AddressOf cmbUserName_SelectedValueChanged
        End Sub

        Private Sub cmbUserName_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbUserName.SelectedValueChanged
            Dim username As String = cmbUserName.SelectedItem.ToString()
            richEditControl1.Options.Authentication.UserName = username
            Dim myuser As MyUser = myUserList.Find(Function(s) s.UserName = username)
            richEditControl1.Options.Authentication.Group = If(myuser IsNot Nothing, myuser.Group, String.Empty)

        End Sub
        #End Region ' #FetchUsers

    End Class
End Namespace
Imports DevExpress.XtraRichEdit.API.Native
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ReadOnlyRangesInCodeExample
    #Region "#MyUserListService"
    Friend Class MyUserListService
        Implements DevExpress.XtraRichEdit.Services.IUserListService

        Private users As New List(Of String)()

        Public Sub New(ByVal myUsers As List(Of MyUser))
            For Each user As MyUser In myUsers
                users.Add(user.UserName)
            Next user
        End Sub

        Public Function GetUsers() As IList(Of String) Implements DevExpress.XtraRichEdit.Services.IUserListService.GetUsers

            Return users
        End Function
    End Class
    #End Region ' #MyUserListService
    #Region "#MyGroupListService"
    Friend Class MyGroupListService
        Implements DevExpress.XtraRichEdit.Services.IUserGroupListService

        Private userGroups As List(Of String) = CreateUserGroups()

        Private Shared Function CreateUserGroups() As List(Of String)
            Dim result As New List(Of String)()
            result.Add("Everyone")
            result.Add("Administrators")
            result.Add("Contributors")
            result.Add("Owners")
            result.Add("Editors")
            result.Add("Current User")
            result.Add("Skywalkers")
            result.Add("Nihlus")
            Return result
        End Function
        Public Function GetUserGroups() As IList(Of String) Implements DevExpress.XtraRichEdit.Services.IUserGroupListService.GetUserGroups
            Return userGroups
        End Function
    End Class
    #End Region ' #MyGroupListService
    #Region "#MyUser"
    Public Class MyUser
        Public Sub New(ByVal s As String)
            UserName = s
            Group = String.Empty
        End Sub
        Public Sub New(ByVal s1 As String, ByVal s2 As String)
            UserName = s1
            Group = s2
        End Sub
        Public Property UserName() As String
        Public Property Group() As String
    End Class
    #End Region ' #MyUser
End Namespace

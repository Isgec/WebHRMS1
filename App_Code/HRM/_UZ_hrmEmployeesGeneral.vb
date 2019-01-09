Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  Partial Public Class hrmEmployeesGeneral
    Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmEmployeesGeneral) As Int32
      Dim _Result As Integer = Update(Record)
      If _Result > 0 Then
        'Update Web User
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "UPDATE aspnet_Users SET EMailID ='" & Record.EMailID & "', Contractual = " & IIf(Record.Contractual, 1, 0) & ", MobileNo = '" & Record.ContactNumbers & "' WHERE UserName = '" & Record.CardNo & "'"
            Con.Open()
            Cmd.ExecuteNonQuery()
          End Using
        End Using
      End If
      Return _Result
    End Function
  End Class
End Namespace

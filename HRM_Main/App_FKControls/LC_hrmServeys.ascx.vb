Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

<ValidationProperty("SelectedValue")> _
Partial Class LC_hrmServeys
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Property CssClass() As String
    Get
      Return DDLhrmServeys.CssClass
    End Get
    Set(ByVal value As String)
      DDLhrmServeys.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLhrmServeys.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLhrmServeys.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorhrmServeys.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmServeys.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorhrmServeys.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmServeys.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLhrmServeys.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLhrmServeys.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLhrmServeys.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLhrmServeys.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLhrmServeys.DataTextField
    End Get
    Set(ByVal value As String)
      DDLhrmServeys.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLhrmServeys.DataValueField
    End Get
    Set(ByVal value As String)
      DDLhrmServeys.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLhrmServeys.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLhrmServeys.SelectedValue = String.Empty
      Else
        DDLhrmServeys.SelectedValue = value
      End If
    End Set
  End Property
  Public Property OrderBy() As String
    Get
      Return _OrderBy
    End Get
    Set(ByVal value As String)
      _OrderBy = value
    End Set
  End Property
  Public Property IncludeDefault() As Boolean
    Get
      Return _IncludeDefault
    End Get
    Set(ByVal value As Boolean)
      _IncludeDefault = value
    End Set
  End Property
  Public Property DefaultText() As String
    Get
      Return _DefaultText
    End Get
    Set(ByVal value As String)
      _DefaultText = value
    End Set
  End Property
  Public Property DefaultValue() As String
    Get
      Return _DefaultValue
    End Get
    Set(ByVal value As String)
      _DefaultValue = value
    End Set
  End Property
  Protected Sub OdsDdlhrmServeys_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlhrmServeys.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLhrmServeys_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmServeys.DataBinding
    If _IncludeDefault Then
      DDLhrmServeys.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLhrmServeys_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmServeys.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class

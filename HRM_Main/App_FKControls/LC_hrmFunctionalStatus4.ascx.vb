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
Partial Class LC_hrmFunctionalStatus4
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Property CssClass() As String
    Get
      Return DDLhrmFunctionalStatus4.CssClass
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus4.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLhrmFunctionalStatus4.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLhrmFunctionalStatus4.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus4.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus4.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus4.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus4.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLhrmFunctionalStatus4.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus4.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLhrmFunctionalStatus4.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus4.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLhrmFunctionalStatus4.DataTextField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus4.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLhrmFunctionalStatus4.DataValueField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus4.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLhrmFunctionalStatus4.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLhrmFunctionalStatus4.SelectedValue = String.Empty
      Else
        DDLhrmFunctionalStatus4.SelectedValue = value
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
  Protected Sub OdsDdlhrmFunctionalStatus4_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlhrmFunctionalStatus4.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLhrmFunctionalStatus4_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus4.DataBinding
    If _IncludeDefault Then
      DDLhrmFunctionalStatus4.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLhrmFunctionalStatus4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus4.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class

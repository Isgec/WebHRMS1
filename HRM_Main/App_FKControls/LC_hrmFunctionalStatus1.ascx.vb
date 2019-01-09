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
Partial Class LC_hrmFunctionalStatus1
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Property CssClass() As String
    Get
      Return DDLhrmFunctionalStatus1.CssClass
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus1.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLhrmFunctionalStatus1.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLhrmFunctionalStatus1.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus1.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus1.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus1.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus1.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLhrmFunctionalStatus1.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus1.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLhrmFunctionalStatus1.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus1.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLhrmFunctionalStatus1.DataTextField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus1.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLhrmFunctionalStatus1.DataValueField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus1.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLhrmFunctionalStatus1.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLhrmFunctionalStatus1.SelectedValue = String.Empty
      Else
        DDLhrmFunctionalStatus1.SelectedValue = value
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
  Protected Sub OdsDdlhrmFunctionalStatus1_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlhrmFunctionalStatus1.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLhrmFunctionalStatus1_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus1.DataBinding
    If _IncludeDefault Then
      DDLhrmFunctionalStatus1.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLhrmFunctionalStatus1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus1.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class

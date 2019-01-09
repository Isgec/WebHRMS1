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
Partial Class LC_hrmFunctionalStatus3
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Property CssClass() As String
    Get
      Return DDLhrmFunctionalStatus3.CssClass
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus3.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLhrmFunctionalStatus3.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLhrmFunctionalStatus3.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus3.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus3.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorhrmFunctionalStatus3.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmFunctionalStatus3.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLhrmFunctionalStatus3.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus3.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLhrmFunctionalStatus3.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLhrmFunctionalStatus3.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLhrmFunctionalStatus3.DataTextField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus3.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLhrmFunctionalStatus3.DataValueField
    End Get
    Set(ByVal value As String)
      DDLhrmFunctionalStatus3.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLhrmFunctionalStatus3.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLhrmFunctionalStatus3.SelectedValue = String.Empty
      Else
        DDLhrmFunctionalStatus3.SelectedValue = value
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
  Protected Sub OdsDdlhrmFunctionalStatus3_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlhrmFunctionalStatus3.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLhrmFunctionalStatus3_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus3.DataBinding
    If _IncludeDefault Then
      DDLhrmFunctionalStatus3.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLhrmFunctionalStatus3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmFunctionalStatus3.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class

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
Partial Class LC_hrmRatings
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public Property CssClass() As String
    Get
      Return DDLhrmRatings.CssClass
    End Get
    Set(ByVal value As String)
      DDLhrmRatings.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLhrmRatings.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLhrmRatings.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorhrmRatings.Text
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmRatings.Text = value
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorhrmRatings.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorhrmRatings.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLhrmRatings.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLhrmRatings.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLhrmRatings.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLhrmRatings.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLhrmRatings.DataTextField
    End Get
    Set(ByVal value As String)
      DDLhrmRatings.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLhrmRatings.DataValueField
    End Get
    Set(ByVal value As String)
      DDLhrmRatings.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLhrmRatings.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLhrmRatings.SelectedValue = String.Empty
      Else
        DDLhrmRatings.SelectedValue = value
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
  Protected Sub OdsDdlhrmRatings_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlhrmRatings.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLhrmRatings_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmRatings.DataBinding
    If _IncludeDefault Then
      DDLhrmRatings.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
  End Sub
  Protected Sub DDLhrmRatings_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLhrmRatings.SelectedIndexChanged
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub
End Class

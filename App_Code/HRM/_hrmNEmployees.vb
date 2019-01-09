Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmNEmployees
    Private Shared _RecordCount As Integer
    Private _CardNo As String = ""
    Private _Salute As String = ""
    Private _EmployeeName As String = ""
    Private _AliasName As String = ""
    Private _Gender As String = ""
    Private _C_DateOfJoining As String = ""
    Private _C_CompanyID As String = ""
    Private _C_DivisionID As String = ""
    Private _C_OfficeID As String = ""
    Private _C_DepartmentID As String = ""
    Private _C_ProjectSiteID As String = ""
    Private _C_DesignationID As String = ""
    Private _C_BasicSalary As String = ""
    Private _C_StatusID As String = ""
    Private _C_StatusRemark As String = ""
    Private _C_JoinngStateID As String = ""
    Private _C_RatingID As String = ""
		Private _ActiveState As Boolean = False
    Private _ActiveStateEventName As String = ""
    Private _U_UnderIncrement As Boolean = False
    Private _U_NewBasicSalary As String = ""
    Private _C_IncrementOn As String = ""
    Private _C_IncrementRemark As String = ""
    Private _U_UnderPromotion As Boolean = False
    Private _U_NewDesignationID As String = ""
    Private _C_PromotionOn As String = ""
    Private _C_PromotionRemark As String = ""
    Private _U_UnderTransfer As Boolean = False
    Private _U_CompanyID As String = ""
    Private _U_DivisionID As String = ""
    Private _U_OfficeID As String = ""
    Private _U_DepartmentID As String = ""
    Private _U_ProjectSiteID As String = ""
    Private _U_ActiveState As Boolean = False
    Private _C_TransferedOn As String = ""
    Private _C_TransferRemark As String = ""
    Private _U_UnderRating As Boolean = False
    Private _U_NewRatingID As String = ""
    Private _C_RatingDoneOn As String = ""
    Private _C_RatingPoints As String = ""
    Private _C_RatingRemark As String = ""
    Private _Resigned As Boolean = False
    Private _C_ResignedOn As String = ""
    Private _C_DateOfReleaving As String = ""
    Private _C_ResignedRemark As String = ""
    Private _Confirmed As Boolean = False
    Private _C_ConfirmedOn As String = ""
    Private _C_ConfirmationRemark As String = ""
    Private _J_CompanyID As String = ""
    Private _J_DivisionID As String = ""
    Private _J_OfficeID As String = ""
    Private _J_DepartmentID As String = ""
    Private _J_ProjectSiteID As String = ""
    Private _J_DesignationID As String = ""
    Private _J_BasicSalary As String = ""
    Private _J_StatusID As String = ""
    Private _J_StatusRemark As String = ""
    Private _WorkingAreaID As String = ""
    Private _FunctionalStatusID1 As String = ""
    Private _FunctionalStatusID2 As String = ""
    Private _FunctionalStatusID3 As String = ""
    Private _FunctionalStatusID4 As String = ""
    Private _EducationDetails As String = ""
    Private _IncrementCompany As String = ""
    Private _CareerStartedOn As String = ""
    Private _QualificationID1 As String = ""
    Private _QualificationYear1 As String = ""
    Private _QualificationID2 As String = ""
    Private _QualificationYear2 As String = ""
    Private _DateOfBirth As String = ""
    Private _BloodGroupID As String = ""
    Private _FatherName As String = ""
    Private _SpouseName As String = ""
    Private _ContactNumbers As String = ""
    Private _PermanentAddress As String = ""
    Private _PermanentCity As String = ""
    Private _CurrentAddress As String = ""
    Private _CurrentCity As String = ""
    Private _OfficeFileNumber As String = ""
    Private _PFNumber As String = ""
    Private _ESINumber As String = ""
    Private _PAN As String = ""
    Private _EMailID As String = ""
    Private _Freezed As Boolean = False
    Private _ModifiedBy As String = ""
    Private _ModifiedOn As String = ""
    Private _ModifiedEvent As String = ""
    Private _VerificationRequired As Boolean = False
    Private _VerifierID As String = ""
    Private _ApprovalRequired As Boolean = False
    Private _ApproverID As String = ""
    Private _ResponsibleAgencyID As String = ""
    Private _Contractual As Boolean = False
    Private _VPNMailExpireOn As String = ""
    Private _HRM_BloodGroups4_Description As String = ""
    Private _HRM_Companies5_Description As String = ""
    Private _HRM_Companies6_Description As String = ""
    Private _HRM_Companies7_Description As String = ""
    Private _HRM_Companies8_Description As String = ""
    Private _HRM_Departments9_Description As String = ""
    Private _HRM_Departments10_Description As String = ""
    Private _HRM_Departments11_Description As String = ""
    Private _HRM_Designations12_Description As String = ""
    Private _HRM_Designations13_Description As String = ""
    Private _HRM_Designations14_Description As String = ""
    Private _HRM_Divisions15_Description As String = ""
    Private _HRM_Divisions16_Description As String = ""
    Private _HRM_Divisions17_Description As String = ""
    Private _HRM_FunctionalStatus120_Description As String = ""
    Private _HRM_FunctionalStatus221_Description As String = ""
    Private _HRM_FunctionalStatus322_Description As String = ""
    Private _HRM_FunctionalStatus423_Description As String = ""
    Private _HRM_JoiningStates24_Description As String = ""
    Private _HRM_Offices25_Description As String = ""
    Private _HRM_Offices26_Description As String = ""
    Private _HRM_Offices27_Description As String = ""
    Private _HRM_Qualifications28_Description As String = ""
    Private _HRM_Qualifications29_Description As String = ""
    Private _HRM_Ratings30_Description As String = ""
    Private _HRM_Ratings31_Description As String = ""
    Private _HRM_Status32_Description As String = ""
    Private _HRM_Status33_Description As String = ""
    Private _HRM_WorkingAreas34_Description As String = ""
    Private _IDM_ResponsibleAgency35_Description As String = ""
    Private _IDM_Projects1_Description As String = ""
    Private _IDM_Projects2_Description As String = ""
    Private _IDM_Projects3_Description As String = ""
    Private _FK_HRM_Employees_HRM_BloodGroups As SIS.HRM.hrmBloodGroups = Nothing
    Private _FK_HRM_Employees_HRM_Companies3 As SIS.HRM.hrmCompanies = Nothing
    Private _FK_HRM_Employees_HRM_Companies1 As SIS.HRM.hrmCompanies = Nothing
    Private _FK_HRM_Employees_HRM_Companies2 As SIS.HRM.hrmCompanies = Nothing
    Private _FK_HRM_Employees_HRM_Companies As SIS.HRM.hrmCompanies = Nothing
    Private _FK_HRM_Employees_HRM_Departments2 As SIS.HRM.hrmDepartments = Nothing
    Private _FK_HRM_Employees_HRM_Departments1 As SIS.HRM.hrmDepartments = Nothing
    Private _FK_HRM_Employees_HRM_Departments As SIS.HRM.hrmDepartments = Nothing
    Private _FK_HRM_Employees_HRM_Designations2 As SIS.HRM.hrmDesignations = Nothing
    Private _FK_HRM_Employees_HRM_Designations1 As SIS.HRM.hrmDesignations = Nothing
    Private _FK_HRM_Employees_HRM_Designations As SIS.HRM.hrmDesignations = Nothing
    Private _FK_HRM_Employees_HRM_Divisions1 As SIS.HRM.hrmDivisions = Nothing
    Private _FK_HRM_Employees_HRM_Divisions As SIS.HRM.hrmDivisions = Nothing
    Private _FK_HRM_Employees_HRM_Divisions2 As SIS.HRM.hrmDivisions = Nothing
    Private _FK_HRM_Employees_HRM_Employees1 As SIS.HRM.hrmNEmployees = Nothing
    Private _FK_HRM_Employees_HRM_Employees As SIS.HRM.hrmNEmployees = Nothing
    Private _FK_HRM_Employees_HRM_FunctionalStatus1 As SIS.HRM.hrmFunctionalStatus1 = Nothing
    Private _FK_HRM_Employees_HRM_FunctionalStatus2 As SIS.HRM.hrmFunctionalStatus2 = Nothing
    Private _FK_HRM_Employees_HRM_FunctionalStatus3 As SIS.HRM.hrmFunctionalStatus3 = Nothing
    Private _FK_HRM_Employees_HRM_FunctionalStatus4 As SIS.HRM.hrmFunctionalStatus4 = Nothing
    Private _FK_HRM_Employees_HRM_JoiningStates As SIS.HRM.hrmJoiningStates = Nothing
    Private _FK_HRM_Employees_HRM_Offices As SIS.HRM.hrmOffices = Nothing
    Private _FK_HRM_Employees_HRM_Offices1 As SIS.HRM.hrmOffices = Nothing
    Private _FK_HRM_Employees_HRM_Offices2 As SIS.HRM.hrmOffices = Nothing
    Private _FK_HRM_Employees_HRM_Qualifications As SIS.HRM.hrmQualifications = Nothing
    Private _FK_HRM_Employees_HRM_Qualifications1 As SIS.HRM.hrmQualifications = Nothing
    Private _FK_HRM_Employees_HRM_Ratings As SIS.HRM.hrmRatings = Nothing
    Private _FK_HRM_Employees_HRM_Ratings1 As SIS.HRM.hrmRatings = Nothing
    Private _FK_HRM_Employees_HRM_Status1 As SIS.HRM.hrmStatus = Nothing
    Private _FK_HRM_Employees_HRM_Status As SIS.HRM.hrmStatus = Nothing
    Private _FK_HRM_Employees_HRM_WorkingAreas As SIS.HRM.hrmWorkingAreas = Nothing
    Private _FK_HRM_Employees_IDM_ResponsibleAgency As SIS.IDM.idmResponsibleAgency = Nothing
    Private _FK_HRM_C_ProjectSiteID As SIS.IDM.idmProjects = Nothing
    Private _FK_HRM_J_ProjectSiteID As SIS.IDM.idmProjects = Nothing
		Private _FK_HRM_U_ProjectSiteID As SIS.IDM.idmProjects = Nothing
		Private _Blackberry As Boolean = False
		Public Property Blackberry() As Boolean
			Get
				Return _Blackberry
			End Get
			Set(ByVal value As Boolean)
				If Convert.IsDBNull(value) Then
					_Blackberry = False
				Else
					_Blackberry = value
				End If
			End Set
		End Property
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
					mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property CardNo() As String
      Get
        Return _CardNo
      End Get
      Set(ByVal value As String)
        _CardNo = value
      End Set
    End Property
    Public Property Salute() As String
      Get
        Return _Salute
      End Get
      Set(ByVal value As String)
        _Salute = value
      End Set
    End Property
    Public Property EmployeeName() As String
      Get
        Return _EmployeeName
      End Get
      Set(ByVal value As String)
        _EmployeeName = value
      End Set
    End Property
    Public Property AliasName() As String
      Get
        Return _AliasName
      End Get
      Set(ByVal value As String)
        _AliasName = value
      End Set
    End Property
    Public Property Gender() As String
      Get
        Return _Gender
      End Get
      Set(ByVal value As String)
        _Gender = value
      End Set
    End Property
    Public Property C_DateOfJoining() As String
      Get
        If Not _C_DateOfJoining = String.Empty Then
          Return Convert.ToDateTime(_C_DateOfJoining).ToString("dd/MM/yyyy")
        End If
        Return _C_DateOfJoining
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DateOfJoining = ""
				 Else
					 _C_DateOfJoining = value
			   End If
      End Set
    End Property
    Public Property C_CompanyID() As String
      Get
        Return _C_CompanyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_CompanyID = ""
				 Else
					 _C_CompanyID = value
			   End If
      End Set
    End Property
    Public Property C_DivisionID() As String
      Get
        Return _C_DivisionID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DivisionID = ""
				 Else
					 _C_DivisionID = value
			   End If
      End Set
    End Property
    Public Property C_OfficeID() As String
      Get
        Return _C_OfficeID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_OfficeID = ""
				 Else
					 _C_OfficeID = value
			   End If
      End Set
    End Property
    Public Property C_DepartmentID() As String
      Get
        Return _C_DepartmentID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DepartmentID = ""
				 Else
					 _C_DepartmentID = value
			   End If
      End Set
    End Property
    Public Property C_ProjectSiteID() As String
      Get
        Return _C_ProjectSiteID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ProjectSiteID = ""
				 Else
					 _C_ProjectSiteID = value
			   End If
      End Set
    End Property
    Public Property C_DesignationID() As String
      Get
        Return _C_DesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DesignationID = ""
				 Else
					 _C_DesignationID = value
			   End If
      End Set
    End Property
    Public Property C_BasicSalary() As String
      Get
        Return _C_BasicSalary
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_BasicSalary = ""
				 Else
					 _C_BasicSalary = value
			   End If
      End Set
    End Property
    Public Property C_StatusID() As String
      Get
        Return _C_StatusID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_StatusID = ""
				 Else
					 _C_StatusID = value
			   End If
      End Set
    End Property
    Public Property C_StatusRemark() As String
      Get
        Return _C_StatusRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_StatusRemark = ""
				 Else
					 _C_StatusRemark = value
			   End If
      End Set
    End Property
    Public Property C_JoinngStateID() As String
      Get
        Return _C_JoinngStateID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_JoinngStateID = ""
				 Else
					 _C_JoinngStateID = value
			   End If
      End Set
    End Property
    Public Property C_RatingID() As String
      Get
        Return _C_RatingID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_RatingID = ""
				 Else
					 _C_RatingID = value
			   End If
      End Set
    End Property
		Public Property ActiveState() As Boolean
			Get
				Return _ActiveState
			End Get
			Set(ByVal value As Boolean)
				If Convert.IsDBNull(value) Then
					_ActiveState = False
				Else
					_ActiveState = value
				End If
			End Set
		End Property
    Public Property ActiveStateEventName() As String
      Get
        Return _ActiveStateEventName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ActiveStateEventName = ""
				 Else
					 _ActiveStateEventName = value
			   End If
      End Set
    End Property
    Public Property U_UnderIncrement() As Boolean
      Get
        Return _U_UnderIncrement
      End Get
      Set(ByVal value As Boolean)
        _U_UnderIncrement = value
      End Set
    End Property
    Public Property U_NewBasicSalary() As String
      Get
        Return _U_NewBasicSalary
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_NewBasicSalary = ""
				 Else
					 _U_NewBasicSalary = value
			   End If
      End Set
    End Property
    Public Property C_IncrementOn() As String
      Get
        If Not _C_IncrementOn = String.Empty Then
          Return Convert.ToDateTime(_C_IncrementOn).ToString("dd/MM/yyyy")
        End If
        Return _C_IncrementOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_IncrementOn = ""
				 Else
					 _C_IncrementOn = value
			   End If
      End Set
    End Property
    Public Property C_IncrementRemark() As String
      Get
        Return _C_IncrementRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_IncrementRemark = ""
				 Else
					 _C_IncrementRemark = value
			   End If
      End Set
    End Property
    Public Property U_UnderPromotion() As Boolean
      Get
        Return _U_UnderPromotion
      End Get
      Set(ByVal value As Boolean)
        _U_UnderPromotion = value
      End Set
    End Property
    Public Property U_NewDesignationID() As String
      Get
        Return _U_NewDesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_NewDesignationID = ""
				 Else
					 _U_NewDesignationID = value
			   End If
      End Set
    End Property
    Public Property C_PromotionOn() As String
      Get
        If Not _C_PromotionOn = String.Empty Then
          Return Convert.ToDateTime(_C_PromotionOn).ToString("dd/MM/yyyy")
        End If
        Return _C_PromotionOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_PromotionOn = ""
				 Else
					 _C_PromotionOn = value
			   End If
      End Set
    End Property
    Public Property C_PromotionRemark() As String
      Get
        Return _C_PromotionRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_PromotionRemark = ""
				 Else
					 _C_PromotionRemark = value
			   End If
      End Set
    End Property
    Public Property U_UnderTransfer() As Boolean
      Get
        Return _U_UnderTransfer
      End Get
      Set(ByVal value As Boolean)
        _U_UnderTransfer = value
      End Set
    End Property
    Public Property U_CompanyID() As String
      Get
        Return _U_CompanyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_CompanyID = ""
				 Else
					 _U_CompanyID = value
			   End If
      End Set
    End Property
    Public Property U_DivisionID() As String
      Get
        Return _U_DivisionID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_DivisionID = ""
				 Else
					 _U_DivisionID = value
			   End If
      End Set
    End Property
    Public Property U_OfficeID() As String
      Get
        Return _U_OfficeID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_OfficeID = ""
				 Else
					 _U_OfficeID = value
			   End If
      End Set
    End Property
    Public Property U_DepartmentID() As String
      Get
        Return _U_DepartmentID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_DepartmentID = ""
				 Else
					 _U_DepartmentID = value
			   End If
      End Set
    End Property
    Public Property U_ProjectSiteID() As String
      Get
        Return _U_ProjectSiteID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_ProjectSiteID = ""
				 Else
					 _U_ProjectSiteID = value
			   End If
      End Set
    End Property
    Public Property U_ActiveState() As Boolean
      Get
        Return _U_ActiveState
      End Get
      Set(ByVal value As Boolean)
        _U_ActiveState = value
      End Set
    End Property
    Public Property C_TransferedOn() As String
      Get
        If Not _C_TransferedOn = String.Empty Then
          Return Convert.ToDateTime(_C_TransferedOn).ToString("dd/MM/yyyy")
        End If
        Return _C_TransferedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_TransferedOn = ""
				 Else
					 _C_TransferedOn = value
			   End If
      End Set
    End Property
    Public Property C_TransferRemark() As String
      Get
        Return _C_TransferRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_TransferRemark = ""
				 Else
					 _C_TransferRemark = value
			   End If
      End Set
    End Property
    Public Property U_UnderRating() As Boolean
      Get
        Return _U_UnderRating
      End Get
      Set(ByVal value As Boolean)
        _U_UnderRating = value
      End Set
    End Property
    Public Property U_NewRatingID() As String
      Get
        Return _U_NewRatingID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_NewRatingID = ""
				 Else
					 _U_NewRatingID = value
			   End If
      End Set
    End Property
    Public Property C_RatingDoneOn() As String
      Get
        If Not _C_RatingDoneOn = String.Empty Then
          Return Convert.ToDateTime(_C_RatingDoneOn).ToString("dd/MM/yyyy")
        End If
        Return _C_RatingDoneOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_RatingDoneOn = ""
				 Else
					 _C_RatingDoneOn = value
			   End If
      End Set
    End Property
    Public Property C_RatingPoints() As String
      Get
        Return _C_RatingPoints
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_RatingPoints = ""
				 Else
					 _C_RatingPoints = value
			   End If
      End Set
    End Property
    Public Property C_RatingRemark() As String
      Get
        Return _C_RatingRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_RatingRemark = ""
				 Else
					 _C_RatingRemark = value
			   End If
      End Set
    End Property
    Public Property Resigned() As Boolean
      Get
        Return _Resigned
      End Get
      Set(ByVal value As Boolean)
        _Resigned = value
      End Set
    End Property
    Public Property C_ResignedOn() As String
      Get
        If Not _C_ResignedOn = String.Empty Then
          Return Convert.ToDateTime(_C_ResignedOn).ToString("dd/MM/yyyy")
        End If
        Return _C_ResignedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ResignedOn = ""
				 Else
					 _C_ResignedOn = value
			   End If
      End Set
    End Property
    Public Property C_DateOfReleaving() As String
      Get
        If Not _C_DateOfReleaving = String.Empty Then
          Return Convert.ToDateTime(_C_DateOfReleaving).ToString("dd/MM/yyyy")
        End If
        Return _C_DateOfReleaving
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DateOfReleaving = ""
				 Else
					 _C_DateOfReleaving = value
			   End If
      End Set
    End Property
    Public Property C_ResignedRemark() As String
      Get
        Return _C_ResignedRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ResignedRemark = ""
				 Else
					 _C_ResignedRemark = value
			   End If
      End Set
    End Property
    Public Property Confirmed() As Boolean
      Get
        Return _Confirmed
      End Get
      Set(ByVal value As Boolean)
        _Confirmed = value
      End Set
    End Property
    Public Property C_ConfirmedOn() As String
      Get
        If Not _C_ConfirmedOn = String.Empty Then
          Return Convert.ToDateTime(_C_ConfirmedOn).ToString("dd/MM/yyyy")
        End If
        Return _C_ConfirmedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ConfirmedOn = ""
				 Else
					 _C_ConfirmedOn = value
			   End If
      End Set
    End Property
    Public Property C_ConfirmationRemark() As String
      Get
        Return _C_ConfirmationRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ConfirmationRemark = ""
				 Else
					 _C_ConfirmationRemark = value
			   End If
      End Set
    End Property
    Public Property J_CompanyID() As String
      Get
        Return _J_CompanyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_CompanyID = ""
				 Else
					 _J_CompanyID = value
			   End If
      End Set
    End Property
    Public Property J_DivisionID() As String
      Get
        Return _J_DivisionID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DivisionID = ""
				 Else
					 _J_DivisionID = value
			   End If
      End Set
    End Property
    Public Property J_OfficeID() As String
      Get
        Return _J_OfficeID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_OfficeID = ""
				 Else
					 _J_OfficeID = value
			   End If
      End Set
    End Property
    Public Property J_DepartmentID() As String
      Get
        Return _J_DepartmentID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DepartmentID = ""
				 Else
					 _J_DepartmentID = value
			   End If
      End Set
    End Property
    Public Property J_ProjectSiteID() As String
      Get
        Return _J_ProjectSiteID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_ProjectSiteID = ""
				 Else
					 _J_ProjectSiteID = value
			   End If
      End Set
    End Property
    Public Property J_DesignationID() As String
      Get
        Return _J_DesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DesignationID = ""
				 Else
					 _J_DesignationID = value
			   End If
      End Set
    End Property
    Public Property J_BasicSalary() As String
      Get
        Return _J_BasicSalary
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_BasicSalary = ""
				 Else
					 _J_BasicSalary = value
			   End If
      End Set
    End Property
    Public Property J_StatusID() As String
      Get
        Return _J_StatusID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_StatusID = ""
				 Else
					 _J_StatusID = value
			   End If
      End Set
    End Property
    Public Property J_StatusRemark() As String
      Get
        Return _J_StatusRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_StatusRemark = ""
				 Else
					 _J_StatusRemark = value
			   End If
      End Set
    End Property
    Public Property WorkingAreaID() As String
      Get
        Return _WorkingAreaID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _WorkingAreaID = ""
				 Else
					 _WorkingAreaID = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID1() As String
      Get
        Return _FunctionalStatusID1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID1 = ""
				 Else
					 _FunctionalStatusID1 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID2() As String
      Get
        Return _FunctionalStatusID2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID2 = ""
				 Else
					 _FunctionalStatusID2 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID3() As String
      Get
        Return _FunctionalStatusID3
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID3 = ""
				 Else
					 _FunctionalStatusID3 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID4() As String
      Get
        Return _FunctionalStatusID4
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID4 = ""
				 Else
					 _FunctionalStatusID4 = value
			   End If
      End Set
    End Property
    Public Property EducationDetails() As String
      Get
        Return _EducationDetails
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EducationDetails = ""
				 Else
					 _EducationDetails = value
			   End If
      End Set
    End Property
    Public Property IncrementCompany() As String
      Get
        Return _IncrementCompany
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _IncrementCompany = ""
				 Else
					 _IncrementCompany = value
			   End If
      End Set
    End Property
    Public Property CareerStartedOn() As String
      Get
        If Not _CareerStartedOn = String.Empty Then
          Return Convert.ToDateTime(_CareerStartedOn).ToString("dd/MM/yyyy")
        End If
        Return _CareerStartedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CareerStartedOn = ""
				 Else
					 _CareerStartedOn = value
			   End If
      End Set
    End Property
    Public Property QualificationID1() As String
      Get
        Return _QualificationID1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationID1 = ""
				 Else
					 _QualificationID1 = value
			   End If
      End Set
    End Property
    Public Property QualificationYear1() As String
      Get
        Return _QualificationYear1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationYear1 = ""
				 Else
					 _QualificationYear1 = value
			   End If
      End Set
    End Property
    Public Property QualificationID2() As String
      Get
        Return _QualificationID2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationID2 = ""
				 Else
					 _QualificationID2 = value
			   End If
      End Set
    End Property
    Public Property QualificationYear2() As String
      Get
        Return _QualificationYear2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationYear2 = ""
				 Else
					 _QualificationYear2 = value
			   End If
      End Set
    End Property
    Public Property DateOfBirth() As String
      Get
        If Not _DateOfBirth = String.Empty Then
          Return Convert.ToDateTime(_DateOfBirth).ToString("dd/MM/yyyy")
        End If
        Return _DateOfBirth
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _DateOfBirth = ""
				 Else
					 _DateOfBirth = value
			   End If
      End Set
    End Property
    Public Property BloodGroupID() As String
      Get
        Return _BloodGroupID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _BloodGroupID = ""
				 Else
					 _BloodGroupID = value
			   End If
      End Set
    End Property
    Public Property FatherName() As String
      Get
        Return _FatherName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FatherName = ""
				 Else
					 _FatherName = value
			   End If
      End Set
    End Property
    Public Property SpouseName() As String
      Get
        Return _SpouseName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _SpouseName = ""
				 Else
					 _SpouseName = value
			   End If
      End Set
    End Property
    Public Property ContactNumbers() As String
      Get
        Return _ContactNumbers
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactNumbers = ""
				 Else
					 _ContactNumbers = value
			   End If
      End Set
    End Property
    Public Property PermanentAddress() As String
      Get
        Return _PermanentAddress
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PermanentAddress = ""
				 Else
					 _PermanentAddress = value
			   End If
      End Set
    End Property
    Public Property PermanentCity() As String
      Get
        Return _PermanentCity
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PermanentCity = ""
				 Else
					 _PermanentCity = value
			   End If
      End Set
    End Property
    Public Property CurrentAddress() As String
      Get
        Return _CurrentAddress
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CurrentAddress = ""
				 Else
					 _CurrentAddress = value
			   End If
      End Set
    End Property
    Public Property CurrentCity() As String
      Get
        Return _CurrentCity
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CurrentCity = ""
				 Else
					 _CurrentCity = value
			   End If
      End Set
    End Property
    Public Property OfficeFileNumber() As String
      Get
        Return _OfficeFileNumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _OfficeFileNumber = ""
				 Else
					 _OfficeFileNumber = value
			   End If
      End Set
    End Property
    Public Property PFNumber() As String
      Get
        Return _PFNumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PFNumber = ""
				 Else
					 _PFNumber = value
			   End If
      End Set
    End Property
    Public Property ESINumber() As String
      Get
        Return _ESINumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ESINumber = ""
				 Else
					 _ESINumber = value
			   End If
      End Set
    End Property
    Public Property PAN() As String
      Get
        Return _PAN
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PAN = ""
				 Else
					 _PAN = value
			   End If
      End Set
    End Property
    Public Property EMailID() As String
      Get
        Return _EMailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EMailID = ""
				 Else
					 _EMailID = value
			   End If
      End Set
    End Property
    Public Property Freezed() As Boolean
      Get
        Return _Freezed
      End Get
      Set(ByVal value As Boolean)
        _Freezed = value
      End Set
    End Property
    Public Property ModifiedBy() As String
      Get
        Return _ModifiedBy
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedBy = ""
				 Else
					 _ModifiedBy = value
			   End If
      End Set
    End Property
    Public Property ModifiedOn() As String
      Get
        If Not _ModifiedOn = String.Empty Then
          Return Convert.ToDateTime(_ModifiedOn).ToString("dd/MM/yyyy")
        End If
        Return _ModifiedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedOn = ""
				 Else
					 _ModifiedOn = value
			   End If
      End Set
    End Property
    Public Property ModifiedEvent() As String
      Get
        Return _ModifiedEvent
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedEvent = ""
				 Else
					 _ModifiedEvent = value
			   End If
      End Set
    End Property
    Public Property VerificationRequired() As Boolean
      Get
        Return _VerificationRequired
      End Get
      Set(ByVal value As Boolean)
        _VerificationRequired = value
      End Set
    End Property
    Public Property VerifierID() As String
      Get
        Return _VerifierID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _VerifierID = ""
				 Else
					 _VerifierID = value
			   End If
      End Set
    End Property
    Public Property ApprovalRequired() As Boolean
      Get
        Return _ApprovalRequired
      End Get
      Set(ByVal value As Boolean)
        _ApprovalRequired = value
      End Set
    End Property
    Public Property ApproverID() As String
      Get
        Return _ApproverID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ApproverID = ""
				 Else
					 _ApproverID = value
			   End If
      End Set
    End Property
    Public Property ResponsibleAgencyID() As String
      Get
        Return _ResponsibleAgencyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ResponsibleAgencyID = ""
				 Else
					 _ResponsibleAgencyID = value
			   End If
      End Set
    End Property
    Public Property Contractual() As Boolean
      Get
        Return _Contractual
      End Get
      Set(ByVal value As Boolean)
        _Contractual = value
      End Set
    End Property
    Public Property VPNMailExpireOn() As String
      Get
        If Not _VPNMailExpireOn = String.Empty Then
          Return Convert.ToDateTime(_VPNMailExpireOn).ToString("dd/MM/yyyy")
        End If
        Return _VPNMailExpireOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _VPNMailExpireOn = ""
				 Else
					 _VPNMailExpireOn = value
			   End If
      End Set
    End Property
    Public Property HRM_BloodGroups4_Description() As String
      Get
        Return _HRM_BloodGroups4_Description
      End Get
      Set(ByVal value As String)
        _HRM_BloodGroups4_Description = value
      End Set
    End Property
    Public Property HRM_Companies5_Description() As String
      Get
        Return _HRM_Companies5_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies5_Description = value
      End Set
    End Property
    Public Property HRM_Companies6_Description() As String
      Get
        Return _HRM_Companies6_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies6_Description = value
      End Set
    End Property
    Public Property HRM_Companies7_Description() As String
      Get
        Return _HRM_Companies7_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies7_Description = value
      End Set
    End Property
    Public Property HRM_Companies8_Description() As String
      Get
        Return _HRM_Companies8_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies8_Description = value
      End Set
    End Property
    Public Property HRM_Departments9_Description() As String
      Get
        Return _HRM_Departments9_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments9_Description = value
      End Set
    End Property
    Public Property HRM_Departments10_Description() As String
      Get
        Return _HRM_Departments10_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments10_Description = value
      End Set
    End Property
    Public Property HRM_Departments11_Description() As String
      Get
        Return _HRM_Departments11_Description
      End Get
      Set(ByVal value As String)
        _HRM_Departments11_Description = value
      End Set
    End Property
    Public Property HRM_Designations12_Description() As String
      Get
        Return _HRM_Designations12_Description
      End Get
      Set(ByVal value As String)
        _HRM_Designations12_Description = value
      End Set
    End Property
    Public Property HRM_Designations13_Description() As String
      Get
        Return _HRM_Designations13_Description
      End Get
      Set(ByVal value As String)
        _HRM_Designations13_Description = value
      End Set
    End Property
    Public Property HRM_Designations14_Description() As String
      Get
        Return _HRM_Designations14_Description
      End Get
      Set(ByVal value As String)
        _HRM_Designations14_Description = value
      End Set
    End Property
    Public Property HRM_Divisions15_Description() As String
      Get
        Return _HRM_Divisions15_Description
      End Get
      Set(ByVal value As String)
        _HRM_Divisions15_Description = value
      End Set
    End Property
    Public Property HRM_Divisions16_Description() As String
      Get
        Return _HRM_Divisions16_Description
      End Get
      Set(ByVal value As String)
        _HRM_Divisions16_Description = value
      End Set
    End Property
    Public Property HRM_Divisions17_Description() As String
      Get
        Return _HRM_Divisions17_Description
      End Get
      Set(ByVal value As String)
        _HRM_Divisions17_Description = value
      End Set
    End Property
    Public Property HRM_FunctionalStatus120_Description() As String
      Get
        Return _HRM_FunctionalStatus120_Description
      End Get
      Set(ByVal value As String)
        _HRM_FunctionalStatus120_Description = value
      End Set
    End Property
    Public Property HRM_FunctionalStatus221_Description() As String
      Get
        Return _HRM_FunctionalStatus221_Description
      End Get
      Set(ByVal value As String)
        _HRM_FunctionalStatus221_Description = value
      End Set
    End Property
    Public Property HRM_FunctionalStatus322_Description() As String
      Get
        Return _HRM_FunctionalStatus322_Description
      End Get
      Set(ByVal value As String)
        _HRM_FunctionalStatus322_Description = value
      End Set
    End Property
    Public Property HRM_FunctionalStatus423_Description() As String
      Get
        Return _HRM_FunctionalStatus423_Description
      End Get
      Set(ByVal value As String)
        _HRM_FunctionalStatus423_Description = value
      End Set
    End Property
    Public Property HRM_JoiningStates24_Description() As String
      Get
        Return _HRM_JoiningStates24_Description
      End Get
      Set(ByVal value As String)
        _HRM_JoiningStates24_Description = value
      End Set
    End Property
    Public Property HRM_Offices25_Description() As String
      Get
        Return _HRM_Offices25_Description
      End Get
      Set(ByVal value As String)
        _HRM_Offices25_Description = value
      End Set
    End Property
    Public Property HRM_Offices26_Description() As String
      Get
        Return _HRM_Offices26_Description
      End Get
      Set(ByVal value As String)
        _HRM_Offices26_Description = value
      End Set
    End Property
    Public Property HRM_Offices27_Description() As String
      Get
        Return _HRM_Offices27_Description
      End Get
      Set(ByVal value As String)
        _HRM_Offices27_Description = value
      End Set
    End Property
    Public Property HRM_Qualifications28_Description() As String
      Get
        Return _HRM_Qualifications28_Description
      End Get
      Set(ByVal value As String)
        _HRM_Qualifications28_Description = value
      End Set
    End Property
    Public Property HRM_Qualifications29_Description() As String
      Get
        Return _HRM_Qualifications29_Description
      End Get
      Set(ByVal value As String)
        _HRM_Qualifications29_Description = value
      End Set
    End Property
    Public Property HRM_Ratings30_Description() As String
      Get
        Return _HRM_Ratings30_Description
      End Get
      Set(ByVal value As String)
        _HRM_Ratings30_Description = value
      End Set
    End Property
    Public Property HRM_Ratings31_Description() As String
      Get
        Return _HRM_Ratings31_Description
      End Get
      Set(ByVal value As String)
        _HRM_Ratings31_Description = value
      End Set
    End Property
    Public Property HRM_Status32_Description() As String
      Get
        Return _HRM_Status32_Description
      End Get
      Set(ByVal value As String)
        _HRM_Status32_Description = value
      End Set
    End Property
    Public Property HRM_Status33_Description() As String
      Get
        Return _HRM_Status33_Description
      End Get
      Set(ByVal value As String)
        _HRM_Status33_Description = value
      End Set
    End Property
    Public Property HRM_WorkingAreas34_Description() As String
      Get
        Return _HRM_WorkingAreas34_Description
      End Get
      Set(ByVal value As String)
        _HRM_WorkingAreas34_Description = value
      End Set
    End Property
    Public Property IDM_ResponsibleAgency35_Description() As String
      Get
        Return _IDM_ResponsibleAgency35_Description
      End Get
      Set(ByVal value As String)
        _IDM_ResponsibleAgency35_Description = value
      End Set
    End Property
    Public Property IDM_Projects1_Description() As String
      Get
        Return _IDM_Projects1_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects1_Description = value
      End Set
    End Property
    Public Property IDM_Projects2_Description() As String
      Get
        Return _IDM_Projects2_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects2_Description = value
      End Set
    End Property
    Public Property IDM_Projects3_Description() As String
      Get
        Return _IDM_Projects3_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects3_Description = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _CardNo
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKhrmNEmployees
			Private _CardNo As String = ""
			Public Property CardNo() As String
				Get
					Return _CardNo
				End Get
				Set(ByVal value As String)
					_CardNo = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_HRM_Employees_HRM_BloodGroups() As SIS.HRM.hrmBloodGroups
      Get
        If _FK_HRM_Employees_HRM_BloodGroups Is Nothing Then
          _FK_HRM_Employees_HRM_BloodGroups = SIS.HRM.hrmBloodGroups.GetByID(_BloodGroupID)
        End If
        Return _FK_HRM_Employees_HRM_BloodGroups
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Companies3() As SIS.HRM.hrmCompanies
      Get
        If _FK_HRM_Employees_HRM_Companies3 Is Nothing Then
          _FK_HRM_Employees_HRM_Companies3 = SIS.HRM.hrmCompanies.GetByID(_U_CompanyID)
        End If
        Return _FK_HRM_Employees_HRM_Companies3
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Companies1() As SIS.HRM.hrmCompanies
      Get
        If _FK_HRM_Employees_HRM_Companies1 Is Nothing Then
          _FK_HRM_Employees_HRM_Companies1 = SIS.HRM.hrmCompanies.GetByID(_IncrementCompany)
        End If
        Return _FK_HRM_Employees_HRM_Companies1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Companies2() As SIS.HRM.hrmCompanies
      Get
        If _FK_HRM_Employees_HRM_Companies2 Is Nothing Then
          _FK_HRM_Employees_HRM_Companies2 = SIS.HRM.hrmCompanies.GetByID(_J_CompanyID)
        End If
        Return _FK_HRM_Employees_HRM_Companies2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _FK_HRM_Employees_HRM_Companies Is Nothing Then
          _FK_HRM_Employees_HRM_Companies = SIS.HRM.hrmCompanies.GetByID(_C_CompanyID)
        End If
        Return _FK_HRM_Employees_HRM_Companies
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Departments2() As SIS.HRM.hrmDepartments
      Get
        If _FK_HRM_Employees_HRM_Departments2 Is Nothing Then
          _FK_HRM_Employees_HRM_Departments2 = SIS.HRM.hrmDepartments.GetByID(_U_DepartmentID)
        End If
        Return _FK_HRM_Employees_HRM_Departments2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Departments1() As SIS.HRM.hrmDepartments
      Get
        If _FK_HRM_Employees_HRM_Departments1 Is Nothing Then
          _FK_HRM_Employees_HRM_Departments1 = SIS.HRM.hrmDepartments.GetByID(_J_DepartmentID)
        End If
        Return _FK_HRM_Employees_HRM_Departments1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _FK_HRM_Employees_HRM_Departments Is Nothing Then
          _FK_HRM_Employees_HRM_Departments = SIS.HRM.hrmDepartments.GetByID(_C_DepartmentID)
        End If
        Return _FK_HRM_Employees_HRM_Departments
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Designations2() As SIS.HRM.hrmDesignations
      Get
        If _FK_HRM_Employees_HRM_Designations2 Is Nothing Then
          _FK_HRM_Employees_HRM_Designations2 = SIS.HRM.hrmDesignations.GetByID(_U_NewDesignationID)
        End If
        Return _FK_HRM_Employees_HRM_Designations2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Designations1() As SIS.HRM.hrmDesignations
      Get
        If _FK_HRM_Employees_HRM_Designations1 Is Nothing Then
          _FK_HRM_Employees_HRM_Designations1 = SIS.HRM.hrmDesignations.GetByID(_J_DesignationID)
        End If
        Return _FK_HRM_Employees_HRM_Designations1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _FK_HRM_Employees_HRM_Designations Is Nothing Then
          _FK_HRM_Employees_HRM_Designations = SIS.HRM.hrmDesignations.GetByID(_C_DesignationID)
        End If
        Return _FK_HRM_Employees_HRM_Designations
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Divisions1() As SIS.HRM.hrmDivisions
      Get
        If _FK_HRM_Employees_HRM_Divisions1 Is Nothing Then
          _FK_HRM_Employees_HRM_Divisions1 = SIS.HRM.hrmDivisions.GetByID(_J_DivisionID)
        End If
        Return _FK_HRM_Employees_HRM_Divisions1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _FK_HRM_Employees_HRM_Divisions Is Nothing Then
          _FK_HRM_Employees_HRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_C_DivisionID)
        End If
        Return _FK_HRM_Employees_HRM_Divisions
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Divisions2() As SIS.HRM.hrmDivisions
      Get
        If _FK_HRM_Employees_HRM_Divisions2 Is Nothing Then
          _FK_HRM_Employees_HRM_Divisions2 = SIS.HRM.hrmDivisions.GetByID(_U_DivisionID)
        End If
        Return _FK_HRM_Employees_HRM_Divisions2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Employees1() As SIS.HRM.hrmNEmployees
      Get
        If _FK_HRM_Employees_HRM_Employees1 Is Nothing Then
          _FK_HRM_Employees_HRM_Employees1 = SIS.HRM.hrmNEmployees.GetByID(_ApproverID)
        End If
        Return _FK_HRM_Employees_HRM_Employees1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Employees() As SIS.HRM.hrmNEmployees
      Get
        If _FK_HRM_Employees_HRM_Employees Is Nothing Then
          _FK_HRM_Employees_HRM_Employees = SIS.HRM.hrmNEmployees.GetByID(_VerifierID)
        End If
        Return _FK_HRM_Employees_HRM_Employees
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_FunctionalStatus1() As SIS.HRM.hrmFunctionalStatus1
      Get
        If _FK_HRM_Employees_HRM_FunctionalStatus1 Is Nothing Then
          _FK_HRM_Employees_HRM_FunctionalStatus1 = SIS.HRM.hrmFunctionalStatus1.GetByID(_FunctionalStatusID1)
        End If
        Return _FK_HRM_Employees_HRM_FunctionalStatus1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_FunctionalStatus2() As SIS.HRM.hrmFunctionalStatus2
      Get
        If _FK_HRM_Employees_HRM_FunctionalStatus2 Is Nothing Then
          _FK_HRM_Employees_HRM_FunctionalStatus2 = SIS.HRM.hrmFunctionalStatus2.GetByID(_FunctionalStatusID2)
        End If
        Return _FK_HRM_Employees_HRM_FunctionalStatus2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_FunctionalStatus3() As SIS.HRM.hrmFunctionalStatus3
      Get
        If _FK_HRM_Employees_HRM_FunctionalStatus3 Is Nothing Then
          _FK_HRM_Employees_HRM_FunctionalStatus3 = SIS.HRM.hrmFunctionalStatus3.GetByID(_FunctionalStatusID3)
        End If
        Return _FK_HRM_Employees_HRM_FunctionalStatus3
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_FunctionalStatus4() As SIS.HRM.hrmFunctionalStatus4
      Get
        If _FK_HRM_Employees_HRM_FunctionalStatus4 Is Nothing Then
          _FK_HRM_Employees_HRM_FunctionalStatus4 = SIS.HRM.hrmFunctionalStatus4.GetByID(_FunctionalStatusID4)
        End If
        Return _FK_HRM_Employees_HRM_FunctionalStatus4
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_JoiningStates() As SIS.HRM.hrmJoiningStates
      Get
        If _FK_HRM_Employees_HRM_JoiningStates Is Nothing Then
          _FK_HRM_Employees_HRM_JoiningStates = SIS.HRM.hrmJoiningStates.GetByID(_C_JoinngStateID)
        End If
        Return _FK_HRM_Employees_HRM_JoiningStates
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _FK_HRM_Employees_HRM_Offices Is Nothing Then
          _FK_HRM_Employees_HRM_Offices = SIS.HRM.hrmOffices.GetByID(_C_OfficeID)
        End If
        Return _FK_HRM_Employees_HRM_Offices
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Offices1() As SIS.HRM.hrmOffices
      Get
        If _FK_HRM_Employees_HRM_Offices1 Is Nothing Then
          _FK_HRM_Employees_HRM_Offices1 = SIS.HRM.hrmOffices.GetByID(_J_OfficeID)
        End If
        Return _FK_HRM_Employees_HRM_Offices1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Offices2() As SIS.HRM.hrmOffices
      Get
        If _FK_HRM_Employees_HRM_Offices2 Is Nothing Then
          _FK_HRM_Employees_HRM_Offices2 = SIS.HRM.hrmOffices.GetByID(_U_OfficeID)
        End If
        Return _FK_HRM_Employees_HRM_Offices2
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Qualifications() As SIS.HRM.hrmQualifications
      Get
        If _FK_HRM_Employees_HRM_Qualifications Is Nothing Then
          _FK_HRM_Employees_HRM_Qualifications = SIS.HRM.hrmQualifications.GetByID(_QualificationID1)
        End If
        Return _FK_HRM_Employees_HRM_Qualifications
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Qualifications1() As SIS.HRM.hrmQualifications
      Get
        If _FK_HRM_Employees_HRM_Qualifications1 Is Nothing Then
          _FK_HRM_Employees_HRM_Qualifications1 = SIS.HRM.hrmQualifications.GetByID(_QualificationID2)
        End If
        Return _FK_HRM_Employees_HRM_Qualifications1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Ratings() As SIS.HRM.hrmRatings
      Get
        If _FK_HRM_Employees_HRM_Ratings Is Nothing Then
          _FK_HRM_Employees_HRM_Ratings = SIS.HRM.hrmRatings.GetByID(_C_RatingID)
        End If
        Return _FK_HRM_Employees_HRM_Ratings
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Ratings1() As SIS.HRM.hrmRatings
      Get
        If _FK_HRM_Employees_HRM_Ratings1 Is Nothing Then
          _FK_HRM_Employees_HRM_Ratings1 = SIS.HRM.hrmRatings.GetByID(_U_NewRatingID)
        End If
        Return _FK_HRM_Employees_HRM_Ratings1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Status1() As SIS.HRM.hrmStatus
      Get
        If _FK_HRM_Employees_HRM_Status1 Is Nothing Then
          _FK_HRM_Employees_HRM_Status1 = SIS.HRM.hrmStatus.GetByID(_J_StatusID)
        End If
        Return _FK_HRM_Employees_HRM_Status1
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Status() As SIS.HRM.hrmStatus
      Get
        If _FK_HRM_Employees_HRM_Status Is Nothing Then
          _FK_HRM_Employees_HRM_Status = SIS.HRM.hrmStatus.GetByID(_C_StatusID)
        End If
        Return _FK_HRM_Employees_HRM_Status
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_WorkingAreas() As SIS.HRM.hrmWorkingAreas
      Get
        If _FK_HRM_Employees_HRM_WorkingAreas Is Nothing Then
          _FK_HRM_Employees_HRM_WorkingAreas = SIS.HRM.hrmWorkingAreas.GetByID(_WorkingAreaID)
        End If
        Return _FK_HRM_Employees_HRM_WorkingAreas
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_IDM_ResponsibleAgency() As SIS.IDM.idmResponsibleAgency
      Get
        If _FK_HRM_Employees_IDM_ResponsibleAgency Is Nothing Then
          _FK_HRM_Employees_IDM_ResponsibleAgency = SIS.IDM.idmResponsibleAgency.GetByID(_ResponsibleAgencyID)
        End If
        Return _FK_HRM_Employees_IDM_ResponsibleAgency
      End Get
    End Property
    Public ReadOnly Property FK_HRM_C_ProjectSiteID() As SIS.IDM.idmProjects
      Get
        If _FK_HRM_C_ProjectSiteID Is Nothing Then
          _FK_HRM_C_ProjectSiteID = SIS.IDM.idmProjects.GetByID(_C_ProjectSiteID)
        End If
        Return _FK_HRM_C_ProjectSiteID
      End Get
    End Property
    Public ReadOnly Property FK_HRM_J_ProjectSiteID() As SIS.IDM.idmProjects
      Get
        If _FK_HRM_J_ProjectSiteID Is Nothing Then
          _FK_HRM_J_ProjectSiteID = SIS.IDM.idmProjects.GetByID(_J_ProjectSiteID)
        End If
        Return _FK_HRM_J_ProjectSiteID
      End Get
    End Property
    Public ReadOnly Property FK_HRM_U_ProjectSiteID() As SIS.IDM.idmProjects
      Get
        If _FK_HRM_U_ProjectSiteID Is Nothing Then
          _FK_HRM_U_ProjectSiteID = SIS.IDM.idmProjects.GetByID(_U_ProjectSiteID)
        End If
        Return _FK_HRM_U_ProjectSiteID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetNewRecord() As SIS.HRM.hrmNEmployees
      Return New SIS.HRM.hrmNEmployees()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmNEmployees
      Dim Results As SIS.HRM.hrmNEmployees = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNEmployeesSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmNEmployees(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmNEmployees)
      Dim Results As List(Of SIS.HRM.hrmNEmployees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmNEmployeesSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmNEmployeesSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmNEmployees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmNEmployees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.hrmNEmployees) As SIS.HRM.hrmNEmployees
      Dim _Rec As SIS.HRM.hrmNEmployees = SIS.HRM.hrmNEmployees.GetNewRecord()
      With _Rec
        .CardNo = Record.CardNo
        .Salute = Record.Salute
        .EmployeeName = Record.EmployeeName
        .AliasName = Record.AliasName
        .Gender = Record.Gender
        .C_DateOfJoining = Record.C_DateOfJoining
        .C_CompanyID = Record.C_CompanyID
        .C_DivisionID = Record.C_DivisionID
        .C_OfficeID = Record.C_OfficeID
        .C_DepartmentID = Record.C_DepartmentID
        .C_ProjectSiteID = Record.C_ProjectSiteID
        .C_DesignationID = Record.C_DesignationID
        .C_BasicSalary = Record.C_BasicSalary
        .C_StatusID = Record.C_StatusID
        .C_StatusRemark = Record.C_StatusRemark
        .C_JoinngStateID = Record.C_JoinngStateID
        .C_RatingID = Record.C_RatingID
        .ActiveState = Record.ActiveState
        .ActiveStateEventName = Record.ActiveStateEventName
        .U_UnderIncrement = Record.U_UnderIncrement
        .U_NewBasicSalary = Record.U_NewBasicSalary
        .C_IncrementOn = Record.C_IncrementOn
        .C_IncrementRemark = Record.C_IncrementRemark
        .U_UnderPromotion = Record.U_UnderPromotion
        .U_NewDesignationID = Record.U_NewDesignationID
        .C_PromotionOn = Record.C_PromotionOn
        .C_PromotionRemark = Record.C_PromotionRemark
        .U_UnderTransfer = Record.U_UnderTransfer
        .U_CompanyID = Record.U_CompanyID
        .U_DivisionID = Record.U_DivisionID
        .U_OfficeID = Record.U_OfficeID
        .U_DepartmentID = Record.U_DepartmentID
        .U_ProjectSiteID = Record.U_ProjectSiteID
        .U_ActiveState = Record.U_ActiveState
        .C_TransferedOn = Record.C_TransferedOn
        .C_TransferRemark = Record.C_TransferRemark
        .U_UnderRating = Record.U_UnderRating
        .U_NewRatingID = Record.U_NewRatingID
        .C_RatingDoneOn = Record.C_RatingDoneOn
        .C_RatingPoints = Record.C_RatingPoints
        .C_RatingRemark = Record.C_RatingRemark
        .Resigned = Record.Resigned
        .C_ResignedOn = Record.C_ResignedOn
        .C_DateOfReleaving = Record.C_DateOfReleaving
        .C_ResignedRemark = Record.C_ResignedRemark
        .Confirmed = Record.Confirmed
        .C_ConfirmedOn = Record.C_ConfirmedOn
        .C_ConfirmationRemark = Record.C_ConfirmationRemark
        .J_CompanyID = Record.J_CompanyID
        .J_DivisionID = Record.J_DivisionID
        .J_OfficeID = Record.J_OfficeID
        .J_DepartmentID = Record.J_DepartmentID
        .J_ProjectSiteID = Record.J_ProjectSiteID
        .J_DesignationID = Record.J_DesignationID
        .J_BasicSalary = Record.J_BasicSalary
        .J_StatusID = Record.J_StatusID
        .J_StatusRemark = Record.J_StatusRemark
        .WorkingAreaID = Record.WorkingAreaID
        .FunctionalStatusID1 = Record.FunctionalStatusID1
        .FunctionalStatusID2 = Record.FunctionalStatusID2
        .FunctionalStatusID3 = Record.FunctionalStatusID3
        .FunctionalStatusID4 = Record.FunctionalStatusID4
        .EducationDetails = Record.EducationDetails
        .IncrementCompany = Record.IncrementCompany
        .CareerStartedOn = Record.CareerStartedOn
        .QualificationID1 = Record.QualificationID1
        .QualificationYear1 = Record.QualificationYear1
        .QualificationID2 = Record.QualificationID2
        .QualificationYear2 = Record.QualificationYear2
        .DateOfBirth = Record.DateOfBirth
        .BloodGroupID = Record.BloodGroupID
        .FatherName = Record.FatherName
        .SpouseName = Record.SpouseName
        .ContactNumbers = Record.ContactNumbers
        .PermanentAddress = Record.PermanentAddress
        .PermanentCity = Record.PermanentCity
        .CurrentAddress = Record.CurrentAddress
        .CurrentCity = Record.CurrentCity
        .OfficeFileNumber = Record.OfficeFileNumber
        .PFNumber = Record.PFNumber
        .ESINumber = Record.ESINumber
        .PAN = Record.PAN
        .EMailID = Record.EMailID
        .Freezed = Record.Freezed
        .ModifiedBy = Record.ModifiedBy
        .ModifiedOn = Record.ModifiedOn
        .ModifiedEvent = Record.ModifiedEvent
        .VerificationRequired = Record.VerificationRequired
        .VerifierID = Record.VerifierID
        .ApprovalRequired = Record.ApprovalRequired
        .ApproverID = Record.ApproverID
        .ResponsibleAgencyID = Record.ResponsibleAgencyID
        .Contractual = Record.Contractual
				.VPNMailExpireOn = Record.VPNMailExpireOn
				.Blackberry = Record.Blackberry
      End With
      Return SIS.HRM.hrmNEmployees.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.HRM.hrmNEmployees) As SIS.HRM.hrmNEmployees
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNEmployeesInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Salute",SqlDbType.NVarChar,51, Record.Salute)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeName",SqlDbType.NVarChar,51, Record.EmployeeName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AliasName",SqlDbType.NVarChar,51, Record.AliasName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Gender",SqlDbType.NVarChar,2, Record.Gender)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID",SqlDbType.NVarChar,7, Iif(Record.C_CompanyID= "" ,Convert.DBNull, Record.C_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID",SqlDbType.NVarChar,7, Iif(Record.C_DivisionID= "" ,Convert.DBNull, Record.C_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID",SqlDbType.Int,11, Iif(Record.C_OfficeID= "" ,Convert.DBNull, Record.C_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.C_DepartmentID= "" ,Convert.DBNull, Record.C_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.C_ProjectSiteID= "" ,Convert.DBNull, Record.C_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Iif(Record.C_DesignationID= "" ,Convert.DBNull, Record.C_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_BasicSalary",SqlDbType.Decimal,15, Iif(Record.C_BasicSalary= "" ,Convert.DBNull, Record.C_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID",SqlDbType.NVarChar,3, Iif(Record.C_StatusID= "" ,Convert.DBNull, Record.C_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.C_StatusRemark= "" ,Convert.DBNull, Record.C_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_JoinngStateID",SqlDbType.NVarChar,3, Iif(Record.C_JoinngStateID= "" ,Convert.DBNull, Record.C_JoinngStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingID",SqlDbType.NVarChar,4, Iif(Record.C_RatingID= "" ,Convert.DBNull, Record.C_RatingID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Iif(Record.ActiveState= "" ,Convert.DBNull, Record.ActiveState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName",SqlDbType.NVarChar,21, Iif(Record.ActiveStateEventName= "" ,Convert.DBNull, Record.ActiveStateEventName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderIncrement",SqlDbType.Bit,3, Record.U_UnderIncrement)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewBasicSalary",SqlDbType.Decimal,15, Iif(Record.U_NewBasicSalary= "" ,Convert.DBNull, Record.U_NewBasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementOn",SqlDbType.DateTime,21, Iif(Record.C_IncrementOn= "" ,Convert.DBNull, Record.C_IncrementOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementRemark",SqlDbType.NVarChar,251, Iif(Record.C_IncrementRemark= "" ,Convert.DBNull, Record.C_IncrementRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion",SqlDbType.Bit,3, Record.U_UnderPromotion)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewDesignationID",SqlDbType.Int,11, Iif(Record.U_NewDesignationID= "" ,Convert.DBNull, Record.U_NewDesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionOn",SqlDbType.DateTime,21, Iif(Record.C_PromotionOn= "" ,Convert.DBNull, Record.C_PromotionOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionRemark",SqlDbType.NVarChar,251, Iif(Record.C_PromotionRemark= "" ,Convert.DBNull, Record.C_PromotionRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderTransfer",SqlDbType.Bit,3, Record.U_UnderTransfer)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_CompanyID",SqlDbType.NVarChar,7, Iif(Record.U_CompanyID= "" ,Convert.DBNull, Record.U_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DivisionID",SqlDbType.NVarChar,7, Iif(Record.U_DivisionID= "" ,Convert.DBNull, Record.U_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_OfficeID",SqlDbType.Int,11, Iif(Record.U_OfficeID= "" ,Convert.DBNull, Record.U_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.U_DepartmentID= "" ,Convert.DBNull, Record.U_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.U_ProjectSiteID= "" ,Convert.DBNull, Record.U_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ActiveState",SqlDbType.Bit,3, Record.U_ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferedOn",SqlDbType.DateTime,21, Iif(Record.C_TransferedOn= "" ,Convert.DBNull, Record.C_TransferedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferRemark",SqlDbType.NVarChar,251, Iif(Record.C_TransferRemark= "" ,Convert.DBNull, Record.C_TransferRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderRating",SqlDbType.Bit,3, Record.U_UnderRating)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewRatingID",SqlDbType.NVarChar,4, Iif(Record.U_NewRatingID= "" ,Convert.DBNull, Record.U_NewRatingID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingDoneOn",SqlDbType.DateTime,21, Iif(Record.C_RatingDoneOn= "" ,Convert.DBNull, Record.C_RatingDoneOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingPoints",SqlDbType.Decimal,11, Iif(Record.C_RatingPoints= "" ,Convert.DBNull, Record.C_RatingPoints))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingRemark",SqlDbType.NVarChar,251, Iif(Record.C_RatingRemark= "" ,Convert.DBNull, Record.C_RatingRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,3, Record.Resigned)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedOn",SqlDbType.DateTime,21, Iif(Record.C_ResignedOn= "" ,Convert.DBNull, Record.C_ResignedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving",SqlDbType.DateTime,21, Iif(Record.C_DateOfReleaving= "" ,Convert.DBNull, Record.C_DateOfReleaving))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedRemark",SqlDbType.NVarChar,251, Iif(Record.C_ResignedRemark= "" ,Convert.DBNull, Record.C_ResignedRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Confirmed",SqlDbType.Bit,3, Record.Confirmed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmedOn",SqlDbType.DateTime,21, Iif(Record.C_ConfirmedOn= "" ,Convert.DBNull, Record.C_ConfirmedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmationRemark",SqlDbType.NVarChar,251, Iif(Record.C_ConfirmationRemark= "" ,Convert.DBNull, Record.C_ConfirmationRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_CompanyID",SqlDbType.NVarChar,7, Iif(Record.J_CompanyID= "" ,Convert.DBNull, Record.J_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DivisionID",SqlDbType.NVarChar,7, Iif(Record.J_DivisionID= "" ,Convert.DBNull, Record.J_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_OfficeID",SqlDbType.Int,11, Iif(Record.J_OfficeID= "" ,Convert.DBNull, Record.J_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.J_DepartmentID= "" ,Convert.DBNull, Record.J_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.J_ProjectSiteID= "" ,Convert.DBNull, Record.J_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DesignationID",SqlDbType.Int,11, Iif(Record.J_DesignationID= "" ,Convert.DBNull, Record.J_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_BasicSalary",SqlDbType.Decimal,15, Iif(Record.J_BasicSalary= "" ,Convert.DBNull, Record.J_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusID",SqlDbType.NVarChar,3, Iif(Record.J_StatusID= "" ,Convert.DBNull, Record.J_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.J_StatusRemark= "" ,Convert.DBNull, Record.J_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@WorkingAreaID",SqlDbType.Int,11, Iif(Record.WorkingAreaID= "" ,Convert.DBNull, Record.WorkingAreaID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID1",SqlDbType.Int,11, Iif(Record.FunctionalStatusID1= "" ,Convert.DBNull, Record.FunctionalStatusID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID2",SqlDbType.Int,11, Iif(Record.FunctionalStatusID2= "" ,Convert.DBNull, Record.FunctionalStatusID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID3",SqlDbType.Int,11, Iif(Record.FunctionalStatusID3= "" ,Convert.DBNull, Record.FunctionalStatusID3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID4",SqlDbType.Int,11, Iif(Record.FunctionalStatusID4= "" ,Convert.DBNull, Record.FunctionalStatusID4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EducationDetails",SqlDbType.NVarChar,251, Iif(Record.EducationDetails= "" ,Convert.DBNull, Record.EducationDetails))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IncrementCompany",SqlDbType.NVarChar,7, Iif(Record.IncrementCompany= "" ,Convert.DBNull, Record.IncrementCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CareerStartedOn",SqlDbType.DateTime,21, Iif(Record.CareerStartedOn= "" ,Convert.DBNull, Record.CareerStartedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID1",SqlDbType.Int,11, Iif(Record.QualificationID1= "" ,Convert.DBNull, Record.QualificationID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear1",SqlDbType.NVarChar,5, Iif(Record.QualificationYear1= "" ,Convert.DBNull, Record.QualificationYear1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID2",SqlDbType.Int,11, Iif(Record.QualificationID2= "" ,Convert.DBNull, Record.QualificationID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear2",SqlDbType.NVarChar,5, Iif(Record.QualificationYear2= "" ,Convert.DBNull, Record.QualificationYear2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DateOfBirth",SqlDbType.DateTime,21, Iif(Record.DateOfBirth= "" ,Convert.DBNull, Record.DateOfBirth))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BloodGroupID",SqlDbType.NVarChar,6, Iif(Record.BloodGroupID= "" ,Convert.DBNull, Record.BloodGroupID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FatherName",SqlDbType.NVarChar,51, Iif(Record.FatherName= "" ,Convert.DBNull, Record.FatherName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SpouseName",SqlDbType.NVarChar,51, Iif(Record.SpouseName= "" ,Convert.DBNull, Record.SpouseName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNumbers",SqlDbType.NVarChar,101, Iif(Record.ContactNumbers= "" ,Convert.DBNull, Record.ContactNumbers))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentAddress",SqlDbType.NVarChar,251, Iif(Record.PermanentAddress= "" ,Convert.DBNull, Record.PermanentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentCity",SqlDbType.NVarChar,51, Iif(Record.PermanentCity= "" ,Convert.DBNull, Record.PermanentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentAddress",SqlDbType.NVarChar,251, Iif(Record.CurrentAddress= "" ,Convert.DBNull, Record.CurrentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentCity",SqlDbType.NVarChar,51, Iif(Record.CurrentCity= "" ,Convert.DBNull, Record.CurrentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfficeFileNumber",SqlDbType.NVarChar,51, Iif(Record.OfficeFileNumber= "" ,Convert.DBNull, Record.OfficeFileNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PFNumber",SqlDbType.NVarChar,51, Iif(Record.PFNumber= "" ,Convert.DBNull, Record.PFNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ESINumber",SqlDbType.NVarChar,51, Iif(Record.ESINumber= "" ,Convert.DBNull, Record.ESINumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PAN",SqlDbType.NVarChar,21, Iif(Record.PAN= "" ,Convert.DBNull, Record.PAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID",SqlDbType.NVarChar,51, Iif(Record.EMailID= "" ,Convert.DBNull, Record.EMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Freezed",SqlDbType.Bit,3, Record.Freezed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Iif(Record.ModifiedBy= "" ,Convert.DBNull, Record.ModifiedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Iif(Record.ModifiedOn= "" ,Convert.DBNull, Record.ModifiedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, Iif(Record.ModifiedEvent= "" ,Convert.DBNull, Record.ModifiedEvent))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VerificationRequired",SqlDbType.Bit,3, Record.VerificationRequired)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VerifierID",SqlDbType.NVarChar,9, Iif(Record.VerifierID= "" ,Convert.DBNull, Record.VerifierID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovalRequired",SqlDbType.Bit,3, Record.ApprovalRequired)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApproverID",SqlDbType.NVarChar,9, Iif(Record.ApproverID= "" ,Convert.DBNull, Record.ApproverID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ResponsibleAgencyID",SqlDbType.Int,11, Iif(Record.ResponsibleAgencyID= "" ,Convert.DBNull, Record.ResponsibleAgencyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual",SqlDbType.Bit,3, Record.Contractual)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPNMailExpireOn",SqlDbType.DateTime,21, Iif(Record.VPNMailExpireOn= "" ,Convert.DBNull, Record.VPNMailExpireOn))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Blackberry", SqlDbType.Bit, 3, Record.Blackberry)
					Cmd.Parameters.Add("@Return_CardNo", SqlDbType.NVarChar, 9)
          Cmd.Parameters("@Return_CardNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.CardNo = Cmd.Parameters("@Return_CardNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmNEmployees) As SIS.HRM.hrmNEmployees
      Dim _Rec As SIS.HRM.hrmNEmployees = SIS.HRM.hrmNEmployees.GetByID(Record.CardNo)
      With _Rec
        .Salute = Record.Salute
        .EmployeeName = Record.EmployeeName
        .AliasName = Record.AliasName
        .Gender = Record.Gender
        .C_DateOfJoining = Record.C_DateOfJoining
        .C_CompanyID = Record.C_CompanyID
        .C_DivisionID = Record.C_DivisionID
        .C_OfficeID = Record.C_OfficeID
        .C_DepartmentID = Record.C_DepartmentID
        .C_ProjectSiteID = Record.C_ProjectSiteID
        .C_DesignationID = Record.C_DesignationID
        .ActiveState = Record.ActiveState
        .C_DateOfReleaving = Record.C_DateOfReleaving
        .ContactNumbers = Record.ContactNumbers
        .EMailID = Record.EMailID
        .Contractual = Record.Contractual
				.VPNMailExpireOn = Record.VPNMailExpireOn
				.Blackberry = Record.Blackberry
      End With
      Return SIS.HRM.hrmNEmployees.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.HRM.hrmNEmployees) As SIS.HRM.hrmNEmployees
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNEmployeesUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Salute",SqlDbType.NVarChar,51, Record.Salute)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeName",SqlDbType.NVarChar,51, Record.EmployeeName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AliasName",SqlDbType.NVarChar,51, Record.AliasName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Gender",SqlDbType.NVarChar,2, Record.Gender)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID",SqlDbType.NVarChar,7, Iif(Record.C_CompanyID= "" ,Convert.DBNull, Record.C_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID",SqlDbType.NVarChar,7, Iif(Record.C_DivisionID= "" ,Convert.DBNull, Record.C_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID",SqlDbType.Int,11, Iif(Record.C_OfficeID= "" ,Convert.DBNull, Record.C_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.C_DepartmentID= "" ,Convert.DBNull, Record.C_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.C_ProjectSiteID= "" ,Convert.DBNull, Record.C_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Iif(Record.C_DesignationID= "" ,Convert.DBNull, Record.C_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_BasicSalary",SqlDbType.Decimal,15, Iif(Record.C_BasicSalary= "" ,Convert.DBNull, Record.C_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID",SqlDbType.NVarChar,3, Iif(Record.C_StatusID= "" ,Convert.DBNull, Record.C_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.C_StatusRemark= "" ,Convert.DBNull, Record.C_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_JoinngStateID",SqlDbType.NVarChar,3, Iif(Record.C_JoinngStateID= "" ,Convert.DBNull, Record.C_JoinngStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingID",SqlDbType.NVarChar,4, Iif(Record.C_RatingID= "" ,Convert.DBNull, Record.C_RatingID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState", SqlDbType.Bit, 3, Record.ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName",SqlDbType.NVarChar,21, Iif(Record.ActiveStateEventName= "" ,Convert.DBNull, Record.ActiveStateEventName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderIncrement",SqlDbType.Bit,3, Record.U_UnderIncrement)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewBasicSalary",SqlDbType.Decimal,15, Iif(Record.U_NewBasicSalary= "" ,Convert.DBNull, Record.U_NewBasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementOn",SqlDbType.DateTime,21, Iif(Record.C_IncrementOn= "" ,Convert.DBNull, Record.C_IncrementOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementRemark",SqlDbType.NVarChar,251, Iif(Record.C_IncrementRemark= "" ,Convert.DBNull, Record.C_IncrementRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion",SqlDbType.Bit,3, Record.U_UnderPromotion)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewDesignationID",SqlDbType.Int,11, Iif(Record.U_NewDesignationID= "" ,Convert.DBNull, Record.U_NewDesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionOn",SqlDbType.DateTime,21, Iif(Record.C_PromotionOn= "" ,Convert.DBNull, Record.C_PromotionOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionRemark",SqlDbType.NVarChar,251, Iif(Record.C_PromotionRemark= "" ,Convert.DBNull, Record.C_PromotionRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderTransfer",SqlDbType.Bit,3, Record.U_UnderTransfer)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_CompanyID",SqlDbType.NVarChar,7, Iif(Record.U_CompanyID= "" ,Convert.DBNull, Record.U_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DivisionID",SqlDbType.NVarChar,7, Iif(Record.U_DivisionID= "" ,Convert.DBNull, Record.U_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_OfficeID",SqlDbType.Int,11, Iif(Record.U_OfficeID= "" ,Convert.DBNull, Record.U_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.U_DepartmentID= "" ,Convert.DBNull, Record.U_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.U_ProjectSiteID= "" ,Convert.DBNull, Record.U_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ActiveState",SqlDbType.Bit,3, Record.U_ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferedOn",SqlDbType.DateTime,21, Iif(Record.C_TransferedOn= "" ,Convert.DBNull, Record.C_TransferedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferRemark",SqlDbType.NVarChar,251, Iif(Record.C_TransferRemark= "" ,Convert.DBNull, Record.C_TransferRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderRating",SqlDbType.Bit,3, Record.U_UnderRating)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewRatingID",SqlDbType.NVarChar,4, Iif(Record.U_NewRatingID= "" ,Convert.DBNull, Record.U_NewRatingID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingDoneOn",SqlDbType.DateTime,21, Iif(Record.C_RatingDoneOn= "" ,Convert.DBNull, Record.C_RatingDoneOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingPoints",SqlDbType.Decimal,11, Iif(Record.C_RatingPoints= "" ,Convert.DBNull, Record.C_RatingPoints))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingRemark",SqlDbType.NVarChar,251, Iif(Record.C_RatingRemark= "" ,Convert.DBNull, Record.C_RatingRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,3, Record.Resigned)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedOn",SqlDbType.DateTime,21, Iif(Record.C_ResignedOn= "" ,Convert.DBNull, Record.C_ResignedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving",SqlDbType.DateTime,21, Iif(Record.C_DateOfReleaving= "" ,Convert.DBNull, Record.C_DateOfReleaving))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedRemark",SqlDbType.NVarChar,251, Iif(Record.C_ResignedRemark= "" ,Convert.DBNull, Record.C_ResignedRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Confirmed",SqlDbType.Bit,3, Record.Confirmed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmedOn",SqlDbType.DateTime,21, Iif(Record.C_ConfirmedOn= "" ,Convert.DBNull, Record.C_ConfirmedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmationRemark",SqlDbType.NVarChar,251, Iif(Record.C_ConfirmationRemark= "" ,Convert.DBNull, Record.C_ConfirmationRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_CompanyID",SqlDbType.NVarChar,7, Iif(Record.J_CompanyID= "" ,Convert.DBNull, Record.J_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DivisionID",SqlDbType.NVarChar,7, Iif(Record.J_DivisionID= "" ,Convert.DBNull, Record.J_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_OfficeID",SqlDbType.Int,11, Iif(Record.J_OfficeID= "" ,Convert.DBNull, Record.J_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.J_DepartmentID= "" ,Convert.DBNull, Record.J_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.J_ProjectSiteID= "" ,Convert.DBNull, Record.J_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DesignationID",SqlDbType.Int,11, Iif(Record.J_DesignationID= "" ,Convert.DBNull, Record.J_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_BasicSalary",SqlDbType.Decimal,15, Iif(Record.J_BasicSalary= "" ,Convert.DBNull, Record.J_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusID",SqlDbType.NVarChar,3, Iif(Record.J_StatusID= "" ,Convert.DBNull, Record.J_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.J_StatusRemark= "" ,Convert.DBNull, Record.J_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@WorkingAreaID",SqlDbType.Int,11, Iif(Record.WorkingAreaID= "" ,Convert.DBNull, Record.WorkingAreaID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID1",SqlDbType.Int,11, Iif(Record.FunctionalStatusID1= "" ,Convert.DBNull, Record.FunctionalStatusID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID2",SqlDbType.Int,11, Iif(Record.FunctionalStatusID2= "" ,Convert.DBNull, Record.FunctionalStatusID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID3",SqlDbType.Int,11, Iif(Record.FunctionalStatusID3= "" ,Convert.DBNull, Record.FunctionalStatusID3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID4",SqlDbType.Int,11, Iif(Record.FunctionalStatusID4= "" ,Convert.DBNull, Record.FunctionalStatusID4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EducationDetails",SqlDbType.NVarChar,251, Iif(Record.EducationDetails= "" ,Convert.DBNull, Record.EducationDetails))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IncrementCompany",SqlDbType.NVarChar,7, Iif(Record.IncrementCompany= "" ,Convert.DBNull, Record.IncrementCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CareerStartedOn",SqlDbType.DateTime,21, Iif(Record.CareerStartedOn= "" ,Convert.DBNull, Record.CareerStartedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID1",SqlDbType.Int,11, Iif(Record.QualificationID1= "" ,Convert.DBNull, Record.QualificationID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear1",SqlDbType.NVarChar,5, Iif(Record.QualificationYear1= "" ,Convert.DBNull, Record.QualificationYear1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID2",SqlDbType.Int,11, Iif(Record.QualificationID2= "" ,Convert.DBNull, Record.QualificationID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear2",SqlDbType.NVarChar,5, Iif(Record.QualificationYear2= "" ,Convert.DBNull, Record.QualificationYear2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DateOfBirth",SqlDbType.DateTime,21, Iif(Record.DateOfBirth= "" ,Convert.DBNull, Record.DateOfBirth))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BloodGroupID",SqlDbType.NVarChar,6, Iif(Record.BloodGroupID= "" ,Convert.DBNull, Record.BloodGroupID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FatherName",SqlDbType.NVarChar,51, Iif(Record.FatherName= "" ,Convert.DBNull, Record.FatherName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SpouseName",SqlDbType.NVarChar,51, Iif(Record.SpouseName= "" ,Convert.DBNull, Record.SpouseName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNumbers",SqlDbType.NVarChar,101, Iif(Record.ContactNumbers= "" ,Convert.DBNull, Record.ContactNumbers))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentAddress",SqlDbType.NVarChar,251, Iif(Record.PermanentAddress= "" ,Convert.DBNull, Record.PermanentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentCity",SqlDbType.NVarChar,51, Iif(Record.PermanentCity= "" ,Convert.DBNull, Record.PermanentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentAddress",SqlDbType.NVarChar,251, Iif(Record.CurrentAddress= "" ,Convert.DBNull, Record.CurrentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentCity",SqlDbType.NVarChar,51, Iif(Record.CurrentCity= "" ,Convert.DBNull, Record.CurrentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfficeFileNumber",SqlDbType.NVarChar,51, Iif(Record.OfficeFileNumber= "" ,Convert.DBNull, Record.OfficeFileNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PFNumber",SqlDbType.NVarChar,51, Iif(Record.PFNumber= "" ,Convert.DBNull, Record.PFNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ESINumber",SqlDbType.NVarChar,51, Iif(Record.ESINumber= "" ,Convert.DBNull, Record.ESINumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PAN",SqlDbType.NVarChar,21, Iif(Record.PAN= "" ,Convert.DBNull, Record.PAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID",SqlDbType.NVarChar,51, Iif(Record.EMailID= "" ,Convert.DBNull, Record.EMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Freezed",SqlDbType.Bit,3, Record.Freezed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Iif(Record.ModifiedBy= "" ,Convert.DBNull, Record.ModifiedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Iif(Record.ModifiedOn= "" ,Convert.DBNull, Record.ModifiedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, Iif(Record.ModifiedEvent= "" ,Convert.DBNull, Record.ModifiedEvent))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VerificationRequired",SqlDbType.Bit,3, Record.VerificationRequired)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VerifierID",SqlDbType.NVarChar,9, Iif(Record.VerifierID= "" ,Convert.DBNull, Record.VerifierID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApprovalRequired",SqlDbType.Bit,3, Record.ApprovalRequired)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ApproverID",SqlDbType.NVarChar,9, Iif(Record.ApproverID= "" ,Convert.DBNull, Record.ApproverID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ResponsibleAgencyID",SqlDbType.Int,11, Iif(Record.ResponsibleAgencyID= "" ,Convert.DBNull, Record.ResponsibleAgencyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual",SqlDbType.Bit,3, Record.Contractual)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPNMailExpireOn",SqlDbType.DateTime,21, Iif(Record.VPNMailExpireOn= "" ,Convert.DBNull, Record.VPNMailExpireOn))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Blackberry", SqlDbType.Bit, 3, Record.Blackberry)
					Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return SIS.HRM.hrmNEmployees.GetByID(Record.CardNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function Delete(ByVal Record As SIS.HRM.hrmNEmployees, Optional ByVal Cascade As Boolean = False) As Int32
      Dim _Result as Integer = 0
      If Cascade Then
				
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNEmployeesDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,Record.CardNo.ToString.Length, Record.CardNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader("CardNo"),String)
      _Salute = Ctype(Reader("Salute"),String)
      _EmployeeName = Ctype(Reader("EmployeeName"),String)
      _AliasName = Ctype(Reader("AliasName"),String)
      _Gender = Ctype(Reader("Gender"),String)
      If Convert.IsDBNull(Reader("C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader("C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader("C_CompanyID")) Then
        _C_CompanyID = String.Empty
      Else
        _C_CompanyID = Ctype(Reader("C_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DivisionID")) Then
        _C_DivisionID = String.Empty
      Else
        _C_DivisionID = Ctype(Reader("C_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader("C_OfficeID")) Then
        _C_OfficeID = String.Empty
      Else
        _C_OfficeID = Ctype(Reader("C_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader("C_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader("C_ProjectSiteID")) Then
        _C_ProjectSiteID = String.Empty
      Else
        _C_ProjectSiteID = Ctype(Reader("C_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DesignationID")) Then
        _C_DesignationID = String.Empty
      Else
        _C_DesignationID = Ctype(Reader("C_DesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("C_BasicSalary")) Then
        _C_BasicSalary = String.Empty
      Else
        _C_BasicSalary = Ctype(Reader("C_BasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader("C_StatusID")) Then
        _C_StatusID = String.Empty
      Else
        _C_StatusID = Ctype(Reader("C_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader("C_StatusRemark")) Then
        _C_StatusRemark = String.Empty
      Else
        _C_StatusRemark = Ctype(Reader("C_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader("C_JoinngStateID")) Then
        _C_JoinngStateID = String.Empty
      Else
        _C_JoinngStateID = Ctype(Reader("C_JoinngStateID"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingID")) Then
        _C_RatingID = String.Empty
      Else
        _C_RatingID = Ctype(Reader("C_RatingID"), String)
      End If
      If Convert.IsDBNull(Reader("ActiveState")) Then
				_ActiveState = False
      Else
				_ActiveState = CType(Reader("ActiveState"), Boolean)
      End If
      If Convert.IsDBNull(Reader("ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader("ActiveStateEventName"), String)
      End If
      _U_UnderIncrement = Ctype(Reader("U_UnderIncrement"),Boolean)
      If Convert.IsDBNull(Reader("U_NewBasicSalary")) Then
        _U_NewBasicSalary = String.Empty
      Else
        _U_NewBasicSalary = Ctype(Reader("U_NewBasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader("C_IncrementOn")) Then
        _C_IncrementOn = String.Empty
      Else
        _C_IncrementOn = Ctype(Reader("C_IncrementOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_IncrementRemark")) Then
        _C_IncrementRemark = String.Empty
      Else
        _C_IncrementRemark = Ctype(Reader("C_IncrementRemark"), String)
      End If
      _U_UnderPromotion = Ctype(Reader("U_UnderPromotion"),Boolean)
      If Convert.IsDBNull(Reader("U_NewDesignationID")) Then
        _U_NewDesignationID = String.Empty
      Else
        _U_NewDesignationID = Ctype(Reader("U_NewDesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("C_PromotionOn")) Then
        _C_PromotionOn = String.Empty
      Else
        _C_PromotionOn = Ctype(Reader("C_PromotionOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_PromotionRemark")) Then
        _C_PromotionRemark = String.Empty
      Else
        _C_PromotionRemark = Ctype(Reader("C_PromotionRemark"), String)
      End If
      _U_UnderTransfer = Ctype(Reader("U_UnderTransfer"),Boolean)
      If Convert.IsDBNull(Reader("U_CompanyID")) Then
        _U_CompanyID = String.Empty
      Else
        _U_CompanyID = Ctype(Reader("U_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader("U_DivisionID")) Then
        _U_DivisionID = String.Empty
      Else
        _U_DivisionID = Ctype(Reader("U_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader("U_OfficeID")) Then
        _U_OfficeID = String.Empty
      Else
        _U_OfficeID = Ctype(Reader("U_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader("U_DepartmentID")) Then
        _U_DepartmentID = String.Empty
      Else
        _U_DepartmentID = Ctype(Reader("U_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader("U_ProjectSiteID")) Then
        _U_ProjectSiteID = String.Empty
      Else
        _U_ProjectSiteID = Ctype(Reader("U_ProjectSiteID"), String)
      End If
      _U_ActiveState = Ctype(Reader("U_ActiveState"),Boolean)
      If Convert.IsDBNull(Reader("C_TransferedOn")) Then
        _C_TransferedOn = String.Empty
      Else
        _C_TransferedOn = Ctype(Reader("C_TransferedOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_TransferRemark")) Then
        _C_TransferRemark = String.Empty
      Else
        _C_TransferRemark = Ctype(Reader("C_TransferRemark"), String)
      End If
      _U_UnderRating = Ctype(Reader("U_UnderRating"),Boolean)
      If Convert.IsDBNull(Reader("U_NewRatingID")) Then
        _U_NewRatingID = String.Empty
      Else
        _U_NewRatingID = Ctype(Reader("U_NewRatingID"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingDoneOn")) Then
        _C_RatingDoneOn = String.Empty
      Else
        _C_RatingDoneOn = Ctype(Reader("C_RatingDoneOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingPoints")) Then
        _C_RatingPoints = String.Empty
      Else
        _C_RatingPoints = Ctype(Reader("C_RatingPoints"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingRemark")) Then
        _C_RatingRemark = String.Empty
      Else
        _C_RatingRemark = Ctype(Reader("C_RatingRemark"), String)
      End If
      _Resigned = Ctype(Reader("Resigned"),Boolean)
      If Convert.IsDBNull(Reader("C_ResignedOn")) Then
        _C_ResignedOn = String.Empty
      Else
        _C_ResignedOn = Ctype(Reader("C_ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_DateOfReleaving")) Then
        _C_DateOfReleaving = String.Empty
      Else
        _C_DateOfReleaving = Ctype(Reader("C_DateOfReleaving"), String)
      End If
      If Convert.IsDBNull(Reader("C_ResignedRemark")) Then
        _C_ResignedRemark = String.Empty
      Else
        _C_ResignedRemark = Ctype(Reader("C_ResignedRemark"), String)
      End If
      _Confirmed = Ctype(Reader("Confirmed"),Boolean)
      If Convert.IsDBNull(Reader("C_ConfirmedOn")) Then
        _C_ConfirmedOn = String.Empty
      Else
        _C_ConfirmedOn = Ctype(Reader("C_ConfirmedOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_ConfirmationRemark")) Then
        _C_ConfirmationRemark = String.Empty
      Else
        _C_ConfirmationRemark = Ctype(Reader("C_ConfirmationRemark"), String)
      End If
      If Convert.IsDBNull(Reader("J_CompanyID")) Then
        _J_CompanyID = String.Empty
      Else
        _J_CompanyID = Ctype(Reader("J_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DivisionID")) Then
        _J_DivisionID = String.Empty
      Else
        _J_DivisionID = Ctype(Reader("J_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader("J_OfficeID")) Then
        _J_OfficeID = String.Empty
      Else
        _J_OfficeID = Ctype(Reader("J_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DepartmentID")) Then
        _J_DepartmentID = String.Empty
      Else
        _J_DepartmentID = Ctype(Reader("J_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader("J_ProjectSiteID")) Then
        _J_ProjectSiteID = String.Empty
      Else
        _J_ProjectSiteID = Ctype(Reader("J_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DesignationID")) Then
        _J_DesignationID = String.Empty
      Else
        _J_DesignationID = Ctype(Reader("J_DesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("J_BasicSalary")) Then
        _J_BasicSalary = String.Empty
      Else
        _J_BasicSalary = Ctype(Reader("J_BasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader("J_StatusID")) Then
        _J_StatusID = String.Empty
      Else
        _J_StatusID = Ctype(Reader("J_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader("J_StatusRemark")) Then
        _J_StatusRemark = String.Empty
      Else
        _J_StatusRemark = Ctype(Reader("J_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader("WorkingAreaID")) Then
        _WorkingAreaID = String.Empty
      Else
        _WorkingAreaID = Ctype(Reader("WorkingAreaID"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID1")) Then
        _FunctionalStatusID1 = String.Empty
      Else
        _FunctionalStatusID1 = Ctype(Reader("FunctionalStatusID1"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID2")) Then
        _FunctionalStatusID2 = String.Empty
      Else
        _FunctionalStatusID2 = Ctype(Reader("FunctionalStatusID2"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID3")) Then
        _FunctionalStatusID3 = String.Empty
      Else
        _FunctionalStatusID3 = Ctype(Reader("FunctionalStatusID3"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID4")) Then
        _FunctionalStatusID4 = String.Empty
      Else
        _FunctionalStatusID4 = Ctype(Reader("FunctionalStatusID4"), String)
      End If
      If Convert.IsDBNull(Reader("EducationDetails")) Then
        _EducationDetails = String.Empty
      Else
        _EducationDetails = Ctype(Reader("EducationDetails"), String)
      End If
      If Convert.IsDBNull(Reader("IncrementCompany")) Then
        _IncrementCompany = String.Empty
      Else
        _IncrementCompany = Ctype(Reader("IncrementCompany"), String)
      End If
      If Convert.IsDBNull(Reader("CareerStartedOn")) Then
        _CareerStartedOn = String.Empty
      Else
        _CareerStartedOn = Ctype(Reader("CareerStartedOn"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationID1")) Then
        _QualificationID1 = String.Empty
      Else
        _QualificationID1 = Ctype(Reader("QualificationID1"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationYear1")) Then
        _QualificationYear1 = String.Empty
      Else
        _QualificationYear1 = Ctype(Reader("QualificationYear1"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationID2")) Then
        _QualificationID2 = String.Empty
      Else
        _QualificationID2 = Ctype(Reader("QualificationID2"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationYear2")) Then
        _QualificationYear2 = String.Empty
      Else
        _QualificationYear2 = Ctype(Reader("QualificationYear2"), String)
      End If
      If Convert.IsDBNull(Reader("DateOfBirth")) Then
        _DateOfBirth = String.Empty
      Else
        _DateOfBirth = Ctype(Reader("DateOfBirth"), String)
      End If
      If Convert.IsDBNull(Reader("BloodGroupID")) Then
        _BloodGroupID = String.Empty
      Else
        _BloodGroupID = Ctype(Reader("BloodGroupID"), String)
      End If
      If Convert.IsDBNull(Reader("FatherName")) Then
        _FatherName = String.Empty
      Else
        _FatherName = Ctype(Reader("FatherName"), String)
      End If
      If Convert.IsDBNull(Reader("SpouseName")) Then
        _SpouseName = String.Empty
      Else
        _SpouseName = Ctype(Reader("SpouseName"), String)
      End If
      If Convert.IsDBNull(Reader("ContactNumbers")) Then
        _ContactNumbers = String.Empty
      Else
        _ContactNumbers = Ctype(Reader("ContactNumbers"), String)
      End If
      If Convert.IsDBNull(Reader("PermanentAddress")) Then
        _PermanentAddress = String.Empty
      Else
        _PermanentAddress = Ctype(Reader("PermanentAddress"), String)
      End If
      If Convert.IsDBNull(Reader("PermanentCity")) Then
        _PermanentCity = String.Empty
      Else
        _PermanentCity = Ctype(Reader("PermanentCity"), String)
      End If
      If Convert.IsDBNull(Reader("CurrentAddress")) Then
        _CurrentAddress = String.Empty
      Else
        _CurrentAddress = Ctype(Reader("CurrentAddress"), String)
      End If
      If Convert.IsDBNull(Reader("CurrentCity")) Then
        _CurrentCity = String.Empty
      Else
        _CurrentCity = Ctype(Reader("CurrentCity"), String)
      End If
      If Convert.IsDBNull(Reader("OfficeFileNumber")) Then
        _OfficeFileNumber = String.Empty
      Else
        _OfficeFileNumber = Ctype(Reader("OfficeFileNumber"), String)
      End If
      If Convert.IsDBNull(Reader("PFNumber")) Then
        _PFNumber = String.Empty
      Else
        _PFNumber = Ctype(Reader("PFNumber"), String)
      End If
      If Convert.IsDBNull(Reader("ESINumber")) Then
        _ESINumber = String.Empty
      Else
        _ESINumber = Ctype(Reader("ESINumber"), String)
      End If
      If Convert.IsDBNull(Reader("PAN")) Then
        _PAN = String.Empty
      Else
        _PAN = Ctype(Reader("PAN"), String)
      End If
      If Convert.IsDBNull(Reader("EMailID")) Then
        _EMailID = String.Empty
      Else
        _EMailID = Ctype(Reader("EMailID"), String)
      End If
      _Freezed = Ctype(Reader("Freezed"),Boolean)
      If Convert.IsDBNull(Reader("ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader("ModifiedBy"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader("ModifiedOn"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader("ModifiedEvent"), String)
      End If
      _VerificationRequired = Ctype(Reader("VerificationRequired"),Boolean)
      If Convert.IsDBNull(Reader("VerifierID")) Then
        _VerifierID = String.Empty
      Else
        _VerifierID = Ctype(Reader("VerifierID"), String)
      End If
      _ApprovalRequired = Ctype(Reader("ApprovalRequired"),Boolean)
      If Convert.IsDBNull(Reader("ApproverID")) Then
        _ApproverID = String.Empty
      Else
        _ApproverID = Ctype(Reader("ApproverID"), String)
      End If
      If Convert.IsDBNull(Reader("ResponsibleAgencyID")) Then
        _ResponsibleAgencyID = String.Empty
      Else
        _ResponsibleAgencyID = Ctype(Reader("ResponsibleAgencyID"), String)
      End If
      _Contractual = Ctype(Reader("Contractual"),Boolean)
      If Convert.IsDBNull(Reader("VPNMailExpireOn")) Then
        _VPNMailExpireOn = String.Empty
      Else
        _VPNMailExpireOn = Ctype(Reader("VPNMailExpireOn"), String)
      End If
			If Convert.IsDBNull(Reader("Blackberry")) Then
				_Blackberry = String.Empty
			Else
				_Blackberry = CType(Reader("Blackberry"), String)
			End If
			_HRM_BloodGroups4_Description = CType(Reader("HRM_BloodGroups4_Description"), String)
      _HRM_Companies5_Description = Ctype(Reader("HRM_Companies5_Description"),String)
      _HRM_Companies6_Description = Ctype(Reader("HRM_Companies6_Description"),String)
      _HRM_Companies7_Description = Ctype(Reader("HRM_Companies7_Description"),String)
      _HRM_Companies8_Description = Ctype(Reader("HRM_Companies8_Description"),String)
      _HRM_Departments9_Description = Ctype(Reader("HRM_Departments9_Description"),String)
      _HRM_Departments10_Description = Ctype(Reader("HRM_Departments10_Description"),String)
      _HRM_Departments11_Description = Ctype(Reader("HRM_Departments11_Description"),String)
      _HRM_Designations12_Description = Ctype(Reader("HRM_Designations12_Description"),String)
      _HRM_Designations13_Description = Ctype(Reader("HRM_Designations13_Description"),String)
      _HRM_Designations14_Description = Ctype(Reader("HRM_Designations14_Description"),String)
      _HRM_Divisions15_Description = Ctype(Reader("HRM_Divisions15_Description"),String)
      _HRM_Divisions16_Description = Ctype(Reader("HRM_Divisions16_Description"),String)
      _HRM_Divisions17_Description = Ctype(Reader("HRM_Divisions17_Description"),String)
      _HRM_FunctionalStatus120_Description = Ctype(Reader("HRM_FunctionalStatus120_Description"),String)
      _HRM_FunctionalStatus221_Description = Ctype(Reader("HRM_FunctionalStatus221_Description"),String)
      _HRM_FunctionalStatus322_Description = Ctype(Reader("HRM_FunctionalStatus322_Description"),String)
      _HRM_FunctionalStatus423_Description = Ctype(Reader("HRM_FunctionalStatus423_Description"),String)
      _HRM_JoiningStates24_Description = Ctype(Reader("HRM_JoiningStates24_Description"),String)
      _HRM_Offices25_Description = Ctype(Reader("HRM_Offices25_Description"),String)
      _HRM_Offices26_Description = Ctype(Reader("HRM_Offices26_Description"),String)
      _HRM_Offices27_Description = Ctype(Reader("HRM_Offices27_Description"),String)
      _HRM_Qualifications28_Description = Ctype(Reader("HRM_Qualifications28_Description"),String)
      _HRM_Qualifications29_Description = Ctype(Reader("HRM_Qualifications29_Description"),String)
      _HRM_Ratings30_Description = Ctype(Reader("HRM_Ratings30_Description"),String)
      _HRM_Ratings31_Description = Ctype(Reader("HRM_Ratings31_Description"),String)
      _HRM_Status32_Description = Ctype(Reader("HRM_Status32_Description"),String)
      _HRM_Status33_Description = Ctype(Reader("HRM_Status33_Description"),String)
      _HRM_WorkingAreas34_Description = Ctype(Reader("HRM_WorkingAreas34_Description"),String)
      _IDM_ResponsibleAgency35_Description = Ctype(Reader("IDM_ResponsibleAgency35_Description"),String)
      _IDM_Projects1_Description = Ctype(Reader("IDM_Projects1_Description"),String)
      _IDM_Projects2_Description = Ctype(Reader("IDM_Projects2_Description"),String)
      _IDM_Projects3_Description = Ctype(Reader("IDM_Projects3_Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace

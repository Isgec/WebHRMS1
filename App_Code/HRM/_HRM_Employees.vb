Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class HRM_Employees
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _Salute As String
    Private _EmployeeName As String
    Private _AliasName As String
    Private _Gender As String
    Private _C_DateOfJoining As String
    Private _C_CompanyID As String
    Private _C_DivisionID As String
    Private _C_OfficeID As String
    Private _C_DepartmentID As String
    Private _C_ProjectSiteID As String
    Private _C_DesignationID As Int32
    Private _C_BasicSalary As Decimal
    Private _C_StatusID As String
    Private _C_StatusRemark As String
    Private _C_JoinngStateID As String
    Private _U_ActiveState As Boolean
    Private _ActiveState As Boolean
    Private _ActiveStateEventName As String
    Private _C_IncrementOn As String
    Private _C_IncrementRemark As String
    Private _U_UnderIncrement As Boolean
    Private _U_NewBasicSalary As String
    Private _C_PromotionOn As String
    Private _C_PromotionRemark As String
    Private _C_TransferedOn As String
    Private _U_UnderPromotion As Boolean
    Private _C_TransferRemark As String
    Private _C_RatingDoneOn As String
    Private _U_NewDesignationID As String
    Private _C_RatingPoints As String
    Private _C_RatingID As String
    Private _C_RatingRemark As String
    Private _U_UnderTransfer As Boolean
    Private _Resigned As Boolean
    Private _U_CompanyID As String
    Private _C_ResignedOn As String
    Private _C_DateOfReleaving As String
    Private _U_DivisionID As String
    Private _U_UnderRating As Boolean
    Private _C_ResignedRemark As String
    Private _U_NewRatingID As String
    Private _U_OfficeID As String
    Private _U_DepartmentID As String
    Private _C_ConfirmedOn As String
    Private _Confirmed As Boolean
    Private _C_ConfirmationRemark As String
    Private _U_ProjectSiteID As String
    Private _J_CompanyID As String
    Private _J_DivisionID As String
    Private _J_OfficeID As String
    Private _J_DepartmentID As String
    Private _J_ProjectSiteID As String
    Private _J_DesignationID As String
    Private _J_BasicSalary As String
    Private _J_StatusID As String
    Private _J_StatusRemark As String
    Private _WorkingAreaID As String
    Private _FunctionalStatusID1 As String
    Private _FunctionalStatusID2 As String
    Private _FunctionalStatusID3 As String
    Private _FunctionalStatusID4 As String
    Private _EducationDetails As String
    Private _IncrementCompany As String
    Private _CareerStartedOn As String
    Private _QualificationID1 As String
    Private _QualificationID2 As String
    Private _DateOfBirth As String
    Private _BloodGroupID As String
    Private _FatherName As String
    Private _SpouseName As String
    Private _ContactNumbers As String
    Private _PermanentAddress As String
    Private _PermanentCity As String
    Private _CurrentAddress As String
    Private _CurrentCity As String
    Private _OfficeFileNumber As String
    Private _PFNumber As String
    Private _ESINumber As String
    Private _PAN As String
    Private _EMailID As String
    Private _Freezed As Boolean
    Private _QualificationYear1 As String
    Private _ModifiedBy As String
    Private _ModifiedOn As String
    Private _QualificationYear2 As String
    Private _ModifiedEvent As String
    Private _C_CompanyIDHRM_Companies As SIS.HRM.hrmCompanies
    Private _C_DivisionIDHRM_Divisions As SIS.HRM.hrmDivisions
    Private _C_OfficeIDHRM_Offices As SIS.HRM.hrmOffices
    Private _C_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _C_ProjectSiteIDDCM_Projects As SIS.HRM.hrmProjects
    Private _C_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _C_StatusIDHRM_Status As SIS.HRM.hrmStatus
    Private _C_JoinngStateIDHRM_JoiningStates As SIS.HRM.hrmJoiningStates
    Private _U_NewDesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _C_RatingIDHRM_Ratings As SIS.HRM.hrmRatings
    Private _U_CompanyIDHRM_Companies As SIS.HRM.hrmCompanies
    Private _U_DivisionIDHRM_Divisions As SIS.HRM.hrmDivisions
    Private _U_NewRatingIDHRM_Ratings As SIS.HRM.hrmRatings
    Private _U_OfficeIDHRM_Offices As SIS.HRM.hrmOffices
    Private _U_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _U_ProjectSiteIDDCM_Projects As SIS.HRM.hrmProjects
    Private _J_CompanyIDHRM_Companies As SIS.HRM.hrmCompanies
    Private _J_DivisionIDHRM_Divisions As SIS.HRM.hrmDivisions
    Private _J_OfficeIDHRM_Offices As SIS.HRM.hrmOffices
    Private _J_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _J_ProjectSiteIDDCM_Projects As SIS.HRM.hrmProjects
    Private _J_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _J_StatusIDHRM_Status As SIS.HRM.hrmStatus
    Private _WorkingAreaIDHRM_WorkingAreas As SIS.HRM.hrmWorkingAreas
    Private _FunctionalStatusID1HRM_FunctionalStatus1 As SIS.HRM.hrmFunctionalStatus1
    Private _FunctionalStatusID2HRM_FunctionalStatus2 As SIS.HRM.hrmFunctionalStatus2
    Private _FunctionalStatusID3HRM_FunctionalStatus3 As SIS.HRM.hrmFunctionalStatus3
    Private _FunctionalStatusID4HRM_FunctionalStatus4 As SIS.HRM.hrmFunctionalStatus4
    Private _IncrementCompanyHRM_Companies As SIS.HRM.hrmCompanies
    Private _QualificationID1HRM_Qualifications As SIS.HRM.hrmQualifications
    Private _QualificationID2HRM_Qualifications As SIS.HRM.hrmQualifications
    Private _BloodGroupIDHRM_BloodGroups As SIS.HRM.hrmBloodGroups
    Private _ModifiedByaspnet_Users As SIS.HRM.hrmUsers
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
    Public Property C_DesignationID() As Int32
      Get
        Return _C_DesignationID
      End Get
      Set(ByVal value As Int32)
        _C_DesignationID = value
      End Set
    End Property
    Public Property C_BasicSalary() As Decimal
      Get
        Return _C_BasicSalary
      End Get
      Set(ByVal value As Decimal)
        _C_BasicSalary = value
      End Set
    End Property
    Public Property C_StatusID() As String
      Get
        Return _C_StatusID
      End Get
      Set(ByVal value As String)
        _C_StatusID = value
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
    Public Property U_ActiveState() As Boolean
      Get
        Return _U_ActiveState
      End Get
      Set(ByVal value As Boolean)
        _U_ActiveState = value
      End Set
    End Property
    Public Property ActiveState() As Boolean
      Get
        Return _ActiveState
      End Get
      Set(ByVal value As Boolean)
        _ActiveState = value
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
    Public Property U_UnderPromotion() As Boolean
      Get
        Return _U_UnderPromotion
      End Get
      Set(ByVal value As Boolean)
        _U_UnderPromotion = value
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
    Public Property U_UnderTransfer() As Boolean
      Get
        Return _U_UnderTransfer
      End Get
      Set(ByVal value As Boolean)
        _U_UnderTransfer = value
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
    Public Property U_UnderRating() As Boolean
      Get
        Return _U_UnderRating
      End Get
      Set(ByVal value As Boolean)
        _U_UnderRating = value
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
    Public Property Confirmed() As Boolean
      Get
        Return _Confirmed
      End Get
      Set(ByVal value As Boolean)
        _Confirmed = value
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
    Public ReadOnly Property C_CompanyIDHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _C_CompanyIDHRM_Companies Is Nothing Then
          _C_CompanyIDHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_C_CompanyID)
        End If
        Return _C_CompanyIDHRM_Companies
      End Get
    End Property
    Public ReadOnly Property C_DivisionIDHRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _C_DivisionIDHRM_Divisions Is Nothing Then
          _C_DivisionIDHRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_C_DivisionID)
        End If
        Return _C_DivisionIDHRM_Divisions
      End Get
    End Property
    Public ReadOnly Property C_OfficeIDHRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _C_OfficeIDHRM_Offices Is Nothing Then
          _C_OfficeIDHRM_Offices = SIS.HRM.hrmOffices.GetByID(_C_OfficeID)
        End If
        Return _C_OfficeIDHRM_Offices
      End Get
    End Property
    Public ReadOnly Property C_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _C_DepartmentIDHRM_Departments Is Nothing Then
          _C_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_C_DepartmentID)
        End If
        Return _C_DepartmentIDHRM_Departments
      End Get
    End Property
    Public ReadOnly Property C_ProjectSiteIDDCM_Projects() As SIS.HRM.hrmProjects
      Get
        If _C_ProjectSiteIDDCM_Projects Is Nothing Then
          _C_ProjectSiteIDDCM_Projects = SIS.HRM.hrmProjects.GetByID(_C_ProjectSiteID)
        End If
        Return _C_ProjectSiteIDDCM_Projects
      End Get
    End Property
    Public ReadOnly Property C_DesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _C_DesignationIDHRM_Designations Is Nothing Then
          _C_DesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_C_DesignationID)
        End If
        Return _C_DesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property C_StatusIDHRM_Status() As SIS.HRM.hrmStatus
      Get
        If _C_StatusIDHRM_Status Is Nothing Then
          _C_StatusIDHRM_Status = SIS.HRM.hrmStatus.GetByID(_C_StatusID)
        End If
        Return _C_StatusIDHRM_Status
      End Get
    End Property
    Public ReadOnly Property C_JoinngStateIDHRM_JoiningStates() As SIS.HRM.hrmJoiningStates
      Get
        If _C_JoinngStateIDHRM_JoiningStates Is Nothing Then
          _C_JoinngStateIDHRM_JoiningStates = SIS.HRM.hrmJoiningStates.GetByID(_C_JoinngStateID)
        End If
        Return _C_JoinngStateIDHRM_JoiningStates
      End Get
    End Property
    Public ReadOnly Property U_NewDesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _U_NewDesignationIDHRM_Designations Is Nothing Then
          _U_NewDesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_U_NewDesignationID)
        End If
        Return _U_NewDesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property C_RatingIDHRM_Ratings() As SIS.HRM.hrmRatings
      Get
        If _C_RatingIDHRM_Ratings Is Nothing Then
          _C_RatingIDHRM_Ratings = SIS.HRM.hrmRatings.GetByID(_C_RatingID)
        End If
        Return _C_RatingIDHRM_Ratings
      End Get
    End Property
    Public ReadOnly Property U_CompanyIDHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _U_CompanyIDHRM_Companies Is Nothing Then
          _U_CompanyIDHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_U_CompanyID)
        End If
        Return _U_CompanyIDHRM_Companies
      End Get
    End Property
    Public ReadOnly Property U_DivisionIDHRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _U_DivisionIDHRM_Divisions Is Nothing Then
          _U_DivisionIDHRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_U_DivisionID)
        End If
        Return _U_DivisionIDHRM_Divisions
      End Get
    End Property
    Public ReadOnly Property U_NewRatingIDHRM_Ratings() As SIS.HRM.hrmRatings
      Get
        If _U_NewRatingIDHRM_Ratings Is Nothing Then
          _U_NewRatingIDHRM_Ratings = SIS.HRM.hrmRatings.GetByID(_U_NewRatingID)
        End If
        Return _U_NewRatingIDHRM_Ratings
      End Get
    End Property
    Public ReadOnly Property U_OfficeIDHRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _U_OfficeIDHRM_Offices Is Nothing Then
          _U_OfficeIDHRM_Offices = SIS.HRM.hrmOffices.GetByID(_U_OfficeID)
        End If
        Return _U_OfficeIDHRM_Offices
      End Get
    End Property
    Public ReadOnly Property U_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _U_DepartmentIDHRM_Departments Is Nothing Then
          _U_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_U_DepartmentID)
        End If
        Return _U_DepartmentIDHRM_Departments
      End Get
    End Property
    Public ReadOnly Property U_ProjectSiteIDDCM_Projects() As SIS.HRM.hrmProjects
      Get
        If _U_ProjectSiteIDDCM_Projects Is Nothing Then
          _U_ProjectSiteIDDCM_Projects = SIS.HRM.hrmProjects.GetByID(_U_ProjectSiteID)
        End If
        Return _U_ProjectSiteIDDCM_Projects
      End Get
    End Property
    Public ReadOnly Property J_CompanyIDHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _J_CompanyIDHRM_Companies Is Nothing Then
          _J_CompanyIDHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_J_CompanyID)
        End If
        Return _J_CompanyIDHRM_Companies
      End Get
    End Property
    Public ReadOnly Property J_DivisionIDHRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _J_DivisionIDHRM_Divisions Is Nothing Then
          _J_DivisionIDHRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_J_DivisionID)
        End If
        Return _J_DivisionIDHRM_Divisions
      End Get
    End Property
    Public ReadOnly Property J_OfficeIDHRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _J_OfficeIDHRM_Offices Is Nothing Then
          _J_OfficeIDHRM_Offices = SIS.HRM.hrmOffices.GetByID(_J_OfficeID)
        End If
        Return _J_OfficeIDHRM_Offices
      End Get
    End Property
    Public ReadOnly Property J_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _J_DepartmentIDHRM_Departments Is Nothing Then
          _J_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_J_DepartmentID)
        End If
        Return _J_DepartmentIDHRM_Departments
      End Get
    End Property
    Public ReadOnly Property J_ProjectSiteIDDCM_Projects() As SIS.HRM.hrmProjects
      Get
        If _J_ProjectSiteIDDCM_Projects Is Nothing Then
          _J_ProjectSiteIDDCM_Projects = SIS.HRM.hrmProjects.GetByID(_J_ProjectSiteID)
        End If
        Return _J_ProjectSiteIDDCM_Projects
      End Get
    End Property
    Public ReadOnly Property J_DesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _J_DesignationIDHRM_Designations Is Nothing Then
          _J_DesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_J_DesignationID)
        End If
        Return _J_DesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property J_StatusIDHRM_Status() As SIS.HRM.hrmStatus
      Get
        If _J_StatusIDHRM_Status Is Nothing Then
          _J_StatusIDHRM_Status = SIS.HRM.hrmStatus.GetByID(_J_StatusID)
        End If
        Return _J_StatusIDHRM_Status
      End Get
    End Property
    Public ReadOnly Property WorkingAreaIDHRM_WorkingAreas() As SIS.HRM.hrmWorkingAreas
      Get
        If _WorkingAreaIDHRM_WorkingAreas Is Nothing Then
          _WorkingAreaIDHRM_WorkingAreas = SIS.HRM.hrmWorkingAreas.GetByID(_WorkingAreaID)
        End If
        Return _WorkingAreaIDHRM_WorkingAreas
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID1HRM_FunctionalStatus1() As SIS.HRM.hrmFunctionalStatus1
      Get
        If _FunctionalStatusID1HRM_FunctionalStatus1 Is Nothing Then
          _FunctionalStatusID1HRM_FunctionalStatus1 = SIS.HRM.hrmFunctionalStatus1.GetByID(_FunctionalStatusID1)
        End If
        Return _FunctionalStatusID1HRM_FunctionalStatus1
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID2HRM_FunctionalStatus2() As SIS.HRM.hrmFunctionalStatus2
      Get
        If _FunctionalStatusID2HRM_FunctionalStatus2 Is Nothing Then
          _FunctionalStatusID2HRM_FunctionalStatus2 = SIS.HRM.hrmFunctionalStatus2.GetByID(_FunctionalStatusID2)
        End If
        Return _FunctionalStatusID2HRM_FunctionalStatus2
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID3HRM_FunctionalStatus3() As SIS.HRM.hrmFunctionalStatus3
      Get
        If _FunctionalStatusID3HRM_FunctionalStatus3 Is Nothing Then
          _FunctionalStatusID3HRM_FunctionalStatus3 = SIS.HRM.hrmFunctionalStatus3.GetByID(_FunctionalStatusID3)
        End If
        Return _FunctionalStatusID3HRM_FunctionalStatus3
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID4HRM_FunctionalStatus4() As SIS.HRM.hrmFunctionalStatus4
      Get
        If _FunctionalStatusID4HRM_FunctionalStatus4 Is Nothing Then
          _FunctionalStatusID4HRM_FunctionalStatus4 = SIS.HRM.hrmFunctionalStatus4.GetByID(_FunctionalStatusID4)
        End If
        Return _FunctionalStatusID4HRM_FunctionalStatus4
      End Get
    End Property
    Public ReadOnly Property IncrementCompanyHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _IncrementCompanyHRM_Companies Is Nothing Then
          _IncrementCompanyHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_IncrementCompany)
        End If
        Return _IncrementCompanyHRM_Companies
      End Get
    End Property
    Public ReadOnly Property QualificationID1HRM_Qualifications() As SIS.HRM.hrmQualifications
      Get
        If _QualificationID1HRM_Qualifications Is Nothing Then
          _QualificationID1HRM_Qualifications = SIS.HRM.hrmQualifications.GetByID(_QualificationID1)
        End If
        Return _QualificationID1HRM_Qualifications
      End Get
    End Property
    Public ReadOnly Property QualificationID2HRM_Qualifications() As SIS.HRM.hrmQualifications
      Get
        If _QualificationID2HRM_Qualifications Is Nothing Then
          _QualificationID2HRM_Qualifications = SIS.HRM.hrmQualifications.GetByID(_QualificationID2)
        End If
        Return _QualificationID2HRM_Qualifications
      End Get
    End Property
    Public ReadOnly Property BloodGroupIDHRM_BloodGroups() As SIS.HRM.hrmBloodGroups
      Get
        If _BloodGroupIDHRM_BloodGroups Is Nothing Then
          _BloodGroupIDHRM_BloodGroups = SIS.HRM.hrmBloodGroups.GetByID(_BloodGroupID)
        End If
        Return _BloodGroupIDHRM_BloodGroups
      End Get
    End Property
    Public ReadOnly Property ModifiedByaspnet_Users() As SIS.HRM.hrmUsers
      Get
        If _ModifiedByaspnet_Users Is Nothing Then
          _ModifiedByaspnet_Users = SIS.HRM.hrmUsers.GetByID(_ModifiedBy)
        End If
        Return _ModifiedByaspnet_Users
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.HRM.HRM_Employees)
      Dim Results As List(Of SIS.HRM.HRM_Employees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spHRM_EmployeesSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.HRM_Employees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.HRM_Employees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.HRM_Employees
      Dim Results As SIS.HRM.HRM_Employees = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spHRM_EmployeesSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.HRM_Employees(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.HRM_Employees)
      Dim Results As List(Of SIS.HRM.HRM_Employees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spHRM_EmployeesSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spHRM_EmployeesSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.HRM_Employees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.HRM_Employees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.HRM_Employees) As String
      Dim _Result As String = Record.CardNo
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spHRM_EmployeesInsert"
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
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Record.C_DesignationID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_BasicSalary",SqlDbType.Decimal,15, Record.C_BasicSalary)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID",SqlDbType.NVarChar,3, Record.C_StatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.C_StatusRemark= "" ,Convert.DBNull, Record.C_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_JoinngStateID",SqlDbType.NVarChar,3, Iif(Record.C_JoinngStateID= "" ,Convert.DBNull, Record.C_JoinngStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ActiveState",SqlDbType.Bit,3, Record.U_ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Record.ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName",SqlDbType.NVarChar,21, Iif(Record.ActiveStateEventName= "" ,Convert.DBNull, Record.ActiveStateEventName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementOn",SqlDbType.DateTime,21, Iif(Record.C_IncrementOn= "" ,Convert.DBNull, Record.C_IncrementOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementRemark",SqlDbType.NVarChar,251, Iif(Record.C_IncrementRemark= "" ,Convert.DBNull, Record.C_IncrementRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderIncrement",SqlDbType.Bit,3, Record.U_UnderIncrement)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewBasicSalary",SqlDbType.Decimal,15, Iif(Record.U_NewBasicSalary= "" ,Convert.DBNull, Record.U_NewBasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionOn",SqlDbType.DateTime,21, Iif(Record.C_PromotionOn= "" ,Convert.DBNull, Record.C_PromotionOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionRemark",SqlDbType.NVarChar,251, Iif(Record.C_PromotionRemark= "" ,Convert.DBNull, Record.C_PromotionRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferedOn",SqlDbType.DateTime,21, Iif(Record.C_TransferedOn= "" ,Convert.DBNull, Record.C_TransferedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion",SqlDbType.Bit,3, Record.U_UnderPromotion)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_TransferRemark",SqlDbType.NVarChar,251, Iif(Record.C_TransferRemark= "" ,Convert.DBNull, Record.C_TransferRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingDoneOn",SqlDbType.DateTime,21, Iif(Record.C_RatingDoneOn= "" ,Convert.DBNull, Record.C_RatingDoneOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewDesignationID",SqlDbType.Int,11, Iif(Record.U_NewDesignationID= "" ,Convert.DBNull, Record.U_NewDesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingPoints",SqlDbType.Decimal,11, Iif(Record.C_RatingPoints= "" ,Convert.DBNull, Record.C_RatingPoints))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingID",SqlDbType.NVarChar,4, Iif(Record.C_RatingID= "" ,Convert.DBNull, Record.C_RatingID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingRemark",SqlDbType.NVarChar,251, Iif(Record.C_RatingRemark= "" ,Convert.DBNull, Record.C_RatingRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderTransfer",SqlDbType.Bit,3, Record.U_UnderTransfer)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,3, Record.Resigned)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_CompanyID",SqlDbType.NVarChar,7, Iif(Record.U_CompanyID= "" ,Convert.DBNull, Record.U_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedOn",SqlDbType.DateTime,21, Iif(Record.C_ResignedOn= "" ,Convert.DBNull, Record.C_ResignedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving",SqlDbType.DateTime,21, Iif(Record.C_DateOfReleaving= "" ,Convert.DBNull, Record.C_DateOfReleaving))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DivisionID",SqlDbType.NVarChar,7, Iif(Record.U_DivisionID= "" ,Convert.DBNull, Record.U_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderRating",SqlDbType.Bit,3, Record.U_UnderRating)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedRemark",SqlDbType.NVarChar,251, Iif(Record.C_ResignedRemark= "" ,Convert.DBNull, Record.C_ResignedRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewRatingID",SqlDbType.NVarChar,4, Iif(Record.U_NewRatingID= "" ,Convert.DBNull, Record.U_NewRatingID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_OfficeID",SqlDbType.Int,11, Iif(Record.U_OfficeID= "" ,Convert.DBNull, Record.U_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.U_DepartmentID= "" ,Convert.DBNull, Record.U_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmedOn",SqlDbType.DateTime,21, Iif(Record.C_ConfirmedOn= "" ,Convert.DBNull, Record.C_ConfirmedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Confirmed",SqlDbType.Bit,3, Record.Confirmed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ConfirmationRemark",SqlDbType.NVarChar,251, Iif(Record.C_ConfirmationRemark= "" ,Convert.DBNull, Record.C_ConfirmationRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.U_ProjectSiteID= "" ,Convert.DBNull, Record.U_ProjectSiteID))
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
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID2",SqlDbType.Int,11, Iif(Record.QualificationID2= "" ,Convert.DBNull, Record.QualificationID2))
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
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear1",SqlDbType.NVarChar,5, Iif(Record.QualificationYear1= "" ,Convert.DBNull, Record.QualificationYear1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Iif(Record.ModifiedBy= "" ,Convert.DBNull, Record.ModifiedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Iif(Record.ModifiedOn= "" ,Convert.DBNull, Record.ModifiedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear2",SqlDbType.NVarChar,5, Iif(Record.QualificationYear2= "" ,Convert.DBNull, Record.QualificationYear2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, Iif(Record.ModifiedEvent= "" ,Convert.DBNull, Record.ModifiedEvent))
          Cmd.Parameters.Add("@Return_CardNo", SqlDbType.NVarChar, 8)
          Cmd.Parameters("@Return_CardNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_CardNo").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.HRM_Employees) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spHRM_EmployeesUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AliasName", SqlDbType.NVarChar, 51, Record.AliasName)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_RatingID", SqlDbType.NVarChar, 4, IIf(Record.C_RatingID = "", Convert.DBNull, Record.C_RatingID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving", SqlDbType.DateTime, 21, IIf(Record.C_DateOfReleaving = "", Convert.DBNull, Record.C_DateOfReleaving))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DivisionID", SqlDbType.NVarChar, 7, IIf(Record.J_DivisionID = "", Convert.DBNull, Record.J_DivisionID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EducationDetails", SqlDbType.NVarChar, 251, IIf(Record.EducationDetails = "", Convert.DBNull, Record.EducationDetails))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IncrementCompany", SqlDbType.NVarChar, 7, IIf(Record.IncrementCompany = "", Convert.DBNull, Record.IncrementCompany))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CareerStartedOn",SqlDbType.DateTime,21, Iif(Record.CareerStartedOn= "" ,Convert.DBNull, Record.CareerStartedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID1",SqlDbType.Int,11, Iif(Record.QualificationID1= "" ,Convert.DBNull, Record.QualificationID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID2",SqlDbType.Int,11, Iif(Record.QualificationID2= "" ,Convert.DBNull, Record.QualificationID2))
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
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear1", SqlDbType.NVarChar, 5, IIf(Record.QualificationYear1 = "", Convert.DBNull, Record.QualificationYear1))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear2", SqlDbType.NVarChar, 5, IIf(Record.QualificationYear2 = "", Convert.DBNull, Record.QualificationYear2))
					Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function Delete(ByVal Record As SIS.HRM.HRM_Employees) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spHRM_EmployeesDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,Record.CardNo.ToString.Length, Record.CardNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
'		Autocomplete Method
		Public Shared Function SelectHRM_EmployeesAutoCompleteList(ByVal Prefix As String, ByVal count As Integer) As String()
			Dim Results As List(Of String) = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spHRM_EmployeesAutoCompleteList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---", ""))
					While (Reader.Read())
						Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Reader(0), Reader(1)))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
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
      _C_DesignationID = Ctype(Reader("C_DesignationID"),Int32)
      _C_BasicSalary = Ctype(Reader("C_BasicSalary"),Decimal)
      _C_StatusID = Ctype(Reader("C_StatusID"),String)
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
      _U_ActiveState = Ctype(Reader("U_ActiveState"),Boolean)
      _ActiveState = Ctype(Reader("ActiveState"),Boolean)
      If Convert.IsDBNull(Reader("ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader("ActiveStateEventName"), String)
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
      _U_UnderIncrement = Ctype(Reader("U_UnderIncrement"),Boolean)
      If Convert.IsDBNull(Reader("U_NewBasicSalary")) Then
        _U_NewBasicSalary = String.Empty
      Else
        _U_NewBasicSalary = Ctype(Reader("U_NewBasicSalary"), String)
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
      If Convert.IsDBNull(Reader("C_TransferedOn")) Then
        _C_TransferedOn = String.Empty
      Else
        _C_TransferedOn = Ctype(Reader("C_TransferedOn"), String)
      End If
      _U_UnderPromotion = Ctype(Reader("U_UnderPromotion"),Boolean)
      If Convert.IsDBNull(Reader("C_TransferRemark")) Then
        _C_TransferRemark = String.Empty
      Else
        _C_TransferRemark = Ctype(Reader("C_TransferRemark"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingDoneOn")) Then
        _C_RatingDoneOn = String.Empty
      Else
        _C_RatingDoneOn = Ctype(Reader("C_RatingDoneOn"), String)
      End If
      If Convert.IsDBNull(Reader("U_NewDesignationID")) Then
        _U_NewDesignationID = String.Empty
      Else
        _U_NewDesignationID = Ctype(Reader("U_NewDesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingPoints")) Then
        _C_RatingPoints = String.Empty
      Else
        _C_RatingPoints = Ctype(Reader("C_RatingPoints"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingID")) Then
        _C_RatingID = String.Empty
      Else
        _C_RatingID = Ctype(Reader("C_RatingID"), String)
      End If
      If Convert.IsDBNull(Reader("C_RatingRemark")) Then
        _C_RatingRemark = String.Empty
      Else
        _C_RatingRemark = Ctype(Reader("C_RatingRemark"), String)
      End If
      _U_UnderTransfer = Ctype(Reader("U_UnderTransfer"),Boolean)
      _Resigned = Ctype(Reader("Resigned"),Boolean)
      If Convert.IsDBNull(Reader("U_CompanyID")) Then
        _U_CompanyID = String.Empty
      Else
        _U_CompanyID = Ctype(Reader("U_CompanyID"), String)
      End If
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
      If Convert.IsDBNull(Reader("U_DivisionID")) Then
        _U_DivisionID = String.Empty
      Else
        _U_DivisionID = Ctype(Reader("U_DivisionID"), String)
      End If
      _U_UnderRating = Ctype(Reader("U_UnderRating"),Boolean)
      If Convert.IsDBNull(Reader("C_ResignedRemark")) Then
        _C_ResignedRemark = String.Empty
      Else
        _C_ResignedRemark = Ctype(Reader("C_ResignedRemark"), String)
      End If
      If Convert.IsDBNull(Reader("U_NewRatingID")) Then
        _U_NewRatingID = String.Empty
      Else
        _U_NewRatingID = Ctype(Reader("U_NewRatingID"), String)
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
      If Convert.IsDBNull(Reader("C_ConfirmedOn")) Then
        _C_ConfirmedOn = String.Empty
      Else
        _C_ConfirmedOn = Ctype(Reader("C_ConfirmedOn"), String)
      End If
      _Confirmed = Ctype(Reader("Confirmed"),Boolean)
      If Convert.IsDBNull(Reader("C_ConfirmationRemark")) Then
        _C_ConfirmationRemark = String.Empty
      Else
        _C_ConfirmationRemark = Ctype(Reader("C_ConfirmationRemark"), String)
      End If
      If Convert.IsDBNull(Reader("U_ProjectSiteID")) Then
        _U_ProjectSiteID = String.Empty
      Else
        _U_ProjectSiteID = Ctype(Reader("U_ProjectSiteID"), String)
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
      If Convert.IsDBNull(Reader("QualificationID2")) Then
        _QualificationID2 = String.Empty
      Else
        _QualificationID2 = Ctype(Reader("QualificationID2"), String)
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
      If Convert.IsDBNull(Reader("QualificationYear1")) Then
        _QualificationYear1 = String.Empty
      Else
        _QualificationYear1 = Ctype(Reader("QualificationYear1"), String)
      End If
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
      If Convert.IsDBNull(Reader("QualificationYear2")) Then
        _QualificationYear2 = String.Empty
      Else
        _QualificationYear2 = Ctype(Reader("QualificationYear2"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader("ModifiedEvent"), String)
      End If
      _C_CompanyIDHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies1",Reader)
      _C_DivisionIDHRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions2",Reader)
      _C_OfficeIDHRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices3",Reader)
      _C_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments4",Reader)
      _C_ProjectSiteIDDCM_Projects = New SIS.HRM.hrmProjects("DCM_Projects5",Reader)
      _C_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations6",Reader)
      _C_StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status7",Reader)
      _C_JoinngStateIDHRM_JoiningStates = New SIS.HRM.hrmJoiningStates("HRM_JoiningStates8",Reader)
      _U_NewDesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations9",Reader)
      _C_RatingIDHRM_Ratings = New SIS.HRM.hrmRatings("HRM_Ratings10",Reader)
      _U_CompanyIDHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies11",Reader)
      _U_DivisionIDHRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions12",Reader)
      _U_NewRatingIDHRM_Ratings = New SIS.HRM.hrmRatings("HRM_Ratings14",Reader)
      _U_OfficeIDHRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices13",Reader)
      _U_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments15",Reader)
      _U_ProjectSiteIDDCM_Projects = New SIS.HRM.hrmProjects("DCM_Projects16",Reader)
      _J_CompanyIDHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies17",Reader)
      _J_DivisionIDHRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions18",Reader)
      _J_OfficeIDHRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices19",Reader)
      _J_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments20",Reader)
      _J_ProjectSiteIDDCM_Projects = New SIS.HRM.hrmProjects("DCM_Projects21",Reader)
      _J_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations22",Reader)
      _J_StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status23",Reader)
      _WorkingAreaIDHRM_WorkingAreas = New SIS.HRM.hrmWorkingAreas("HRM_WorkingAreas24",Reader)
      _FunctionalStatusID1HRM_FunctionalStatus1 = New SIS.HRM.hrmFunctionalStatus1("HRM_FunctionalStatus125",Reader)
      _FunctionalStatusID2HRM_FunctionalStatus2 = New SIS.HRM.hrmFunctionalStatus2("HRM_FunctionalStatus226",Reader)
      _FunctionalStatusID3HRM_FunctionalStatus3 = New SIS.HRM.hrmFunctionalStatus3("HRM_FunctionalStatus327",Reader)
      _FunctionalStatusID4HRM_FunctionalStatus4 = New SIS.HRM.hrmFunctionalStatus4("HRM_FunctionalStatus428",Reader)
      _IncrementCompanyHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies29",Reader)
      _QualificationID1HRM_Qualifications = New SIS.HRM.hrmQualifications("HRM_Qualifications30",Reader)
      _QualificationID2HRM_Qualifications = New SIS.HRM.hrmQualifications("HRM_Qualifications31",Reader)
      _BloodGroupIDHRM_BloodGroups = New SIS.HRM.hrmBloodGroups("HRM_BloodGroups32",Reader)
      _ModifiedByaspnet_Users = New SIS.HRM.hrmUsers("aspnet_Users33",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _Salute = Ctype(Reader(AliasName & "_Salute"),String)
      _EmployeeName = Ctype(Reader(AliasName & "_EmployeeName"),String)
      _AliasName = Ctype(Reader(AliasName & "_AliasName"),String)
      _Gender = Ctype(Reader(AliasName & "_Gender"),String)
      If Convert.IsDBNull(Reader(AliasName & "_C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader(AliasName & "_C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_CompanyID")) Then
        _C_CompanyID = String.Empty
      Else
        _C_CompanyID = Ctype(Reader(AliasName & "_C_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DivisionID")) Then
        _C_DivisionID = String.Empty
      Else
        _C_DivisionID = Ctype(Reader(AliasName & "_C_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_OfficeID")) Then
        _C_OfficeID = String.Empty
      Else
        _C_OfficeID = Ctype(Reader(AliasName & "_C_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader(AliasName & "_C_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_ProjectSiteID")) Then
        _C_ProjectSiteID = String.Empty
      Else
        _C_ProjectSiteID = Ctype(Reader(AliasName & "_C_ProjectSiteID"), String)
      End If
      _C_DesignationID = Ctype(Reader(AliasName & "_C_DesignationID"),Int32)
      _C_BasicSalary = Ctype(Reader(AliasName & "_C_BasicSalary"),Decimal)
      _C_StatusID = Ctype(Reader(AliasName & "_C_StatusID"),String)
      If Convert.IsDBNull(Reader(AliasName & "_C_StatusRemark")) Then
        _C_StatusRemark = String.Empty
      Else
        _C_StatusRemark = Ctype(Reader(AliasName & "_C_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_JoinngStateID")) Then
        _C_JoinngStateID = String.Empty
      Else
        _C_JoinngStateID = Ctype(Reader(AliasName & "_C_JoinngStateID"), String)
      End If
      _U_ActiveState = Ctype(Reader(AliasName & "_U_ActiveState"),Boolean)
      _ActiveState = Ctype(Reader(AliasName & "_ActiveState"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader(AliasName & "_ActiveStateEventName"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_IncrementOn")) Then
        _C_IncrementOn = String.Empty
      Else
        _C_IncrementOn = Ctype(Reader(AliasName & "_C_IncrementOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_IncrementRemark")) Then
        _C_IncrementRemark = String.Empty
      Else
        _C_IncrementRemark = Ctype(Reader(AliasName & "_C_IncrementRemark"), String)
      End If
      _U_UnderIncrement = Ctype(Reader(AliasName & "_U_UnderIncrement"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_U_NewBasicSalary")) Then
        _U_NewBasicSalary = String.Empty
      Else
        _U_NewBasicSalary = Ctype(Reader(AliasName & "_U_NewBasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_PromotionOn")) Then
        _C_PromotionOn = String.Empty
      Else
        _C_PromotionOn = Ctype(Reader(AliasName & "_C_PromotionOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_PromotionRemark")) Then
        _C_PromotionRemark = String.Empty
      Else
        _C_PromotionRemark = Ctype(Reader(AliasName & "_C_PromotionRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_TransferedOn")) Then
        _C_TransferedOn = String.Empty
      Else
        _C_TransferedOn = Ctype(Reader(AliasName & "_C_TransferedOn"), String)
      End If
      _U_UnderPromotion = Ctype(Reader(AliasName & "_U_UnderPromotion"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_C_TransferRemark")) Then
        _C_TransferRemark = String.Empty
      Else
        _C_TransferRemark = Ctype(Reader(AliasName & "_C_TransferRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_RatingDoneOn")) Then
        _C_RatingDoneOn = String.Empty
      Else
        _C_RatingDoneOn = Ctype(Reader(AliasName & "_C_RatingDoneOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_NewDesignationID")) Then
        _U_NewDesignationID = String.Empty
      Else
        _U_NewDesignationID = Ctype(Reader(AliasName & "_U_NewDesignationID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_RatingPoints")) Then
        _C_RatingPoints = String.Empty
      Else
        _C_RatingPoints = Ctype(Reader(AliasName & "_C_RatingPoints"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_RatingID")) Then
        _C_RatingID = String.Empty
      Else
        _C_RatingID = Ctype(Reader(AliasName & "_C_RatingID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_RatingRemark")) Then
        _C_RatingRemark = String.Empty
      Else
        _C_RatingRemark = Ctype(Reader(AliasName & "_C_RatingRemark"), String)
      End If
      _U_UnderTransfer = Ctype(Reader(AliasName & "_U_UnderTransfer"),Boolean)
      _Resigned = Ctype(Reader(AliasName & "_Resigned"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_U_CompanyID")) Then
        _U_CompanyID = String.Empty
      Else
        _U_CompanyID = Ctype(Reader(AliasName & "_U_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_ResignedOn")) Then
        _C_ResignedOn = String.Empty
      Else
        _C_ResignedOn = Ctype(Reader(AliasName & "_C_ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DateOfReleaving")) Then
        _C_DateOfReleaving = String.Empty
      Else
        _C_DateOfReleaving = Ctype(Reader(AliasName & "_C_DateOfReleaving"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_DivisionID")) Then
        _U_DivisionID = String.Empty
      Else
        _U_DivisionID = Ctype(Reader(AliasName & "_U_DivisionID"), String)
      End If
      _U_UnderRating = Ctype(Reader(AliasName & "_U_UnderRating"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_C_ResignedRemark")) Then
        _C_ResignedRemark = String.Empty
      Else
        _C_ResignedRemark = Ctype(Reader(AliasName & "_C_ResignedRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_NewRatingID")) Then
        _U_NewRatingID = String.Empty
      Else
        _U_NewRatingID = Ctype(Reader(AliasName & "_U_NewRatingID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_OfficeID")) Then
        _U_OfficeID = String.Empty
      Else
        _U_OfficeID = Ctype(Reader(AliasName & "_U_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_DepartmentID")) Then
        _U_DepartmentID = String.Empty
      Else
        _U_DepartmentID = Ctype(Reader(AliasName & "_U_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_ConfirmedOn")) Then
        _C_ConfirmedOn = String.Empty
      Else
        _C_ConfirmedOn = Ctype(Reader(AliasName & "_C_ConfirmedOn"), String)
      End If
      _Confirmed = Ctype(Reader(AliasName & "_Confirmed"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_C_ConfirmationRemark")) Then
        _C_ConfirmationRemark = String.Empty
      Else
        _C_ConfirmationRemark = Ctype(Reader(AliasName & "_C_ConfirmationRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_U_ProjectSiteID")) Then
        _U_ProjectSiteID = String.Empty
      Else
        _U_ProjectSiteID = Ctype(Reader(AliasName & "_U_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_CompanyID")) Then
        _J_CompanyID = String.Empty
      Else
        _J_CompanyID = Ctype(Reader(AliasName & "_J_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DivisionID")) Then
        _J_DivisionID = String.Empty
      Else
        _J_DivisionID = Ctype(Reader(AliasName & "_J_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_OfficeID")) Then
        _J_OfficeID = String.Empty
      Else
        _J_OfficeID = Ctype(Reader(AliasName & "_J_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DepartmentID")) Then
        _J_DepartmentID = String.Empty
      Else
        _J_DepartmentID = Ctype(Reader(AliasName & "_J_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_ProjectSiteID")) Then
        _J_ProjectSiteID = String.Empty
      Else
        _J_ProjectSiteID = Ctype(Reader(AliasName & "_J_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DesignationID")) Then
        _J_DesignationID = String.Empty
      Else
        _J_DesignationID = Ctype(Reader(AliasName & "_J_DesignationID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_BasicSalary")) Then
        _J_BasicSalary = String.Empty
      Else
        _J_BasicSalary = Ctype(Reader(AliasName & "_J_BasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_StatusID")) Then
        _J_StatusID = String.Empty
      Else
        _J_StatusID = Ctype(Reader(AliasName & "_J_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_StatusRemark")) Then
        _J_StatusRemark = String.Empty
      Else
        _J_StatusRemark = Ctype(Reader(AliasName & "_J_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_WorkingAreaID")) Then
        _WorkingAreaID = String.Empty
      Else
        _WorkingAreaID = Ctype(Reader(AliasName & "_WorkingAreaID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID1")) Then
        _FunctionalStatusID1 = String.Empty
      Else
        _FunctionalStatusID1 = Ctype(Reader(AliasName & "_FunctionalStatusID1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID2")) Then
        _FunctionalStatusID2 = String.Empty
      Else
        _FunctionalStatusID2 = Ctype(Reader(AliasName & "_FunctionalStatusID2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID3")) Then
        _FunctionalStatusID3 = String.Empty
      Else
        _FunctionalStatusID3 = Ctype(Reader(AliasName & "_FunctionalStatusID3"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID4")) Then
        _FunctionalStatusID4 = String.Empty
      Else
        _FunctionalStatusID4 = Ctype(Reader(AliasName & "_FunctionalStatusID4"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_EducationDetails")) Then
        _EducationDetails = String.Empty
      Else
        _EducationDetails = Ctype(Reader(AliasName & "_EducationDetails"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_IncrementCompany")) Then
        _IncrementCompany = String.Empty
      Else
        _IncrementCompany = Ctype(Reader(AliasName & "_IncrementCompany"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CareerStartedOn")) Then
        _CareerStartedOn = String.Empty
      Else
        _CareerStartedOn = Ctype(Reader(AliasName & "_CareerStartedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationID1")) Then
        _QualificationID1 = String.Empty
      Else
        _QualificationID1 = Ctype(Reader(AliasName & "_QualificationID1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationID2")) Then
        _QualificationID2 = String.Empty
      Else
        _QualificationID2 = Ctype(Reader(AliasName & "_QualificationID2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_DateOfBirth")) Then
        _DateOfBirth = String.Empty
      Else
        _DateOfBirth = Ctype(Reader(AliasName & "_DateOfBirth"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_BloodGroupID")) Then
        _BloodGroupID = String.Empty
      Else
        _BloodGroupID = Ctype(Reader(AliasName & "_BloodGroupID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FatherName")) Then
        _FatherName = String.Empty
      Else
        _FatherName = Ctype(Reader(AliasName & "_FatherName"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_SpouseName")) Then
        _SpouseName = String.Empty
      Else
        _SpouseName = Ctype(Reader(AliasName & "_SpouseName"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ContactNumbers")) Then
        _ContactNumbers = String.Empty
      Else
        _ContactNumbers = Ctype(Reader(AliasName & "_ContactNumbers"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PermanentAddress")) Then
        _PermanentAddress = String.Empty
      Else
        _PermanentAddress = Ctype(Reader(AliasName & "_PermanentAddress"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PermanentCity")) Then
        _PermanentCity = String.Empty
      Else
        _PermanentCity = Ctype(Reader(AliasName & "_PermanentCity"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CurrentAddress")) Then
        _CurrentAddress = String.Empty
      Else
        _CurrentAddress = Ctype(Reader(AliasName & "_CurrentAddress"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CurrentCity")) Then
        _CurrentCity = String.Empty
      Else
        _CurrentCity = Ctype(Reader(AliasName & "_CurrentCity"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_OfficeFileNumber")) Then
        _OfficeFileNumber = String.Empty
      Else
        _OfficeFileNumber = Ctype(Reader(AliasName & "_OfficeFileNumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PFNumber")) Then
        _PFNumber = String.Empty
      Else
        _PFNumber = Ctype(Reader(AliasName & "_PFNumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ESINumber")) Then
        _ESINumber = String.Empty
      Else
        _ESINumber = Ctype(Reader(AliasName & "_ESINumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PAN")) Then
        _PAN = String.Empty
      Else
        _PAN = Ctype(Reader(AliasName & "_PAN"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_EMailID")) Then
        _EMailID = String.Empty
      Else
        _EMailID = Ctype(Reader(AliasName & "_EMailID"), String)
      End If
      _Freezed = Ctype(Reader(AliasName & "_Freezed"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_QualificationYear1")) Then
        _QualificationYear1 = String.Empty
      Else
        _QualificationYear1 = Ctype(Reader(AliasName & "_QualificationYear1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader(AliasName & "_ModifiedBy"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader(AliasName & "_ModifiedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationYear2")) Then
        _QualificationYear2 = String.Empty
      Else
        _QualificationYear2 = Ctype(Reader(AliasName & "_QualificationYear2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader(AliasName & "_ModifiedEvent"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace

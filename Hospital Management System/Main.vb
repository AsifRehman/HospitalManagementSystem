Imports System.Windows.Forms

Public Class Main

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub


    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AddUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUsersToolStripMenuItem.Click
        frmAddNew_User.MdiParent = Me
        frmAddNew_User.Show()
    End Sub

    Private Sub ManageLabTestsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageLabTestsToolStripMenuItem.Click
        testentry.MdiParent = Me
        testentry.Show()
    End Sub

    Private Sub SelfLabTestRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelfLabTestRequestToolStripMenuItem.Click
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub VendorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Vendors.MdiParent = Me
        Vendors.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ViewDrugsInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDrugsInToolStripMenuItem.Click
        Drugs_Instock.MdiParent = Me
        Drugs_Instock.Show()
    End Sub

    Private Sub ViewDrugsOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Drugs_Out.MdiParent = Me
        Drugs_Out.Show()

    End Sub

    Private Sub IPAdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DischargePatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Discharge.MdiParent = Me
        'Discharge.Show()
    End Sub

    Private Sub OPBillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPBillingToolStripMenuItem.Click
        Outpatient_Billing.MdiParent = Me
        Outpatient_Billing.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TreatmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationToolStripMenuItem.Click
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub TreatmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub FamilyPlanningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamilyPlanningToolStripMenuItem.Click
        frmFamplan.MdiParent = Me
        frmFamplan.Show()
    End Sub

    Private Sub MCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCHToolStripMenuItem.Click
        Immunization.MdiParent = Me
        Immunization.Show()
    End Sub

    Private Sub OthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersToolStripMenuItem.Click
        Others.MdiParent = Me
        Others.Show()
    End Sub

    Private Sub ReceivePatientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceivePatientsToolStripMenuItem.Click
        OutpatLabTreatment.MdiParent = Me
        OutpatLabTreatment.Show()
    End Sub

    Private Sub LabResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabResultsToolStripMenuItem.Click
        LabResult.MdiParent = Me
        LabResult.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Counter_Sale.MdiParent = Me
        Counter_Sale.Show()
    End Sub

    Private Sub OutpatientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutpatientsToolStripMenuItem.Click
        PatientRec.MdiParent = Me
        PatientRec.Show()
    End Sub

    Private Sub OPPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'OpPayment.MdiParent = Me
        'OpPayment.Show()
    End Sub

    Private Sub PaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem.Click
        'PaymentRpt.MdiParent = Me
        'PaymentRpt.Show()
    End Sub

    Private Sub InventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem1.Click

    End Sub

    Private Sub DrugsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrugsToolStripMenuItem.Click
        stock.MdiParent = Me
        stock.Show()
    End Sub

    Private Sub OutPatientsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientsToolStripMenuItem1.Click
        PatientRec.MdiParent = Me
        PatientRec.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc.exe")
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Shell("notepad")
    End Sub

    Private Sub LabTestPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestPaymentToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        ''Me.Close()
        With frmlogin

            .ShowDialog()
        End With
    End Sub

    Private Sub MDI_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to Turn off system?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            With frmlogin
                .ShowDialog()
            End With
        End If
    End Sub



    Private Sub SelfLabRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelfLabRequestToolStripMenuItem.Click
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub


    Private Sub Above5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Above5ToolStripMenuItem.Click
        AboveFive.MdiParent = Me
        AboveFive.Show()
    End Sub

    Private Sub Below5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Below5ToolStripMenuItem.Click
        Below5.MdiParent = Me
        Below5.Show()
    End Sub

    Private Sub LabReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabResults.MdiParent = Me
        LabResults.Show()
    End Sub

    Private Sub PatientProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientProfileToolStripMenuItem.Click
        Patient_Profile.MdiParent = Me
        Patient_Profile.Show()
    End Sub

    Private Sub PhysicalExaminationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalExaminationToolStripMenuItem1.Click
        Physical_Examination.MdiParent = Me
        Physical_Examination.Show()
    End Sub

    Private Sub VitalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VitalsToolStripMenuItem.Click
        View_Vitals.MdiParent = Me
        View_Vitals.Show()
    End Sub

    Private Sub LabRequstResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabRequstResultToolStripMenuItem.Click
        Lab_Request_Results.MdiParent = Me
        Lab_Request_Results.Show()
    End Sub

    Private Sub DailyCostToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCostToolStripMenuItem.Click

        DailyDrug_Cost.MdiParent = Me
        DailyDrug_Cost.Show()
    End Sub


    Private Sub GeneralViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralViewToolStripMenuItem.Click
        ViewFP.MdiParent = Me
        ViewFP.Show()
    End Sub

    Private Sub DailyRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyRecordsToolStripMenuItem.Click
        DailyFP.MdiParent = Me
        DailyFP.Show()
    End Sub

    Private Sub GeneralViewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralViewToolStripMenuItem1.Click
        GeneralMCH.MdiParent = Me
        GeneralMCH.Show()
    End Sub

    Private Sub DailyRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyRecordToolStripMenuItem.Click
        DailyMCH.MdiParent = Me
        DailyMCH.Show()
    End Sub

    Private Sub WeeklyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeeklyReportToolStripMenuItem.Click
        WklyRpt.MdiParent = Me
        WklyRpt.Show()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmlogin

            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Vendors.MdiParent = Me
        Vendors.Show()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
        Outpatient_Registration.MdiParent = Me
        Outpatient_Registration.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub RecievePatientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecievePatientsToolStripMenuItem.Click
        OutpatLabTreatment.MdiParent = Me
        OutpatLabTreatment.Show()
    End Sub

    Private Sub SelfRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelfRequestToolStripMenuItem.Click
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub ManageTestsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageTestsToolStripMenuItem.Click
        testentry.MdiParent = Me
        testentry.Show()
    End Sub

    Private Sub LabTestPaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestPaymentToolStripMenuItem1.Click
        LabTestPayment.MdiParent = Me
        LabTestPayment.Show()
    End Sub

    Private Sub ReportingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportingToolStripMenuItem1.Click
        WklyRpt.MdiParent = Me
        WklyRpt.Show()
    End Sub

    Private Sub PrescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionToolStripMenuItem.Click
        PrescriptionBill.MdiParent = Me
        PrescriptionBill.Show()
    End Sub

    Private Sub POSSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSSaleToolStripMenuItem.Click
        Counter_Sale.MdiParent = Me
        Counter_Sale.Show()
    End Sub

    Private Sub InStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InStockToolStripMenuItem.Click
        Drugs_Instock.MdiParent = Me
        Drugs_Instock.Show()
    End Sub

    Private Sub PatientProfileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientProfileToolStripMenuItem1.Click
        Patient_Profile.MdiParent = Me
        Patient_Profile.Show()
    End Sub

    Private Sub PhysicalExamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalExamsToolStripMenuItem.Click
        Physical_Examination.MdiParent = Me
        Physical_Examination.Show()
    End Sub

    Private Sub VitalInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VitalInformationToolStripMenuItem.Click
        View_Vitals.MdiParent = Me
        View_Vitals.Show()
    End Sub

    Private Sub LabRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabRequestToolStripMenuItem.Click
        Lab_Request_Results.MdiParent = Me
        Lab_Request_Results.Show()
    End Sub

    Private Sub DailyCostsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyCostsToolStripMenuItem.Click
        DailyDrug_Cost.MdiParent = Me
        DailyDrug_Cost.Show()
    End Sub

    Private Sub AddUsersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUsersToolStripMenuItem1.Click
        frmAddNew_User.MdiParent = Me
        frmAddNew_User.Show()
    End Sub

    Private Sub MedicalSickOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalSickOffToolStripMenuItem.Click
        Sick_Off.MdiParent = Me
        Sick_Off.Show()
    End Sub

    Private Sub OtherProceduresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherProceduresToolStripMenuItem.Click
        Others.MdiParent = Me
        Others.Show()
    End Sub

    Private Sub MCHToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCHToolStripMenuItem1.Click
        Immunization.MdiParent = Me
        Immunization.Show()
    End Sub

    Private Sub FamilyPlanningToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamilyPlanningToolStripMenuItem2.Click

    End Sub

    Private Sub GeneralViewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralViewToolStripMenuItem2.Click
        ViewFP.MdiParent = Me
        ViewFP.Show()
    End Sub

    Private Sub DailyRecordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyRecordToolStripMenuItem1.Click
        DailyFP.MdiParent = Me
        DailyFP.Show()
    End Sub

    Private Sub GeneralViewToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralViewToolStripMenuItem3.Click
        GeneralMCH.MdiParent = Me
        GeneralMCH.Show()
    End Sub

    Private Sub DailyRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyRecordsToolStripMenuItem1.Click
        DailyMCH.MdiParent = Me
        DailyMCH.Show()
    End Sub

    Private Sub DrugEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrugEntryToolStripMenuItem.Click
        'frmDrugEntry.MdiParent = Me
        'frmDrugEntry.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        'Vendors.MdiParent = Me
        'Vendors.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem1.Click
        Shell("calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem1.Click
        Shell("notepad.exe")
    End Sub

    Private Sub PaymentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsToolStripMenuItem1.Click
        'PaymentRpt.MdiParent = Me
        'PaymentRpt.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockOutToolStripMenuItem1.Click

    End Sub

    Private Sub OutpatientsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutpatientsReportToolStripMenuItem.Click
        PatientRec.MdiParent = Me
        PatientRec.Show()
    End Sub

    Private Sub DrugsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrugsReportToolStripMenuItem.Click
        stock.MdiParent = Me
        stock.Show()
    End Sub


    Private Sub DiagnosisEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dianosis_Entry.MdiParent = Me
        Dianosis_Entry.Show()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click

    End Sub

    Private Sub PaymentMonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentMonthlyToolStripMenuItem.Click
        Monthly_Payment_View.MdiParent = Me
        Monthly_Payment_View.Show()
    End Sub

    Private Sub PendingPatientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingPatientsToolStripMenuItem.Click
        Pending_Patients.MdiParent = Me
        Pending_Patients.Show()
    End Sub

    Private Sub ProcedureEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcedureEntryToolStripMenuItem.Click
        Procedures_Entry.MdiParent = Me
        Procedures_Entry.Show()
    End Sub

    Private Sub DiagnosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisToolStripMenuItem.Click
        frmDiagnosis.MdiParent = Me
        frmDiagnosis.Show()
    End Sub

    Private Sub DiagnosisToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosisToolStripMenuItem1.Click
        frmDiagnosis.MdiParent = Me
        frmDiagnosis.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Outpatient_Registration.MdiParent = Me
        Outpatient_Registration.Show()
    End Sub

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Outpatient_Billing.MdiParent = Me
        Outpatient_Billing.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub ToolStripMenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem26.Click
        Update_Payments.MdiParent = Me
        Update_Payments.Show()
    End Sub

    Private Sub ToolStripMenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
        ViewPayments.MdiParent = Me
        ViewPayments.Show()
    End Sub

    Private Sub ToolStripMenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        AboveFive.MdiParent = Me
        AboveFive.Show()
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        Counter_Sale.MdiParent = Me
        Counter_Sale.Show()
    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        Below5.MdiParent = Me
        Below5.Show()
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        Drugs_Out.MdiParent = Me
        Drugs_Out.Show()
    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        frmFamplan.MdiParent = Me
        frmFamplan.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        LabTestPayment.MdiParent = Me
        LabTestPayment.Show()
    End Sub

    Private Sub ToolStripMenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem31.Click
        Sick_Off.MdiParent = Me
        Sick_Off.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        testentry.MdiParent = Me
        testentry.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        WklyRpt.MdiParent = Me
        WklyRpt.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        OutpatLabTreatment.MdiParent = Me
        OutpatLabTreatment.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Pending_Patients.MdiParent = Me
        Pending_Patients.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub ToolStripMenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem29.Click
        Immunization.MdiParent = Me
        Immunization.Show()
    End Sub

    Private Sub ToolStripMenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem30.Click
        Others.MdiParent = Me
        Others.Show()
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        Patient_Profile.MdiParent = Me
        Patient_Profile.Show()
    End Sub

    Private Sub ToolStripMenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem35.Click
        Physical_Examination.MdiParent = Me
        Physical_Examination.Show()
    End Sub

    Private Sub ToolStripMenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem36.Click
        View_Vitals.MdiParent = Me
        View_Vitals.Show()
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        Lab_Request_Results.MdiParent = Me
        Lab_Request_Results.Show()
    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        DailyDrug_Cost.MdiParent = Me
        DailyDrug_Cost.Show()
    End Sub

    Private Sub ToolStripMenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem43.Click
        ViewFP.MdiParent = Me
        ViewFP.Show()
    End Sub

    Private Sub ToolStripMenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem44.Click
        DailyFP.MdiParent = Me
        DailyFP.Show()
    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        GeneralMCH.MdiParent = Me
        GeneralMCH.Show()
    End Sub

    Private Sub ToolStripMenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem47.Click

    End Sub

    Private Sub ToolStripMenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem64.Click
        Shell("calc.exe")
    End Sub

    Private Sub ToolStripMenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem65.Click
        Shell("notepad.exe")

    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        frmDiagnosis.MdiParent = Me
        frmDiagnosis.Show()
    End Sub

    Private Sub ToolStripMenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        PatientRec.MdiParent = Me
        PatientRec.Show()
    End Sub

    Private Sub ToolStripMenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem58.Click
        stock.MdiParent = Me
        stock.Show()
    End Sub

    Private Sub ToolStripMenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddNew_User.MdiParent = Me
        frmAddNew_User.Show()
    End Sub

    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem66.Click
        With frmlogin

            .ShowDialog()
        End With
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        LabResult.MdiParent = Me
        LabResult.Show()
    End Sub

    Private Sub DrugEntryToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrugEntryToolStripMenuItem3.Click
        frmDrugEntry.MdiParent = Me
        frmDrugEntry.Show()
    End Sub

    Private Sub AddUsersToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUsersToolStripMenuItem2.Click
        frmAddNew_User.MdiParent = Me
        frmAddNew_User.Show()
    End Sub

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DateTime = Today
        frmlogin.ShowDialog()
        datetime.Text = dt.ToString("dd/MM/yyyy")
        time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim dt As DateTime = Today
        datetime.Text = dt.ToString("dd/MM/yyyy")
        time.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        PrescriptionBill.MdiParent = Me
        PrescriptionBill.Show()
    End Sub

    Private Sub ProcedureEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcedureEntryToolStripMenuItem1.Click
        Procedures_Entry.MdiParent = Me
        Procedures_Entry.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        Drugs_Instock.MdiParent = Me
        Drugs_Instock.Show()
    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click
        frmLock.ShowDialog()
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutAppToolStripMenuItem.Click
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub VButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDrugEntry.MdiParent = Me
        frmDrugEntry.Show()
    End Sub

    Private Sub VButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddNew_User.MdiParent = Me
        frmAddNew_User.Show()
    End Sub

    Private Sub VButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Procedures_Entry.MdiParent = Me
        Procedures_Entry.Show()
    End Sub

    Private Sub VButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("calc.exe")
    End Sub

    Private Sub VButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell("Notepad.exe")
    End Sub

    Private Sub VButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Outpatient_Registration.MdiParent = Me
        Outpatient_Registration.Show()
    End Sub

    Private Sub VButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub VButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabResult.MdiParent = Me
        LabResult.Show()
    End Sub

    Private Sub VButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Consultation.MdiParent = Me
        Consultation.Show()
    End Sub

    Private Sub VButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabResult.MdiParent = Me
        LabResult.Show()
    End Sub

    Private Sub VButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Physical_Examination.MdiParent = Me
        Physical_Examination.Show()
    End Sub

    Private Sub VButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDiagnosis.MdiParent = Me
        frmDiagnosis.Show()
    End Sub

    Private Sub VButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OutpatLabTreatment.MdiParent = Me
        OutpatLabTreatment.Show()
    End Sub

    Private Sub VButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabTestPayment.MdiParent = Me
        LabTestPayment.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click

    End Sub

    Private Sub VButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WklyRpt.MdiParent = Me
        WklyRpt.Show()
    End Sub

    Private Sub VButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Self_Request.MdiParent = Me
        Self_Request.Show()
    End Sub

    Private Sub VButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        testentry.MdiParent = Me
        testentry.Show()
    End Sub

    Private Sub VButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Outpatient_Billing.MdiParent = Me
        Outpatient_Billing.Show()
    End Sub

    Private Sub VButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewPayments.MdiParent = Me
        ViewPayments.Show()
    End Sub

    Private Sub VButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Update_Payments.MdiParent = Me
        Update_Payments.Show()
    End Sub

    Private Sub VButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmlogin
            .ShowDialog()
        End With
    End Sub

    Private Sub VButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLock.ShowDialog()
    End Sub

    Private Sub VButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure you want to Turn off system?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            Application.ExitThread()
            'Else
            '    With frmlogin
            '        .ShowDialog()
            '    End With
        End If
    End Sub

    Private Sub VButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrescriptionBill.MdiParent = Me
        PrescriptionBill.Show()
    End Sub

    Private Sub VButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Counter_Sale.MdiParent = Me
        Counter_Sale.Show()
    End Sub

    Private Sub VButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Drugs_Instock.MdiParent = Me
        Drugs_Instock.Show()
    End Sub

    Private Sub VButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Drugs_Out.MdiParent = Me
        Drugs_Out.Show()
    End Sub

    Private Sub VButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFamplan.MdiParent = Me
        frmFamplan.Show()
    End Sub

    Private Sub VButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Immunization.MdiParent = Me
        Immunization.Show()
    End Sub

    Private Sub VButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Others.MdiParent = Me
        Others.Show()
    End Sub


    Private Sub VButton40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboveFive.MdiParent = Me
        AboveFive.Show()
    End Sub

    Private Sub VButton41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Below5.MdiParent = Me
        Below5.Show()
    End Sub


    Private Sub VButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stock.MdiParent = Me
        stock.Show()
    End Sub

    Private Sub VButton39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub VButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Physical_Examination.MdiParent = Me
        Physical_Examination.Show()
    End Sub

    Private Sub VButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        View_Vitals.MdiParent = Me
        View_Vitals.Show()
    End Sub

    Private Sub VButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Lab_Request_Results.MdiParent = Me
        Lab_Request_Results.Show()
    End Sub

    Private Sub VButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DailyDrug_Cost.MdiParent = Me
        DailyDrug_Cost.Show()
    End Sub

    Private Sub VButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DailyFP.MdiParent = Me
        DailyFP.Show()
    End Sub

    Private Sub VButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GeneralMCH.MdiParent = Me
        GeneralMCH.Show()
    End Sub

    Private Sub PatientReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientReportToolStripMenuItem.Click
        Patient_Report.MdiParent = Me
        Patient_Report.Show()
    End Sub

    Private Sub FamilyPlanningMethodsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamilyPlanningMethodsToolStripMenuItem.Click
        FrmFpMethods_Entry.MdiParent = Me
        FrmFpMethods_Entry.Show()
    End Sub
End Class

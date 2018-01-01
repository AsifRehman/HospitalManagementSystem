Imports MySql.Data.MySqlClient
Module Declaration
    Public Sub filllabCombo()
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select distinct PatientNO from outpatientlabrequest where Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("PatientNO")
                OutpatLabTreatment.cbopno.Items.Add(pno)
            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub fillFPMethod()
        Try
            connectDB()
            
            sql = "select distinct Name from proce_entry"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("Name")
                frmFamplan.cboMethod.Items.Add(pno)
            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Public Sub fillFamilyPlanning()
        Try
            connectDB()

            sql = "select distinct Name from tblfp"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("Name")
                frmFamplan.cboMethod.Items.Add(pno)
            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Public Sub fillCounterSaleCombo()
        'Try
        '    connectDB()
        '    'Dim Lbqst As String
        '    'Lbqst = "YES"
        '    sql = "select distinct Drug_Name from drugentry where Quantity > 0 "
        '    cmd = New MySqlCommand(sql, conn)
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        Dim pno = dr.GetString("Drug_Name")
        '        Counter_Sale.cbodrgname.Items.Add(pno)
        '    End While
        '    conn.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    conn.Dispose()
        'End Try
    End Sub
    Public Sub filllabResult()
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select distinct PatientNO from outpatientlabresult where Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("PatientNO")
                LabResult.cbopno.Items.Add(pno)
            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub fillOutpatPrescription()
        'Try
        '    connectDB()
        '    sql = "select * from drugentry where Quantity > 0 "
        '    cmd = New MySqlCommand(sql, conn)
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        Dim pno = dr.GetString("Drug_Name")
        '        Prescription.cmbDrgName.Items.Add(pno)
        '    End While
        '    conn.Close()
        '    dr.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    conn.Dispose()
        'End Try
    End Sub
    Public Sub fillprocedure()
        Try
            connectDB()

            sql = "select * from Proce_Entry "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("Name")
                Others.cboprname.Items.Add(pno)
            End While
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Public Sub fillDrugVendorName()
        'Try
        '    connectDB()

        '    sql = "select * from vendor "
        '    cmd = New MySqlCommand(sql, conn)
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        Dim pno = dr.GetString("VendorName")
        '        Drugs_Entry.cbovName.Items.Add(pno)
        '    End While
        '    conn.Close()
        '    dr.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    conn.Dispose()
        'End Try
    End Sub
    Public Sub fillinpRegWard()
        Try
            connectDB()
            Dim how As String
            how = "PARTIAL _PAYMENT"
            sql = "select * from payments where Balance > 0 "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("PatientNO")
                'Discharge.cbopno.Items.Add(pno)
            End While
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub fillinpRegBed()
        Try
            connectDB()
            Dim how As String
            how = "PARTIAL _PAYMENT"
            sql = "select * from payments where Balance > 0 "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("PatientNO")
                'Discharge.cbopno.Items.Add(pno)
            End While
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub fillMoveOutpat2inpat()
        'Try
        '    connectDB()
        '    Dim how As String
        '    how = "PARTIAL _PAYMENT"
        '    sql = "select * from outpatregistration  "
        '    cmd = New MySqlCommand(sql, conn)
        '    dr = cmd.ExecuteReader
        '    While dr.Read
        '        Dim pno = dr.GetString("PatientNO")
        '        Move_Patients.cmbopid.Items.Add(pno)
        '    End While
        '    conn.Close()
        '    dr.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    conn.Dispose()
        'End Try
    End Sub
    Public Sub fillConsultPNO()
        Try
            connectDB()

            sql = "select * from Proce_Entry "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("Name")
                frmFamplan.cboMethod.Items.Add(pno)
            End While
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Public Sub fillPatientReport()
        Try
            connectDB()
            'Dim how As String

            sql = "select * from outpattreatment where Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim pno = dr.GetString("PatientNO")
                Patient_Report.cbopno.Items.Add(pno)
            End While
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub Fadein()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.05
            frmSplashScreen.Opacity = fade
            frmSplashScreen.Refresh()
            Threading.Thread.Sleep(100)
        Next

    End Sub

End Module

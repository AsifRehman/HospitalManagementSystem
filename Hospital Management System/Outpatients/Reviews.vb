Imports MySql.Data.MySqlClient
Public Class Reviews

    Private Sub Reviews_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select PatientNO,Patient_Name,Age,CNS,GIT,GNT,RS,Abnominal,Compains,History,Examination,impression,LabInvestigation,NextReview,Entry_Date from outpattreatment where NextReview = '" & DateTime.Today & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select PatientNO,Patient_Name,Age,CNS,GIT,GNT,RS,Abnominal,Compains,History,Examination,impression,LabInvestigation,NextReview,Entry_Date from outpattreatment where Patient_Name like '" & txtsearch.Text & "%' and NextReview = '" & DateTime.Today & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
Public Class Qlsv
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
        Me.SINHVIENTableAdapter.Fill(Me.QLSVDataSet.SINHVIEN)
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        SINHVIENBindingSource.AddNew()
    End Sub

    Private Sub btnFix_Click(sender As Object, e As EventArgs) Handles btnFix.Click
        On Error GoTo SaveErr
        SINHVIENBindingSource.EndEdit()
        SINHVIENTableAdapter.Update(QLSVDataSet.SINHVIEN)
        MessageBox.Show(" Update Successful!")
SaveErr: Exit Sub
    End Sub

    Private Sub btnTIMKIEM_Click(sender As Object, e As EventArgs) Handles btnTIMKIEM.Click
        gbTTSV.Hide()
        Dim masv = InputBox("Fill the MASV:")
        SINHVIENBindingSource.Filter = "Masv='" & masv & "'"
    End Sub




    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        SINHVIENBindingSource.RemoveCurrent()
    End Sub

    Private Sub RefreshDataGridView()
        ' Làm mới dữ liệu từ nguồn dữ liệu (SINHVIENBindingSource1)
        SINHVIENBindingSource.ResetBindings(False)
        ' Cập nhật lại hiển thị của DataGridView (BHTTT)
        BHTTTSV.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        gbTTSV.Show()
        SINHVIENBindingSource.RemoveFilter()
        RefreshDataGridView()


    End Sub

End Class

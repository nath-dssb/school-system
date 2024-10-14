Public Class Frmregister
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_MouseEnter(sender As Object, e As EventArgs) Handles btnclose.MouseEnter
        btnclose.BackColor = ColorTranslator.FromHtml("#3087F9")
    End Sub

    Private Sub btnclose_MouseLeave(sender As Object, e As EventArgs) Handles btnclose.MouseLeave
        btnclose.BackColor = ColorTranslator.FromHtml("#1B1B27")
    End Sub


    Private Sub btnmin_MouseEnter(sender As Object, e As EventArgs) Handles btnmin.MouseEnter
        btnmin.BackColor = ColorTranslator.FromHtml("#3087F9")
    End Sub

    Private Sub btnmin_MouseLeave(sender As Object, e As EventArgs) Handles btnmin.MouseLeave
        btnmin.BackColor = ColorTranslator.FromHtml("#1B1B27")
    End Sub

    Private Sub Frmregister_Load(sender As Object, e As EventArgs)
    End Sub

    Private Sub BtnRegisterLogin_MouseEnter(sender As Object, e As EventArgs) Handles BtnRegisterLogin.MouseEnter
        BtnRegisterLogin.BackColor = ColorTranslator.FromHtml("#3087F9")
    End Sub

    Private Sub BtnRegisterLogin_MouseLeave(sender As Object, e As EventArgs) Handles BtnRegisterLogin.MouseLeave
        BtnRegisterLogin.BackColor = ColorTranslator.FromHtml("#1B1B27")
    End Sub

    Private Sub BtnUploadImg_MouseEnter(sender As Object, e As EventArgs) Handles BtnUploadImg.MouseEnter
        BtnUploadImg.BackColor = ColorTranslator.FromHtml("#3087F9")
    End Sub

    Private Sub BtnUploadImg_MouseLeave(sender As Object, e As EventArgs) Handles BtnUploadImg.MouseLeave
        BtnUploadImg.BackColor = ColorTranslator.FromHtml("#1B1B27")
    End Sub

    Private Sub LnkLblRedirectLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLblRedirectLogin.LinkClicked
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub BtnRegisterLogin_Click(sender As Object, e As EventArgs) Handles BtnRegisterLogin.Click
        If RdbRegStudent.Checked = True Then
            FrmMainStudent.Show()
        ElseIf RdbRegTeacher.Checked = True Then
            FrmMainTeacher.Show()
        End If

        Me.Close()
    End Sub
End Class
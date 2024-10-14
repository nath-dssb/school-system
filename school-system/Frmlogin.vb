Public Class frmlogin
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

    Private Sub btnlogin_MouseEnter(sender As Object, e As EventArgs) Handles btnlogin.MouseEnter
        btnlogin.BackColor = ColorTranslator.FromHtml("#3087F9")
    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = ColorTranslator.FromHtml("#1B1B27")
    End Sub

    Private Sub lnklblregister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblregister.LinkClicked
        Me.Hide()
        Frmregister.Show()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If rdbstudent.Checked = True Then
            FrmMainStudent.Show()
        ElseIf rdbteacher.Checked = True Then
            FrmMainTeacher.Show()
        End If

        Me.Close()

    End Sub
End Class

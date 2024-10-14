<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnclose = New Button()
        btnmin = New Button()
        Pcblogo = New PictureBox()
        lbllogin = New Label()
        lblname = New Label()
        txtuser = New TextBox()
        txtpw = New TextBox()
        lblpw = New Label()
        btnlogin = New Button()
        lblregister = New Label()
        lnklblregister = New LinkLabel()
        pnlusertype = New Panel()
        lblusertype = New Label()
        rdbstudent = New RadioButton()
        rdbteacher = New RadioButton()
        CType(Pcblogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlusertype.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnclose
        ' 
        btnclose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnclose.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        btnclose.Cursor = Cursors.Hand
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.ForeColor = Color.Transparent
        btnclose.Image = My.Resources.Resources.close_white
        btnclose.Location = New Point(1368, 17)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(55, 55)
        btnclose.TabIndex = 1
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' btnmin
        ' 
        btnmin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnmin.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        btnmin.BackgroundImage = My.Resources.Resources.minimize_48white
        btnmin.BackgroundImageLayout = ImageLayout.Zoom
        btnmin.Cursor = Cursors.Hand
        btnmin.FlatStyle = FlatStyle.Flat
        btnmin.ForeColor = Color.Transparent
        btnmin.Location = New Point(1307, 17)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(55, 55)
        btnmin.TabIndex = 2
        btnmin.UseVisualStyleBackColor = False
        ' 
        ' Pcblogo
        ' 
        Pcblogo.Anchor = AnchorStyles.None
        Pcblogo.BackColor = Color.Transparent
        Pcblogo.BackgroundImageLayout = ImageLayout.Stretch
        Pcblogo.Image = My.Resources.Resources.socatres_logo_black_1
        Pcblogo.Location = New Point(471, 178)
        Pcblogo.Name = "Pcblogo"
        Pcblogo.Size = New Size(497, 97)
        Pcblogo.SizeMode = PictureBoxSizeMode.AutoSize
        Pcblogo.TabIndex = 3
        Pcblogo.TabStop = False
        ' 
        ' lbllogin
        ' 
        lbllogin.Anchor = AnchorStyles.None
        lbllogin.AutoSize = True
        lbllogin.Font = New Font("Montserrat SemiBold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbllogin.Location = New Point(570, 293)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(289, 46)
        lbllogin.TabIndex = 4
        lbllogin.Text = "Inicio de Sesión"
        ' 
        ' lblname
        ' 
        lblname.Anchor = AnchorStyles.None
        lblname.AutoSize = True
        lblname.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblname.Location = New Point(420, 388)
        lblname.Name = "lblname"
        lblname.Size = New Size(216, 27)
        lblname.TabIndex = 5
        lblname.Text = "Nombre de Usuario:"
        ' 
        ' txtuser
        ' 
        txtuser.Anchor = AnchorStyles.None
        txtuser.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtuser.BorderStyle = BorderStyle.FixedSingle
        txtuser.Font = New Font("Montserrat Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtuser.Location = New Point(730, 383)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(320, 32)
        txtuser.TabIndex = 6
        txtuser.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpw
        ' 
        txtpw.Anchor = AnchorStyles.None
        txtpw.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtpw.BorderStyle = BorderStyle.FixedSingle
        txtpw.Font = New Font("Montserrat Light", 12F)
        txtpw.Location = New Point(730, 427)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(320, 32)
        txtpw.TabIndex = 8
        txtpw.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblpw
        ' 
        lblpw.Anchor = AnchorStyles.None
        lblpw.AutoSize = True
        lblpw.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblpw.Location = New Point(420, 432)
        lblpw.Name = "lblpw"
        lblpw.Size = New Size(133, 27)
        lblpw.TabIndex = 7
        lblpw.Text = "Contraseña:"
        ' 
        ' btnlogin
        ' 
        btnlogin.Anchor = AnchorStyles.None
        btnlogin.AutoSize = True
        btnlogin.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        btnlogin.Cursor = Cursors.Hand
        btnlogin.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(828, 586)
        btnlogin.Name = "btnlogin"
        btnlogin.Padding = New Padding(10)
        btnlogin.Size = New Size(222, 57)
        btnlogin.TabIndex = 9
        btnlogin.Text = "Iniciar Sesión"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' lblregister
        ' 
        lblregister.Anchor = AnchorStyles.None
        lblregister.AutoSize = True
        lblregister.Font = New Font("Montserrat Medium", 11F, FontStyle.Bold)
        lblregister.Location = New Point(425, 587)
        lblregister.Name = "lblregister"
        lblregister.Size = New Size(220, 26)
        lblregister.TabIndex = 10
        lblregister.Text = "¿No estás registrado?"
        ' 
        ' lnklblregister
        ' 
        lnklblregister.ActiveLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        lnklblregister.Anchor = AnchorStyles.None
        lnklblregister.AutoSize = True
        lnklblregister.BackColor = Color.Transparent
        lnklblregister.DisabledLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        lnklblregister.Font = New Font("Montserrat Medium", 13F, FontStyle.Bold)
        lnklblregister.LinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        lnklblregister.Location = New Point(439, 613)
        lnklblregister.Name = "lnklblregister"
        lnklblregister.Size = New Size(197, 30)
        lnklblregister.TabIndex = 11
        lnklblregister.TabStop = True
        lnklblregister.Text = "Crea una cuenta"
        lnklblregister.VisitedLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        ' 
        ' pnlusertype
        ' 
        pnlusertype.Anchor = AnchorStyles.None
        pnlusertype.Controls.Add(lblusertype)
        pnlusertype.Controls.Add(rdbstudent)
        pnlusertype.Controls.Add(rdbteacher)
        pnlusertype.Location = New Point(420, 485)
        pnlusertype.Name = "pnlusertype"
        pnlusertype.Size = New Size(630, 74)
        pnlusertype.TabIndex = 13
        ' 
        ' lblusertype
        ' 
        lblusertype.AutoSize = True
        lblusertype.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblusertype.Location = New Point(5, 25)
        lblusertype.Name = "lblusertype"
        lblusertype.Size = New Size(177, 27)
        lblusertype.TabIndex = 5
        lblusertype.Text = "Tipo de Usuario:"
        ' 
        ' rdbstudent
        ' 
        rdbstudent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        rdbstudent.AutoSize = True
        rdbstudent.Font = New Font("Montserrat Light", 12F)
        rdbstudent.Location = New Point(502, 23)
        rdbstudent.Name = "rdbstudent"
        rdbstudent.Size = New Size(111, 31)
        rdbstudent.TabIndex = 4
        rdbstudent.TabStop = True
        rdbstudent.Text = "Alumno"
        rdbstudent.UseVisualStyleBackColor = True
        ' 
        ' rdbteacher
        ' 
        rdbteacher.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        rdbteacher.AutoSize = True
        rdbteacher.Font = New Font("Montserrat Light", 12F)
        rdbteacher.Location = New Point(320, 23)
        rdbteacher.Name = "rdbteacher"
        rdbteacher.Size = New Size(118, 31)
        rdbteacher.TabIndex = 3
        rdbteacher.TabStop = True
        rdbteacher.Text = "Docente"
        rdbteacher.UseVisualStyleBackColor = True
        ' 
        ' frmlogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        ClientSize = New Size(1440, 742)
        Controls.Add(pnlusertype)
        Controls.Add(lnklblregister)
        Controls.Add(lblregister)
        Controls.Add(btnlogin)
        Controls.Add(txtpw)
        Controls.Add(lblpw)
        Controls.Add(txtuser)
        Controls.Add(lblname)
        Controls.Add(lbllogin)
        Controls.Add(Pcblogo)
        Controls.Add(btnmin)
        Controls.Add(btnclose)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmlogin"
        Padding = New Padding(5)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(Pcblogo, ComponentModel.ISupportInitialize).EndInit()
        pnlusertype.ResumeLayout(False)
        pnlusertype.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnclose As Button
    Friend WithEvents btnmin As Button
    Friend WithEvents Pcblogo As PictureBox
    Friend WithEvents lbllogin As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpw As TextBox
    Friend WithEvents lblpw As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblregister As Label
    Friend WithEvents lnklblregister As LinkLabel
    Friend WithEvents pnlusertype As Panel
    Friend WithEvents lblusertype As Label
    Friend WithEvents rdbstudent As RadioButton
    Friend WithEvents rdbteacher As RadioButton

End Class

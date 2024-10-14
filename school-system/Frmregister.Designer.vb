<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmregister
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnmin = New Button()
        btnclose = New Button()
        pcbxlogosmall = New PictureBox()
        lblname = New Label()
        txtName = New TextBox()
        txtlName = New TextBox()
        lbllastname = New Label()
        txtemail = New TextBox()
        lblemail = New Label()
        txtmatricula = New TextBox()
        lblmatricula = New Label()
        txtpw = New TextBox()
        lblpw = New Label()
        txtconfirmpw = New TextBox()
        lblpwconfirm = New Label()
        pbprofilepic = New PictureBox()
        BtnUploadImg = New Button()
        BtnRegisterLogin = New Button()
        pnlsex = New Panel()
        rdbsexfem = New RadioButton()
        RdbSexMasc = New RadioButton()
        lblgender = New Label()
        pnlusertype = New Panel()
        RdbRegTeacher = New RadioButton()
        RdbRegStudent = New RadioButton()
        lblusertype = New Label()
        lblregistertitle = New Label()
        lblredirectlogin = New Label()
        LnkLblRedirectLogin = New LinkLabel()
        CType(pcbxlogosmall, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbprofilepic, ComponentModel.ISupportInitialize).BeginInit()
        pnlsex.SuspendLayout()
        pnlusertype.SuspendLayout()
        SuspendLayout()
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
        btnmin.Location = New Point(1312, 5)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(55, 55)
        btnmin.TabIndex = 5
        btnmin.UseVisualStyleBackColor = False
        ' 
        ' btnclose
        ' 
        btnclose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnclose.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        btnclose.Cursor = Cursors.Hand
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.ForeColor = Color.Transparent
        btnclose.Image = My.Resources.Resources.close_white
        btnclose.Location = New Point(1373, 5)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(55, 55)
        btnclose.TabIndex = 4
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' pcbxlogosmall
        ' 
        pcbxlogosmall.Anchor = AnchorStyles.None
        pcbxlogosmall.Image = My.Resources.Resources.socatres_logo_black2
        pcbxlogosmall.Location = New Point(67, 86)
        pcbxlogosmall.Name = "pcbxlogosmall"
        pcbxlogosmall.Size = New Size(367, 72)
        pcbxlogosmall.SizeMode = PictureBoxSizeMode.AutoSize
        pcbxlogosmall.TabIndex = 6
        pcbxlogosmall.TabStop = False
        ' 
        ' lblname
        ' 
        lblname.Anchor = AnchorStyles.None
        lblname.AutoSize = True
        lblname.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblname.Location = New Point(443, 188)
        lblname.Name = "lblname"
        lblname.Size = New Size(101, 27)
        lblname.TabIndex = 7
        lblname.Text = "Nombre:"
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.None
        txtName.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Montserrat Light", 12F)
        txtName.Location = New Point(443, 220)
        txtName.Name = "txtName"
        txtName.Size = New Size(335, 32)
        txtName.TabIndex = 8
        ' 
        ' txtlName
        ' 
        txtlName.Anchor = AnchorStyles.None
        txtlName.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtlName.BorderStyle = BorderStyle.FixedSingle
        txtlName.Font = New Font("Montserrat Light", 12F)
        txtlName.Location = New Point(798, 220)
        txtlName.Name = "txtlName"
        txtlName.Size = New Size(470, 32)
        txtlName.TabIndex = 10
        ' 
        ' lbllastname
        ' 
        lbllastname.Anchor = AnchorStyles.None
        lbllastname.AutoSize = True
        lbllastname.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lbllastname.Location = New Point(798, 188)
        lbllastname.Name = "lbllastname"
        lbllastname.Size = New Size(103, 27)
        lbllastname.TabIndex = 9
        lbllastname.Text = "Apellido:"
        ' 
        ' txtemail
        ' 
        txtemail.Anchor = AnchorStyles.None
        txtemail.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Montserrat Light", 12F)
        txtemail.Location = New Point(656, 304)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(233, 32)
        txtemail.TabIndex = 14
        ' 
        ' lblemail
        ' 
        lblemail.Anchor = AnchorStyles.None
        lblemail.AutoSize = True
        lblemail.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblemail.Location = New Point(671, 274)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(218, 27)
        lblemail.TabIndex = 13
        lblemail.Text = "Correo institucional:"
        ' 
        ' txtmatricula
        ' 
        txtmatricula.Anchor = AnchorStyles.None
        txtmatricula.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtmatricula.BorderStyle = BorderStyle.FixedSingle
        txtmatricula.Font = New Font("Montserrat Light", 12F)
        txtmatricula.Location = New Point(444, 304)
        txtmatricula.Name = "txtmatricula"
        txtmatricula.Size = New Size(193, 32)
        txtmatricula.TabIndex = 12
        ' 
        ' lblmatricula
        ' 
        lblmatricula.Anchor = AnchorStyles.None
        lblmatricula.AutoSize = True
        lblmatricula.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblmatricula.Location = New Point(445, 274)
        lblmatricula.Name = "lblmatricula"
        lblmatricula.Size = New Size(113, 27)
        lblmatricula.TabIndex = 11
        lblmatricula.Text = "Matricula:"
        ' 
        ' txtpw
        ' 
        txtpw.Anchor = AnchorStyles.None
        txtpw.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtpw.BorderStyle = BorderStyle.FixedSingle
        txtpw.Font = New Font("Montserrat Light", 12F)
        txtpw.Location = New Point(443, 384)
        txtpw.Name = "txtpw"
        txtpw.Size = New Size(445, 32)
        txtpw.TabIndex = 16
        ' 
        ' lblpw
        ' 
        lblpw.Anchor = AnchorStyles.None
        lblpw.AutoSize = True
        lblpw.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblpw.Location = New Point(445, 354)
        lblpw.Name = "lblpw"
        lblpw.Size = New Size(133, 27)
        lblpw.TabIndex = 15
        lblpw.Text = "Contraseña:"
        ' 
        ' txtconfirmpw
        ' 
        txtconfirmpw.Anchor = AnchorStyles.None
        txtconfirmpw.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        txtconfirmpw.BorderStyle = BorderStyle.FixedSingle
        txtconfirmpw.Font = New Font("Montserrat Light", 12F)
        txtconfirmpw.Location = New Point(444, 455)
        txtconfirmpw.Name = "txtconfirmpw"
        txtconfirmpw.Size = New Size(445, 32)
        txtconfirmpw.TabIndex = 18
        ' 
        ' lblpwconfirm
        ' 
        lblpwconfirm.Anchor = AnchorStyles.None
        lblpwconfirm.AutoSize = True
        lblpwconfirm.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblpwconfirm.Location = New Point(444, 425)
        lblpwconfirm.Name = "lblpwconfirm"
        lblpwconfirm.Size = New Size(238, 27)
        lblpwconfirm.TabIndex = 17
        lblpwconfirm.Text = "Confirmar contraseña:"
        ' 
        ' pbprofilepic
        ' 
        pbprofilepic.Anchor = AnchorStyles.None
        pbprofilepic.Image = My.Resources.Resources.mock_profileicon
        pbprofilepic.Location = New Point(122, 188)
        pbprofilepic.Name = "pbprofilepic"
        pbprofilepic.Size = New Size(244, 244)
        pbprofilepic.SizeMode = PictureBoxSizeMode.Zoom
        pbprofilepic.TabIndex = 19
        pbprofilepic.TabStop = False
        ' 
        ' BtnUploadImg
        ' 
        BtnUploadImg.Anchor = AnchorStyles.None
        BtnUploadImg.AutoSize = True
        BtnUploadImg.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        BtnUploadImg.BackgroundImageLayout = ImageLayout.Center
        BtnUploadImg.Cursor = Cursors.Hand
        BtnUploadImg.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold)
        BtnUploadImg.ForeColor = Color.White
        BtnUploadImg.Image = My.Resources.Resources.upload_white
        BtnUploadImg.ImageAlign = ContentAlignment.MiddleLeft
        BtnUploadImg.Location = New Point(137, 442)
        BtnUploadImg.Name = "BtnUploadImg"
        BtnUploadImg.Padding = New Padding(10)
        BtnUploadImg.Size = New Size(220, 57)
        BtnUploadImg.TabIndex = 20
        BtnUploadImg.Text = "Subir imagen"
        BtnUploadImg.TextAlign = ContentAlignment.MiddleRight
        BtnUploadImg.UseVisualStyleBackColor = False
        ' 
        ' BtnRegisterLogin
        ' 
        BtnRegisterLogin.Anchor = AnchorStyles.None
        BtnRegisterLogin.AutoSize = True
        BtnRegisterLogin.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        BtnRegisterLogin.Cursor = Cursors.Hand
        BtnRegisterLogin.Font = New Font("Montserrat SemiBold", 12F, FontStyle.Bold)
        BtnRegisterLogin.ForeColor = Color.White
        BtnRegisterLogin.Location = New Point(953, 582)
        BtnRegisterLogin.Name = "BtnRegisterLogin"
        BtnRegisterLogin.Padding = New Padding(10)
        BtnRegisterLogin.Size = New Size(315, 57)
        BtnRegisterLogin.TabIndex = 21
        BtnRegisterLogin.Text = "Registrarse e iniciar sesión"
        BtnRegisterLogin.UseVisualStyleBackColor = False
        ' 
        ' pnlsex
        ' 
        pnlsex.Anchor = AnchorStyles.None
        pnlsex.Controls.Add(rdbsexfem)
        pnlsex.Controls.Add(RdbSexMasc)
        pnlsex.Controls.Add(lblgender)
        pnlsex.Location = New Point(905, 274)
        pnlsex.Name = "pnlsex"
        pnlsex.Size = New Size(363, 87)
        pnlsex.TabIndex = 22
        ' 
        ' rdbsexfem
        ' 
        rdbsexfem.AutoSize = True
        rdbsexfem.Cursor = Cursors.Hand
        rdbsexfem.Font = New Font("Montserrat Light", 12F)
        rdbsexfem.Location = New Point(190, 47)
        rdbsexfem.Name = "rdbsexfem"
        rdbsexfem.Size = New Size(90, 31)
        rdbsexfem.TabIndex = 26
        rdbsexfem.TabStop = True
        rdbsexfem.Text = "Mujer"
        rdbsexfem.UseVisualStyleBackColor = True
        ' 
        ' RdbSexMasc
        ' 
        RdbSexMasc.AutoSize = True
        RdbSexMasc.Cursor = Cursors.Hand
        RdbSexMasc.Font = New Font("Montserrat Light", 12F)
        RdbSexMasc.Location = New Point(3, 47)
        RdbSexMasc.Name = "RdbSexMasc"
        RdbSexMasc.Size = New Size(116, 31)
        RdbSexMasc.TabIndex = 25
        RdbSexMasc.TabStop = True
        RdbSexMasc.Text = "Hombre"
        RdbSexMasc.UseVisualStyleBackColor = True
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblgender.Location = New Point(3, 11)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(65, 27)
        lblgender.TabIndex = 24
        lblgender.Text = "Sexo:"
        ' 
        ' pnlusertype
        ' 
        pnlusertype.Anchor = AnchorStyles.None
        pnlusertype.Controls.Add(RdbRegTeacher)
        pnlusertype.Controls.Add(RdbRegStudent)
        pnlusertype.Controls.Add(lblusertype)
        pnlusertype.Location = New Point(905, 398)
        pnlusertype.Name = "pnlusertype"
        pnlusertype.Size = New Size(363, 89)
        pnlusertype.TabIndex = 23
        ' 
        ' RdbRegTeacher
        ' 
        RdbRegTeacher.AutoSize = True
        RdbRegTeacher.Cursor = Cursors.Hand
        RdbRegTeacher.Font = New Font("Montserrat Light", 12F)
        RdbRegTeacher.Location = New Point(190, 39)
        RdbRegTeacher.Name = "RdbRegTeacher"
        RdbRegTeacher.Size = New Size(118, 31)
        RdbRegTeacher.TabIndex = 28
        RdbRegTeacher.TabStop = True
        RdbRegTeacher.Text = "Docente"
        RdbRegTeacher.UseVisualStyleBackColor = True
        ' 
        ' RdbRegStudent
        ' 
        RdbRegStudent.AutoSize = True
        RdbRegStudent.Cursor = Cursors.Hand
        RdbRegStudent.Font = New Font("Montserrat Light", 12F)
        RdbRegStudent.Location = New Point(6, 39)
        RdbRegStudent.Name = "RdbRegStudent"
        RdbRegStudent.Size = New Size(141, 31)
        RdbRegStudent.TabIndex = 27
        RdbRegStudent.TabStop = True
        RdbRegStudent.Text = "Estudiante"
        RdbRegStudent.UseVisualStyleBackColor = True
        ' 
        ' lblusertype
        ' 
        lblusertype.AutoSize = True
        lblusertype.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblusertype.Location = New Point(3, 7)
        lblusertype.Name = "lblusertype"
        lblusertype.Size = New Size(175, 27)
        lblusertype.TabIndex = 25
        lblusertype.Text = "Tipo de usuario:"
        ' 
        ' lblregistertitle
        ' 
        lblregistertitle.Anchor = AnchorStyles.None
        lblregistertitle.AutoSize = True
        lblregistertitle.Font = New Font("Montserrat SemiBold", 19.7999973F, FontStyle.Bold)
        lblregistertitle.Location = New Point(440, 102)
        lblregistertitle.Name = "lblregistertitle"
        lblregistertitle.Size = New Size(417, 46)
        lblregistertitle.TabIndex = 25
        lblregistertitle.Text = "Registrar nueva cuenta"
        ' 
        ' lblredirectlogin
        ' 
        lblredirectlogin.Anchor = AnchorStyles.None
        lblredirectlogin.AutoSize = True
        lblredirectlogin.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        lblredirectlogin.Location = New Point(445, 582)
        lblredirectlogin.Name = "lblredirectlogin"
        lblredirectlogin.Size = New Size(244, 27)
        lblredirectlogin.TabIndex = 26
        lblredirectlogin.Text = "¿Ya tienes una cuenta?"
        ' 
        ' LnkLblRedirectLogin
        ' 
        LnkLblRedirectLogin.ActiveLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        LnkLblRedirectLogin.Anchor = AnchorStyles.None
        LnkLblRedirectLogin.AutoSize = True
        LnkLblRedirectLogin.DisabledLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        LnkLblRedirectLogin.Font = New Font("Montserrat Medium", 13F, FontStyle.Bold)
        LnkLblRedirectLogin.LinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        LnkLblRedirectLogin.Location = New Point(488, 609)
        LnkLblRedirectLogin.Name = "LnkLblRedirectLogin"
        LnkLblRedirectLogin.Size = New Size(149, 30)
        LnkLblRedirectLogin.TabIndex = 27
        LnkLblRedirectLogin.TabStop = True
        LnkLblRedirectLogin.Text = "Inicia sesión"
        LnkLblRedirectLogin.VisitedLinkColor = Color.FromArgb(CByte(48), CByte(135), CByte(249))
        ' 
        ' Frmregister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        ClientSize = New Size(1440, 742)
        Controls.Add(LnkLblRedirectLogin)
        Controls.Add(lblredirectlogin)
        Controls.Add(lblregistertitle)
        Controls.Add(pnlusertype)
        Controls.Add(pnlsex)
        Controls.Add(BtnRegisterLogin)
        Controls.Add(BtnUploadImg)
        Controls.Add(pbprofilepic)
        Controls.Add(txtconfirmpw)
        Controls.Add(lblpwconfirm)
        Controls.Add(txtpw)
        Controls.Add(lblpw)
        Controls.Add(txtemail)
        Controls.Add(lblemail)
        Controls.Add(txtmatricula)
        Controls.Add(lblmatricula)
        Controls.Add(txtlName)
        Controls.Add(lbllastname)
        Controls.Add(txtName)
        Controls.Add(lblname)
        Controls.Add(pcbxlogosmall)
        Controls.Add(btnmin)
        Controls.Add(btnclose)
        FormBorderStyle = FormBorderStyle.None
        Name = "Frmregister"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(pcbxlogosmall, ComponentModel.ISupportInitialize).EndInit()
        CType(pbprofilepic, ComponentModel.ISupportInitialize).EndInit()
        pnlsex.ResumeLayout(False)
        pnlsex.PerformLayout()
        pnlusertype.ResumeLayout(False)
        pnlusertype.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnmin As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents pcbxlogosmall As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtlName As TextBox
    Friend WithEvents lbllastname As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents txtmatricula As TextBox
    Friend WithEvents lblmatricula As Label
    Friend WithEvents txtpw As TextBox
    Friend WithEvents lblpw As Label
    Friend WithEvents txtconfirmpw As TextBox
    Friend WithEvents lblpwconfirm As Label
    Friend WithEvents pbprofilepic As PictureBox
    Friend WithEvents BtnUploadImg As Button
    Friend WithEvents BtnRegisterLogin As Button
    Friend WithEvents pnlsex As Panel
    Friend WithEvents rdbsexfem As RadioButton
    Friend WithEvents RdbSexMasc As RadioButton
    Friend WithEvents lblgender As Label
    Friend WithEvents pnlusertype As Panel
    Friend WithEvents RdbRegTeacher As RadioButton
    Friend WithEvents RdbRegStudent As RadioButton
    Friend WithEvents lblusertype As Label
    Friend WithEvents lblregistertitle As Label
    Friend WithEvents lblredirectlogin As Label
    Friend WithEvents LnkLblRedirectLogin As LinkLabel
End Class

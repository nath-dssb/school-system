<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainStudent
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
        Panel1 = New Panel()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        btnmin.Location = New Point(1312, 12)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(55, 55)
        btnmin.TabIndex = 4
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
        btnclose.Location = New Point(1373, 12)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(55, 55)
        btnclose.TabIndex = 3
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(205, 742)
        Panel1.TabIndex = 5
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Top
        Button8.AutoSize = True
        Button8.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button8.Cursor = Cursors.Hand
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button8.ForeColor = Color.White
        Button8.Image = My.Resources.Resources.courses_nav
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(13, 265)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(123, 40)
        Button8.TabIndex = 9
        Button8.Text = "Cursos"
        Button8.TextAlign = ContentAlignment.MiddleRight
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Bottom
        Button7.AutoSize = True
        Button7.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button7.Cursor = Cursors.Hand
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button7.ForeColor = Color.White
        Button7.Image = My.Resources.Resources.exit_nav
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(56, 674)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(95, 40)
        Button7.TabIndex = 8
        Button7.Text = "Salir"
        Button7.TextAlign = ContentAlignment.MiddleRight
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom
        Button6.AutoSize = True
        Button6.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button6.Cursor = Cursors.Hand
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button6.ForeColor = Color.White
        Button6.Image = My.Resources.Resources.achvm_nav
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(35, 634)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(136, 40)
        Button6.TabIndex = 7
        Button6.Text = "Insignias"
        Button6.TextAlign = ContentAlignment.MiddleRight
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom
        Button5.AutoSize = True
        Button5.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button5.ForeColor = Color.White
        Button5.Image = My.Resources.Resources.message_nav
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(54, 594)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(97, 40)
        Button5.TabIndex = 6
        Button5.Text = "Chat"
        Button5.TextAlign = ContentAlignment.MiddleRight
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top
        Button4.AutoSize = True
        Button4.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.grades_nav
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(10, 434)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(186, 40)
        Button4.TabIndex = 5
        Button4.Text = "Calificaciones"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top
        Button3.AutoSize = True
        Button3.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.hw_nav
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(13, 380)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(182, 40)
        Button3.TabIndex = 4
        Button3.Text = "Asignaciones"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.AutoSize = True
        Button2.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.calendar_nav
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(13, 327)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 40)
        Button2.TabIndex = 3
        Button2.Text = "Calendario"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.AutoSize = True
        Button1.BackColor = Color.FromArgb(CByte(27), CByte(27), CByte(39))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Montserrat Medium", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.home_nav
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(13, 209)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 40)
        Button1.TabIndex = 2
        Button1.Text = "Inicio"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.mock_profileicon
        PictureBox2.Location = New Point(43, 74)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(112, 107)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.socatres_logo_nav
        PictureBox1.Location = New Point(13, 12)
        PictureBox1.Margin = New Padding(5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(177, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FrmMainStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        ClientSize = New Size(1440, 742)
        Controls.Add(Panel1)
        Controls.Add(btnmin)
        Controls.Add(btnclose)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMainStudent"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnmin As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
End Class

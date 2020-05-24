<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.imgRuleta = New System.Windows.Forms.PictureBox()
        Me.imgFlecha = New System.Windows.Forms.PictureBox()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.txtApuesta = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbltxtPuntos = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.imgRuleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.Location = New System.Drawing.Point(409, 461)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(99, 35)
        Me.btnJugar.TabIndex = 2
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'imgRuleta
        '
        Me.imgRuleta.BackColor = System.Drawing.Color.Transparent
        Me.imgRuleta.Image = CType(resources.GetObject("imgRuleta.Image"), System.Drawing.Image)
        Me.imgRuleta.Location = New System.Drawing.Point(263, 182)
        Me.imgRuleta.Name = "imgRuleta"
        Me.imgRuleta.Size = New System.Drawing.Size(396, 273)
        Me.imgRuleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgRuleta.TabIndex = 3
        Me.imgRuleta.TabStop = False
        '
        'imgFlecha
        '
        Me.imgFlecha.BackColor = System.Drawing.Color.Transparent
        Me.imgFlecha.Image = CType(resources.GetObject("imgFlecha.Image"), System.Drawing.Image)
        Me.imgFlecha.Location = New System.Drawing.Point(431, 173)
        Me.imgFlecha.Name = "imgFlecha"
        Me.imgFlecha.Size = New System.Drawing.Size(59, 29)
        Me.imgFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgFlecha.TabIndex = 4
        Me.imgFlecha.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(-1, -2)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(619, 169)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 5
        Me.imgLogo.TabStop = False
        '
        'txtApuesta
        '
        Me.txtApuesta.Location = New System.Drawing.Point(39, 299)
        Me.txtApuesta.Name = "txtApuesta"
        Me.txtApuesta.Size = New System.Drawing.Size(110, 20)
        Me.txtApuesta.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(155, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lbltxtPuntos
        '
        Me.lbltxtPuntos.AutoSize = True
        Me.lbltxtPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lbltxtPuntos.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtPuntos.ForeColor = System.Drawing.Color.White
        Me.lbltxtPuntos.Location = New System.Drawing.Point(12, 147)
        Me.lbltxtPuntos.Name = "lbltxtPuntos"
        Me.lbltxtPuntos.Size = New System.Drawing.Size(57, 20)
        Me.lbltxtPuntos.TabIndex = 8
        Me.lbltxtPuntos.Text = "Puntos:"
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntos.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntos.ForeColor = System.Drawing.Color.White
        Me.lblPuntos.Location = New System.Drawing.Point(76, 147)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(0, 20)
        Me.lblPuntos.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Recargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(617, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lbltxtPuntos)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtApuesta)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.imgFlecha)
        Me.Controls.Add(Me.imgRuleta)
        Me.Controls.Add(Me.btnJugar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgRuleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJugar As Button
    Friend WithEvents imgRuleta As PictureBox
    Friend WithEvents imgFlecha As PictureBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents txtApuesta As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lbltxtPuntos As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents Button1 As Button
End Class

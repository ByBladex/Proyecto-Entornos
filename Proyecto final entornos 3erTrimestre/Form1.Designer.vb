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
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.lbltxtPuntos = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.Location = New System.Drawing.Point(254, 397)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(94, 36)
        Me.btnJugar.TabIndex = 2
        Me.btnJugar.Text = "Jugar"
        Me.btnJugar.UseVisualStyleBackColor = True
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
        'btnRecargar
        '
        Me.btnRecargar.Location = New System.Drawing.Point(543, 144)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(75, 23)
        Me.btnRecargar.TabIndex = 10
        Me.btnRecargar.Text = "Recargar"
        Me.btnRecargar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(103, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(415, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lbl1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(136, 256)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(97, 120)
        Me.lbl1.TabIndex = 12
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lbl2.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(251, 256)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(97, 120)
        Me.lbl2.TabIndex = 13
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lbl3.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(365, 256)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(97, 120)
        Me.lbl3.TabIndex = 14
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(617, 520)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lbltxtPuntos)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJugar As Button
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents lbltxtPuntos As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents btnRecargar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
End Class

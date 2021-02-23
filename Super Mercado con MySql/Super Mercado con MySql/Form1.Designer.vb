<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmusuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prginiciodesesion = New System.Windows.Forms.ProgressBar()
        Me.btniniciarsesion = New System.Windows.Forms.Button()
        Me.txtcontraseñaV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuarioV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnvolver)
        Me.GroupBox1.Controls.Add(Me.btncerrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.prginiciodesesion)
        Me.GroupBox1.Controls.Add(Me.btniniciarsesion)
        Me.GroupBox1.Controls.Add(Me.txtcontraseñaV)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtusuarioV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 435)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ".:: Ingrese Credenciales ::."
        '
        'btnvolver
        '
        Me.btnvolver.ForeColor = System.Drawing.Color.Black
        Me.btnvolver.Location = New System.Drawing.Point(365, 16)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(48, 23)
        Me.btnvolver.TabIndex = 8
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.ForeColor = System.Drawing.Color.Black
        Me.btncerrar.Location = New System.Drawing.Point(419, 16)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(22, 23)
        Me.btncerrar.TabIndex = 6
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 77)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Orca 1.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(147, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'prginiciodesesion
        '
        Me.prginiciodesesion.Location = New System.Drawing.Point(6, 398)
        Me.prginiciodesesion.Name = "prginiciodesesion"
        Me.prginiciodesesion.Size = New System.Drawing.Size(435, 23)
        Me.prginiciodesesion.TabIndex = 7
        '
        'btniniciarsesion
        '
        Me.btniniciarsesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciarsesion.ForeColor = System.Drawing.Color.Black
        Me.btniniciarsesion.Location = New System.Drawing.Point(135, 357)
        Me.btniniciarsesion.Name = "btniniciarsesion"
        Me.btniniciarsesion.Size = New System.Drawing.Size(131, 30)
        Me.btniniciarsesion.TabIndex = 4
        Me.btniniciarsesion.Text = "Iniciar Sesion"
        Me.btniniciarsesion.UseVisualStyleBackColor = True
        '
        'txtcontraseñaV
        '
        Me.txtcontraseñaV.Location = New System.Drawing.Point(134, 317)
        Me.txtcontraseñaV.Name = "txtcontraseñaV"
        Me.txtcontraseñaV.Size = New System.Drawing.Size(132, 20)
        Me.txtcontraseñaV.TabIndex = 3
        Me.txtcontraseñaV.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'txtusuarioV
        '
        Me.txtusuarioV.Location = New System.Drawing.Point(135, 272)
        Me.txtusuarioV.Name = "txtusuarioV"
        Me.txtusuarioV.Size = New System.Drawing.Size(131, 20)
        Me.txtusuarioV.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'frmusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(470, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Login ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcontraseñaV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuarioV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btniniciarsesion As Button
    Friend WithEvents prginiciodesesion As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnvolver As Button
End Class

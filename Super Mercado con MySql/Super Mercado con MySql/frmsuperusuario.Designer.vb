<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsuperusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsuperusuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnvolversuper = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.prginiciodesesionsuper = New System.Windows.Forms.ProgressBar()
        Me.btniniciarsesionsupersu = New System.Windows.Forms.Button()
        Me.txtsupercontraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsuperusuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnvolversuper)
        Me.GroupBox1.Controls.Add(Me.btncerrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.prginiciodesesionsuper)
        Me.GroupBox1.Controls.Add(Me.btniniciarsesionsupersu)
        Me.GroupBox1.Controls.Add(Me.txtsupercontraseña)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsuperusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 435)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = ".:: Ingrese Credenciales ::."
        '
        'btnvolversuper
        '
        Me.btnvolversuper.ForeColor = System.Drawing.Color.Black
        Me.btnvolversuper.Location = New System.Drawing.Point(365, 16)
        Me.btnvolversuper.Name = "btnvolversuper"
        Me.btnvolversuper.Size = New System.Drawing.Size(48, 23)
        Me.btnvolversuper.TabIndex = 9
        Me.btnvolversuper.Text = "Volver"
        Me.btnvolversuper.UseVisualStyleBackColor = True
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
        'prginiciodesesionsuper
        '
        Me.prginiciodesesionsuper.Location = New System.Drawing.Point(6, 398)
        Me.prginiciodesesionsuper.Name = "prginiciodesesionsuper"
        Me.prginiciodesesionsuper.Size = New System.Drawing.Size(435, 23)
        Me.prginiciodesesionsuper.TabIndex = 7
        '
        'btniniciarsesionsupersu
        '
        Me.btniniciarsesionsupersu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciarsesionsupersu.ForeColor = System.Drawing.Color.Black
        Me.btniniciarsesionsupersu.Location = New System.Drawing.Point(148, 362)
        Me.btniniciarsesionsupersu.Name = "btniniciarsesionsupersu"
        Me.btniniciarsesionsupersu.Size = New System.Drawing.Size(131, 30)
        Me.btniniciarsesionsupersu.TabIndex = 4
        Me.btniniciarsesionsupersu.Text = "Iniciar Sesion"
        Me.btniniciarsesionsupersu.UseVisualStyleBackColor = True
        '
        'txtsupercontraseña
        '
        Me.txtsupercontraseña.Location = New System.Drawing.Point(147, 317)
        Me.txtsupercontraseña.Name = "txtsupercontraseña"
        Me.txtsupercontraseña.Size = New System.Drawing.Size(132, 20)
        Me.txtsupercontraseña.TabIndex = 3
        Me.txtsupercontraseña.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'txtsuperusuario
        '
        Me.txtsuperusuario.Location = New System.Drawing.Point(147, 272)
        Me.txtsuperusuario.Name = "txtsuperusuario"
        Me.txtsuperusuario.Size = New System.Drawing.Size(131, 20)
        Me.txtsuperusuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Super Usuario:"
        '
        'frmsuperusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(472, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsuperusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmsuperusuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents prginiciodesesionsuper As ProgressBar
    Friend WithEvents btniniciarsesionsupersu As Button
    Friend WithEvents txtsupercontraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsuperusuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolversuper As Button
End Class

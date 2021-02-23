<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagregarusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmagregarusuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkmostrarconfirmarcontraseña = New System.Windows.Forms.CheckBox()
        Me.chkmostrarcontraseña = New System.Windows.Forms.CheckBox()
        Me.txtconfirmarcontra = New System.Windows.Forms.TextBox()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.txtingresarcontra = New System.Windows.Forms.TextBox()
        Me.txtingresaruser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txteliminarid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkmostrarconfirmarcontraseña)
        Me.GroupBox1.Controls.Add(Me.chkmostrarcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtconfirmarcontra)
        Me.GroupBox1.Controls.Add(Me.btnregistrar)
        Me.GroupBox1.Controls.Add(Me.txtingresarcontra)
        Me.GroupBox1.Controls.Add(Me.txtingresaruser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 293)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese nuevo usuario"
        '
        'chkmostrarconfirmarcontraseña
        '
        Me.chkmostrarconfirmarcontraseña.AutoSize = True
        Me.chkmostrarconfirmarcontraseña.Location = New System.Drawing.Point(267, 201)
        Me.chkmostrarconfirmarcontraseña.Name = "chkmostrarconfirmarcontraseña"
        Me.chkmostrarconfirmarcontraseña.Size = New System.Drawing.Size(35, 17)
        Me.chkmostrarconfirmarcontraseña.TabIndex = 11
        Me.chkmostrarconfirmarcontraseña.Text = "M"
        Me.chkmostrarconfirmarcontraseña.UseVisualStyleBackColor = True
        '
        'chkmostrarcontraseña
        '
        Me.chkmostrarcontraseña.AutoSize = True
        Me.chkmostrarcontraseña.Location = New System.Drawing.Point(267, 132)
        Me.chkmostrarcontraseña.Name = "chkmostrarcontraseña"
        Me.chkmostrarcontraseña.Size = New System.Drawing.Size(35, 17)
        Me.chkmostrarcontraseña.TabIndex = 10
        Me.chkmostrarcontraseña.Text = "M"
        Me.chkmostrarcontraseña.UseVisualStyleBackColor = True
        '
        'txtconfirmarcontra
        '
        Me.txtconfirmarcontra.Location = New System.Drawing.Point(163, 198)
        Me.txtconfirmarcontra.Name = "txtconfirmarcontra"
        Me.txtconfirmarcontra.Size = New System.Drawing.Size(100, 20)
        Me.txtconfirmarcontra.TabIndex = 8
        Me.txtconfirmarcontra.UseSystemPasswordChar = True
        '
        'btnregistrar
        '
        Me.btnregistrar.ForeColor = System.Drawing.Color.Black
        Me.btnregistrar.Location = New System.Drawing.Point(163, 243)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(84, 34)
        Me.btnregistrar.TabIndex = 9
        Me.btnregistrar.Text = ".:: Registrar ::."
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'txtingresarcontra
        '
        Me.txtingresarcontra.Location = New System.Drawing.Point(163, 130)
        Me.txtingresarcontra.Name = "txtingresarcontra"
        Me.txtingresarcontra.Size = New System.Drawing.Size(100, 20)
        Me.txtingresarcontra.TabIndex = 7
        Me.txtingresarcontra.UseSystemPasswordChar = True
        '
        'txtingresaruser
        '
        Me.txtingresaruser.Location = New System.Drawing.Point(163, 65)
        Me.txtingresaruser.Name = "txtingresaruser"
        Me.txtingresaruser.Size = New System.Drawing.Size(100, 20)
        Me.txtingresaruser.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirme Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese Usuario:"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(333, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(455, 426)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.txteliminarid)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 127)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar usuario"
        '
        'btneliminar
        '
        Me.btneliminar.ForeColor = System.Drawing.Color.Black
        Me.btneliminar.Location = New System.Drawing.Point(10, 50)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(52, 22)
        Me.btneliminar.TabIndex = 10
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txteliminarid
        '
        Me.txteliminarid.Location = New System.Drawing.Point(28, 24)
        Me.txteliminarid.Name = "txteliminarid"
        Me.txteliminarid.Size = New System.Drawing.Size(33, 20)
        Me.txteliminarid.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmagregarusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmagregarusuario"
        Me.Text = ".:: Registrar Usuario ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnregistrar As Button
    Friend WithEvents txtconfirmarcontra As TextBox
    Friend WithEvents txtingresarcontra As TextBox
    Friend WithEvents txtingresaruser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents txteliminarid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkmostrarconfirmarcontraseña As CheckBox
    Friend WithEvents chkmostrarcontraseña As CheckBox
End Class

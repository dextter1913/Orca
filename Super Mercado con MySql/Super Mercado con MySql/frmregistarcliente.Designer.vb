<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistarcliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistarcliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombreingresarcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellidoingresarcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtingresecedulacliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtingreseteefonocliete = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtingresedireccioncliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtingresarcorreocliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtingreseidempleado = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvingresarclientes = New System.Windows.Forms.DataGridView()
        Me.btningresarcliente = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtingreseciudadcliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtingresesexocliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvingresarclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtingresesexocliente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtingreseciudadcliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btningresarcliente)
        Me.GroupBox1.Controls.Add(Me.txtingreseidempleado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtingresarcorreocliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtingresedireccioncliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtingreseteefonocliete)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtingresecedulacliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellidoingresarcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombreingresarcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ingrese datos del cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente:"
        '
        'txtnombreingresarcliente
        '
        Me.txtnombreingresarcliente.Location = New System.Drawing.Point(134, 43)
        Me.txtnombreingresarcliente.Name = "txtnombreingresarcliente"
        Me.txtnombreingresarcliente.Size = New System.Drawing.Size(107, 20)
        Me.txtnombreingresarcliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido Cliente:"
        '
        'txtapellidoingresarcliente
        '
        Me.txtapellidoingresarcliente.Location = New System.Drawing.Point(134, 79)
        Me.txtapellidoingresarcliente.Name = "txtapellidoingresarcliente"
        Me.txtapellidoingresarcliente.Size = New System.Drawing.Size(107, 20)
        Me.txtapellidoingresarcliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cedula Cliente:"
        '
        'txtingresecedulacliente
        '
        Me.txtingresecedulacliente.Location = New System.Drawing.Point(123, 115)
        Me.txtingresecedulacliente.Name = "txtingresecedulacliente"
        Me.txtingresecedulacliente.Size = New System.Drawing.Size(118, 20)
        Me.txtingresecedulacliente.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono Cliente:"
        '
        'txtingreseteefonocliete
        '
        Me.txtingreseteefonocliete.Location = New System.Drawing.Point(134, 150)
        Me.txtingreseteefonocliete.Name = "txtingreseteefonocliete"
        Me.txtingreseteefonocliete.Size = New System.Drawing.Size(107, 20)
        Me.txtingreseteefonocliete.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Direccion Cliente:"
        '
        'txtingresedireccioncliente
        '
        Me.txtingresedireccioncliente.Location = New System.Drawing.Point(133, 219)
        Me.txtingresedireccioncliente.Name = "txtingresedireccioncliente"
        Me.txtingresedireccioncliente.Size = New System.Drawing.Size(258, 20)
        Me.txtingresedireccioncliente.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Correo Cliente:"
        '
        'txtingresarcorreocliente
        '
        Me.txtingresarcorreocliente.Location = New System.Drawing.Point(133, 254)
        Me.txtingresarcorreocliente.Name = "txtingresarcorreocliente"
        Me.txtingresarcorreocliente.Size = New System.Drawing.Size(174, 20)
        Me.txtingresarcorreocliente.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ID Empleado:"
        '
        'txtingreseidempleado
        '
        Me.txtingreseidempleado.Location = New System.Drawing.Point(133, 289)
        Me.txtingreseidempleado.Name = "txtingreseidempleado"
        Me.txtingreseidempleado.Size = New System.Drawing.Size(107, 20)
        Me.txtingreseidempleado.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(12, 364)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'dgvingresarclientes
        '
        Me.dgvingresarclientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvingresarclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvingresarclientes.Location = New System.Drawing.Point(429, 12)
        Me.dgvingresarclientes.Name = "dgvingresarclientes"
        Me.dgvingresarclientes.Size = New System.Drawing.Size(371, 554)
        Me.dgvingresarclientes.TabIndex = 2
        '
        'btningresarcliente
        '
        Me.btningresarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresarcliente.ForeColor = System.Drawing.Color.Black
        Me.btningresarcliente.Location = New System.Drawing.Point(248, 39)
        Me.btningresarcliente.Name = "btningresarcliente"
        Me.btningresarcliente.Size = New System.Drawing.Size(157, 131)
        Me.btningresarcliente.TabIndex = 14
        Me.btningresarcliente.Text = ".:: Ingresar ::."
        Me.btningresarcliente.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ciudad Cliente:"
        '
        'txtingreseciudadcliente
        '
        Me.txtingreseciudadcliente.Location = New System.Drawing.Point(134, 185)
        Me.txtingreseciudadcliente.Name = "txtingreseciudadcliente"
        Me.txtingreseciudadcliente.Size = New System.Drawing.Size(123, 20)
        Me.txtingreseciudadcliente.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(262, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Sexo:"
        '
        'txtingresesexocliente
        '
        Me.txtingresesexocliente.Location = New System.Drawing.Point(311, 185)
        Me.txtingresesexocliente.Name = "txtingresesexocliente"
        Me.txtingresesexocliente.Size = New System.Drawing.Size(28, 20)
        Me.txtingresesexocliente.TabIndex = 18
        '
        'frmregistarcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(812, 578)
        Me.Controls.Add(Me.dgvingresarclientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmregistarcliente"
        Me.Text = ".:: Registrar Cliente ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvingresarclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtingreseidempleado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtingresarcorreocliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtingresedireccioncliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtingreseteefonocliete As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtingresecedulacliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellidoingresarcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombreingresarcliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvingresarclientes As DataGridView
    Friend WithEvents btningresarcliente As Button
    Friend WithEvents txtingresesexocliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtingreseciudadcliente As TextBox
    Friend WithEvents Label8 As Label
End Class

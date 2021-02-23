<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarC = New System.Windows.Forms.Button()
        Me.rdonombre = New System.Windows.Forms.RadioButton()
        Me.rdoapellido = New System.Windows.Forms.RadioButton()
        Me.rdotelefono = New System.Windows.Forms.RadioButton()
        Me.rdoidcliente = New System.Windows.Forms.RadioButton()
        Me.rdocedula = New System.Windows.Forms.RadioButton()
        Me.txtbuscarC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIDcl = New System.Windows.Forms.Label()
        Me.lblcorreocl = New System.Windows.Forms.Label()
        Me.lblciudadcl = New System.Windows.Forms.Label()
        Me.lbldireccioncl = New System.Windows.Forms.Label()
        Me.lbltelefonocl = New System.Windows.Forms.Label()
        Me.lblsexo = New System.Windows.Forms.Label()
        Me.lblcedulacliente = New System.Windows.Forms.Label()
        Me.lblapellidocliente = New System.Windows.Forms.Label()
        Me.lblnombrecliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btningresarpedido = New System.Windows.Forms.Button()
        Me.btnexportarpedido = New System.Windows.Forms.Button()
        Me.dgvexportar = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvexportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscarC)
        Me.GroupBox1.Controls.Add(Me.rdonombre)
        Me.GroupBox1.Controls.Add(Me.rdoapellido)
        Me.GroupBox1.Controls.Add(Me.rdotelefono)
        Me.GroupBox1.Controls.Add(Me.rdoidcliente)
        Me.GroupBox1.Controls.Add(Me.rdocedula)
        Me.GroupBox1.Controls.Add(Me.txtbuscarC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de busqueda"
        '
        'btnbuscarC
        '
        Me.btnbuscarC.ForeColor = System.Drawing.Color.Black
        Me.btnbuscarC.Location = New System.Drawing.Point(95, 199)
        Me.btnbuscarC.Name = "btnbuscarC"
        Me.btnbuscarC.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarC.TabIndex = 1
        Me.btnbuscarC.Text = "Buscar"
        Me.btnbuscarC.UseVisualStyleBackColor = True
        '
        'rdonombre
        '
        Me.rdonombre.AutoSize = True
        Me.rdonombre.Location = New System.Drawing.Point(9, 90)
        Me.rdonombre.Name = "rdonombre"
        Me.rdonombre.Size = New System.Drawing.Size(62, 17)
        Me.rdonombre.TabIndex = 6
        Me.rdonombre.TabStop = True
        Me.rdonombre.Text = "Nombre"
        Me.rdonombre.UseVisualStyleBackColor = True
        '
        'rdoapellido
        '
        Me.rdoapellido.AutoSize = True
        Me.rdoapellido.Location = New System.Drawing.Point(9, 113)
        Me.rdoapellido.Name = "rdoapellido"
        Me.rdoapellido.Size = New System.Drawing.Size(62, 17)
        Me.rdoapellido.TabIndex = 5
        Me.rdoapellido.TabStop = True
        Me.rdoapellido.Text = "Apellido"
        Me.rdoapellido.UseVisualStyleBackColor = True
        '
        'rdotelefono
        '
        Me.rdotelefono.AutoSize = True
        Me.rdotelefono.Location = New System.Drawing.Point(9, 182)
        Me.rdotelefono.Name = "rdotelefono"
        Me.rdotelefono.Size = New System.Drawing.Size(67, 17)
        Me.rdotelefono.TabIndex = 4
        Me.rdotelefono.TabStop = True
        Me.rdotelefono.Text = "Telefono"
        Me.rdotelefono.UseVisualStyleBackColor = True
        '
        'rdoidcliente
        '
        Me.rdoidcliente.AutoSize = True
        Me.rdoidcliente.Location = New System.Drawing.Point(9, 159)
        Me.rdoidcliente.Name = "rdoidcliente"
        Me.rdoidcliente.Size = New System.Drawing.Size(71, 17)
        Me.rdoidcliente.TabIndex = 3
        Me.rdoidcliente.TabStop = True
        Me.rdoidcliente.Text = "ID Cliente"
        Me.rdoidcliente.UseVisualStyleBackColor = True
        '
        'rdocedula
        '
        Me.rdocedula.AutoSize = True
        Me.rdocedula.Location = New System.Drawing.Point(9, 136)
        Me.rdocedula.Name = "rdocedula"
        Me.rdocedula.Size = New System.Drawing.Size(58, 17)
        Me.rdocedula.TabIndex = 2
        Me.rdocedula.TabStop = True
        Me.rdocedula.Text = "Cedula"
        Me.rdocedula.UseVisualStyleBackColor = True
        '
        'txtbuscarC
        '
        Me.txtbuscarC.Location = New System.Drawing.Point(95, 60)
        Me.txtbuscarC.Name = "txtbuscarC"
        Me.txtbuscarC.Size = New System.Drawing.Size(117, 20)
        Me.txtbuscarC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese dato:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(-35, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblIDcl)
        Me.GroupBox2.Controls.Add(Me.lblcorreocl)
        Me.GroupBox2.Controls.Add(Me.lblciudadcl)
        Me.GroupBox2.Controls.Add(Me.lbldireccioncl)
        Me.GroupBox2.Controls.Add(Me.lbltelefonocl)
        Me.GroupBox2.Controls.Add(Me.lblsexo)
        Me.GroupBox2.Controls.Add(Me.lblcedulacliente)
        Me.GroupBox2.Controls.Add(Me.lblapellidocliente)
        Me.GroupBox2.Controls.Add(Me.lblnombrecliente)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(242, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 255)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'lblIDcl
        '
        Me.lblIDcl.AutoSize = True
        Me.lblIDcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDcl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblIDcl.Location = New System.Drawing.Point(18, 48)
        Me.lblIDcl.Name = "lblIDcl"
        Me.lblIDcl.Size = New System.Drawing.Size(0, 18)
        Me.lblIDcl.TabIndex = 17
        '
        'lblcorreocl
        '
        Me.lblcorreocl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblcorreocl.AutoSize = True
        Me.lblcorreocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreocl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcorreocl.Location = New System.Drawing.Point(227, 153)
        Me.lblcorreocl.Name = "lblcorreocl"
        Me.lblcorreocl.Size = New System.Drawing.Size(0, 18)
        Me.lblcorreocl.TabIndex = 16
        '
        'lblciudadcl
        '
        Me.lblciudadcl.AutoSize = True
        Me.lblciudadcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblciudadcl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblciudadcl.Location = New System.Drawing.Point(18, 216)
        Me.lblciudadcl.Name = "lblciudadcl"
        Me.lblciudadcl.Size = New System.Drawing.Size(0, 18)
        Me.lblciudadcl.TabIndex = 15
        '
        'lbldireccioncl
        '
        Me.lbldireccioncl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldireccioncl.AutoSize = True
        Me.lbldireccioncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccioncl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbldireccioncl.Location = New System.Drawing.Point(462, 150)
        Me.lbldireccioncl.Name = "lbldireccioncl"
        Me.lbldireccioncl.Size = New System.Drawing.Size(0, 18)
        Me.lbldireccioncl.TabIndex = 14
        '
        'lbltelefonocl
        '
        Me.lbltelefonocl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbltelefonocl.AutoSize = True
        Me.lbltelefonocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefonocl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbltelefonocl.Location = New System.Drawing.Point(223, 217)
        Me.lbltelefonocl.Name = "lbltelefonocl"
        Me.lbltelefonocl.Size = New System.Drawing.Size(0, 18)
        Me.lbltelefonocl.TabIndex = 13
        '
        'lblsexo
        '
        Me.lblsexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsexo.AutoSize = True
        Me.lblsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblsexo.Location = New System.Drawing.Point(474, 94)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(0, 18)
        Me.lblsexo.TabIndex = 12
        '
        'lblcedulacliente
        '
        Me.lblcedulacliente.AutoSize = True
        Me.lblcedulacliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedulacliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblcedulacliente.Location = New System.Drawing.Point(18, 155)
        Me.lblcedulacliente.Name = "lblcedulacliente"
        Me.lblcedulacliente.Size = New System.Drawing.Size(0, 18)
        Me.lblcedulacliente.TabIndex = 11
        '
        'lblapellidocliente
        '
        Me.lblapellidocliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblapellidocliente.AutoSize = True
        Me.lblapellidocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapellidocliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblapellidocliente.Location = New System.Drawing.Point(223, 97)
        Me.lblapellidocliente.Name = "lblapellidocliente"
        Me.lblapellidocliente.Size = New System.Drawing.Size(0, 18)
        Me.lblapellidocliente.TabIndex = 10
        '
        'lblnombrecliente
        '
        Me.lblnombrecliente.AutoSize = True
        Me.lblnombrecliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblnombrecliente.Location = New System.Drawing.Point(18, 97)
        Me.lblnombrecliente.Name = "lblnombrecliente"
        Me.lblnombrecliente.Size = New System.Drawing.Size(0, 18)
        Me.lblnombrecliente.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Ciudad:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(474, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(227, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Correo:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(462, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cedula:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Cliente:"
        '
        'btningresarpedido
        '
        Me.btningresarpedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btningresarpedido.Enabled = False
        Me.btningresarpedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresarpedido.ForeColor = System.Drawing.Color.Black
        Me.btningresarpedido.Location = New System.Drawing.Point(802, 293)
        Me.btningresarpedido.Name = "btningresarpedido"
        Me.btningresarpedido.Size = New System.Drawing.Size(75, 66)
        Me.btningresarpedido.TabIndex = 7
        Me.btningresarpedido.Text = "Ingresar pedido"
        Me.btningresarpedido.UseVisualStyleBackColor = True
        '
        'btnexportarpedido
        '
        Me.btnexportarpedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexportarpedido.Enabled = False
        Me.btnexportarpedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexportarpedido.ForeColor = System.Drawing.Color.Black
        Me.btnexportarpedido.Location = New System.Drawing.Point(802, 381)
        Me.btnexportarpedido.Name = "btnexportarpedido"
        Me.btnexportarpedido.Size = New System.Drawing.Size(75, 66)
        Me.btnexportarpedido.TabIndex = 8
        Me.btnexportarpedido.Text = "Exportar datos"
        Me.btnexportarpedido.UseVisualStyleBackColor = True
        '
        'dgvexportar
        '
        Me.dgvexportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvexportar.Location = New System.Drawing.Point(3, 16)
        Me.dgvexportar.Name = "dgvexportar"
        Me.dgvexportar.Size = New System.Drawing.Size(458, 174)
        Me.dgvexportar.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dgvexportar)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(332, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 193)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Base de datos"
        '
        'frmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(889, 498)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnexportarpedido)
        Me.Controls.Add(Me.btningresarpedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Datos Cliente ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvexportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarC As Button
    Friend WithEvents rdonombre As RadioButton
    Friend WithEvents rdoapellido As RadioButton
    Friend WithEvents rdotelefono As RadioButton
    Friend WithEvents rdoidcliente As RadioButton
    Friend WithEvents rdocedula As RadioButton
    Friend WithEvents txtbuscarC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIDcl As Label
    Friend WithEvents lblcorreocl As Label
    Friend WithEvents lblciudadcl As Label
    Friend WithEvents lbldireccioncl As Label
    Friend WithEvents lbltelefonocl As Label
    Friend WithEvents lblsexo As Label
    Friend WithEvents lblcedulacliente As Label
    Friend WithEvents lblapellidocliente As Label
    Friend WithEvents lblnombrecliente As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btningresarpedido As Button
    Friend WithEvents btnexportarpedido As Button
    Friend WithEvents dgvexportar As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
End Class

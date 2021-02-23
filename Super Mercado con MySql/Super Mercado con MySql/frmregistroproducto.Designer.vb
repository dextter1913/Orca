<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmregistroproducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregistroproducto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombreprod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecioprod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcategoriaprod = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnregistrarP = New System.Windows.Forms.Button()
        Me.dgvregistrarproducto = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvregistrarproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Producto:"
        '
        'txtnombreprod
        '
        Me.txtnombreprod.Location = New System.Drawing.Point(214, 50)
        Me.txtnombreprod.Name = "txtnombreprod"
        Me.txtnombreprod.Size = New System.Drawing.Size(175, 20)
        Me.txtnombreprod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio del Producto:"
        '
        'txtprecioprod
        '
        Me.txtprecioprod.Location = New System.Drawing.Point(202, 71)
        Me.txtprecioprod.Name = "txtprecioprod"
        Me.txtprecioprod.Size = New System.Drawing.Size(110, 20)
        Me.txtprecioprod.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(93, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Categoria:"
        '
        'txtcategoriaprod
        '
        Me.txtcategoriaprod.Location = New System.Drawing.Point(202, 102)
        Me.txtcategoriaprod.Name = "txtcategoriaprod"
        Me.txtcategoriaprod.Size = New System.Drawing.Size(110, 20)
        Me.txtcategoriaprod.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnregistrarP)
        Me.GroupBox1.Controls.Add(Me.txtprecioprod)
        Me.GroupBox1.Controls.Add(Me.txtcategoriaprod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 269)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos del producto a registrar"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(87, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Mostrar Categoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(6, 188)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnregistrarP
        '
        Me.btnregistrarP.ForeColor = System.Drawing.Color.Black
        Me.btnregistrarP.Location = New System.Drawing.Point(203, 128)
        Me.btnregistrarP.Name = "btnregistrarP"
        Me.btnregistrarP.Size = New System.Drawing.Size(109, 30)
        Me.btnregistrarP.TabIndex = 0
        Me.btnregistrarP.Text = "Registrar producto"
        Me.btnregistrarP.UseVisualStyleBackColor = True
        '
        'dgvregistrarproducto
        '
        Me.dgvregistrarproducto.AllowUserToOrderColumns = True
        Me.dgvregistrarproducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvregistrarproducto.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvregistrarproducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvregistrarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvregistrarproducto.Location = New System.Drawing.Point(420, 13)
        Me.dgvregistrarproducto.Name = "dgvregistrarproducto"
        Me.dgvregistrarproducto.Size = New System.Drawing.Size(368, 268)
        Me.dgvregistrarproducto.TabIndex = 7
        '
        'frmregistroproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 292)
        Me.Controls.Add(Me.dgvregistrarproducto)
        Me.Controls.Add(Me.txtnombreprod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmregistroproducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Registrar Producto Nuevo ::."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvregistrarproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombreprod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprecioprod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcategoriaprod As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnregistrarP As Button
    Friend WithEvents dgvregistrarproducto As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class

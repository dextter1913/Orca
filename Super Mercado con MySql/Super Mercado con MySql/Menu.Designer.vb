<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrmenu = New System.Windows.Forms.Timer(Me.components)
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.txtminuto = New System.Windows.Forms.TextBox()
        Me.txtsegundo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarClienteToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(878, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarClienteToolStripMenuItem
        '
        Me.BuscarClienteToolStripMenuItem.Name = "BuscarClienteToolStripMenuItem"
        Me.BuscarClienteToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.BuscarClienteToolStripMenuItem.Text = "Buscar Cliente"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem1, Me.ModificarToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'RegistrarToolStripMenuItem1
        '
        Me.RegistrarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.RegistrarToolStripMenuItem1.Name = "RegistrarToolStripMenuItem1"
        Me.RegistrarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarToolStripMenuItem1.Text = "Registrar"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem1})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Super_Mercado_con_MySql.My.Resources.Resources.orca
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(878, 507)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'tmrmenu
        '
        Me.tmrmenu.Enabled = True
        Me.tmrmenu.Interval = 400
        '
        'txthora
        '
        Me.txthora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txthora.BackColor = System.Drawing.Color.Gray
        Me.txthora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthora.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.txthora.ForeColor = System.Drawing.Color.White
        Me.txthora.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txthora.Location = New System.Drawing.Point(792, 27)
        Me.txthora.MaximumSize = New System.Drawing.Size(23, 26)
        Me.txthora.MinimumSize = New System.Drawing.Size(23, 26)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(23, 26)
        Me.txthora.TabIndex = 2
        '
        'txtminuto
        '
        Me.txtminuto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtminuto.BackColor = System.Drawing.Color.Gray
        Me.txtminuto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtminuto.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.txtminuto.ForeColor = System.Drawing.Color.White
        Me.txtminuto.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtminuto.Location = New System.Drawing.Point(821, 27)
        Me.txtminuto.MaximumSize = New System.Drawing.Size(23, 26)
        Me.txtminuto.MinimumSize = New System.Drawing.Size(23, 26)
        Me.txtminuto.Name = "txtminuto"
        Me.txtminuto.Size = New System.Drawing.Size(23, 26)
        Me.txtminuto.TabIndex = 3
        '
        'txtsegundo
        '
        Me.txtsegundo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsegundo.BackColor = System.Drawing.Color.Gray
        Me.txtsegundo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsegundo.Font = New System.Drawing.Font("Palatino Linotype", 14.25!)
        Me.txtsegundo.ForeColor = System.Drawing.Color.White
        Me.txtsegundo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtsegundo.Location = New System.Drawing.Point(850, 27)
        Me.txtsegundo.MaximumSize = New System.Drawing.Size(23, 26)
        Me.txtsegundo.MinimumSize = New System.Drawing.Size(23, 26)
        Me.txtsegundo.Name = "txtsegundo"
        Me.txtsegundo.Size = New System.Drawing.Size(23, 26)
        Me.txtsegundo.TabIndex = 4
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(878, 531)
        Me.Controls.Add(Me.txtsegundo)
        Me.Controls.Add(Me.txtminuto)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Orca v1.0 ::."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrmenu As Timer
    Friend WithEvents BuscarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txthora As TextBox
    Friend WithEvents txtminuto As TextBox
    Friend WithEvents txtsegundo As TextBox
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
End Class

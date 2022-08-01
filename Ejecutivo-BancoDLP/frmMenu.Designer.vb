<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReposicionDeTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelacionDeTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.AToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(336, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem, Me.ActualizacionToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RegistroToolStripMenuItem.Text = "Apertura"
        '
        'ActualizacionToolStripMenuItem
        '
        Me.ActualizacionToolStripMenuItem.Name = "ActualizacionToolStripMenuItem"
        Me.ActualizacionToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ActualizacionToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EliminarToolStripMenuItem.Text = "Cancelacion"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem, Me.SexoToolStripMenuItem, Me.EdadToolStripMenuItem, Me.CiudadToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'SexoToolStripMenuItem
        '
        Me.SexoToolStripMenuItem.Name = "SexoToolStripMenuItem"
        Me.SexoToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SexoToolStripMenuItem.Text = "Sexo"
        '
        'EdadToolStripMenuItem
        '
        Me.EdadToolStripMenuItem.Name = "EdadToolStripMenuItem"
        Me.EdadToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EdadToolStripMenuItem.Text = "Edad"
        '
        'CiudadToolStripMenuItem
        '
        Me.CiudadToolStripMenuItem.Name = "CiudadToolStripMenuItem"
        Me.CiudadToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CiudadToolStripMenuItem.Text = "Ciudad"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoDeCuentaToolStripMenuItem, Me.ReposicionDeTarjetaToolStripMenuItem, Me.CancelacionDeTarjetaToolStripMenuItem})
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AToolStripMenuItem.Text = "Servicios"
        '
        'EstadoDeCuentaToolStripMenuItem
        '
        Me.EstadoDeCuentaToolStripMenuItem.Name = "EstadoDeCuentaToolStripMenuItem"
        Me.EstadoDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EstadoDeCuentaToolStripMenuItem.Text = "Estado de cuenta"
        '
        'ReposicionDeTarjetaToolStripMenuItem
        '
        Me.ReposicionDeTarjetaToolStripMenuItem.Name = "ReposicionDeTarjetaToolStripMenuItem"
        Me.ReposicionDeTarjetaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ReposicionDeTarjetaToolStripMenuItem.Text = "Reposicion de tarjeta"
        '
        'CancelacionDeTarjetaToolStripMenuItem
        '
        Me.CancelacionDeTarjetaToolStripMenuItem.Name = "CancelacionDeTarjetaToolStripMenuItem"
        Me.CancelacionDeTarjetaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CancelacionDeTarjetaToolStripMenuItem.Text = "Cancelacion de tarjeta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SexoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CiudadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReposicionDeTarjetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelacionDeTarjetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

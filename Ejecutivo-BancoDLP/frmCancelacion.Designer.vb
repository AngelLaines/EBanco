<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtEstadoDP = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMunicipioDP = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcodigopostalDP = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCiudadDP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtColoniaDP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumerodecasaDP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCalleDP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCorreoelectronicoDP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCelularDP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefonodecasaDp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxEstadocivilDP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPFechaDeNacimientoDP = New System.Windows.Forms.DateTimePicker()
        Me.cbxSexoDP = New System.Windows.Forms.ComboBox()
        Me.txtEdadDP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCURPDP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidoMaternoDP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidoPaternoDP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreDP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdCliente2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboTipodecuentaDC = New System.Windows.Forms.ComboBox()
        Me.TxtSaldoDC = New System.Windows.Forms.TextBox()
        Me.TxtMontodeaperturaDC = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtNumerodecuentaDC = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.txtEstadoDP)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtMunicipioDP)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtcodigopostalDP)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCiudadDP)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtColoniaDP)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNumerodecasaDP)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCalleDP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCorreoelectronicoDP)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCelularDP)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtTelefonodecasaDp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxEstadocivilDP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DTPFechaDeNacimientoDP)
        Me.GroupBox1.Controls.Add(Me.cbxSexoDP)
        Me.GroupBox1.Controls.Add(Me.txtEdadDP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCURPDP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtApellidoMaternoDP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellidoPaternoDP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombreDP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 323)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(224, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 76
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(135, 22)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(84, 20)
        Me.txtIdCliente.TabIndex = 75
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(18, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 13)
        Me.Label37.TabIndex = 74
        Me.Label37.Text = "ID CLIENTE"
        '
        'txtEstadoDP
        '
        Me.txtEstadoDP.Enabled = False
        Me.txtEstadoDP.Location = New System.Drawing.Point(452, 204)
        Me.txtEstadoDP.Name = "txtEstadoDP"
        Me.txtEstadoDP.Size = New System.Drawing.Size(164, 20)
        Me.txtEstadoDP.TabIndex = 73
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(335, 207)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Estado"
        '
        'txtMunicipioDP
        '
        Me.txtMunicipioDP.Enabled = False
        Me.txtMunicipioDP.Location = New System.Drawing.Point(452, 178)
        Me.txtMunicipioDP.Name = "txtMunicipioDP"
        Me.txtMunicipioDP.Size = New System.Drawing.Size(164, 20)
        Me.txtMunicipioDP.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(335, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Municipio"
        '
        'txtcodigopostalDP
        '
        Me.txtcodigopostalDP.Enabled = False
        Me.txtcodigopostalDP.Location = New System.Drawing.Point(452, 152)
        Me.txtcodigopostalDP.Name = "txtcodigopostalDP"
        Me.txtcodigopostalDP.Size = New System.Drawing.Size(164, 20)
        Me.txtcodigopostalDP.TabIndex = 69
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(335, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Codigo Postal"
        '
        'txtCiudadDP
        '
        Me.txtCiudadDP.Enabled = False
        Me.txtCiudadDP.Location = New System.Drawing.Point(452, 126)
        Me.txtCiudadDP.Name = "txtCiudadDP"
        Me.txtCiudadDP.Size = New System.Drawing.Size(164, 20)
        Me.txtCiudadDP.TabIndex = 67
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(335, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Ciudad"
        '
        'txtColoniaDP
        '
        Me.txtColoniaDP.Enabled = False
        Me.txtColoniaDP.Location = New System.Drawing.Point(452, 100)
        Me.txtColoniaDP.Name = "txtColoniaDP"
        Me.txtColoniaDP.Size = New System.Drawing.Size(164, 20)
        Me.txtColoniaDP.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(335, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Colonia"
        '
        'txtNumerodecasaDP
        '
        Me.txtNumerodecasaDP.Enabled = False
        Me.txtNumerodecasaDP.Location = New System.Drawing.Point(452, 74)
        Me.txtNumerodecasaDP.Name = "txtNumerodecasaDP"
        Me.txtNumerodecasaDP.Size = New System.Drawing.Size(164, 20)
        Me.txtNumerodecasaDP.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(335, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Numero de casa"
        '
        'txtCalleDP
        '
        Me.txtCalleDP.Enabled = False
        Me.txtCalleDP.Location = New System.Drawing.Point(452, 48)
        Me.txtCalleDP.Name = "txtCalleDP"
        Me.txtCalleDP.Size = New System.Drawing.Size(164, 20)
        Me.txtCalleDP.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Calle"
        '
        'txtCorreoelectronicoDP
        '
        Me.txtCorreoelectronicoDP.Enabled = False
        Me.txtCorreoelectronicoDP.Location = New System.Drawing.Point(452, 22)
        Me.txtCorreoelectronicoDP.Name = "txtCorreoelectronicoDP"
        Me.txtCorreoelectronicoDP.Size = New System.Drawing.Size(164, 20)
        Me.txtCorreoelectronicoDP.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(335, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Correo electronico"
        '
        'txtCelularDP
        '
        Me.txtCelularDP.Enabled = False
        Me.txtCelularDP.Location = New System.Drawing.Point(135, 283)
        Me.txtCelularDP.Name = "txtCelularDP"
        Me.txtCelularDP.Size = New System.Drawing.Size(164, 20)
        Me.txtCelularDP.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Celular"
        '
        'TxtTelefonodecasaDp
        '
        Me.TxtTelefonodecasaDp.Enabled = False
        Me.TxtTelefonodecasaDp.Location = New System.Drawing.Point(135, 257)
        Me.TxtTelefonodecasaDp.Name = "TxtTelefonodecasaDp"
        Me.TxtTelefonodecasaDp.Size = New System.Drawing.Size(164, 20)
        Me.TxtTelefonodecasaDp.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Telefono Casa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Estado civil"
        '
        'cbxEstadocivilDP
        '
        Me.cbxEstadocivilDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEstadocivilDP.Enabled = False
        Me.cbxEstadocivilDP.FormattingEnabled = True
        Me.cbxEstadocivilDP.Items.AddRange(New Object() {"SOLTERO(A)", "CASADO(A)", "DIVORCIADO(A)", "UNION LIBRE"})
        Me.cbxEstadocivilDP.Location = New System.Drawing.Point(135, 230)
        Me.cbxEstadocivilDP.Name = "cbxEstadocivilDP"
        Me.cbxEstadocivilDP.Size = New System.Drawing.Size(164, 21)
        Me.cbxEstadocivilDP.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Sexo"
        '
        'DTPFechaDeNacimientoDP
        '
        Me.DTPFechaDeNacimientoDP.Enabled = False
        Me.DTPFechaDeNacimientoDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDeNacimientoDP.Location = New System.Drawing.Point(135, 204)
        Me.DTPFechaDeNacimientoDP.Name = "DTPFechaDeNacimientoDP"
        Me.DTPFechaDeNacimientoDP.Size = New System.Drawing.Size(164, 20)
        Me.DTPFechaDeNacimientoDP.TabIndex = 49
        '
        'cbxSexoDP
        '
        Me.cbxSexoDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSexoDP.Enabled = False
        Me.cbxSexoDP.FormattingEnabled = True
        Me.cbxSexoDP.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cbxSexoDP.Location = New System.Drawing.Point(135, 151)
        Me.cbxSexoDP.Name = "cbxSexoDP"
        Me.cbxSexoDP.Size = New System.Drawing.Size(164, 21)
        Me.cbxSexoDP.TabIndex = 48
        '
        'txtEdadDP
        '
        Me.txtEdadDP.Enabled = False
        Me.txtEdadDP.Location = New System.Drawing.Point(135, 178)
        Me.txtEdadDP.Name = "txtEdadDP"
        Me.txtEdadDP.Size = New System.Drawing.Size(164, 20)
        Me.txtEdadDP.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Edad"
        '
        'txtCURPDP
        '
        Me.txtCURPDP.Enabled = False
        Me.txtCURPDP.Location = New System.Drawing.Point(135, 125)
        Me.txtCURPDP.Name = "txtCURPDP"
        Me.txtCURPDP.Size = New System.Drawing.Size(164, 20)
        Me.txtCURPDP.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CURP"
        '
        'txtApellidoMaternoDP
        '
        Me.txtApellidoMaternoDP.Enabled = False
        Me.txtApellidoMaternoDP.Location = New System.Drawing.Point(135, 99)
        Me.txtApellidoMaternoDP.Name = "txtApellidoMaternoDP"
        Me.txtApellidoMaternoDP.Size = New System.Drawing.Size(164, 20)
        Me.txtApellidoMaternoDP.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Apellido Materno"
        '
        'txtApellidoPaternoDP
        '
        Me.txtApellidoPaternoDP.Enabled = False
        Me.txtApellidoPaternoDP.Location = New System.Drawing.Point(135, 73)
        Me.txtApellidoPaternoDP.Name = "txtApellidoPaternoDP"
        Me.txtApellidoPaternoDP.Size = New System.Drawing.Size(164, 20)
        Me.txtApellidoPaternoDP.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Apellido Paterno"
        '
        'txtNombreDP
        '
        Me.txtNombreDP.Enabled = False
        Me.txtNombreDP.Location = New System.Drawing.Point(135, 47)
        Me.txtNombreDP.Name = "txtNombreDP"
        Me.txtNombreDP.Size = New System.Drawing.Size(164, 20)
        Me.txtNombreDP.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nombre"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(762, 199)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(648, 199)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdCliente2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtEstatus)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cboTipodecuentaDC)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoDC)
        Me.GroupBox2.Controls.Add(Me.TxtMontodeaperturaDC)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.TxtNumerodecuentaDC)
        Me.GroupBox2.Location = New System.Drawing.Point(648, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 181)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la cuenta"
        '
        'txtIdCliente2
        '
        Me.txtIdCliente2.Enabled = False
        Me.txtIdCliente2.Location = New System.Drawing.Point(166, 151)
        Me.txtIdCliente2.Name = "txtIdCliente2"
        Me.txtIdCliente2.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente2.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(94, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "ID CLIENTE"
        '
        'txtEstatus
        '
        Me.txtEstatus.Enabled = False
        Me.txtEstatus.Location = New System.Drawing.Point(166, 125)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(101, 20)
        Me.txtEstatus.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(126, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Estatus"
        '
        'cboTipodecuentaDC
        '
        Me.cboTipodecuentaDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipodecuentaDC.Enabled = False
        Me.cboTipodecuentaDC.FormattingEnabled = True
        Me.cboTipodecuentaDC.Items.AddRange(New Object() {"CORRIENTE", "JOVEN", "REMUNERADA"})
        Me.cboTipodecuentaDC.Location = New System.Drawing.Point(166, 44)
        Me.cboTipodecuentaDC.Name = "cboTipodecuentaDC"
        Me.cboTipodecuentaDC.Size = New System.Drawing.Size(101, 21)
        Me.cboTipodecuentaDC.TabIndex = 40
        '
        'TxtSaldoDC
        '
        Me.TxtSaldoDC.Enabled = False
        Me.TxtSaldoDC.Location = New System.Drawing.Point(166, 100)
        Me.TxtSaldoDC.Name = "TxtSaldoDC"
        Me.TxtSaldoDC.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoDC.TabIndex = 39
        '
        'TxtMontodeaperturaDC
        '
        Me.TxtMontodeaperturaDC.Enabled = False
        Me.TxtMontodeaperturaDC.Location = New System.Drawing.Point(166, 70)
        Me.TxtMontodeaperturaDC.Name = "TxtMontodeaperturaDC"
        Me.TxtMontodeaperturaDC.Size = New System.Drawing.Size(100, 20)
        Me.TxtMontodeaperturaDC.TabIndex = 36
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(126, 100)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(34, 13)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "Saldo"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(66, 73)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(94, 13)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Monto de apertura"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(82, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 13)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Tipo de cuenta"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(66, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Numero de cuenta"
        '
        'TxtNumerodecuentaDC
        '
        Me.TxtNumerodecuentaDC.Enabled = False
        Me.TxtNumerodecuentaDC.Location = New System.Drawing.Point(167, 18)
        Me.TxtNumerodecuentaDC.Name = "TxtNumerodecuentaDC"
        Me.TxtNumerodecuentaDC.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumerodecuentaDC.TabIndex = 29
        '
        'frmCancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 349)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCancelacion"
        Me.Text = "frmCancelacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtEstadoDP As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtMunicipioDP As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcodigopostalDP As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCiudadDP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtColoniaDP As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNumerodecasaDP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCalleDP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoelectronicoDP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCelularDP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefonodecasaDp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxEstadocivilDP As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTPFechaDeNacimientoDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxSexoDP As System.Windows.Forms.ComboBox
    Friend WithEvents txtEdadDP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCURPDP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaternoDP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaternoDP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreDP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdCliente2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboTipodecuentaDC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSaldoDC As System.Windows.Forms.TextBox
    Friend WithEvents TxtMontodeaperturaDC As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtNumerodecuentaDC As System.Windows.Forms.TextBox
End Class

Imports System.Data
Imports System.Data.OleDb
Public Class frmRegistroCliente

   

    Private Sub btnRegistrarRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarRC.Click
        ''Datos personales
        If txtNombreDP.Text = "" Then
            MsgBox("Falta el dato Id del empleado")
            txtNombreDP.Focus()
        End If

        If TxtNombreRL.Text = "" Then
            MsgBox("Falta el dato Nombre")
            TxtNombreRL.Focus()
            Exit Sub
        End If

        If txtApellidoPaternoDP.Text = "" Then
            MsgBox("Falta el dato apellido paterno")
            txtApellidoPaternoDP.Focus()
            Exit Sub
        End If

        If txtApellidoMaternoDP.Text = "" Then
            MsgBox("Falta el dato apellido materno")
            txtApellidoMaternoDP.Focus()
            Exit Sub
        End If

        If TxtDireccionDL.Text = "" Then
            MsgBox("Falta el dato direccion")
            TxtDireccionDL.Focus()
            Exit Sub
        End If

        If cbxSexoDP.SelectedIndex = -1 Then
            MsgBox("Falta el dato sexo")
            cbxSexoDP.Focus()
            Exit Sub

        End If

        If txtCURPDP.Text = "" Then
            MsgBox("Falta el dato curp")
            txtCURPDP.Focus()
            Exit Sub
        End If
        If txtEdadDP.Text = "" Then
            MsgBox("Falta el dato Edad")
            txtEdadDP.Focus()
            Exit Sub
        End If
        If cbxEstadocivilDP.Text = "" Then
            MsgBox("Falta el dato estado civil")
            cbxEstadocivilDP.Focus()
            Exit Sub
        End If
        If TxtTelefonodecasaDp.Text = "" Then
            MsgBox("Falta el dato telefono de casa")
            TxtTelefonodecasaDp.Focus()
            Exit Sub
        End If

        If txtCelularDP.Text = "" Then
            MsgBox("Falta el dato celular")
            txtCelularDP.Focus()
            Exit Sub
        End If
        If txtCorreoelectronicoDP.Text = "" Then
            MsgBox("Falta el dato correo")
            txtCorreoelectronicoDP.Focus()
            Exit Sub
        End If
        If txtCalleDP.Text = "" Then
            MsgBox("Falta el dato calle")
            txtCalleDP.Focus()
            Exit Sub
        End If
        If txtNumerodecasaDP.Text = "" Then
            MsgBox("Falta el dato Numero de casa")
            txtNumerodecasaDP.Focus()
            Exit Sub
        End If
        If txtColoniaDP.Text = "" Then
            MsgBox("Falta el dato colonia")
            txtColoniaDP.Focus()
            Exit Sub
        End If
        If txtCiudadDP.Text = "" Then
            MsgBox("Falta el dato Ciaudad")
            txtCiudadDP.Focus()
            Exit Sub
        End If
        If txtcodigopostalDP.Text = "" Then
            MsgBox("Falta el dato Codigo postal")
            txtcodigopostalDP.Focus()
            Exit Sub
        End If
        If txtMunicipioDP.Text = "" Then
            MsgBox("Falta el dato municipio")
            txtMunicipioDP.Focus()
            Exit Sub
        End If
        If txtEstadoDP.Text = "" Then
            MsgBox("Falta el dato Estado")
            txtEstadoDP.Focus()
            Exit Sub
        End If
        If TxtTelefonodecasaDp.Text = "" Then
            MsgBox("Falta el dato telefono")
            TxtTelefonodecasaDp.Focus()
            Exit Sub
        End If

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim SentSQLinsert As String
            SentSQLinsert = "INSERT INTO CLIENTES(idcliente,Nombre,ApellidoPaterno,ApellidoMaterno,CURP,Sexo,Edad,FechaNacimiento,EstadoCivil,Telefono,Celular,CorreoElectronico,Calle,NoCasa,Colonia,Ciudad,CodigoPostal,Municipio,Estado) VALUES(" & txtIdCliente.Text & ",'" & txtNombreDP.Text & "','" & txtApellidoPaternoDP.Text & "','" & txtApellidoMaternoDP.Text & "','" & txtCURPDP.Text & "','" & cbxSexoDP.SelectedItem.ToString & "'," & txtEdadDP.Text & ",'" & DTPFechaDeNacimientoDP.Value & "','" & cbxEstadocivilDP.SelectedItem.ToString & "'," & TxtTelefonodecasaDp.Text & "," & txtCelularDP.Text & ",'" & txtCorreoelectronicoDP.Text & "','" & txtCalleDP.Text & "'," & txtNumerodecasaDP.Text & ",'" & txtColoniaDP.Text & "','" & txtCiudadDP.Text & "'," & txtcodigopostalDP.Text & ",'" & txtMunicipioDP.Text & "','" & txtEstadoDP.Text & "')"
            Dim comando As New OleDbCommand(SentSQLinsert, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Los datos fueron guardados con exito.", "Sistema de control")
            conexion.Close()

            ''poner que se limpien los campos al guaradar

            ''de todos los textos
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        ''esto es de la tabla Referencias laborales.

        If TxtNombreRL.Text = "" Then
            MsgBox("Falta el dato nombre en Referencias laborales")
            TxtNombreRL.Focus()
            Exit Sub
        End If
        If TxtTelefonoRL.Text = "" Then
            MsgBox("Falta el dato telefono Referencias laborales")
            TxtTelefonoRL.Focus()
            Exit Sub
        End If
        If TxtDireccionRL.Text = "" Then
            MsgBox("Falta el dato Direccion Referencias laborales")
            TxtDireccionRL.Focus()
            Exit Sub
        End If

        If TxtParentescoRL.Text = "" Then
            MsgBox("Falta el dato Parentesco Referencias laborales")
            TxtParentescoRL.Focus()
            Exit Sub
        End If
        If TxtTiempodeconocerloRL.Text = "" Then
            MsgBox("Falta el dato riempo de conocerlo Referencias laborales")
            TxtTiempodeconocerloRL.Focus()
            Exit Sub
        End If
        ''datos laborales 
        If TxtNombredelaempresaDL.Text = "" Then
            MsgBox("Falta el dato nombre de Empresa en datos laborales")
            TxtNombredelaempresaDL.Focus()
            Exit Sub
        End If
        If TxtTelefonoDL.Text = "" Then
            MsgBox("Falta el dato telefono en datos laborales")
            TxtTelefonoDL.Focus()
            Exit Sub
        End If
        If TxtPuestoDL.Text = "" Then
            MsgBox("Falta el dato puesto en datos laborales")
            TxtPuestoDL.Focus()
            Exit Sub
        End If
        If TxtsueldomensualDL.Text = "" Then
            MsgBox("Falta el dato sueldo mensual en datos laborales")
            TxtNombredelaempresaDL.Focus()
            Exit Sub
        End If
        If TxtantiguedadDL.Text = "" Then
            MsgBox("Falta el dato Antiguedad en datos laborales")
            TxtantiguedadDL.Focus()
            Exit Sub
        End If
        ''Datos de cuenta
        If TxtNumerodecuentaDC.Text = "" Then
            MsgBox("Falta el dato Numero de cuenta en datos de cuenta")
            TxtNumerodecuentaDC.Focus()
            Exit Sub
        End If
        If cboTipodecuentaDC.Text = "" Then
            MsgBox("Falta el datotipode cuenta en datos de cuenta")
            cboTipodecuentaDC.Focus()
            Exit Sub
        End If
        If TxtMontodeaperturaDC.Text = "" Then
            MsgBox("Falta el dato monto de apertura en datos de cuenta")
            TxtMontodeaperturaDC.Focus()
            Exit Sub
        End If

        If TxtSaldoDC.Text = "" Then
            MsgBox("Falta el dato Saldo en datos de cuenta")
            TxtSaldoDC.Focus()
            Exit Sub
        End If

        ''finaliza la verificacion de los datos 

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim SentSQLinsert As String
            SentSQLinsert = "INSERT INTO Referencias(idcliente,Nombre,Telefono,Direccion,parentesco,TiempoConocerlo ) VALUES(" & txtIdCliente.Text & ",'" & TxtNombreRL.Text & "'," & TxtTelefonoRL.Text & ",'" & TxtDireccionRL.Text & "','" & TxtParentescoRL.Text & "','" & TxtTiempodeconocerloRL.Text & "')"

            Dim comando As New OleDbCommand(SentSQLinsert, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            ''poner que se limpien los campos al guaradar

            ''de todos los textos
            MessageBox.Show("Los datos fueron guardados con exito.", "Sistema de control ")
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub

        End Try

        ''Datos laborales
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQLinsert As String
            sentSQLinsert = "INSERT INTO Laborales(idcliente,NombreEmpresa,Direccion,Telefono,Puesto,SueldoMensual,Antiguedad) Values(" & txtIdCliente.Text & ",'" & TxtNombredelaempresaDL.Text & "','" & TxtDireccionDL.Text & "','" & TxtTelefonoDL.Text & "','" & TxtPuestoDL.Text & "','" & TxtsueldomensualDL.Text & "','" & TxtantiguedadDL.Text & "')"

            Dim comando As New OleDbCommand(sentSQLinsert, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            ''póner que se limpien los campos al guardar

            ''de todos los textbox
            MessageBox.Show("los datos fueron guardados con exito.", "sistema de control")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        ''datos de cuenta 
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQLinsert As String
            sentSQLinsert = "INSERT INTO Cuentas values(" & TxtNumerodecuentaDC.Text & ",'" & cboTipodecuentaDC.SelectedItem.ToString & "'," & TxtMontodeaperturaDC.Text & "," & TxtSaldoDC.Text & ",'ACTIVO'," & txtIdCliente.Text & ")"
            Dim comando As New OleDbCommand(sentSQLinsert, conexion)
            conexion.Open()
            comando.ExecuteNonQuery()

            ''poner que se limpien los campos al guardar


            ''de todos los textbox

            MessageBox.Show("los datos fueron guardados con exito", "sistema de control")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try


        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQL As String
            sentSQL = "SELECT MAX(NoCuenta) FROM Cuentas"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtIdCliente.Text = "1"
            Else
                txtIdCliente.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            Exit Sub
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQL As String
            sentSQL = "SELECT MAX(IDcliente) FROM CLIENTES WHERE idcliente>" & Format(Now, "yyyy") & "000"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtIdCliente.Text = Format(Now, "yyyy") & "001"
            Else
                txtIdCliente.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub CbsTipodecuentaDC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipodecuentaDC.SelectedIndexChanged

    End Sub

    Private Sub frmRegistroCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQL As String
            sentSQL = "SELECT MAX(IDcliente) FROM CLIENTES WHERE idcliente>" & Format(Now, "yyyy") & "000"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                txtIdCliente.Text = Format(Now, "yyyy") & "001"
            Else
                txtIdCliente.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        Try
            Dim conexion As New OleDbConnection
            conexion.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)

            Dim sentSQL As String
            sentSQL = "SELECT MAX(NoCuenta) FROM Cuentas"

            Dim MiComando As New OleDbCommand(sentSQL, conexion)

            conexion.Open()

            If IsDBNull(MiComando.ExecuteScalar()) = True Then
                'No hay registros coincidentes
                TxtNumerodecuentaDC.Text = "1"
            Else
                TxtNumerodecuentaDC.Text = (MiComando.ExecuteScalar() + 1).ToString

            End If

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class
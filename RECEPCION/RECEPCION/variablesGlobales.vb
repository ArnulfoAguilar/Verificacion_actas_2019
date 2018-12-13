Imports System.Data.OracleClient
Module variablesGlobales
    Public evento As Integer
    Public cadena As String = "server = ORCL; User id =RECEPCION_ACTAS_2019; Password = Usi123; Unicode =True"
    Public conn As New OracleConnection(cadena)
    Public bandera = 0 'Me ayudara a cargar el combobox de la ruta dependiendo de la sede logistica escogida.
    Public ROL As String
    Public USUARIO As String
    Public verificado As Integer
    Public id_bolsa As String ' Guardo el id de la bolsa que esta siendo escaneada, apra actualizar el acta respecto a ese ID
End Module

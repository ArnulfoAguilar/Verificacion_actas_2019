Imports System.Data.OracleClient
Module variables_globales
    'Conexion a bases de datos
    Public cadena As String = "server = localhost/ORCL; User id = recepcion_actas_2019; Password = Usi123; Unicode =True"
    Public conn As New OracleConnection(cadena)
    ' /Fin conexion a base de datos
    Public id_bolsa_seguridad As Integer 'ID de la bolsa de seguridad que se esta escaneando 
    Public Ipreader As String 'IP de la Ubicacion donde se conecta
    Public ROL As String    'Rol del usuario
    Public USUARIO As String 'nombre del usuario
    Public evento As Integer 'id del evento que se quiere escanear
End Module

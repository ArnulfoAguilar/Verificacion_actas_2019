Imports System.Data.OracleClient
Module variables_Globales
    Public cadena As String = "server = ORCL; User id = recepcion_actas_2019; Password = Usi123; Unicode =True"
    Public conn As New OracleConnection(cadena)
    Public evento As Integer
End Module

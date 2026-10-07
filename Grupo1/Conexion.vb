Module Conexion

    Public ReadOnly Ruta As String = My.Application.Info.DirectoryPath & "\LEVEL_UP.accdb"
    Public ReadOnly CadenaDeConexion As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Ruta};"

    Public rol As String = ""

End Module

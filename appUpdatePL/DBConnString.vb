Option Explicit On
Option Strict On

Public NotInheritable Class DBConnString

    'VPN  7.191.194.14    
    'Public Shared strConn2 As String = "Data Source=7.49.100.224\SQLEXPRESS;Initial Catalog=DB2012;User ID=sa;Password=$y$05000"

    '  DataBaseTest 
    Public Shared strConn2 As String = "Data Source=192.168.1.3\SQLEXPRESS;Initial Catalog=newZone;User ID=sa;Password=$y$05000"
    'Public Shared strConn2 As String = "Data Source=192.168.1.3\SQLEXPRESS;Initial Catalog=db2012;User ID=sa;Password=$y$05000"

    'Public Shared strConn2 As String = "Data Source=bd_kritpon-pc\SQLEXPRESS;Initial Catalog=db2012;User ID=sa;Password=sys0500"

    '===================================================================================

    Public Shared UserName As String = ""

End Class

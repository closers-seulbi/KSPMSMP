'Imports System.Net
'Imports System.IO

Module Dropbox
    'Function HTTP_Get(Page As String) As Byte()
    '    Dim Request As HttpWebRequest = WebRequest.Create(Page)
    '    Request.Method = "GET"
    '    Request.KeepAlive = True
    '    Request.ContentType = "application/x-www-form-urlencoded"
    '    Request.UserAgent = "Mozilla/5.0 (Windows NT 6.3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.154 Safari/537.36"
    '    Request.AllowAutoRedirect = True

    '    Dim Response As HttpWebResponse = Request.GetResponse()
    '    Dim Data As Stream = Response.GetResponseStream()
    '    Dim Bytes() As Byte
    '    Using Writer As New MemoryStream
    '        Dim Buffer(&HFFF) As Byte

    '        Do
    '            Dim BytesRead As Integer = Data.Read(Buffer, 0, Buffer.Length)
    '            If BytesRead > 0 Then Writer.Write(Buffer, 0, BytesRead) Else Exit Do
    '        Loop

    '        Bytes = Writer.ToArray()
    '    End Using

    '    Return Bytes
    'End Function
End Module

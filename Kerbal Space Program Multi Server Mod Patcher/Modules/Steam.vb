Imports System.IO

Module Steam

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '공통 변수 선언
    Private Property steam_registry As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", Nothing)
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '스팀 설치 여부 확인
    Function steam_existence(e As Boolean) As Integer
        If String.IsNullOrEmpty(steam_registry) = False Then Return 1
        Return 0
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '스팀 설치 경로
    Function steam_directory(d As Boolean) As String
        If steam_existence(True) = 1 Then Return steam_registry
        Return ""
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '스팀 라이브러리 경로
    Function library(l As Boolean) As String
        Dim line As String
        Dim withoutParts As String

        Using reader As New StreamReader(steam_registry + "/config/config.vdf")
            While Not reader.EndOfStream
                line = reader.ReadLine()
                'line = "				""BaseInstallFolder_1""		""D:\\Game\\Steam"""
                If line.Contains("BaseInstallFolder_1") Then
                    withoutParts = Replace(line, "				""BaseInstallFolder_1""		", "")
                    withoutParts = Replace(withoutParts, """", "")
                    withoutParts = Replace(withoutParts, "\\", "\")
                    'withoutParts = withoutParts + "\steamapps\common\Kerbal Space Program"
                    Return withoutParts
                End If
            End While
        End Using
        Return ""
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    'Kerbal Space Program 설치 여부 확인
    Function ksp_existence(k As Boolean) As Integer
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\220200", "Installed", Nothing) = "1" Then Return 1
        Return 0
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    'Kerbal Space Program 경로
    Function ksp_directory(k As Boolean) As String
        Dim ksp As String = "\steamapps\common\Kerbal Space Program"
        If ksp_existence(True) = 1 Then Return (library(True) + ksp)
        Return ""
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////
End Module

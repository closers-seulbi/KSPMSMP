Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.ComponentModel

Public Class Tudy

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '공통 변수 선언
    Dim WithEvents WebC As New WebClient
    Dim ksp As String = Steam.ksp_directory(True)
    Dim ksp_temp As String = ksp + "\_TEMP"
    Dim gamedata As String = ksp_temp + "\GameData.zip"
    Dim gamedata_temp As String = ksp_temp + "\GameData"
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '다운로드 서버 #1 버튼
    Private Sub DownloadButton1_Click(sender As Object, e As EventArgs) Handles DownloadButton1.Click
        DownloadButton1.Enabled = False
        Dim download_url As String = "https://kerbalkorea.cf/server/tudy/GameData.zip"

        If My.Computer.FileSystem.DirectoryExists(ksp_temp) = True Then My.Computer.FileSystem.DeleteDirectory(ksp_temp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.CreateDirectory(ksp_temp)

        WebC.DownloadFileAsync(New Uri(download_url), gamedata)
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '다운로드 진행도
    Private Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WebC.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '다운로드 완료시 실행되는 설치 스크립트
    Private Sub DownloadFinished(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles WebC.DownloadFileCompleted
        MsgBox("모드팩 다운로드가 완료되었습니다" + Environment.NewLine + "설치를 진행합니다" + Environment.NewLine + "다음 팝업이 뜰때 까지 잠시만 기다려 주세요")
        MainModule.unzip(True)
        MainModule.backup(True)
        MainModule.install(True)
        If MainModule.clean(True) = 1 Then MsgBox("설치가 완료되었습니다" + Environment.NewLine + "즐거운 게임 하시길 바랍니다")
        DownloadButton1.Enabled = True
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '다운로드 서버 #2 버튼
    Private Sub DownloadButton2_Click(sender As Object, e As EventArgs) Handles DownloadButton2.Click
        Dim desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Download_Dropbox("https://www.dropbox.com/s/fdw7n64oobvn476/GameData.zip?dl=1", desktop + "\GameData.zip")

        'My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/content_link/q2mvUzy5TZFCzuJRdVpRrv64J9b0n8ncYT4uLGq32mDLnZe87vmEvJnEpK433IBl/file?dl=1", desktop + "\GameData.zip", "", "", True, 3124800, True)

        'If My.Computer.FileSystem.DirectoryExists(desktop + "\Unzip") = True Then My.Computer.FileSystem.DeleteDirectory(desktop + "\Unzip", FileIO.DeleteDirectoryOption.DeleteAllContents)
        'My.Computer.FileSystem.CreateDirectory(desktop + "\Unzip")

        'ZipFile.ExtractToDirectory(desktop + "\GameData.zip", desktop + "\Unzip")

    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '드랍박스 다운로드 - 소스 코드 수정중
    Private Sub Download_Dropbox(URL As String, FileName As String)
        'Dim Data() = Dropbox.HTTP_Get(URL)
        'File.WriteAllBytes(FileName, Data)
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '브라우저 홈 버튼
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        WebBrowser1.Navigate("http://cafe.naver.com/kerbal/42477")
        DownloadButton1.Enabled = False
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////////
    '웹 페이지 로딩 완료 후 다운로드 버튼 활성화
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        DownloadButton1.Enabled = True
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub Tudy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
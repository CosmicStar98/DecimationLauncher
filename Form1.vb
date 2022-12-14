
Imports System.Environment
Imports System
Imports System.IO
Imports System.Net
Imports System.Drawing.Pen
Imports System.Drawing.Rectangle

Public Class Form1

    Dim isHovering As Boolean = False

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles picMain.Click
        System.Diagnostics.Process.Start("http://www.mcdecimation.net/forums/")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (Manager_VersionControl.isForgeInstalled) Then
            lblForgeNotification.Text = "Forge 1.7.10 is not installed!"
        End If
        loadUI()

    End Sub

    Function loadUI()

        Dim MyWebClient As New System.Net.WebClient

        Try
            Dim ImageInBytes() As Byte = MyWebClient.DownloadData("http://www.mcdecimation.net/serverfiles/decimation/launcher_image.png")

            Dim ImageStream As New IO.MemoryStream(ImageInBytes)

            picMain.Image = New System.Drawing.Bitmap(ImageStream)

            ImageStream.Close()

        Catch ex As Exception

            picMain.Image = My.Resources.launcher_image

        End Try

        lblVersion.Text = "Latest Game Version: " & Manager_VersionControl.getVersion


    End Function

    Private Sub lblTopRight_Click(sender As Object, e As EventArgs) Handles lblTopRight.Click
        System.Diagnostics.Process.Start("http://www.mcdecimation.net")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        My.Computer.Audio.Play(My.Resources.button_click_1, AudioPlayMode.Background)
        Manager_Installer.init()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLaunch.MouseHover

        btnLaunch.BackgroundImage = My.Resources.button_highlighted

        If (isHovering = False) Then
            isHovering = True
            My.Computer.Audio.Play(My.Resources.button_click_2, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLaunch.MouseLeave
        btnLaunch.BackgroundImage = My.Resources.button

        isHovering = False

    End Sub

    Shared Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        My.Forms.Form1.lblDownload.Visible = True
        My.Forms.Form1.lblDownload.Text = "Downloading... (" & Convert.ToInt32((bytesIn / 1048576)) & "Mb/" & Convert.ToInt32((totalBytes / 1048576)) & "Mb) " & Convert.ToInt32(percentage) & "%"

        My.Forms.Form1.dlBar.Visible = True
        My.Forms.Form1.dlBar.Value = Int32.Parse(Math.Truncate(percentage).ToString())

    End Sub

    Shared Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        Manager_Installer.finishInstallation()
        My.Forms.Form1.lblDownload.Text = "Download Complete! - Use Minecraft Launcher to Play!"

    End Sub


End Class

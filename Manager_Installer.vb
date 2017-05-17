
Imports System.Environment
Imports System
Imports System.IO
Imports System.Net
Imports System.Security.Permissions

<FileIOPermission(SecurityAction.Demand)> Public Class Manager_Installer

    Shared Function init()

        If Not (Manager_VersionControl.isForgeInstalled) Then

            Dim result = MsgBox("Forge 1.7.10 is not installed! " & Environment.NewLine & "Go to files.minecraftforge.net and download the Forge 1.7.10 installer!" & Environment.NewLine & Environment.NewLine & "Open Forge website now?", vbYesNo, "Forge 1.7.10 not found!")

            Select Case result
                Case vbYes
                    Try
                        System.Diagnostics.Process.Start("http://files.minecraftforge.net/maven/net/minecraftforge/forge/index_1.7.10.html")
                    Catch ex As System.Security.SecurityException
                        MsgBox("Unable to open Forge Downloads Webpage! (Run Launcher as Administrator)")
                    End Try
            End Select

            My.Forms.Form1.progBar.Visible = False

        Else

            My.Forms.Form1.btnLaunch.Enabled = False
            My.Forms.Form1.progBar.Visible = True
            My.Forms.Form1.progBar.Value = 10

            Manager_VersionControl.deleteOldFiles()

            downloadLatestGame()

        End If

    End Function

    <FileIOPermission(SecurityAction.Demand)> Shared Function downloadLatestGame()

        My.Forms.Form1.progBar.Value = 30

        Dim client As WebClient = New WebClient

        AddHandler client.DownloadProgressChanged, AddressOf My.Forms.Form1.client_ProgressChanged

        AddHandler client.DownloadFileCompleted, AddressOf My.Forms.Form1.client_DownloadCompleted

        My.Forms.Form1.progBar.Value = 40

        Dim downloadPath As String
        downloadPath = GetFolderPath(SpecialFolder.ApplicationData) + "\.minecraft\mods\"

        If (Not System.IO.Directory.Exists(downloadPath)) Then
            Try
                System.IO.Directory.CreateDirectory(downloadPath)
            Catch ex As System.Security.SecurityException
                MsgBox("Invalid permissions to create \mods\ path")
            End Try
        End If

        My.Forms.Form1.progBar.Value = 50

        My.Forms.Form1.dlBar.Visible = True

        Try
            client.DownloadFileAsync(New Uri("http://www.mcdecimation.net/download/Decimation-" & Manager_VersionControl.getVersion & ".zip"), downloadPath & "Decimation-" & Manager_VersionControl.getVersion & ".zip")
        Catch ex As System.Security.SecurityException
            MsgBox("Invalid permissions to download mod! (Run Launcher as Administrator)")
        End Try

    End Function

    Shared Function finishInstallation()

        My.Forms.Form1.progBar.Value = 60

        If (Manager_VersionControl.otherModsInstalled) Then
            MessageBox.Show("You have other mods installed!" & Environment.NewLine & "Remember that this may prevent you from playing Decimation" & Environment.NewLine & "on Official Servers!", "Other mods found!")
        End If

        My.Forms.Form1.progBar.Value = 70

        MessageBox.Show("Decimation has been Installed/Updated!" & Environment.NewLine & "Use your Minecraft Launcher and chose Forge 1.7.10!", "Installation Complete!")

        My.Forms.Form1.progBar.Value = 80

        My.Forms.Form1.dlBar.Visible = False
        My.Forms.Form1.progBar.Visible = False

        My.Forms.Form1.progBar.Value = 100

        My.Forms.Form1.btnLaunch.Enabled = True

    End Function

End Class


Imports System.Environment
Imports System
Imports System.IO

Public Class Manager_VersionControl

    Shared Function getVersion() As String

        Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\"

        If My.Computer.FileSystem.FileExists(TempPath & "ver.txt") Then
            My.Computer.FileSystem.DeleteFile(TempPath & "ver.txt")
        End If

        My.Computer.Network.DownloadFile("http://www.mcdecimation.net/serverfiles/decimation/latestversion.txt", TempPath & "ver.txt")

        Dim Reader As New IO.StreamReader(TempPath & "ver.txt")

        Dim FileContents As String = Reader.ReadToEnd

        Reader.Close()

        Return FileContents.ToString

    End Function

    Shared Function isForgeInstalled() As Boolean

        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData) + "\.minecraft\versions\"

        For Each Dir As String In Directory.GetDirectories(appData)
            If (Dir.Contains("1.7.10") And (Dir.Contains("forge") Or Dir.Contains("Forge"))) Then
                Return True
            End If
        Next

        Return False

    End Function

    Shared Function otherModsInstalled() As Boolean

        Dim modsFolder As String = GetFolderPath(SpecialFolder.ApplicationData) + "\.minecraft\mods\"

        If My.Computer.FileSystem.DirectoryExists(modsFolder) Then

            Dim counter = My.Computer.FileSystem.GetFiles(modsFolder)

            If (counter.Count > 1) Then
                Return True
            Else
                Return False
            End If

        End If

    End Function

    Shared Function deleteOldFiles()

        Dim modsPath As String = GetFolderPath(SpecialFolder.ApplicationData) + "\.minecraft\mods\"

        If My.Computer.FileSystem.DirectoryExists(modsPath) Then
            For Each LogFile In Directory.GetFiles(modsPath)
                If (LogFile.ToString.Contains("decimation") Or (LogFile.ToString.Contains("Decimation"))) Then
                    My.Computer.FileSystem.DeleteFile(LogFile)
                End If
            Next
        Else
            System.IO.Directory.CreateDirectory(modsPath)
        End If

        Return False

    End Function

End Class

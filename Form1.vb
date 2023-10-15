Public Class Form1
    Public Structure recHighScore
        Public name As String
        Public score As Integer
    End Structure
    Dim arrHighScores(6) As recHighScore
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readHighScores()
        printHighScores()
        arrHighScores(6).name = "Jack"
        arrHighScores(6).score = 9
        BubbleSort()
        printHighScores()
    End Sub

    Private Sub BubbleSort()
        Dim Last As Integer
        Last = 6
        Dim Swapped As Boolean
        Swapped = True
        Dim i As Integer
        i = 1
        While Swapped = True
            Swapped = False
            i = 1
            While i < Last
                If arrHighScores(i).score < arrHighScores(i + 1).score Then
                    Swap(arrHighScores(i), arrHighScores(i + 1))
                    Swapped = True
                End If
                i = i + 1
            End While
            Last = Last - 1
        End While
    End Sub
    Private Sub printHighScores()
        For u = 1 To 5
            ListBox1.Items.Add(u & " " & arrHighScores(u).name & " " & arrHighScores(u).score)
        Next u
    End Sub
    Private Sub readHighScores()
        FileSystem.FileOpen(1, "hs.txt", OpenMode.Input)
        For i = 1 To 5
            FileSystem.Input(1, arrHighScores(i).name)
        Next i
        For i = 1 To 5
            FileSystem.Input(1, arrHighScores(i).score)
        Next i
        FileSystem.FileClose(1)
    End Sub
    Private Sub Swap(ByRef A As recHighScore, ByRef B As recHighScore)
        Dim Temp As recHighScore
        Temp = A
        A = B
        B = Temp
    End Sub
End Class

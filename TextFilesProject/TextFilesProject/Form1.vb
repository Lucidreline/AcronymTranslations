Public Class Acronyms
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListBoxes()
    End Sub


    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        LoadListBoxes()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim DICTIONARY_FILE As String = GetFilePath()
        Dim checkAcro As String = txtNewLine.Text.Trim
        Dim checkDef As String = txtDefinition.Text.Trim

        If (checkAcro = "" Or checkDef = "") Then
            MessageBox.Show("Acronym was not added because a text box was left blank")
        Else
            Dim formatNewEntry As String = vbNewLine & txtNewLine.Text.ToUpper & " = " & txtDefinition.Text
            Dim objWriter As New System.IO.StreamWriter(DICTIONARY_FILE, True)

            objWriter.Write(formatNewEntry)
            objWriter.Close()

            LoadListBoxes()

            txtDefinition.Clear()
            txtNewLine.Clear()
        End If
    End Sub


    Private Sub lstTranslation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTranslation.SelectedIndexChanged
        Dim selIndex As Integer
        selIndex = lstTranslation.SelectedIndex
        TextBox1.Text = lstText.Items.Item(selIndex)

    End Sub


    Private Sub lstText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstText.SelectedIndexChanged
        Dim selIndex As Integer
        selIndex = lstText.SelectedIndex
        TextBox1.Text = lstTranslation.Items.Item(selIndex)
    End Sub



    Private Shared Function GetFilePath() As String
        Return "C:\Users\ma52c\Google Drive\Coding\VisualBasic\TextFilesProject\prep\Dictionary.txt"
    End Function


    Private Sub LoadListBoxes()
        Dim DICTIONARY_FILE As String = GetFilePath()

        If System.IO.File.Exists(DICTIONARY_FILE) = True Then
            Dim text As String
            Dim AryLine() As String
            Dim objReader As New System.IO.StreamReader(DICTIONARY_FILE)
            Dim term As String
            Dim def As String

            lstTranslation.Items.Clear()
            lstText.Items.Clear()

            Do While objReader.Peek() <> -1
                text = objReader.ReadLine()
                AryLine = text.Split("=")
                term = AryLine(0)
                def = AryLine(1)

                term = term.Trim
                def = def.Trim

                lstTranslation.Items.Add(term)
                lstText.Items.Add(def)
            Loop
            objReader.Close()
        Else
            MessageBox.Show("Can't Load Data because Dictionary file could not be located.")
        End If
    End Sub
End Class

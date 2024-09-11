
Imports System.Drawing.Printing


Public Class Form1

    'Storing file
    Dim fileName As String = ""

    'Check if file is savede or not
    Dim dirty As Boolean


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()

    End Sub

    Private Sub leftAlignButton_Click(sender As Object, e As EventArgs) Handles leftAlignButton.Click
        textBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub centreAlignButton_Click(sender As Object, e As EventArgs) Handles centreAlignButton.Click
        textBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub


    Private Sub rightAlignButton_Click(sender As Object, e As EventArgs) Handles rightAlignButton.Click
        textBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        textBox.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        textBox.Copy()

    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        textBox.Redo()

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        textBox.Undo()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        textBox.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        textBox.SelectAll()

    End Sub

    Private Sub boldButton_Click(sender As Object, e As EventArgs) Handles boldButton.Click
        ChangeStyle(FontStyle.Bold)

    End Sub

    Sub ChangeStyle(StyleToChange As FontStyle)
        'Holding current fontstyle in something

        Dim currentStyle As FontStyle = textBox.SelectionFont.Style

        'checking what to change
        If StyleToChange = FontStyle.Bold Then
            'checking if selection is on or off
            If textBox.SelectionFont.Bold = False Then
                'add the stylees together
                currentStyle = currentStyle + FontStyle.Bold

            Else
                'taking bold off
                currentStyle = currentStyle - FontStyle.Bold

            End If

        ElseIf StyleToChange = FontStyle.Italic Then

            'checking if selection is on or off
            If textBox.SelectionFont.Italic = False Then
                'add the stylees together
                currentStyle = currentStyle + FontStyle.Italic

            Else
                'taking bold off
                currentStyle = currentStyle - FontStyle.Italic

            End If

        ElseIf StyleToChange = FontStyle.Underline Then
            'add the stylees together

            If textBox.SelectionFont.Underline = False Then
                'add the stylees together
                currentStyle = currentStyle + FontStyle.Underline

            Else
                'taking bold off
                currentStyle = currentStyle - FontStyle.Underline

            End If

        End If

        'Replacing current fone with new style
        textBox.SelectionFont = New Font(textBox.SelectionFont, currentStyle)

    End Sub

    Private Sub ItalicButton_Click(sender As Object, e As EventArgs) Handles ItalicButton.Click
        ChangeStyle(FontStyle.Italic)

    End Sub

    Private Sub underlineButton_Click(sender As Object, e As EventArgs) Handles underlineButton.Click
        ChangeStyle(FontStyle.Underline)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Making default doc as New and nothing is placed inside
        dirty = False
        textBox.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - MenuStrip1.Height - ToolStrip1.Height - 6)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        textBox.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - MenuStrip1.Height - ToolStrip1.Height - 6)
    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As EventArgs) Handles textBox.TextChanged, textBox.SizeChanged, textBox.StyleChanged
        'Making the doc as new and unsaved
        dirty = True

        'Wordcount
        Dim text As String = textBox.Text

        ' Splitting text into words by spaces
        Dim words As String() = text.Split({" ", vbNewLine}, StringSplitOptions.RemoveEmptyEntries)

        Dim wordCOunt As Integer = words.Length

        'putting into label

        wordCountLabel.Text = wordCOunt.ToString()

    End Sub

    Private Sub fontSizeBox_TextChanged(sender As Object, e As EventArgs) Handles fontSizeBox.TextChanged
        'chaning number in combo box to number called single
        Dim newSize As Single = Convert.ToSingle(fontSizeBox.Text)

        'apply to selected font
        textBox.SelectionFont = New Font(textBox.SelectionFont.FontFamily, newSize)

    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        'Setting the the type of file, called filter
        OpenFile.Filter = "Image Files|*.png;*.bmp;*.jpg;*.bmp"

        'Checking if user chooses a file
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'We need an image variable to hold the image
            Dim img As Image = Image.FromFile(OpenFile.FileName)

            'Then we put it into the clipboard first before pasting into the text editor
            Clipboard.SetImage(img)
            textBox.Paste()

        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'save the file now
            textBox.SaveFile(SaveFile.FileName)
            dirty = False

            'remember file we using, we declared that on line 5

            fileName = SaveFile.FileName

            'change form title now
            Me.Text = "Ultimate Text - " & IO.Path.GetFileName(fileName)

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'Check if document is already saved

        If fileName = "" Then
            SaveAsToolStripMenuItem_Click(Nothing, Nothing)

        Else
            textBox.SaveFile(fileName)
            dirty = False

        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Check if document is saved or updates
        If dirty = True Then

            If MessageBox.Show("Save Changes", "Comfirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'call on save
                SaveToolStripMenuItem_Click(Nothing, Nothing)
            End If
        End If
        Me.Close()


    End Sub

    Private Sub newMenuItem_Click(sender As Object, e As EventArgs) Handles newMenuItem.Click
        ''Check if document is saved or updates
        If dirty = True Then
            If MessageBox.Show("Save Changes", "Comfirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'call on save
                SaveToolStripMenuItem_Click(Nothing, Nothing)
            End If

        End If

        fileName = ""
        dirty = False
        Me.Text = "Ultimate Text "
        textBox.ResetText()


    End Sub

    Private Sub OpenSToolStrip_Click(sender As Object, e As EventArgs) Handles OpenSToolStrip.Click

        'Check if document is saved or updates
        'If dirty = True Then
        '    If MessageBox.Show("Save Changes", "Comfirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

        '        'call on save
        '        SaveToolStripMenuItem_Click(Nothing, Nothing)
        '    End If

        OpenFile.Filter = "RTf DOCUMENT|*.rtf*"
        'End If
        'opening the file

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            textBox.LoadFile(OpenFile.FileName)
            dirty = False

            fileName = OpenFile.FileName
            'change form title now
            Me.Text = "Ultimate Text - " & IO.Path.GetFileName(fileName)
        End If
    End Sub


    Private Sub WordCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordCountToolStripMenuItem.Click
        MessageBox.Show("Words Typed: " & wordCountLabel.Text)

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Info.Show()


    End Sub

    Private Sub undoButton5_Click(sender As Object, e As EventArgs) Handles undoButton5.Click
        textBox.Undo()

    End Sub

    Private Sub redoButton1_Click(sender As Object, e As EventArgs) Handles redoButton1.Click
        textBox.Redo()

    End Sub

    Private Sub openButton2_Click(sender As Object, e As EventArgs) Handles openButton2.Click
        OpenFile.Filter = "RTf DOCUMENT|*.rtf*"
        'End If
        'opening the file

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            textBox.LoadFile(OpenFile.FileName)
            dirty = False

            fileName = OpenFile.FileName
            'change form title now
            Me.Text = "Ultimate Text - " & IO.Path.GetFileName(fileName)
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'Check if document is already saved

        If fileName = "" Then
            SaveToolStripMenuItem_Click(Nothing, Nothing)

        Else
            textBox.SaveFile(fileName)
            dirty = False

        End If
    End Sub

    Private Sub saveasButton4_Click(sender As Object, e As EventArgs) Handles saveasButton4.Click

        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'save the file now
            textBox.SaveFile(SaveFile.FileName)
            dirty = False

            'remember file we using, we declared that on line 5

            fileName = SaveFile.FileName

            'change form title now
            Me.Text = "Ultimate Text - " & IO.Path.GetFileName(fileName)

        End If

    End Sub

    Private Sub newButton1_Click(sender As Object, e As EventArgs) Handles newButton1.Click
        'Check if document is saved or updates
        If dirty = True Then
            If MessageBox.Show("Save Changes", "Comfirm?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                'call on save
                SaveAsToolStripMenuItem_Click(Nothing, Nothing)
            End If

        End If
    End Sub

    Private Sub Fontbutton_Click(sender As Object, e As EventArgs) Handles Fontbutton.Click
        FontDialog.Font = textBox.Font
        FontDialog.ShowDialog()
        textBox.Font = FontDialog.Font

    End Sub


    Private Sub copyContext_Click(sender As Object, e As EventArgs) Handles copyContext.Click
        textBox.Copy()
    End Sub

    Private Sub cutContext_Click(sender As Object, e As EventArgs) Handles cutContext.Click
        textBox.Cut()

    End Sub

    Private Sub pasteContext_Click(sender As Object, e As EventArgs) Handles pasteContext.Click
        textBox.Paste()

    End Sub

    Private Sub selectAllContext_Click(sender As Object, e As EventArgs) Handles selectAllContext.Click
        textBox.SelectAll()

    End Sub

    Private Sub zoomIn_Click(sender As Object, e As EventArgs) Handles zoomIn.Click
        textBox.ZoomFactor = 2.0F

    End Sub

    'Private Sub zoomOUt_Click(sender As Object, e As EventArgs) Handles zoomOUt.Click
    '    textBox.ZoomFactor= = 1.0F

    'End Sub

    'Private Sub fontColor_Click(sender As Object, e As EventArgs) Handles fontColor.Click
    '    If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

    '    End If

End Class

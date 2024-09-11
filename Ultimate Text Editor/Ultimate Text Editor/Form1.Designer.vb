<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textBox = New System.Windows.Forms.RichTextBox()
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.copyContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.cutContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectAllContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.newMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fontbutton = New System.Windows.Forms.ToolStripMenuItem()
        Me.fontColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.zoomOUt = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newButton1 = New System.Windows.Forms.ToolStripButton()
        Me.openButton2 = New System.Windows.Forms.ToolStripButton()
        Me.saveButton = New System.Windows.Forms.ToolStripButton()
        Me.saveasButton4 = New System.Windows.Forms.ToolStripButton()
        Me.undoButton5 = New System.Windows.Forms.ToolStripButton()
        Me.redoButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fontSizeBox = New System.Windows.Forms.ToolStripComboBox()
        Me.boldButton = New System.Windows.Forms.ToolStripButton()
        Me.underlineButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicButton = New System.Windows.Forms.ToolStripButton()
        Me.leftAlignButton = New System.Windows.Forms.ToolStripButton()
        Me.centreAlignButton = New System.Windows.Forms.ToolStripButton()
        Me.rightAlignButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.wordCountLabel = New System.Windows.Forms.Label()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ContextMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBox
        '
        Me.textBox.ContextMenuStrip = Me.ContextMenu
        Me.textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox.Location = New System.Drawing.Point(12, 76)
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(917, 534)
        Me.textBox.TabIndex = 1
        Me.textBox.Text = ""
        '
        'ContextMenu
        '
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyContext, Me.cutContext, Me.pasteContext, Me.selectAllContext})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(141, 100)
        '
        'copyContext
        '
        Me.copyContext.Name = "copyContext"
        Me.copyContext.Size = New System.Drawing.Size(140, 24)
        Me.copyContext.Text = "Copy"
        '
        'cutContext
        '
        Me.cutContext.Name = "cutContext"
        Me.cutContext.Size = New System.Drawing.Size(140, 24)
        Me.cutContext.Text = "Cut"
        '
        'pasteContext
        '
        Me.pasteContext.Name = "pasteContext"
        Me.pasteContext.Size = New System.Drawing.Size(140, 24)
        Me.pasteContext.Text = "Paste"
        '
        'selectAllContext
        '
        Me.selectAllContext.Name = "selectAllContext"
        Me.selectAllContext.Size = New System.Drawing.Size(140, 24)
        Me.selectAllContext.Text = "Select All"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenu, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.InsertToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(951, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenu
        '
        Me.FileToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newMenuItem, Me.OpenSToolStrip, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.Print, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenu.Name = "FileToolStripMenu"
        Me.FileToolStripMenu.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenu.Text = "File"
        '
        'newMenuItem
        '
        Me.newMenuItem.Name = "newMenuItem"
        Me.newMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.newMenuItem.Text = "New"
        '
        'OpenSToolStrip
        '
        Me.OpenSToolStrip.Name = "OpenSToolStrip"
        Me.OpenSToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenSToolStrip.Size = New System.Drawing.Size(167, 24)
        Me.OpenSToolStrip.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'Print
        '
        Me.Print.Name = "Print"
        Me.Print.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Print.Size = New System.Drawing.Size(167, 24)
        Me.Print.Text = "Print"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fontbutton, Me.fontColor, Me.WordCountToolStripMenuItem, Me.zoomIn, Me.zoomOUt})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'Fontbutton
        '
        Me.Fontbutton.Name = "Fontbutton"
        Me.Fontbutton.Size = New System.Drawing.Size(153, 24)
        Me.Fontbutton.Text = "Font "
        '
        'fontColor
        '
        Me.fontColor.Name = "fontColor"
        Me.fontColor.Size = New System.Drawing.Size(153, 24)
        Me.fontColor.Text = "Font Color"
        '
        'WordCountToolStripMenuItem
        '
        Me.WordCountToolStripMenuItem.Name = "WordCountToolStripMenuItem"
        Me.WordCountToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.WordCountToolStripMenuItem.Text = "WordCount"
        '
        'zoomIn
        '
        Me.zoomIn.Name = "zoomIn"
        Me.zoomIn.Size = New System.Drawing.Size(153, 24)
        Me.zoomIn.Text = "Zoom in"
        '
        'zoomOUt
        '
        Me.zoomOUt.Name = "zoomOUt"
        Me.zoomOUt.Size = New System.Drawing.Size(153, 24)
        Me.zoomOUt.Text = "Zoom out"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newButton1, Me.openButton2, Me.saveButton, Me.saveasButton4, Me.undoButton5, Me.redoButton1, Me.ToolStripSeparator1, Me.fontSizeBox, Me.boldButton, Me.underlineButton, Me.ItalicButton, Me.leftAlignButton, Me.centreAlignButton, Me.rightAlignButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(951, 32)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newButton1
        '
        Me.newButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newButton1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newButton1.Image = CType(resources.GetObject("newButton1.Image"), System.Drawing.Image)
        Me.newButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newButton1.Name = "newButton1"
        Me.newButton1.Size = New System.Drawing.Size(23, 29)
        Me.newButton1.Text = "newButton"
        '
        'openButton2
        '
        Me.openButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openButton2.Image = CType(resources.GetObject("openButton2.Image"), System.Drawing.Image)
        Me.openButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openButton2.Name = "openButton2"
        Me.openButton2.Size = New System.Drawing.Size(23, 29)
        Me.openButton2.Text = "Open"
        '
        'saveButton
        '
        Me.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(23, 29)
        Me.saveButton.Text = "Save"
        '
        'saveasButton4
        '
        Me.saveasButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveasButton4.Image = CType(resources.GetObject("saveasButton4.Image"), System.Drawing.Image)
        Me.saveasButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveasButton4.Name = "saveasButton4"
        Me.saveasButton4.Size = New System.Drawing.Size(23, 29)
        Me.saveasButton4.Text = "Saveas"
        '
        'undoButton5
        '
        Me.undoButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.undoButton5.Image = CType(resources.GetObject("undoButton5.Image"), System.Drawing.Image)
        Me.undoButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.undoButton5.Name = "undoButton5"
        Me.undoButton5.Size = New System.Drawing.Size(23, 29)
        Me.undoButton5.Text = "Undo"
        '
        'redoButton1
        '
        Me.redoButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.redoButton1.Image = CType(resources.GetObject("redoButton1.Image"), System.Drawing.Image)
        Me.redoButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.redoButton1.Name = "redoButton1"
        Me.redoButton1.Size = New System.Drawing.Size(23, 29)
        Me.redoButton1.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'fontSizeBox
        '
        Me.fontSizeBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontSizeBox.Items.AddRange(New Object() {"8", "12", "14", "16", "18", "20", "22", "26", "28", "30", "32", "34", "36", "38", "40"})
        Me.fontSizeBox.Name = "fontSizeBox"
        Me.fontSizeBox.Size = New System.Drawing.Size(121, 32)
        Me.fontSizeBox.Text = "10"
        '
        'boldButton
        '
        Me.boldButton.CheckOnClick = True
        Me.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.boldButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boldButton.Image = CType(resources.GetObject("boldButton.Image"), System.Drawing.Image)
        Me.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.boldButton.Name = "boldButton"
        Me.boldButton.Size = New System.Drawing.Size(28, 29)
        Me.boldButton.Text = "B"
        '
        'underlineButton
        '
        Me.underlineButton.CheckOnClick = True
        Me.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.underlineButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.underlineButton.Image = CType(resources.GetObject("underlineButton.Image"), System.Drawing.Image)
        Me.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.underlineButton.Name = "underlineButton"
        Me.underlineButton.Size = New System.Drawing.Size(30, 29)
        Me.underlineButton.Text = "U"
        '
        'ItalicButton
        '
        Me.ItalicButton.CheckOnClick = True
        Me.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ItalicButton.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItalicButton.Image = CType(resources.GetObject("ItalicButton.Image"), System.Drawing.Image)
        Me.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicButton.Name = "ItalicButton"
        Me.ItalicButton.Size = New System.Drawing.Size(23, 29)
        Me.ItalicButton.Text = "I"
        '
        'leftAlignButton
        '
        Me.leftAlignButton.CheckOnClick = True
        Me.leftAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.leftAlignButton.Image = CType(resources.GetObject("leftAlignButton.Image"), System.Drawing.Image)
        Me.leftAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.leftAlignButton.Name = "leftAlignButton"
        Me.leftAlignButton.Size = New System.Drawing.Size(23, 29)
        Me.leftAlignButton.Text = "Left Align"
        '
        'centreAlignButton
        '
        Me.centreAlignButton.CheckOnClick = True
        Me.centreAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.centreAlignButton.Image = CType(resources.GetObject("centreAlignButton.Image"), System.Drawing.Image)
        Me.centreAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.centreAlignButton.Name = "centreAlignButton"
        Me.centreAlignButton.Size = New System.Drawing.Size(23, 29)
        Me.centreAlignButton.Text = "Centre Align"
        '
        'rightAlignButton
        '
        Me.rightAlignButton.CheckOnClick = True
        Me.rightAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.rightAlignButton.Image = CType(resources.GetObject("rightAlignButton.Image"), System.Drawing.Image)
        Me.rightAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.rightAlignButton.Name = "rightAlignButton"
        Me.rightAlignButton.Size = New System.Drawing.Size(23, 29)
        Me.rightAlignButton.Text = "Right Align"
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "RTF Document |*.rtf"
        Me.SaveFile.Title = "Save As"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        Me.OpenFile.Title = "Open File"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 608)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(951, 25)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 20)
        Me.ToolStripStatusLabel1.Text = "WordCount: "
        '
        'wordCountLabel
        '
        Me.wordCountLabel.AutoSize = True
        Me.wordCountLabel.Location = New System.Drawing.Point(89, 612)
        Me.wordCountLabel.Name = "wordCountLabel"
        Me.wordCountLabel.Size = New System.Drawing.Size(16, 17)
        Me.wordCountLabel.TabIndex = 4
        Me.wordCountLabel.Text = "0"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 633)
        Me.Controls.Add(Me.wordCountLabel)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.textBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Ultimate Text"
        Me.ContextMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenSToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Fontbutton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents openButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveasButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents undoButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents redoButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents fontSizeBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents boldButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents underlineButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItalicButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents leftAlignButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents centreAlignButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents rightAlignButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents newMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents wordCountLabel As System.Windows.Forms.Label
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents copyContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cutContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pasteContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents selectAllContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents zoomIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents zoomOUt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fontColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog

End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateEntryForm
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
        Me.lstForms = New System.Windows.Forms.ListBox()
        Me.lblForms = New System.Windows.Forms.Label()
        Me.cboElements = New System.Windows.Forms.ComboBox()
        Me.lblElements = New System.Windows.Forms.Label()
        Me.lstSelected = New System.Windows.Forms.Label()
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.lstvElements = New System.Windows.Forms.ListView()
        Me.butClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstForms
        '
        Me.lstForms.FormattingEnabled = True
        Me.lstForms.Location = New System.Drawing.Point(93, 31)
        Me.lstForms.Name = "lstForms"
        Me.lstForms.Size = New System.Drawing.Size(427, 30)
        Me.lstForms.TabIndex = 0
        '
        'lblForms
        '
        Me.lblForms.AutoSize = True
        Me.lblForms.Location = New System.Drawing.Point(90, 15)
        Me.lblForms.Name = "lblForms"
        Me.lblForms.Size = New System.Drawing.Size(140, 13)
        Me.lblForms.TabIndex = 1
        Me.lblForms.Text = "Select form to create/modify"
        '
        'cboElements
        '
        Me.cboElements.FormattingEnabled = True
        Me.cboElements.Location = New System.Drawing.Point(93, 83)
        Me.cboElements.Name = "cboElements"
        Me.cboElements.Size = New System.Drawing.Size(423, 21)
        Me.cboElements.TabIndex = 2
        '
        'lblElements
        '
        Me.lblElements.AutoSize = True
        Me.lblElements.Location = New System.Drawing.Point(90, 68)
        Me.lblElements.Name = "lblElements"
        Me.lblElements.Size = New System.Drawing.Size(212, 13)
        Me.lblElements.TabIndex = 4
        Me.lblElements.Text = "Select element name or enter element code"
        '
        'lstSelected
        '
        Me.lstSelected.AutoSize = True
        Me.lstSelected.Location = New System.Drawing.Point(90, 112)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(180, 13)
        Me.lstSelected.TabIndex = 5
        Me.lstSelected.Text = "List of selected elements - Modifiable"
        '
        'cmdFinish
        '
        Me.cmdFinish.Location = New System.Drawing.Point(123, 420)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(45, 24)
        Me.cmdFinish.TabIndex = 6
        Me.cmdFinish.Text = "Save"
        Me.cmdFinish.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(329, 420)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(45, 24)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(432, 420)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(45, 24)
        Me.cmdHelp.TabIndex = 8
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'lstvElements
        '
        Me.lstvElements.AllowColumnReorder = True
        Me.lstvElements.AllowDrop = True
        Me.lstvElements.FullRowSelect = True
        Me.lstvElements.GridLines = True
        Me.lstvElements.HideSelection = False
        Me.lstvElements.HoverSelection = True
        Me.lstvElements.LabelEdit = True
        Me.lstvElements.Location = New System.Drawing.Point(93, 125)
        Me.lstvElements.Name = "lstvElements"
        Me.lstvElements.RightToLeftLayout = True
        Me.lstvElements.Size = New System.Drawing.Size(423, 289)
        Me.lstvElements.TabIndex = 19
        Me.lstvElements.UseCompatibleStateImageBehavior = False
        Me.lstvElements.View = System.Windows.Forms.View.Details
        '
        'butClear
        '
        Me.butClear.Location = New System.Drawing.Point(226, 420)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(45, 24)
        Me.butClear.TabIndex = 20
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = True
        '
        'frmCreateEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 450)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.lstvElements)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.lblElements)
        Me.Controls.Add(Me.cboElements)
        Me.Controls.Add(Me.lblForms)
        Me.Controls.Add(Me.lstForms)
        Me.Name = "frmCreateEntryForm"
        Me.Text = "frmCreateEntryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstForms As ListBox
    Friend WithEvents lblForms As Label
    Friend WithEvents cboElements As ComboBox
    Friend WithEvents lblElements As Label
    Friend WithEvents lstSelected As Label
    Friend WithEvents cmdFinish As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdHelp As Button
    Public WithEvents lstvElements As ListView
    Friend WithEvents butClear As Button
End Class

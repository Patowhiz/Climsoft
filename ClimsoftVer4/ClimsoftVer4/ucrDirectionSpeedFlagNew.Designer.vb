<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrDirectionSpeedFlagNew
    Inherits ClimsoftVer4.ucrValue

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrSpeed = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrFlag = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrDirection = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrDDFF = New ClimsoftVer4.ucrTextBoxNew()
        Me.SuspendLayout()
        '
        'ucrSpeed
        '
        Me.ucrSpeed.FieldName = Nothing
        Me.ucrSpeed.Location = New System.Drawing.Point(117, 0)
        Me.ucrSpeed.Name = "ucrSpeed"
        Me.ucrSpeed.Size = New System.Drawing.Size(55, 24)
        Me.ucrSpeed.TabIndex = 0
        Me.ucrSpeed.TextboxValue = ""
        '
        'ucrFlag
        '
        Me.ucrFlag.FieldName = Nothing
        Me.ucrFlag.Location = New System.Drawing.Point(174, 0)
        Me.ucrFlag.Name = "ucrFlag"
        Me.ucrFlag.Size = New System.Drawing.Size(55, 24)
        Me.ucrFlag.TabIndex = 4
        Me.ucrFlag.TextboxValue = ""
        '
        'ucrDirection
        '
        Me.ucrDirection.FieldName = Nothing
        Me.ucrDirection.Location = New System.Drawing.Point(61, 0)
        Me.ucrDirection.Name = "ucrDirection"
        Me.ucrDirection.Size = New System.Drawing.Size(55, 24)
        Me.ucrDirection.TabIndex = 5
        Me.ucrDirection.TextboxValue = ""
        '
        'ucrDDFF
        '
        Me.ucrDDFF.FieldName = Nothing
        Me.ucrDDFF.Location = New System.Drawing.Point(4, 0)
        Me.ucrDDFF.Name = "ucrDDFF"
        Me.ucrDDFF.Size = New System.Drawing.Size(55, 24)
        Me.ucrDDFF.TabIndex = 6
        Me.ucrDDFF.TextboxValue = ""
        '
        'ucrDirectionSpeedFlagNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDDFF)
        Me.Controls.Add(Me.ucrDirection)
        Me.Controls.Add(Me.ucrFlag)
        Me.Controls.Add(Me.ucrSpeed)
        Me.Name = "ucrDirectionSpeedFlagNew"
        Me.Size = New System.Drawing.Size(236, 26)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSpeed As ucrTextBoxNew
    Friend WithEvents ucrFlag As ucrTextBoxNew
    Friend WithEvents ucrDirection As ucrTextBoxNew
    Friend WithEvents ucrDDFF As ucrTextBoxNew
End Class

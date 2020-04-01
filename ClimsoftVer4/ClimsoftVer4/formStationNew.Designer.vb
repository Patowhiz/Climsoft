<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStationNew
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
        Me.UcrStationInformation1 = New ClimsoftVer4.ucrStationInformation()
        Me.SuspendLayout()
        '
        'UcrStationInformation1
        '
        Me.UcrStationInformation1.Location = New System.Drawing.Point(18, 6)
        Me.UcrStationInformation1.Name = "UcrStationInformation1"
        Me.UcrStationInformation1.Size = New System.Drawing.Size(740, 399)
        Me.UcrStationInformation1.TabIndex = 0
        '
        'formStationNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.UcrStationInformation1)
        Me.Name = "formStationNew"
        Me.Text = "formStationNew"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrStationInformation1 As ucrStationInformation
End Class

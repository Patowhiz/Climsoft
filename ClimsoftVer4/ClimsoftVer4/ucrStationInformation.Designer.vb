<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrStationInformation
    Inherits ClimsoftVer4.ucrPage


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
        Dim StationOperationalLabel As System.Windows.Forms.Label
        Dim CptSelectionLabel As System.Windows.Forms.Label
        Dim DrainageBasinLabel As System.Windows.Forms.Label
        Dim AdminRegionLabel As System.Windows.Forms.Label
        Dim AuthorityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ClosingDatetimeLabel As System.Windows.Forms.Label
        Dim OpeningDatetimeLabel As System.Windows.Forms.Label
        Dim GeoLocationAccuracyLabel As System.Windows.Forms.Label
        Dim GeoLocationMethodLabel As System.Windows.Forms.Label
        Dim ElevationLabel As System.Windows.Forms.Label
        Dim LongitudeLabel As System.Windows.Forms.Label
        Dim LatitudeLabel As System.Windows.Forms.Label
        Dim StationNameLabel As System.Windows.Forms.Label
        Dim StationIdLabel As System.Windows.Forms.Label
        Me.ucrStationIdDSelector = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrStationNameSelector = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrTxtCountry = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtLongitude = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtStationOperational = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtLatitude = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrtxtElevation = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtAdminRegion = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrGeoLocationMethod = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrAuthority = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrDrainageBasin = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtGeoLocationAccuracy = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtCPTSelection = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrDtpOpeningDatetime = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrDtpCLosingDatetime = New ClimsoftVer4.ucrDatePickerNew()
        Me.UcrNavigator1 = New ClimsoftVer4.ucrNavigator()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClose = New ClimsoftVer4.ucrButton()
        Me.UcrBtnHelp = New ClimsoftVer4.ucrButton()
        StationOperationalLabel = New System.Windows.Forms.Label()
        CptSelectionLabel = New System.Windows.Forms.Label()
        DrainageBasinLabel = New System.Windows.Forms.Label()
        AdminRegionLabel = New System.Windows.Forms.Label()
        AuthorityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ClosingDatetimeLabel = New System.Windows.Forms.Label()
        OpeningDatetimeLabel = New System.Windows.Forms.Label()
        GeoLocationAccuracyLabel = New System.Windows.Forms.Label()
        GeoLocationMethodLabel = New System.Windows.Forms.Label()
        ElevationLabel = New System.Windows.Forms.Label()
        LongitudeLabel = New System.Windows.Forms.Label()
        LatitudeLabel = New System.Windows.Forms.Label()
        StationNameLabel = New System.Windows.Forms.Label()
        StationIdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StationOperationalLabel
        '
        StationOperationalLabel.AutoSize = True
        StationOperationalLabel.Location = New System.Drawing.Point(37, 173)
        StationOperationalLabel.Name = "StationOperationalLabel"
        StationOperationalLabel.Size = New System.Drawing.Size(100, 13)
        StationOperationalLabel.TabIndex = 46
        StationOperationalLabel.Text = "Station Operational:"
        '
        'CptSelectionLabel
        '
        CptSelectionLabel.AutoSize = True
        CptSelectionLabel.Location = New System.Drawing.Point(63, 213)
        CptSelectionLabel.Name = "CptSelectionLabel"
        CptSelectionLabel.Size = New System.Drawing.Size(78, 13)
        CptSelectionLabel.TabIndex = 45
        CptSelectionLabel.Text = "CPT Selection:"
        '
        'DrainageBasinLabel
        '
        DrainageBasinLabel.AutoSize = True
        DrainageBasinLabel.Location = New System.Drawing.Point(500, 124)
        DrainageBasinLabel.Name = "DrainageBasinLabel"
        DrainageBasinLabel.Size = New System.Drawing.Size(82, 13)
        DrainageBasinLabel.TabIndex = 44
        DrainageBasinLabel.Text = "Drainage Basin:"
        '
        'AdminRegionLabel
        '
        AdminRegionLabel.AutoSize = True
        AdminRegionLabel.Location = New System.Drawing.Point(287, 127)
        AdminRegionLabel.Name = "AdminRegionLabel"
        AdminRegionLabel.Size = New System.Drawing.Size(76, 13)
        AdminRegionLabel.TabIndex = 43
        AdminRegionLabel.Text = "Admin Region:"
        '
        'AuthorityLabel
        '
        AuthorityLabel.AutoSize = True
        AuthorityLabel.Location = New System.Drawing.Point(85, 124)
        AuthorityLabel.Name = "AuthorityLabel"
        AuthorityLabel.Size = New System.Drawing.Size(51, 13)
        AuthorityLabel.TabIndex = 42
        AuthorityLabel.Text = "Authority:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(565, 43)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 41
        CountryLabel.Text = "Country:"
        '
        'ClosingDatetimeLabel
        '
        ClosingDatetimeLabel.AutoSize = True
        ClosingDatetimeLabel.Location = New System.Drawing.Point(252, 210)
        ClosingDatetimeLabel.Name = "ClosingDatetimeLabel"
        ClosingDatetimeLabel.Size = New System.Drawing.Size(89, 13)
        ClosingDatetimeLabel.TabIndex = 40
        ClosingDatetimeLabel.Text = "Closing Datetime:"
        '
        'OpeningDatetimeLabel
        '
        OpeningDatetimeLabel.AutoSize = True
        OpeningDatetimeLabel.Location = New System.Drawing.Point(252, 170)
        OpeningDatetimeLabel.Name = "OpeningDatetimeLabel"
        OpeningDatetimeLabel.Size = New System.Drawing.Size(95, 13)
        OpeningDatetimeLabel.TabIndex = 39
        OpeningDatetimeLabel.Text = "Opening Datetime:"
        '
        'GeoLocationAccuracyLabel
        '
        GeoLocationAccuracyLabel.AutoSize = True
        GeoLocationAccuracyLabel.Location = New System.Drawing.Point(324, 258)
        GeoLocationAccuracyLabel.Name = "GeoLocationAccuracyLabel"
        GeoLocationAccuracyLabel.Size = New System.Drawing.Size(122, 13)
        GeoLocationAccuracyLabel.TabIndex = 38
        GeoLocationAccuracyLabel.Text = "Geo Location Accuracy:"
        '
        'GeoLocationMethodLabel
        '
        GeoLocationMethodLabel.AutoSize = True
        GeoLocationMethodLabel.Location = New System.Drawing.Point(24, 258)
        GeoLocationMethodLabel.Name = "GeoLocationMethodLabel"
        GeoLocationMethodLabel.Size = New System.Drawing.Size(113, 13)
        GeoLocationMethodLabel.TabIndex = 37
        GeoLocationMethodLabel.Text = "Geo Location Method:"
        '
        'ElevationLabel
        '
        ElevationLabel.AutoSize = True
        ElevationLabel.Location = New System.Drawing.Point(557, 87)
        ElevationLabel.Name = "ElevationLabel"
        ElevationLabel.Size = New System.Drawing.Size(54, 13)
        ElevationLabel.TabIndex = 36
        ElevationLabel.Text = "Elevation:"
        '
        'LongitudeLabel
        '
        LongitudeLabel.AutoSize = True
        LongitudeLabel.Location = New System.Drawing.Point(309, 84)
        LongitudeLabel.Name = "LongitudeLabel"
        LongitudeLabel.Size = New System.Drawing.Size(57, 13)
        LongitudeLabel.TabIndex = 35
        LongitudeLabel.Text = "Longitude:"
        '
        'LatitudeLabel
        '
        LatitudeLabel.AutoSize = True
        LatitudeLabel.Location = New System.Drawing.Point(85, 84)
        LatitudeLabel.Name = "LatitudeLabel"
        LatitudeLabel.Size = New System.Drawing.Size(48, 13)
        LatitudeLabel.TabIndex = 34
        LatitudeLabel.Text = "Latitude:"
        '
        'StationNameLabel
        '
        StationNameLabel.AutoSize = True
        StationNameLabel.Location = New System.Drawing.Point(290, 40)
        StationNameLabel.Name = "StationNameLabel"
        StationNameLabel.Size = New System.Drawing.Size(74, 13)
        StationNameLabel.TabIndex = 33
        StationNameLabel.Text = "Station Name:"
        '
        'StationIdLabel
        '
        StationIdLabel.AutoSize = True
        StationIdLabel.Location = New System.Drawing.Point(76, 37)
        StationIdLabel.Name = "StationIdLabel"
        StationIdLabel.Size = New System.Drawing.Size(55, 13)
        StationIdLabel.TabIndex = 32
        StationIdLabel.Text = "Station Id:"
        '
        'ucrStationIdDSelector
        '
        Me.ucrStationIdDSelector.FieldName = Nothing
        Me.ucrStationIdDSelector.Location = New System.Drawing.Point(141, 34)
        Me.ucrStationIdDSelector.Name = "ucrStationIdDSelector"
        Me.ucrStationIdDSelector.Size = New System.Drawing.Size(100, 22)
        Me.ucrStationIdDSelector.TabIndex = 47
        '
        'ucrStationNameSelector
        '
        Me.ucrStationNameSelector.FieldName = Nothing
        Me.ucrStationNameSelector.Location = New System.Drawing.Point(368, 37)
        Me.ucrStationNameSelector.Name = "ucrStationNameSelector"
        Me.ucrStationNameSelector.Size = New System.Drawing.Size(175, 30)
        Me.ucrStationNameSelector.TabIndex = 48
        '
        'ucrTxtCountry
        '
        Me.ucrTxtCountry.FieldName = Nothing
        Me.ucrTxtCountry.Location = New System.Drawing.Point(616, 40)
        Me.ucrTxtCountry.Name = "ucrTxtCountry"
        Me.ucrTxtCountry.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtCountry.TabIndex = 49
        Me.ucrTxtCountry.TextboxValue = ""
        '
        'ucrTxtLongitude
        '
        Me.ucrTxtLongitude.FieldName = Nothing
        Me.ucrTxtLongitude.Location = New System.Drawing.Point(368, 81)
        Me.ucrTxtLongitude.Name = "ucrTxtLongitude"
        Me.ucrTxtLongitude.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtLongitude.TabIndex = 50
        Me.ucrTxtLongitude.TextboxValue = ""
        '
        'ucrTxtStationOperational
        '
        Me.ucrTxtStationOperational.FieldName = Nothing
        Me.ucrTxtStationOperational.Location = New System.Drawing.Point(141, 170)
        Me.ucrTxtStationOperational.Name = "ucrTxtStationOperational"
        Me.ucrTxtStationOperational.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtStationOperational.TabIndex = 52
        Me.ucrTxtStationOperational.TextboxValue = ""
        '
        'ucrTxtLatitude
        '
        Me.ucrTxtLatitude.FieldName = Nothing
        Me.ucrTxtLatitude.Location = New System.Drawing.Point(141, 81)
        Me.ucrTxtLatitude.Name = "ucrTxtLatitude"
        Me.ucrTxtLatitude.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtLatitude.TabIndex = 53
        Me.ucrTxtLatitude.TextboxValue = ""
        '
        'ucrtxtElevation
        '
        Me.ucrtxtElevation.FieldName = Nothing
        Me.ucrtxtElevation.Location = New System.Drawing.Point(616, 84)
        Me.ucrtxtElevation.Name = "ucrtxtElevation"
        Me.ucrtxtElevation.Size = New System.Drawing.Size(100, 20)
        Me.ucrtxtElevation.TabIndex = 55
        Me.ucrtxtElevation.TextboxValue = ""
        '
        'ucrTxtAdminRegion
        '
        Me.ucrTxtAdminRegion.FieldName = Nothing
        Me.ucrTxtAdminRegion.Location = New System.Drawing.Point(368, 124)
        Me.ucrTxtAdminRegion.Name = "ucrTxtAdminRegion"
        Me.ucrTxtAdminRegion.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtAdminRegion.TabIndex = 56
        Me.ucrTxtAdminRegion.TextboxValue = ""
        '
        'ucrGeoLocationMethod
        '
        Me.ucrGeoLocationMethod.FieldName = Nothing
        Me.ucrGeoLocationMethod.Location = New System.Drawing.Point(141, 255)
        Me.ucrGeoLocationMethod.Name = "ucrGeoLocationMethod"
        Me.ucrGeoLocationMethod.Size = New System.Drawing.Size(100, 20)
        Me.ucrGeoLocationMethod.TabIndex = 57
        Me.ucrGeoLocationMethod.TextboxValue = ""
        '
        'ucrAuthority
        '
        Me.ucrAuthority.FieldName = Nothing
        Me.ucrAuthority.Location = New System.Drawing.Point(141, 121)
        Me.ucrAuthority.Name = "ucrAuthority"
        Me.ucrAuthority.Size = New System.Drawing.Size(100, 20)
        Me.ucrAuthority.TabIndex = 58
        Me.ucrAuthority.TextboxValue = ""
        '
        'ucrDrainageBasin
        '
        Me.ucrDrainageBasin.FieldName = Nothing
        Me.ucrDrainageBasin.Location = New System.Drawing.Point(616, 121)
        Me.ucrDrainageBasin.Name = "ucrDrainageBasin"
        Me.ucrDrainageBasin.Size = New System.Drawing.Size(100, 20)
        Me.ucrDrainageBasin.TabIndex = 59
        Me.ucrDrainageBasin.TextboxValue = ""
        '
        'ucrTxtGeoLocationAccuracy
        '
        Me.ucrTxtGeoLocationAccuracy.FieldName = Nothing
        Me.ucrTxtGeoLocationAccuracy.Location = New System.Drawing.Point(459, 255)
        Me.ucrTxtGeoLocationAccuracy.Name = "ucrTxtGeoLocationAccuracy"
        Me.ucrTxtGeoLocationAccuracy.Size = New System.Drawing.Size(109, 20)
        Me.ucrTxtGeoLocationAccuracy.TabIndex = 60
        Me.ucrTxtGeoLocationAccuracy.TextboxValue = ""
        '
        'ucrTxtCPTSelection
        '
        Me.ucrTxtCPTSelection.FieldName = Nothing
        Me.ucrTxtCPTSelection.Location = New System.Drawing.Point(141, 210)
        Me.ucrTxtCPTSelection.Name = "ucrTxtCPTSelection"
        Me.ucrTxtCPTSelection.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtCPTSelection.TabIndex = 61
        Me.ucrTxtCPTSelection.TextboxValue = ""
        '
        'ucrDtpOpeningDatetime
        '
        Me.ucrDtpOpeningDatetime.FieldName = Nothing
        Me.ucrDtpOpeningDatetime.Location = New System.Drawing.Point(368, 166)
        Me.ucrDtpOpeningDatetime.Name = "ucrDtpOpeningDatetime"
        Me.ucrDtpOpeningDatetime.Size = New System.Drawing.Size(200, 20)
        Me.ucrDtpOpeningDatetime.TabIndex = 62
        '
        'ucrDtpCLosingDatetime
        '
        Me.ucrDtpCLosingDatetime.FieldName = Nothing
        Me.ucrDtpCLosingDatetime.Location = New System.Drawing.Point(368, 206)
        Me.ucrDtpCLosingDatetime.Name = "ucrDtpCLosingDatetime"
        Me.ucrDtpCLosingDatetime.Size = New System.Drawing.Size(200, 20)
        Me.ucrDtpCLosingDatetime.TabIndex = 63
        '
        'UcrNavigator1
        '
        Me.UcrNavigator1.Location = New System.Drawing.Point(231, 327)
        Me.UcrNavigator1.Name = "UcrNavigator1"
        Me.UcrNavigator1.Size = New System.Drawing.Size(340, 30)
        Me.UcrNavigator1.TabIndex = 64
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.AddNew
        Me.ucrBtnAddNew.ButtonText = "AddNew"
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(119, 364)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnAddNew.TabIndex = 65
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Save
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.Location = New System.Drawing.Point(200, 364)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnSave.TabIndex = 66
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Update
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(284, 364)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 67
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Delete
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.Location = New System.Drawing.Point(365, 364)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 68
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.Location = New System.Drawing.Point(446, 364)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 69
        '
        'ucrBtnClose
        '
        Me.ucrBtnClose.ButtonText = "Close"
        Me.ucrBtnClose.Location = New System.Drawing.Point(527, 364)
        Me.ucrBtnClose.Name = "ucrBtnClose"
        Me.ucrBtnClose.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClose.TabIndex = 70
        '
        'UcrBtnHelp
        '
        Me.UcrBtnHelp.ButtonText = "Help"
        Me.UcrBtnHelp.Location = New System.Drawing.Point(608, 364)
        Me.UcrBtnHelp.Name = "UcrBtnHelp"
        Me.UcrBtnHelp.Size = New System.Drawing.Size(75, 23)
        Me.UcrBtnHelp.TabIndex = 71
        '
        'ucrStationInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrBtnHelp)
        Me.Controls.Add(Me.ucrBtnClose)
        Me.Controls.Add(Me.ucrBtnClear)
        Me.Controls.Add(Me.ucrBtnDelete)
        Me.Controls.Add(Me.ucrBtnUpdate)
        Me.Controls.Add(Me.ucrBtnSave)
        Me.Controls.Add(Me.ucrBtnAddNew)
        Me.Controls.Add(Me.UcrNavigator1)
        Me.Controls.Add(Me.ucrDtpCLosingDatetime)
        Me.Controls.Add(Me.ucrDtpOpeningDatetime)
        Me.Controls.Add(Me.ucrTxtCPTSelection)
        Me.Controls.Add(Me.ucrTxtGeoLocationAccuracy)
        Me.Controls.Add(Me.ucrDrainageBasin)
        Me.Controls.Add(Me.ucrAuthority)
        Me.Controls.Add(Me.ucrGeoLocationMethod)
        Me.Controls.Add(Me.ucrTxtAdminRegion)
        Me.Controls.Add(Me.ucrtxtElevation)
        Me.Controls.Add(Me.ucrTxtLatitude)
        Me.Controls.Add(Me.ucrTxtStationOperational)
        Me.Controls.Add(Me.ucrTxtLongitude)
        Me.Controls.Add(Me.ucrTxtCountry)
        Me.Controls.Add(Me.ucrStationNameSelector)
        Me.Controls.Add(Me.ucrStationIdDSelector)
        Me.Controls.Add(StationOperationalLabel)
        Me.Controls.Add(CptSelectionLabel)
        Me.Controls.Add(DrainageBasinLabel)
        Me.Controls.Add(AdminRegionLabel)
        Me.Controls.Add(AuthorityLabel)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(ClosingDatetimeLabel)
        Me.Controls.Add(OpeningDatetimeLabel)
        Me.Controls.Add(GeoLocationAccuracyLabel)
        Me.Controls.Add(GeoLocationMethodLabel)
        Me.Controls.Add(ElevationLabel)
        Me.Controls.Add(LongitudeLabel)
        Me.Controls.Add(LatitudeLabel)
        Me.Controls.Add(StationNameLabel)
        Me.Controls.Add(StationIdLabel)
        Me.Name = "ucrStationInformation"
        Me.Size = New System.Drawing.Size(790, 440)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrStationIdDSelector As ucrStationSelectorNew
    Friend WithEvents ucrStationNameSelector As ucrStationSelectorNew
    Friend WithEvents ucrTxtCountry As ucrTextBoxNew
    Friend WithEvents ucrTxtLongitude As ucrTextBoxNew
    Friend WithEvents ucrTxtStationOperational As ucrTextBoxNew
    Friend WithEvents ucrTxtLatitude As ucrTextBoxNew
    Friend WithEvents ucrtxtElevation As ucrTextBoxNew
    Friend WithEvents ucrTxtAdminRegion As ucrTextBoxNew
    Friend WithEvents ucrGeoLocationMethod As ucrTextBoxNew
    Friend WithEvents ucrAuthority As ucrTextBoxNew
    Friend WithEvents ucrDrainageBasin As ucrTextBoxNew
    Friend WithEvents ucrTxtGeoLocationAccuracy As ucrTextBoxNew
    Friend WithEvents ucrTxtCPTSelection As ucrTextBoxNew
    Friend WithEvents ucrDtpOpeningDatetime As ucrDatePickerNew
    Friend WithEvents ucrDtpCLosingDatetime As ucrDatePickerNew
    Friend WithEvents UcrNavigator1 As ucrNavigator
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnClose As ucrButton
    Friend WithEvents UcrBtnHelp As ucrButton
End Class

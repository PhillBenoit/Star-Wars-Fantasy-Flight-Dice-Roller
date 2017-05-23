<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDice
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
        Me.nudBoost = New System.Windows.Forms.NumericUpDown()
        Me.lblBoost = New System.Windows.Forms.Label()
        Me.lstBoost = New System.Windows.Forms.ListBox()
        Me.cmdRoll = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.gbxPositive = New System.Windows.Forms.GroupBox()
        Me.nudSuccess = New System.Windows.Forms.NumericUpDown()
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.lblAdvantage = New System.Windows.Forms.Label()
        Me.nudAdvantage = New System.Windows.Forms.NumericUpDown()
        Me.lblTriumph = New System.Windows.Forms.Label()
        Me.nudTriumph = New System.Windows.Forms.NumericUpDown()
        Me.gbxNegative = New System.Windows.Forms.GroupBox()
        Me.lblDispair = New System.Windows.Forms.Label()
        Me.nudDispair = New System.Windows.Forms.NumericUpDown()
        Me.lblThreat = New System.Windows.Forms.Label()
        Me.nudThreat = New System.Windows.Forms.NumericUpDown()
        Me.lblFailure = New System.Windows.Forms.Label()
        Me.nudFailure = New System.Windows.Forms.NumericUpDown()
        Me.gbxForce = New System.Windows.Forms.GroupBox()
        Me.lblDark = New System.Windows.Forms.Label()
        Me.nudDark = New System.Windows.Forms.NumericUpDown()
        Me.lblLight = New System.Windows.Forms.Label()
        Me.nudLight = New System.Windows.Forms.NumericUpDown()
        Me.lstSetback = New System.Windows.Forms.ListBox()
        Me.lblSetback = New System.Windows.Forms.Label()
        Me.nudSetback = New System.Windows.Forms.NumericUpDown()
        Me.lstPercent = New System.Windows.Forms.ListBox()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.nudPercent = New System.Windows.Forms.NumericUpDown()
        Me.lstAbility = New System.Windows.Forms.ListBox()
        Me.lblAbility = New System.Windows.Forms.Label()
        Me.nudAbility = New System.Windows.Forms.NumericUpDown()
        Me.lstDifficulty = New System.Windows.Forms.ListBox()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.nudDifficulty = New System.Windows.Forms.NumericUpDown()
        Me.lstProficiency = New System.Windows.Forms.ListBox()
        Me.lblProficiency = New System.Windows.Forms.Label()
        Me.nudProficiency = New System.Windows.Forms.NumericUpDown()
        Me.lstChallenge = New System.Windows.Forms.ListBox()
        Me.lblChallenge = New System.Windows.Forms.Label()
        Me.nudChallenge = New System.Windows.Forms.NumericUpDown()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.lstForce = New System.Windows.Forms.ListBox()
        Me.lblForce = New System.Windows.Forms.Label()
        Me.nudForce = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudBoost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPositive.SuspendLayout()
        CType(Me.nudSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAdvantage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTriumph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxNegative.SuspendLayout()
        CType(Me.nudDispair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudThreat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFailure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxForce.SuspendLayout()
        CType(Me.nudDark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSetback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAbility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDifficulty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProficiency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudChallenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudForce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudBoost
        '
        Me.nudBoost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBoost.Location = New System.Drawing.Point(42, 33)
        Me.nudBoost.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudBoost.Name = "nudBoost"
        Me.nudBoost.Size = New System.Drawing.Size(70, 39)
        Me.nudBoost.TabIndex = 0
        Me.nudBoost.Tag = "6"
        Me.nudBoost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBoost
        '
        Me.lblBoost.AutoSize = True
        Me.lblBoost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoost.Location = New System.Drawing.Point(118, 35)
        Me.lblBoost.Name = "lblBoost"
        Me.lblBoost.Size = New System.Drawing.Size(88, 32)
        Me.lblBoost.TabIndex = 2
        Me.lblBoost.Text = "Boost"
        '
        'lstBoost
        '
        Me.lstBoost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoost.FormattingEnabled = True
        Me.lstBoost.ItemHeight = 32
        Me.lstBoost.Location = New System.Drawing.Point(42, 78)
        Me.lstBoost.Name = "lstBoost"
        Me.lstBoost.Size = New System.Drawing.Size(164, 100)
        Me.lstBoost.TabIndex = 3
        '
        'cmdRoll
        '
        Me.cmdRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRoll.Location = New System.Drawing.Point(475, 572)
        Me.cmdRoll.Name = "cmdRoll"
        Me.cmdRoll.Size = New System.Drawing.Size(126, 53)
        Me.cmdRoll.TabIndex = 4
        Me.cmdRoll.Text = "Roll"
        Me.cmdRoll.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(607, 572)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(126, 53)
        Me.cmdClear.TabIndex = 5
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(871, 572)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(126, 53)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'gbxPositive
        '
        Me.gbxPositive.Controls.Add(Me.lblTriumph)
        Me.gbxPositive.Controls.Add(Me.nudTriumph)
        Me.gbxPositive.Controls.Add(Me.lblAdvantage)
        Me.gbxPositive.Controls.Add(Me.nudAdvantage)
        Me.gbxPositive.Controls.Add(Me.lblSuccess)
        Me.gbxPositive.Controls.Add(Me.nudSuccess)
        Me.gbxPositive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPositive.Location = New System.Drawing.Point(720, 35)
        Me.gbxPositive.Name = "gbxPositive"
        Me.gbxPositive.Size = New System.Drawing.Size(277, 184)
        Me.gbxPositive.TabIndex = 7
        Me.gbxPositive.TabStop = False
        Me.gbxPositive.Text = "Positive Results"
        '
        'nudSuccess
        '
        Me.nudSuccess.Enabled = False
        Me.nudSuccess.Location = New System.Drawing.Point(193, 38)
        Me.nudSuccess.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSuccess.Name = "nudSuccess"
        Me.nudSuccess.ReadOnly = True
        Me.nudSuccess.Size = New System.Drawing.Size(78, 39)
        Me.nudSuccess.TabIndex = 0
        Me.nudSuccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccess.Location = New System.Drawing.Point(13, 40)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(122, 32)
        Me.lblSuccess.TabIndex = 8
        Me.lblSuccess.Text = "Success"
        '
        'lblAdvantage
        '
        Me.lblAdvantage.AutoSize = True
        Me.lblAdvantage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvantage.Location = New System.Drawing.Point(13, 85)
        Me.lblAdvantage.Name = "lblAdvantage"
        Me.lblAdvantage.Size = New System.Drawing.Size(152, 32)
        Me.lblAdvantage.TabIndex = 10
        Me.lblAdvantage.Text = "Advantage"
        '
        'nudAdvantage
        '
        Me.nudAdvantage.Enabled = False
        Me.nudAdvantage.Location = New System.Drawing.Point(193, 83)
        Me.nudAdvantage.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudAdvantage.Name = "nudAdvantage"
        Me.nudAdvantage.ReadOnly = True
        Me.nudAdvantage.Size = New System.Drawing.Size(78, 39)
        Me.nudAdvantage.TabIndex = 9
        Me.nudAdvantage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTriumph
        '
        Me.lblTriumph.AutoSize = True
        Me.lblTriumph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriumph.Location = New System.Drawing.Point(13, 132)
        Me.lblTriumph.Name = "lblTriumph"
        Me.lblTriumph.Size = New System.Drawing.Size(119, 32)
        Me.lblTriumph.TabIndex = 12
        Me.lblTriumph.Text = "Triumph"
        '
        'nudTriumph
        '
        Me.nudTriumph.Enabled = False
        Me.nudTriumph.Location = New System.Drawing.Point(193, 130)
        Me.nudTriumph.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudTriumph.Name = "nudTriumph"
        Me.nudTriumph.ReadOnly = True
        Me.nudTriumph.Size = New System.Drawing.Size(78, 39)
        Me.nudTriumph.TabIndex = 11
        Me.nudTriumph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxNegative
        '
        Me.gbxNegative.Controls.Add(Me.lblDispair)
        Me.gbxNegative.Controls.Add(Me.nudDispair)
        Me.gbxNegative.Controls.Add(Me.lblThreat)
        Me.gbxNegative.Controls.Add(Me.nudThreat)
        Me.gbxNegative.Controls.Add(Me.lblFailure)
        Me.gbxNegative.Controls.Add(Me.nudFailure)
        Me.gbxNegative.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxNegative.Location = New System.Drawing.Point(720, 225)
        Me.gbxNegative.Name = "gbxNegative"
        Me.gbxNegative.Size = New System.Drawing.Size(277, 184)
        Me.gbxNegative.TabIndex = 13
        Me.gbxNegative.TabStop = False
        Me.gbxNegative.Text = "Negative Results"
        '
        'lblDispair
        '
        Me.lblDispair.AutoSize = True
        Me.lblDispair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispair.Location = New System.Drawing.Point(13, 132)
        Me.lblDispair.Name = "lblDispair"
        Me.lblDispair.Size = New System.Drawing.Size(104, 32)
        Me.lblDispair.TabIndex = 12
        Me.lblDispair.Text = "Dispair"
        '
        'nudDispair
        '
        Me.nudDispair.Enabled = False
        Me.nudDispair.Location = New System.Drawing.Point(193, 130)
        Me.nudDispair.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudDispair.Name = "nudDispair"
        Me.nudDispair.ReadOnly = True
        Me.nudDispair.Size = New System.Drawing.Size(78, 39)
        Me.nudDispair.TabIndex = 11
        Me.nudDispair.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThreat
        '
        Me.lblThreat.AutoSize = True
        Me.lblThreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreat.Location = New System.Drawing.Point(13, 85)
        Me.lblThreat.Name = "lblThreat"
        Me.lblThreat.Size = New System.Drawing.Size(97, 32)
        Me.lblThreat.TabIndex = 10
        Me.lblThreat.Text = "Threat"
        '
        'nudThreat
        '
        Me.nudThreat.Enabled = False
        Me.nudThreat.Location = New System.Drawing.Point(193, 83)
        Me.nudThreat.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudThreat.Name = "nudThreat"
        Me.nudThreat.ReadOnly = True
        Me.nudThreat.Size = New System.Drawing.Size(78, 39)
        Me.nudThreat.TabIndex = 9
        Me.nudThreat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFailure
        '
        Me.lblFailure.AutoSize = True
        Me.lblFailure.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailure.Location = New System.Drawing.Point(13, 40)
        Me.lblFailure.Name = "lblFailure"
        Me.lblFailure.Size = New System.Drawing.Size(103, 32)
        Me.lblFailure.TabIndex = 8
        Me.lblFailure.Text = "Failure"
        '
        'nudFailure
        '
        Me.nudFailure.Enabled = False
        Me.nudFailure.Location = New System.Drawing.Point(193, 38)
        Me.nudFailure.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudFailure.Name = "nudFailure"
        Me.nudFailure.ReadOnly = True
        Me.nudFailure.Size = New System.Drawing.Size(78, 39)
        Me.nudFailure.TabIndex = 0
        Me.nudFailure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxForce
        '
        Me.gbxForce.Controls.Add(Me.lblDark)
        Me.gbxForce.Controls.Add(Me.nudDark)
        Me.gbxForce.Controls.Add(Me.lblLight)
        Me.gbxForce.Controls.Add(Me.nudLight)
        Me.gbxForce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxForce.Location = New System.Drawing.Point(720, 415)
        Me.gbxForce.Name = "gbxForce"
        Me.gbxForce.Size = New System.Drawing.Size(277, 151)
        Me.gbxForce.TabIndex = 14
        Me.gbxForce.TabStop = False
        Me.gbxForce.Text = "Force Results"
        '
        'lblDark
        '
        Me.lblDark.AutoSize = True
        Me.lblDark.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDark.Location = New System.Drawing.Point(13, 85)
        Me.lblDark.Name = "lblDark"
        Me.lblDark.Size = New System.Drawing.Size(74, 32)
        Me.lblDark.TabIndex = 10
        Me.lblDark.Text = "Dark"
        '
        'nudDark
        '
        Me.nudDark.Enabled = False
        Me.nudDark.Location = New System.Drawing.Point(193, 83)
        Me.nudDark.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudDark.Name = "nudDark"
        Me.nudDark.ReadOnly = True
        Me.nudDark.Size = New System.Drawing.Size(78, 39)
        Me.nudDark.TabIndex = 9
        Me.nudDark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLight
        '
        Me.lblLight.AutoSize = True
        Me.lblLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLight.Location = New System.Drawing.Point(13, 40)
        Me.lblLight.Name = "lblLight"
        Me.lblLight.Size = New System.Drawing.Size(78, 32)
        Me.lblLight.TabIndex = 8
        Me.lblLight.Text = "Light"
        '
        'nudLight
        '
        Me.nudLight.Enabled = False
        Me.nudLight.Location = New System.Drawing.Point(193, 38)
        Me.nudLight.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudLight.Name = "nudLight"
        Me.nudLight.ReadOnly = True
        Me.nudLight.Size = New System.Drawing.Size(78, 39)
        Me.nudLight.TabIndex = 0
        Me.nudLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstSetback
        '
        Me.lstSetback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSetback.FormattingEnabled = True
        Me.lstSetback.ItemHeight = 32
        Me.lstSetback.Location = New System.Drawing.Point(279, 78)
        Me.lstSetback.Name = "lstSetback"
        Me.lstSetback.Size = New System.Drawing.Size(164, 100)
        Me.lstSetback.TabIndex = 17
        '
        'lblSetback
        '
        Me.lblSetback.AutoSize = True
        Me.lblSetback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetback.Location = New System.Drawing.Point(355, 35)
        Me.lblSetback.Name = "lblSetback"
        Me.lblSetback.Size = New System.Drawing.Size(118, 32)
        Me.lblSetback.TabIndex = 16
        Me.lblSetback.Text = "Setback"
        '
        'nudSetback
        '
        Me.nudSetback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSetback.Location = New System.Drawing.Point(279, 33)
        Me.nudSetback.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudSetback.Name = "nudSetback"
        Me.nudSetback.Size = New System.Drawing.Size(70, 39)
        Me.nudSetback.TabIndex = 15
        Me.nudSetback.Tag = "6"
        Me.nudSetback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstPercent
        '
        Me.lstPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPercent.FormattingEnabled = True
        Me.lstPercent.ItemHeight = 32
        Me.lstPercent.Location = New System.Drawing.Point(507, 78)
        Me.lstPercent.Name = "lstPercent"
        Me.lstPercent.Size = New System.Drawing.Size(164, 100)
        Me.lstPercent.TabIndex = 20
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(583, 35)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(113, 32)
        Me.lblPercent.TabIndex = 19
        Me.lblPercent.Text = "Percent"
        '
        'nudPercent
        '
        Me.nudPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPercent.Location = New System.Drawing.Point(507, 33)
        Me.nudPercent.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPercent.Name = "nudPercent"
        Me.nudPercent.Size = New System.Drawing.Size(70, 39)
        Me.nudPercent.TabIndex = 18
        Me.nudPercent.Tag = "100"
        Me.nudPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstAbility
        '
        Me.lstAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAbility.FormattingEnabled = True
        Me.lstAbility.ItemHeight = 32
        Me.lstAbility.Location = New System.Drawing.Point(42, 261)
        Me.lstAbility.Name = "lstAbility"
        Me.lstAbility.Size = New System.Drawing.Size(164, 100)
        Me.lstAbility.TabIndex = 23
        '
        'lblAbility
        '
        Me.lblAbility.AutoSize = True
        Me.lblAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbility.Location = New System.Drawing.Point(118, 218)
        Me.lblAbility.Name = "lblAbility"
        Me.lblAbility.Size = New System.Drawing.Size(93, 32)
        Me.lblAbility.TabIndex = 22
        Me.lblAbility.Text = "Ability"
        '
        'nudAbility
        '
        Me.nudAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAbility.Location = New System.Drawing.Point(42, 216)
        Me.nudAbility.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudAbility.Name = "nudAbility"
        Me.nudAbility.Size = New System.Drawing.Size(70, 39)
        Me.nudAbility.TabIndex = 21
        Me.nudAbility.Tag = "8"
        Me.nudAbility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstDifficulty
        '
        Me.lstDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDifficulty.FormattingEnabled = True
        Me.lstDifficulty.ItemHeight = 32
        Me.lstDifficulty.Location = New System.Drawing.Point(279, 261)
        Me.lstDifficulty.Name = "lstDifficulty"
        Me.lstDifficulty.Size = New System.Drawing.Size(164, 100)
        Me.lstDifficulty.TabIndex = 26
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(355, 218)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(124, 32)
        Me.lblDifficulty.TabIndex = 25
        Me.lblDifficulty.Text = "Difficulty"
        '
        'nudDifficulty
        '
        Me.nudDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDifficulty.Location = New System.Drawing.Point(279, 216)
        Me.nudDifficulty.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudDifficulty.Name = "nudDifficulty"
        Me.nudDifficulty.Size = New System.Drawing.Size(70, 39)
        Me.nudDifficulty.TabIndex = 24
        Me.nudDifficulty.Tag = "8"
        Me.nudDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstProficiency
        '
        Me.lstProficiency.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProficiency.FormattingEnabled = True
        Me.lstProficiency.ItemHeight = 32
        Me.lstProficiency.Location = New System.Drawing.Point(42, 443)
        Me.lstProficiency.Name = "lstProficiency"
        Me.lstProficiency.Size = New System.Drawing.Size(164, 100)
        Me.lstProficiency.TabIndex = 29
        '
        'lblProficiency
        '
        Me.lblProficiency.AutoSize = True
        Me.lblProficiency.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProficiency.Location = New System.Drawing.Point(118, 400)
        Me.lblProficiency.Name = "lblProficiency"
        Me.lblProficiency.Size = New System.Drawing.Size(155, 32)
        Me.lblProficiency.TabIndex = 28
        Me.lblProficiency.Text = "Proficiency"
        '
        'nudProficiency
        '
        Me.nudProficiency.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudProficiency.Location = New System.Drawing.Point(42, 398)
        Me.nudProficiency.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudProficiency.Name = "nudProficiency"
        Me.nudProficiency.Size = New System.Drawing.Size(70, 39)
        Me.nudProficiency.TabIndex = 27
        Me.nudProficiency.Tag = "12"
        Me.nudProficiency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstChallenge
        '
        Me.lstChallenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstChallenge.FormattingEnabled = True
        Me.lstChallenge.ItemHeight = 32
        Me.lstChallenge.Location = New System.Drawing.Point(279, 443)
        Me.lstChallenge.Name = "lstChallenge"
        Me.lstChallenge.Size = New System.Drawing.Size(164, 100)
        Me.lstChallenge.TabIndex = 32
        '
        'lblChallenge
        '
        Me.lblChallenge.AutoSize = True
        Me.lblChallenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallenge.Location = New System.Drawing.Point(355, 400)
        Me.lblChallenge.Name = "lblChallenge"
        Me.lblChallenge.Size = New System.Drawing.Size(145, 32)
        Me.lblChallenge.TabIndex = 31
        Me.lblChallenge.Text = "Challenge"
        '
        'nudChallenge
        '
        Me.nudChallenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudChallenge.Location = New System.Drawing.Point(279, 398)
        Me.nudChallenge.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudChallenge.Name = "nudChallenge"
        Me.nudChallenge.Size = New System.Drawing.Size(70, 39)
        Me.nudChallenge.TabIndex = 30
        Me.nudChallenge.Tag = "12"
        Me.nudChallenge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(739, 572)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(126, 53)
        Me.cmdReset.TabIndex = 33
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'lstForce
        '
        Me.lstForce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstForce.FormattingEnabled = True
        Me.lstForce.ItemHeight = 32
        Me.lstForce.Location = New System.Drawing.Point(507, 443)
        Me.lstForce.Name = "lstForce"
        Me.lstForce.Size = New System.Drawing.Size(164, 100)
        Me.lstForce.TabIndex = 36
        '
        'lblForce
        '
        Me.lblForce.AutoSize = True
        Me.lblForce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForce.Location = New System.Drawing.Point(583, 400)
        Me.lblForce.Name = "lblForce"
        Me.lblForce.Size = New System.Drawing.Size(87, 32)
        Me.lblForce.TabIndex = 35
        Me.lblForce.Text = "Force"
        '
        'nudForce
        '
        Me.nudForce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudForce.Location = New System.Drawing.Point(507, 398)
        Me.nudForce.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudForce.Name = "nudForce"
        Me.nudForce.Size = New System.Drawing.Size(70, 39)
        Me.nudForce.TabIndex = 34
        Me.nudForce.Tag = "12"
        Me.nudForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 637)
        Me.Controls.Add(Me.lstForce)
        Me.Controls.Add(Me.lblForce)
        Me.Controls.Add(Me.nudForce)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lstChallenge)
        Me.Controls.Add(Me.lblChallenge)
        Me.Controls.Add(Me.nudChallenge)
        Me.Controls.Add(Me.lstProficiency)
        Me.Controls.Add(Me.lblProficiency)
        Me.Controls.Add(Me.nudProficiency)
        Me.Controls.Add(Me.lstDifficulty)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.nudDifficulty)
        Me.Controls.Add(Me.lstAbility)
        Me.Controls.Add(Me.lblAbility)
        Me.Controls.Add(Me.nudAbility)
        Me.Controls.Add(Me.lstPercent)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.nudPercent)
        Me.Controls.Add(Me.lstSetback)
        Me.Controls.Add(Me.lblSetback)
        Me.Controls.Add(Me.nudSetback)
        Me.Controls.Add(Me.gbxForce)
        Me.Controls.Add(Me.gbxNegative)
        Me.Controls.Add(Me.gbxPositive)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdRoll)
        Me.Controls.Add(Me.lstBoost)
        Me.Controls.Add(Me.lblBoost)
        Me.Controls.Add(Me.nudBoost)
        Me.Name = "frmDice"
        Me.Text = "Dice Roller"
        CType(Me.nudBoost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPositive.ResumeLayout(False)
        Me.gbxPositive.PerformLayout()
        CType(Me.nudSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAdvantage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTriumph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxNegative.ResumeLayout(False)
        Me.gbxNegative.PerformLayout()
        CType(Me.nudDispair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudThreat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFailure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxForce.ResumeLayout(False)
        Me.gbxForce.PerformLayout()
        CType(Me.nudDark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSetback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAbility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDifficulty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProficiency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudChallenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudForce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudBoost As NumericUpDown
    Friend WithEvents lblBoost As Label
    Friend WithEvents lstBoost As ListBox
    Friend WithEvents cmdRoll As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents gbxPositive As GroupBox
    Friend WithEvents lblSuccess As Label
    Friend WithEvents nudSuccess As NumericUpDown
    Friend WithEvents lblTriumph As Label
    Friend WithEvents nudTriumph As NumericUpDown
    Friend WithEvents lblAdvantage As Label
    Friend WithEvents nudAdvantage As NumericUpDown
    Friend WithEvents gbxNegative As GroupBox
    Friend WithEvents lblDispair As Label
    Friend WithEvents nudDispair As NumericUpDown
    Friend WithEvents lblThreat As Label
    Friend WithEvents nudThreat As NumericUpDown
    Friend WithEvents lblFailure As Label
    Friend WithEvents nudFailure As NumericUpDown
    Friend WithEvents gbxForce As GroupBox
    Friend WithEvents lblDark As Label
    Friend WithEvents nudDark As NumericUpDown
    Friend WithEvents lblLight As Label
    Friend WithEvents nudLight As NumericUpDown
    Friend WithEvents lstSetback As ListBox
    Friend WithEvents lblSetback As Label
    Friend WithEvents nudSetback As NumericUpDown
    Friend WithEvents lstPercent As ListBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents nudPercent As NumericUpDown
    Friend WithEvents lstAbility As ListBox
    Friend WithEvents lblAbility As Label
    Friend WithEvents nudAbility As NumericUpDown
    Friend WithEvents lstDifficulty As ListBox
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents nudDifficulty As NumericUpDown
    Friend WithEvents lstProficiency As ListBox
    Friend WithEvents lblProficiency As Label
    Friend WithEvents nudProficiency As NumericUpDown
    Friend WithEvents lstChallenge As ListBox
    Friend WithEvents lblChallenge As Label
    Friend WithEvents nudChallenge As NumericUpDown
    Friend WithEvents cmdReset As Button
    Friend WithEvents lstForce As ListBox
    Friend WithEvents lblForce As Label
    Friend WithEvents nudForce As NumericUpDown
End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxDevice = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPrice = New System.Windows.Forms.ComboBox()
        Me.TextBoxpower = New System.Windows.Forms.TextBox()
        Me.TextBoxhours = New System.Windows.Forms.TextBox()
        Me.TextBoxGallons = New System.Windows.Forms.TextBox()
        Me.TextBoxcostpergallon = New System.Windows.Forms.TextBox()
        Me.TextBoxKWH = New System.Windows.Forms.TextBox()
        Me.TextBoxELECCOst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxWAterCost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Buttonclear = New System.Windows.Forms.Button()
        Me.Buttonsubmit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButtonKillowatts = New System.Windows.Forms.RadioButton()
        Me.radiobuttonwatts = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Device:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Power:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hours:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cos Per KWH:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gallons:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cost Per Gal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "KWH:"
        '
        'ComboBoxDevice
        '
        Me.ComboBoxDevice.FormattingEnabled = True
        Me.ComboBoxDevice.Items.AddRange(New Object() {"Play Station 3", "Aquarium", "Clock radio", "Coffee maker", "Clothes dryer", "Dishwasher", "Dehumidifier", "Electric blanket", "Fans Ceiling", "Hair dryer", "Heater", "Clothes iron", "Microwave oven", "Personal computer", "Washing machine top loader", "Washing machine Front loader"})
        Me.ComboBoxDevice.Location = New System.Drawing.Point(91, 13)
        Me.ComboBoxDevice.Name = "ComboBoxDevice"
        Me.ComboBoxDevice.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDevice.TabIndex = 7
        '
        'ComboBoxPrice
        '
        Me.ComboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPrice.FormattingEnabled = True
        Me.ComboBoxPrice.Items.AddRange(New Object() {"0.08", "0.05", "0.12"})
        Me.ComboBoxPrice.Location = New System.Drawing.Point(91, 93)
        Me.ComboBoxPrice.Name = "ComboBoxPrice"
        Me.ComboBoxPrice.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPrice.TabIndex = 8
        '
        'TextBoxpower
        '
        Me.TextBoxpower.Location = New System.Drawing.Point(91, 41)
        Me.TextBoxpower.Name = "TextBoxpower"
        Me.TextBoxpower.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxpower.TabIndex = 9
        '
        'TextBoxhours
        '
        Me.TextBoxhours.Location = New System.Drawing.Point(91, 67)
        Me.TextBoxhours.Name = "TextBoxhours"
        Me.TextBoxhours.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxhours.TabIndex = 10
        '
        'TextBoxGallons
        '
        Me.TextBoxGallons.Location = New System.Drawing.Point(91, 120)
        Me.TextBoxGallons.Name = "TextBoxGallons"
        Me.TextBoxGallons.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxGallons.TabIndex = 11
        '
        'TextBoxcostpergallon
        '
        Me.TextBoxcostpergallon.Enabled = False
        Me.TextBoxcostpergallon.Location = New System.Drawing.Point(91, 146)
        Me.TextBoxcostpergallon.Name = "TextBoxcostpergallon"
        Me.TextBoxcostpergallon.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxcostpergallon.TabIndex = 12
        '
        'TextBoxKWH
        '
        Me.TextBoxKWH.Enabled = False
        Me.TextBoxKWH.Location = New System.Drawing.Point(91, 172)
        Me.TextBoxKWH.Name = "TextBoxKWH"
        Me.TextBoxKWH.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxKWH.TabIndex = 13
        '
        'TextBoxELECCOst
        '
        Me.TextBoxELECCOst.Enabled = False
        Me.TextBoxELECCOst.Location = New System.Drawing.Point(91, 198)
        Me.TextBoxELECCOst.Name = "TextBoxELECCOst"
        Me.TextBoxELECCOst.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxELECCOst.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Elec Cost:"
        '
        'TextBoxWAterCost
        '
        Me.TextBoxWAterCost.Enabled = False
        Me.TextBoxWAterCost.Location = New System.Drawing.Point(91, 225)
        Me.TextBoxWAterCost.Name = "TextBoxWAterCost"
        Me.TextBoxWAterCost.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxWAterCost.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Water Cost:"
        '
        'Buttonclear
        '
        Me.Buttonclear.Location = New System.Drawing.Point(16, 251)
        Me.Buttonclear.Name = "Buttonclear"
        Me.Buttonclear.Size = New System.Drawing.Size(75, 23)
        Me.Buttonclear.TabIndex = 18
        Me.Buttonclear.Text = "Clear"
        Me.Buttonclear.UseVisualStyleBackColor = True
        '
        'Buttonsubmit
        '
        Me.Buttonsubmit.Location = New System.Drawing.Point(137, 251)
        Me.Buttonsubmit.Name = "Buttonsubmit"
        Me.Buttonsubmit.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsubmit.TabIndex = 19
        Me.Buttonsubmit.Text = "Calculate"
        Me.Buttonsubmit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(219, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(717, 178)
        Me.DataGridView1.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Device"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 66
        '
        'Column2
        '
        Me.Column2.HeaderText = "Power"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 62
        '
        'Column3
        '
        Me.Column3.HeaderText = "Hours"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cost Per KWH"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 101
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gallons"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.HeaderText = "KWH"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 58
        '
        'Column7
        '
        Me.Column7.HeaderText = "Electric Cost"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 91
        '
        'Column8
        '
        Me.Column8.HeaderText = "Water Cost"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 85
        '
        'Column9
        '
        Me.Column9.HeaderText = "Total Cost "
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 83
        '
        'RadioButtonKillowatts
        '
        Me.RadioButtonKillowatts.AutoSize = True
        Me.RadioButtonKillowatts.Location = New System.Drawing.Point(260, 44)
        Me.RadioButtonKillowatts.Name = "RadioButtonKillowatts"
        Me.RadioButtonKillowatts.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonKillowatts.TabIndex = 21
        Me.RadioButtonKillowatts.TabStop = True
        Me.RadioButtonKillowatts.Text = "KW"
        Me.RadioButtonKillowatts.UseVisualStyleBackColor = True
        '
        'radiobuttonwatts
        '
        Me.radiobuttonwatts.AutoSize = True
        Me.radiobuttonwatts.Location = New System.Drawing.Point(219, 44)
        Me.radiobuttonwatts.Name = "radiobuttonwatts"
        Me.radiobuttonwatts.Size = New System.Drawing.Size(36, 17)
        Me.radiobuttonwatts.TabIndex = 22
        Me.radiobuttonwatts.TabStop = True
        Me.radiobuttonwatts.Text = "W"
        Me.radiobuttonwatts.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(861, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Clear Table"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 282)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.radiobuttonwatts)
        Me.Controls.Add(Me.RadioButtonKillowatts)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Buttonsubmit)
        Me.Controls.Add(Me.Buttonclear)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxWAterCost)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxELECCOst)
        Me.Controls.Add(Me.TextBoxKWH)
        Me.Controls.Add(Me.TextBoxcostpergallon)
        Me.Controls.Add(Me.TextBoxGallons)
        Me.Controls.Add(Me.TextBoxhours)
        Me.Controls.Add(Me.TextBoxpower)
        Me.Controls.Add(Me.ComboBoxPrice)
        Me.Controls.Add(Me.ComboBoxDevice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Power"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDevice As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPrice As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxpower As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxhours As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGallons As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxcostpergallon As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKWH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxELECCOst As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxWAterCost As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Buttonclear As System.Windows.Forms.Button
    Friend WithEvents Buttonsubmit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButtonKillowatts As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonwatts As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

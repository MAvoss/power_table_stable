Public Class logic
    Private power As String
    Private hours As String
    Private price As Double
    Private watts As Double
    Private KWH As Double
    Private device As String
    Private cost As Double
    Private wattage As String

    Public Sub defaults()
        'sets default atributes on load 
        Form1.radiobuttonwatts.Checked = True
        Form1.ComboBoxDevice.SelectedIndex = 0
        Form1.ComboBoxPrice.SelectedIndex = 0
        Form1.TextBoxhours.Text = 0
        Form1.TextBoxcostpergallon.Text = "0.005"
    End Sub
    'public subs transfer the info from private subs 
    Public Sub domath()
        math()
    End Sub
    Public Sub dodb()
        db()

    End Sub

    Public Sub devices()
        'changes to defualt settings'
        Form1.TextBoxGallons.Text = ""
        Form1.TextBoxWAterCost.Text = ""
        Form1.radiobuttonwatts.Checked = True

        If Form1.ComboBoxDevice.Text = "Play Station 3" Then
            Form1.TextBoxpower.Text = "3600"
        ElseIf Form1.ComboBoxDevice.Text = "Aquarium" Then
            Form1.TextBoxpower.Text = "50"
        ElseIf Form1.ComboBoxDevice.Text = "Clock radio" Then
            Form1.TextBoxpower.Text = "10"
        ElseIf Form1.ComboBoxDevice.Text = "Coffee maker" Then
            Form1.TextBoxpower.Text = "900"
        ElseIf Form1.ComboBoxDevice.Text = "Clothes dryer" Then
            Form1.TextBoxpower.Text = "1800"
        ElseIf Form1.ComboBoxDevice.Text = "Dishwasher" Then
            Form1.TextBoxpower.Text = "1200"
            Form1.TextBoxGallons.Text = "10"
        ElseIf Form1.ComboBoxDevice.Text = "Dehumidifier" Then
            Form1.TextBoxpower.Text = "785"
        ElseIf Form1.ComboBoxDevice.Text = "Electric blanket" Then
            Form1.TextBoxpower.Text = "100"
        ElseIf Form1.ComboBoxDevice.Text = "Fans Ceiling" Then
            Form1.TextBoxpower.Text = "175"
        ElseIf Form1.ComboBoxDevice.Text = "Hair dryer" Then
            Form1.TextBoxpower.Text = "1875"
        ElseIf Form1.ComboBoxDevice.Text = "Heater" Then
            Form1.TextBoxpower.Text = "1500"
        ElseIf Form1.ComboBoxDevice.Text = "Clothes iron" Then
            Form1.TextBoxpower.Text = "1800"
        ElseIf Form1.ComboBoxDevice.Text = "Microwave oven" Then
            Form1.TextBoxpower.Text = "1100"
        ElseIf Form1.ComboBoxDevice.Text = "Personal computer" Then
            Form1.TextBoxpower.Text = "120"
        ElseIf Form1.ComboBoxDevice.Text = "Dehumidifier" Then
            Form1.TextBoxpower.Text = "785"
        ElseIf Form1.ComboBoxDevice.Text = "Washing machine top loader" Then
            Form1.TextBoxpower.Text = "1850"
            Form1.TextBoxGallons.Text = "40"
        ElseIf Form1.ComboBoxDevice.Text = "Washing machine Front loader" Then
            Form1.TextBoxpower.Text = "1650"
            Form1.TextBoxGallons.Text = "10"


            '============================================================='
            'all data from http://energy.gov/ '
            ' Aquarium = 50
            ' Clock(radio = 10)
            ' Coffee(maker = 900)
            ' Clothes(dryer = 1800)
            ' Dishwasher = 1200
            'Dehumidifier = 785
            'Electric blanket 100
            ' Fans Ceiling  175
            ' Hair dryer 1875
            ' Heater(1500)
            'Clothes iron 1800
            ' Microwave(oven = 1100)
            ' Personal computer 120
            ' Radio(400)
            ' Refrigerator(725)
            ' Televisions 36" 133
            '  Toaster = 1400
            ' Toaster(oven = 1225)
            ' VCR/DVD = 125
            ' Vacuum cleaner = 1000–1440
            ' Water heater (40 gallon)5500
            'Water pump 1100
            ' Water bed 380
            'source 'http://wiki.answers.com/Q/How_much_does_tap_water_cost_per_gallon_in_Arizona'
        End If
    End Sub


    Private Sub math()

        'calls math to do the heavy lifting' 
        Dim alert = "please fill all applicable fields"
        'sents an alert if fields are blank'
        'If Form1.TextBoxhours.Text = "" Then
        'MessageBox.Show(alert)

        If Form1.TextBoxpower.Text = "" Then

            MessageBox.Show(alert)

        ElseIf Form1.ComboBoxDevice.Text = "" Then
            MessageBox.Show(alert)
        Else

            ' calls the math method to do calculations'

            ' want to use but causes errors math()

        End If





        'used to make it easier to hoold and controll math operations'
        power = Form1.TextBoxpower.Text
        hours = Form1.TextBoxhours.Text

        'sets the value of the Kwh for calulation later'
        If Form1.RadioButtonKillowatts.Checked Then
            Form1.TextBoxKWH.Text = power * hours
        End If
        If Form1.radiobuttonwatts.Checked Then

            Form1.TextBoxKWH.Text = power / 1000 * hours

        End If
        Dim price = Form1.ComboBoxPrice.SelectedItem
        Form1.TextBoxELECCOst.Text = Form1.TextBoxKWH.Text * price


        'converts watts to killowatts for watts over 1000'
        If Form1.radiobuttonwatts.Checked = True Then
            If Form1.TextBoxpower.Text > 1000 Then
                Form1.RadioButtonKillowatts.Checked = True
                Form1.TextBoxpower.Text = Form1.TextBoxpower.Text / 1000

            End If
        End If
        'allows numbers to be add together 
        Dim gallons As Double
        Dim costpergallon As Double


        If Form1.TextBoxGallons.Text = "" Then
            'do nothing 
        Else

            costpergallon = Form1.TextBoxcostpergallon.Text
            gallons = Form1.TextBoxGallons.Text
            'gets the cost of water 
            Form1.TextBoxWAterCost.Text = gallons * costpergallon * hours
        End If



    End Sub
    Private Sub db()

        'this makes it so the datagrid cannot get any info without the electricty cost field having a value 
        If Form1.TextBoxELECCOst.Text = "" Then
            'do nothing 
        Else
            power = Form1.TextBoxpower.Text
            device = Form1.ComboBoxDevice.Text
            KWH = Form1.TextBoxKWH.Text
            hours = Form1.TextBoxhours.Text
            'electric cost per kwh
            cost = Form1.ComboBoxPrice.Text

            Dim costpergallons = Form1.TextBoxcostpergallon.Text

            Dim electcost As Double
            electcost = Form1.TextBoxELECCOst.Text
            'sets formating formating for datagridview 
            If Form1.RadioButtonKillowatts.Checked Then

                power = power + " KW"
            Else
                power = power + " W"
            End If
            'gets total info total without water stuff being selected 
            If Form1.TextBoxGallons.Text = "" And Form1.TextBoxWAterCost.Text = "" Then
                Dim gallons As String
                gallons = ""
                Dim watercost As Double
                watercost = 0
                watercost = watercost.ToString
                'gets total cost 
                Dim total = watercost + electcost
                total = total.ToString

                Form1.DataGridView1.Rows.Add(device, power, hours, cost, gallons, KWH, electcost, watercost, total)
                'gets total info total withwater stuff being selected 
            Else
                Dim gallons = Form1.TextBoxGallons.Text * hours
                Dim watercost As Double
                watercost = Form1.TextBoxWAterCost.Text
                Dim total = watercost + electcost
                Form1.DataGridView1.Rows.Add(device, power, hours, cost, gallons, KWH, electcost, watercost, total)
            End If
        End If
        '==========================stuff i want to do but cant figure out ====================================

        'Dim stuff As Double
        'For Each row As DataGridViewRow In DataGridView1.Rows

        'If Not row.IsNewRow Then
        'stuff = row.Cells(8).Value
        'stuff = stuff + stuff
        'stuff = stuff.ToString
        'MessageBox.Show(stuff)
        ' End If
        'Next
        'For Each r As DataRow In DataGridView1.Rows
        'Dim variable As String = DataGridView1.Item(8, 0).Value()

        'MessageBox.Show(variable)
        'Next
        '=========================================================================================================



    End Sub
End Class

Public Class Form1
  
    Dim logic As New logic
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'calls seperate awesome class that i made to do the work and keep the logic secure for no good reason but i wanted to 
        logic.defaults()
    End Sub

    Private Sub Buttonsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsubmit.Click
        'runs calculations 
        logic.domath()

    End Sub

    Private Sub TextBoxpower_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxpower.TextChanged
        'automaticly cancles  letters 
        If IsNumeric(TextBoxpower.Text) = False Then
            SendKeys.Send("{BS}")


        End If
        'automaticly converts to killowatts if over 1000'
        If RadioButtonKillowatts.Checked = True And TextBoxpower.Text >= 1000 Then
            TextBoxpower.Text = TextBoxpower.Text / 1000
        End If


    End Sub
    Private Sub TextBoxhours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxhours.TextChanged

        Dim check As String

        check = TextBoxhours.Text
        'checks to see if variable is a number 
        If IsNumeric(check) = False Then
            'erases any character that is not a number'
            SendKeys.Send("{BS}")
            Return

        End If

        'check to see if hours are with in a valid range'
        Dim hours As Double
        hours = TextBoxhours.Text
        If hours >= "0" And hours <= "24" Then


        Else
            'alerts if not in range'
            MessageBox.Show("Use numbers 1 - 24")
        End If
        'auto runs calculation on hours change 
        logic.domath()


    End Sub
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        'it calculates 
        logic.dodb()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'clears all table data 
        DataGridView1.Rows.Clear()

    End Sub

    
    Private Sub ComboBoxDevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDevice.SelectedIndexChanged
        logic.devices()
        'sets hours back to zero 
        TextBoxhours.Text = "0"
        'sets ecltericity cost to zero disabling add button 
        TextBoxELECCOst.Text = ""

    End Sub

    

   
    Private Sub Buttonclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonclear.Click
        'slears all fields to thier defualts 
        ComboBoxDevice.SelectedIndex = 0
        ComboBoxPrice.SelectedIndex = 0
        TextBoxhours.Text = "0"
        TextBoxcostpergallon.Text = "0.005"
        TextBoxELECCOst.Text = ""
        TextBoxWAterCost.Text = ""
    End Sub
End Class

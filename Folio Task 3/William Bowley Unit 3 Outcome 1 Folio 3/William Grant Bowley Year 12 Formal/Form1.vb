Imports System.Xml

' Developer: William Bowley
' Application: Year 12 Formal sac 
' Version: 1
' Date: 26/06/2024
Public Class Form1
    Dim xmlRecord As New XmlDocument()
    Dim xmlFilePath = "database.xml"

    ' Loads the database or Creates a new one
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Existance check of the database
        If System.IO.File.Exists(xmlFilePath) Then
            xmlRecord.Load(xmlFilePath)
            LoadSalesReport()
            Return
        End If

        ' Creates the database if it doesn't exist.
        Dim xmlDeclaration As XmlDeclaration = xmlRecord.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
        xmlRecord.AppendChild(xmlDeclaration)
        Dim rootNode As XmlNode = xmlRecord.CreateElement("Records")
        xmlRecord.AppendChild(rootNode)
        xmlRecord.Save(xmlFilePath)
    End Sub

    ' List all guests with Dietary Requirements
    Private Sub BtnDietaryRequirements_Click(sender As Object, e As EventArgs) Handles BtnDietaryRequirements.Click
        ' Defines Variables
        Dim strName As String
        Dim strDietaryRequirements As String
        Dim LisDietaryRequirementGuests As New List(Of String)()

        ' Gets the GuestList 
        Dim guestList As XmlNodeList = xmlRecord.SelectNodes("//GUEST")

        ' Gets guests with dietary requirements
        For Each guest As XmlNode In guestList
            strName = guest.SelectSingleNode("GuestName").InnerText
            strDietaryRequirements = guest.SelectSingleNode("DietaryRequirements").InnerText
            If strDietaryRequirements = "Yes" Then
                LisDietaryRequirementGuests.Add(strName)
            End If
        Next

        ' Lists guests with dietary requirements.
        LstReport.Items.Clear()
        LstReport.Items.Add("Guests who have dietary requirements:")
        For Each GuestDietary In LisDietaryRequirementGuests
            LstReport.Items.Add(GuestDietary)
        Next
    End Sub

    ' Adds New Guest to the Xml Record
    Private Sub BtnBuyTickets_Click(sender As Object, e As EventArgs) Handles BtnBuyTickets.Click

        If Validation() = True Then
            ' Defines the input variables
            Dim strName As String = TxtName.Text
            Dim intNumTickets As Integer = Val(TxtTickets.Text)
            Dim dblAmountPaid As Double = Val(TxtPaid.Text)
            Dim blnDietaryRequirements As Boolean = ChkDietaryRequirements.Checked

            ' Creates the Guest Element
            Dim guestNode As XmlNode = xmlRecord.CreateElement("GUEST")

            ' Creates, set & appends the GuestName
            Dim guestNameNode As XmlNode = xmlRecord.CreateElement("GuestName")
            guestNameNode.InnerText = TxtName.Text
            guestNode.AppendChild(guestNameNode)

            ' Creates, set & appends the Ticket Number
            Dim numTicketsNode As XmlNode = xmlRecord.CreateElement("NumTickets")
            numTicketsNode.InnerText = TxtTickets.Text
            guestNode.AppendChild(numTicketsNode)

            ' Creates, set & appends the Amount Paid
            Dim amountPaidNode As XmlNode = xmlRecord.CreateElement("AmountPaid")
            amountPaidNode.InnerText = TxtPaid.Text
            guestNode.AppendChild(amountPaidNode)

            ' Creates, set & appends the Dietary Requirements
            Dim dietaryRequirementsNode As XmlNode = xmlRecord.CreateElement("DietaryRequirements")
            Select Case blnDietaryRequirements
                Case True
                    dietaryRequirementsNode.InnerText = "Yes"
                Case Else
                    dietaryRequirementsNode.InnerText = "No"
            End Select
            guestNode.AppendChild(dietaryRequirementsNode)

            ' Appends the new Guest to the XmlRecord
            Dim rootNode As XmlNode = xmlRecord.SelectSingleNode("Records")
            rootNode.AppendChild(guestNode)

            ' Saves the Record & Recorded
            xmlRecord.Save(xmlFilePath)
            MessageBox.Show("Your ticket purchase has been successfully recorded.")
            LoadSalesReport()
        End If
    End Sub

    ' Loads the ticketSale Report
    Private Sub BtnTicketSale_Click(sender As Object, e As EventArgs) Handles BtnTicketSale.Click
        LoadSalesReport()
    End Sub

    ' Clears all user input
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears TextBoxes and ListBox
        TxtName.Clear()
        TxtPaid.Clear()
        TxtTickets.Clear()
        LstReport.Items.Clear()

        ' Clears the checkBox
        ChkDietaryRequirements.Checked = False
    End Sub

    Private Sub LoadSalesReport()
        ' Defines the Guest variables
        Dim strName As String
        Dim intNumTickets As Integer
        Dim dblAmountPaid As Double

        ' Defines the Totals
        Dim intTotalSold As Integer = 0
        Dim dblTotalPaid As Double = 0
        Dim dblTotalOwed As Double = 0
        Dim LisPartPaid As New List(Of String)()

        ' Gets the GuestList 
        Dim guestList As XmlNodeList = xmlRecord.SelectNodes("//GUEST")

        ' List the guest and calculate totals
        For Each guest As XmlNode In guestList
            strName = guest.SelectSingleNode("GuestName").InnerText
            intNumTickets = Integer.Parse(guest.SelectSingleNode("NumTickets").InnerText)
            dblAmountPaid = Double.Parse(guest.SelectSingleNode("AmountPaid").InnerText)

            intTotalSold += intNumTickets
            dblTotalPaid += dblAmountPaid
            dblTotalOwed = (intTotalSold * 95) - dblTotalPaid
        Next

        ' Identify guests who have part-paid tickets
        For Each guest As XmlNode In guestList
            strName = guest.SelectSingleNode("GuestName").InnerText
            intNumTickets = Integer.Parse(guest.SelectSingleNode("NumTickets").InnerText)
            dblAmountPaid = Double.Parse(guest.SelectSingleNode("AmountPaid").InnerText)

            If (intNumTickets * 95 - dblAmountPaid) > 0 Then
                LisPartPaid.Add(strName)
            End If
        Next

        ' Add items to LstReport
        LstReport.Items.Clear()
        LstReport.Items.Add("The total number of tickets sold: " & intTotalSold)
        LstReport.Items.Add("The total amount of money paid: " & FormatCurrency(dblTotalPaid))
        LstReport.Items.Add("The total amount still owed by guests: " & FormatCurrency(dblTotalOwed))
        LstReport.Items.Add("Guests who have part-paid tickets: ")

        For Each GuestPartPaid In LisPartPaid
            LstReport.Items.Add(GuestPartPaid)
        Next
    End Sub


    'Validation (Existance, Range & Type)
    Private Function Validation() As Boolean
        If String.IsNullOrEmpty(TxtName.Text) Then
            MessageBox.Show("Please enter a guest name.")
            Return False
        ElseIf IsNumeric(TxtName.Text) Then
            MessageBox.Show("The guest name should not include numbers.")
            Return False
        ElseIf String.IsNullOrEmpty(TxtTickets.Text) Then
            MessageBox.Show("Please enter the number of tickets.")
            Return False
        ElseIf Not IsNumeric(TxtTickets.Text) Then
            MessageBox.Show("The number of tickets should only include numbers.")
            Return False
        ElseIf Convert.ToInt32(TxtTickets.Text) > 2 Then
            MessageBox.Show("No more than two tickets can be purchased by one guest.")
            Return False
        ElseIf String.IsNullOrEmpty(TxtPaid.Text) Then
            MessageBox.Show("Please enter the amount paid.")
            Return False
        ElseIf Not IsNumeric(TxtPaid.Text) Then
            MessageBox.Show("The amount paid should only include numbers.")
            Return False
        Else
            Return True
        End If
    End Function

End Class

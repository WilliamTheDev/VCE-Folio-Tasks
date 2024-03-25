Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

' Developer: William Bowley
' Application: Time 2 Play Employee Manager
' Version: 1
' Date: 25/03/2024

Public Class Time2Pay
    ' DataBase file location
    Const Time2PayDataBase As String = "DataBases/Time2PayData.txt"

    ' This subroute displays all employee data to the LstDisplay when Display all button is pressed.
    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        ' Validate that the database exists 
        If Not My.Computer.FileSystem.FileExists(Time2PayDataBase) Then
            MsgBox("Time2Pay: Database Not Found.")
            Exit Sub
        End If

        ' Reads data from plain text to an array lines()
        Dim StrLines() As String = File.ReadAllLines(Time2PayDataBase)

        ' Clears List Box
        LstDisplay.Items.Clear()

        ' Reads 4 lines at a time to get employee data & Displays them.
        For i As Integer = 0 To StrLines.Length - 4 Step 4
            Dim StrName As String = StrLines(i)
            Dim StrDepartment As String = StrLines(i + 1)
            Dim IntHours As Integer = Integer.Parse(StrLines(i + 2))
            Dim DblPayRate As Double = Double.Parse(StrLines(i + 3))

            ' Displays employee data.
            LstDisplay.Items.Add($"{StrName}: || Department: {StrDepartment} - Hours (week): {IntHours} - Rate: ${DblPayRate}/h")
        Next
    End Sub

    ' This subroute displays the total employee amount, department and sorts them (highest -> lowest)
    Private Sub BtnPayReport_Click(sender As Object, e As EventArgs) Handles BtnPayReport.Click
        ' Clears List Box
        LstDisplay.Items.Clear()

        ' Validate that the database exists
        If Not My.Computer.FileSystem.FileExists(Time2PayDataBase) Then
            MsgBox("Time2Pay: Database Not Found.")
            Exit Sub
        End If

        ' Reads data from plain text to an array lines()
        Dim StrLines() As String = File.ReadAllLines(Time2PayDataBase)

        ' Creates the Employee Data Dic & Department Data Dic
        Dim DicEmployeesData As New List(Of Dictionary(Of String, Object))()
        Dim DicDepartmentTotals As New Dictionary(Of String, Double)()

        ' Initializes the department totals
        DicDepartmentTotals.Add("Finance", 0)
        DicDepartmentTotals.Add("Legal", 0)
        DicDepartmentTotals.Add("Technology", 0)
        DicDepartmentTotals.Add("Sales", 0)
        DicDepartmentTotals.Add("Marketing", 0)

        ' Reads 4 lines at a time to get employee data & Stores them in a list of dictionaries.
        For i As Integer = 0 To StrLines.Length - 4 Step 4
            ' Employee Values (Name, Department, Hours, PayRate, TotalPay)
            Dim StrName As String = StrLines(i).Trim()
            Dim StrDepartment As String = StrLines(i + 1).Trim()
            Dim IntHours As Integer = Integer.Parse(StrLines(i + 2))
            Dim DblPayRate As Double = Double.Parse(StrLines(i + 3))
            Dim TotalPay As Double = IntHours * DblPayRate

            ' Creates a New Dictionary for current employee.
            Dim DicCurrentEmployee As New Dictionary(Of String, Object)()
            DicCurrentEmployee.Add("name", StrName)
            DicCurrentEmployee.Add("department", StrDepartment)
            DicCurrentEmployee.Add("total_pay", TotalPay)
            DicEmployeesData.Add(DicCurrentEmployee)

            ' Add total pay to employee Department Pay
            If DicDepartmentTotals.ContainsKey(StrDepartment) Then
                DicDepartmentTotals(StrDepartment) += TotalPay
            Else
                MsgBox($"Department '{StrDepartment}' not found in departmentTotals.")
            End If

        Next

        ' Sorts employee data by total pay (highest to lowest)
        DicEmployeesData.Sort(Function(emp1, emp2) emp2("total_pay").CompareTo(emp1("total_pay")))

        ' Display sorted employee data
        LstDisplay.Items.Add("Sorted Employee Total Pay (Highest -> Lowest)")
        For Each emp In DicEmployeesData
            LstDisplay.Items.Add($"{emp("name")} ({emp("department")}): ${emp("total_pay"):F2}")
        Next

        ' Display department totals
        LstDisplay.Items.Add("Department Totals:")
        For Each dept In DicDepartmentTotals
            LstDisplay.Items.Add($"Total for {dept.Key}: ${dept.Value:F2}")
        Next
    End Sub

    ' This subroute does a linear search through the database for the employee name.
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        ' Gets Entered Employee Name
        Dim StrLinearSearch As String = TxtEmployeeName.Text

        ' Checks for a vaild Employee Name
        If Not Regex.IsMatch(StrLinearSearch, "^[a-zA-Z\s]+$") OrElse String.IsNullOrEmpty(StrLinearSearch) Then
            MsgBox("Time2Pay: Please enter a valid Employee Name.")
            Exit Sub
        End If

        ' Validate that the database exists
        If Not My.Computer.FileSystem.FileExists(Time2PayDataBase) Then
            MsgBox("Time2Pay: Database Not Found.")
            Exit Sub
        End If

        ' Clears List Box
        LstDisplay.Items.Clear()

        ' Reads data from plain text to an array lines()
        Dim StrLines() As String = File.ReadAllLines(Time2PayDataBase)
        Dim BolFound As Boolean = False

        ' Reads 4 lines at a time to get employee data & Stores them in a list of dictionaries.
        For i As Integer = 0 To StrLines.Length - 4 Step 4
            Dim StrName As String = StrLines(i)
            Dim BolIsFound As Boolean = StrName.Contains(StrLinearSearch)

            ' If employee is Found than displays data.
            If BolIsFound Then
                Dim StrDepartment As String = StrLines(i + 1)
                Dim IntHours As Integer = Integer.Parse(StrLines(i + 2))
                Dim DblPayRate As Double = Double.Parse(StrLines(i + 3))
                LstDisplay.Items.Add($"{StrName}: || Department: {StrDepartment} - Hours (week): {IntHours} - Rate: ${DblPayRate}/h")
                BolFound = True
            End If
        Next

        ' If no employees were found.
        If Not BolFound Then
            MsgBox("Time2Pay: We don't employ this person.")
        End If

    End Sub

    ' This subroute adds new employees to the database
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Gets NewEmployee Values:
        Dim StrName As String = TxtEmployeeName.Text
        Dim StrDepartment As String = TxtDepartment.Text
        Dim IntHours As Integer = Integer.Parse(TxtHours.Text)
        Dim DblPayRate As Double = Double.Parse(TxtHourlyRate.Text)

        ' Checks Week Hours between (1-60)
        If IntHours < 1 OrElse IntHours > 60 Then
            MsgBox("Time2Pay: Please enter a week work hours between (1-60 hours).")
            Exit Sub
        End If

        ' Checks hourly rate between $20-$100
        If DblPayRate < 20 OrElse DblPayRate > 100 Then
            MsgBox("Time2Pay: Please enter a PayRate between ($20-100).")
            Exit Sub
        End If

        ' Writes Data to file through Streamwriter.
        Using writer As StreamWriter = New StreamWriter(Time2PayDataBase, True)
            writer.WriteLine(StrName)
            writer.WriteLine(StrDepartment)
            writer.WriteLine(IntHours)
            writer.WriteLine(DblPayRate)
        End Using
    End Sub

    ' This subroute clears all User inputs
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtEmployeeName.Clear()
        TxtDepartment.Clear()
        TxtHourlyRate.Clear()
        TxtHours.Clear()
        LstDisplay.Items.Clear()
    End Sub
End Class

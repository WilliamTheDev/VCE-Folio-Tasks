' Developer: William Bowley
' Application: School Formal Manager
' Version: 1
' Date: 26/02/2024
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' This Subroutine Generates a report from the number of teachers & students.
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' Clears the ListBox.
        lstDisplay.Items.Clear()

        'Check for empty textboxes
        If String.IsNullOrWhiteSpace(txtNumStudents.Text) Or String.IsNullOrWhiteSpace(txtNumTeachers.Text) Then
            MessageBox.Show("ERROR: Please enter values for both students and teachers.")
            Exit Sub
        End If

        ' Validate Student & Teacher Input
        If Not IsNumeric(txtNumStudents.Text) Or Not IsNumeric(txtNumTeachers.Text) Then
            MessageBox.Show("ERROR: Please enter valid numeric values.")
            Exit Sub
        End If

        Dim intNumStudents As Integer = CInt(txtNumStudents.Text)
        Dim intNumTeachers As Integer = CInt(txtNumTeachers.Text)

        ' Checks if the number is an integer
        If Not Integer.TryParse(txtNumStudents.Text, intNumStudents) OrElse Not Integer.TryParse(txtNumTeachers.Text, intNumTeachers) Then
            MessageBox.Show("ERROR: Please enter valid integer values.")
            Exit Sub
        End If

        ' Check for negative numbers
        If intNumStudents < 0 Or intNumTeachers < 0 Then
            MessageBox.Show("ERROR: Please enter positive values for both students and teachers.")
            Exit Sub
        End If

        Dim dblTotalCost As Double = (intNumStudents * 100.0) + (intNumTeachers * 50.0)

        ' 5% Discount for orders over 150 tickets
        Dim dblDiscount As Double = 0
        If intNumStudents + intNumTeachers >= 150 Then
            dblDiscount = dblTotalCost * 0.05
            dblTotalCost -= dblDiscount
        End If

        ' Display the result
        lstDisplay.Items.Add($"Number of Students: {intNumStudents}")
        lstDisplay.Items.Add($"Number of Teachers: {intNumTeachers}")
        lstDisplay.Items.Add($"Total Cost: ${dblTotalCost:F2}")

        ' Displays discount
        If dblDiscount > 0 Then
            lstDisplay.Items.Add($"Amount Saved: ${dblDiscount:F2}")
        End If
    End Sub

    ' This Subroutine clears all user inputs. 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumStudents.Clear()
        txtNumTeachers.Clear()
        lstDisplay.Items.Clear()
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Time2Pay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtEmployeeName = New TextBox()
        TxtDepartment = New TextBox()
        TxtHours = New TextBox()
        TxtHourlyRate = New TextBox()
        LabEmployeeName = New Label()
        LabDepartment = New Label()
        LabHours = New Label()
        LabHourlyRate = New Label()
        BtnAdd = New Button()
        BtnDisplay = New Button()
        BtnPayReport = New Button()
        BtnSearch = New Button()
        BtnClear = New Button()
        LstDisplay = New ListBox()
        LabTitle = New Label()
        SuspendLayout()
        ' 
        ' TxtEmployeeName
        ' 
        TxtEmployeeName.Location = New Point(642, 228)
        TxtEmployeeName.Name = "TxtEmployeeName"
        TxtEmployeeName.Size = New Size(200, 39)
        TxtEmployeeName.TabIndex = 0
        ' 
        ' TxtDepartment
        ' 
        TxtDepartment.Location = New Point(642, 297)
        TxtDepartment.Name = "TxtDepartment"
        TxtDepartment.Size = New Size(200, 39)
        TxtDepartment.TabIndex = 1
        ' 
        ' TxtHours
        ' 
        TxtHours.Location = New Point(642, 372)
        TxtHours.Name = "TxtHours"
        TxtHours.Size = New Size(200, 39)
        TxtHours.TabIndex = 2
        ' 
        ' TxtHourlyRate
        ' 
        TxtHourlyRate.Location = New Point(642, 440)
        TxtHourlyRate.Name = "TxtHourlyRate"
        TxtHourlyRate.Size = New Size(200, 39)
        TxtHourlyRate.TabIndex = 3
        ' 
        ' LabEmployeeName
        ' 
        LabEmployeeName.AutoSize = True
        LabEmployeeName.Location = New Point(364, 235)
        LabEmployeeName.Name = "LabEmployeeName"
        LabEmployeeName.Size = New Size(195, 32)
        LabEmployeeName.TabIndex = 4
        LabEmployeeName.Text = "Employee Name:"
        ' 
        ' LabDepartment
        ' 
        LabDepartment.AutoSize = True
        LabDepartment.Location = New Point(364, 307)
        LabDepartment.Name = "LabDepartment"
        LabDepartment.Size = New Size(147, 32)
        LabDepartment.TabIndex = 5
        LabDepartment.Text = "Department:"
        ' 
        ' LabHours
        ' 
        LabHours.AutoSize = True
        LabHours.Location = New Point(364, 379)
        LabHours.Name = "LabHours"
        LabHours.Size = New Size(243, 32)
        LabHours.TabIndex = 6
        LabHours.Text = "Hours worked (week):"
        ' 
        ' LabHourlyRate
        ' 
        LabHourlyRate.AutoSize = True
        LabHourlyRate.Location = New Point(364, 433)
        LabHourlyRate.Name = "LabHourlyRate"
        LabHourlyRate.Size = New Size(144, 32)
        LabHourlyRate.TabIndex = 7
        LabHourlyRate.Text = "Hourly Rate:"
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(919, 221)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(219, 46)
        BtnAdd.TabIndex = 8
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnDisplay
        ' 
        BtnDisplay.Location = New Point(919, 293)
        BtnDisplay.Name = "BtnDisplay"
        BtnDisplay.Size = New Size(219, 46)
        BtnDisplay.TabIndex = 8
        BtnDisplay.Text = "Display All"
        BtnDisplay.UseVisualStyleBackColor = True
        ' 
        ' BtnPayReport
        ' 
        BtnPayReport.Location = New Point(919, 368)
        BtnPayReport.Name = "BtnPayReport"
        BtnPayReport.Size = New Size(219, 46)
        BtnPayReport.TabIndex = 9
        BtnPayReport.Text = "Pay Report"
        BtnPayReport.UseVisualStyleBackColor = True
        ' 
        ' BtnSearch
        ' 
        BtnSearch.Location = New Point(919, 433)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(219, 46)
        BtnSearch.TabIndex = 10
        BtnSearch.Text = "Search"
        BtnSearch.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(364, 1044)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(774, 46)
        BtnClear.TabIndex = 11
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' LstDisplay
        ' 
        LstDisplay.FormattingEnabled = True
        LstDisplay.Location = New Point(364, 562)
        LstDisplay.Name = "LstDisplay"
        LstDisplay.Size = New Size(774, 452)
        LstDisplay.TabIndex = 12
        ' 
        ' LabTitle
        ' 
        LabTitle.AutoSize = True
        LabTitle.Location = New Point(630, 156)
        LabTitle.Name = "LabTitle"
        LabTitle.Size = New Size(231, 32)
        LabTitle.TabIndex = 13
        LabTitle.Text = "PlantRus - Time2Pay"
        ' 
        ' Time2Pay
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1544, 1134)
        Controls.Add(LabTitle)
        Controls.Add(LstDisplay)
        Controls.Add(BtnClear)
        Controls.Add(BtnSearch)
        Controls.Add(BtnPayReport)
        Controls.Add(BtnDisplay)
        Controls.Add(BtnAdd)
        Controls.Add(LabHourlyRate)
        Controls.Add(LabHours)
        Controls.Add(LabDepartment)
        Controls.Add(LabEmployeeName)
        Controls.Add(TxtHourlyRate)
        Controls.Add(TxtHours)
        Controls.Add(TxtDepartment)
        Controls.Add(TxtEmployeeName)
        Name = "Time2Pay"
        Text = "Time2Pay"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtEmployeeName As TextBox
    Friend WithEvents TxtDepartment As TextBox
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents TxtHourlyRate As TextBox
    Friend WithEvents LabEmployeeName As Label
    Friend WithEvents LabDepartment As Label
    Friend WithEvents LabHours As Label
    Friend WithEvents LabHourlyRate As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnPayReport As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents LstDisplay As ListBox
    Friend WithEvents LabTitle As Label

End Class

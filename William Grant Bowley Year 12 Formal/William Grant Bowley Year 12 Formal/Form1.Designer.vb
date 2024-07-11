<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ChkDietaryRequirements = New CheckBox()
        TxtName = New TextBox()
        lblGuestName = New Label()
        lblNumberTickets = New Label()
        TxtTickets = New TextBox()
        lblAmountPaid = New Label()
        TxtPaid = New TextBox()
        BtnTicketSale = New Button()
        lblTitle = New Label()
        LstReport = New ListBox()
        BtnBuyTickets = New Button()
        btnClear = New Button()
        BtnDietaryRequirements = New Button()
        SuspendLayout()
        ' 
        ' ChkDietaryRequirements
        ' 
        ChkDietaryRequirements.AutoSize = True
        ChkDietaryRequirements.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ChkDietaryRequirements.Location = New Point(56, 247)
        ChkDietaryRequirements.Name = "ChkDietaryRequirements"
        ChkDietaryRequirements.RightToLeft = RightToLeft.Yes
        ChkDietaryRequirements.Size = New Size(300, 36)
        ChkDietaryRequirements.TabIndex = 0
        ChkDietaryRequirements.Text = "Dietary Requirements"
        ChkDietaryRequirements.UseVisualStyleBackColor = True
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(294, 88)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(200, 39)
        TxtName.TabIndex = 1
        ' 
        ' lblGuestName
        ' 
        lblGuestName.AutoSize = True
        lblGuestName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGuestName.Location = New Point(56, 91)
        lblGuestName.Name = "lblGuestName"
        lblGuestName.Size = New Size(153, 32)
        lblGuestName.TabIndex = 2
        lblGuestName.Text = "GuestName:"
        ' 
        ' lblNumberTickets
        ' 
        lblNumberTickets.AutoSize = True
        lblNumberTickets.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberTickets.Location = New Point(56, 134)
        lblNumberTickets.Name = "lblNumberTickets"
        lblNumberTickets.Size = New Size(232, 32)
        lblNumberTickets.TabIndex = 4
        lblNumberTickets.Text = "Number of Tickets:"
        ' 
        ' TxtTickets
        ' 
        TxtTickets.Location = New Point(294, 134)
        TxtTickets.Name = "TxtTickets"
        TxtTickets.Size = New Size(200, 39)
        TxtTickets.TabIndex = 3
        ' 
        ' lblAmountPaid
        ' 
        lblAmountPaid.AutoSize = True
        lblAmountPaid.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmountPaid.Location = New Point(58, 190)
        lblAmountPaid.Name = "lblAmountPaid"
        lblAmountPaid.Size = New Size(163, 32)
        lblAmountPaid.TabIndex = 6
        lblAmountPaid.Text = "Amount Paid"
        ' 
        ' TxtPaid
        ' 
        TxtPaid.Location = New Point(294, 187)
        TxtPaid.Name = "TxtPaid"
        TxtPaid.Size = New Size(200, 39)
        TxtPaid.TabIndex = 5
        ' 
        ' BtnTicketSale
        ' 
        BtnTicketSale.Location = New Point(267, 312)
        BtnTicketSale.Name = "BtnTicketSale"
        BtnTicketSale.Size = New Size(229, 66)
        BtnTicketSale.TabIndex = 9
        BtnTicketSale.Text = "Ticket Sales Report"
        BtnTicketSale.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(283, 31)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(382, 46)
        lblTitle.TabIndex = 11
        lblTitle.Text = "Year 12 Formal 2024"
        ' 
        ' LstReport
        ' 
        LstReport.FormattingEnabled = True
        LstReport.Location = New Point(548, 91)
        LstReport.Name = "LstReport"
        LstReport.Size = New Size(530, 484)
        LstReport.TabIndex = 12
        ' 
        ' BtnBuyTickets
        ' 
        BtnBuyTickets.Location = New Point(58, 312)
        BtnBuyTickets.Name = "BtnBuyTickets"
        BtnBuyTickets.Size = New Size(203, 66)
        BtnBuyTickets.TabIndex = 13
        BtnBuyTickets.Text = "Buy Tickets"
        BtnBuyTickets.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(58, 405)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(203, 66)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnDietaryRequirements
        ' 
        BtnDietaryRequirements.Font = New Font("Segoe UI", 8F)
        BtnDietaryRequirements.Location = New Point(267, 405)
        BtnDietaryRequirements.Name = "BtnDietaryRequirements"
        BtnDietaryRequirements.Size = New Size(229, 66)
        BtnDietaryRequirements.TabIndex = 15
        BtnDietaryRequirements.Text = "Dietary Requirements"
        BtnDietaryRequirements.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1090, 594)
        Controls.Add(BtnDietaryRequirements)
        Controls.Add(btnClear)
        Controls.Add(BtnBuyTickets)
        Controls.Add(LstReport)
        Controls.Add(lblTitle)
        Controls.Add(BtnTicketSale)
        Controls.Add(lblAmountPaid)
        Controls.Add(TxtPaid)
        Controls.Add(lblNumberTickets)
        Controls.Add(TxtTickets)
        Controls.Add(lblGuestName)
        Controls.Add(TxtName)
        Controls.Add(ChkDietaryRequirements)
        Name = "Form1"
        Text = "Y12 Formal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ChkDietaryRequirements As CheckBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblNumberTickets As Label
    Friend WithEvents TxtTickets As TextBox
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents TxtPaid As TextBox
    Friend WithEvents BtnTicketSale As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents LstReport As ListBox
    Friend WithEvents BtnBuyTickets As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents BtnDietaryRequirements As Button

End Class

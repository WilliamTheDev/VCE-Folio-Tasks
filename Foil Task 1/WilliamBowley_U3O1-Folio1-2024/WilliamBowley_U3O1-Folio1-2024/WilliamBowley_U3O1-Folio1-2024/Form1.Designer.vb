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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtNumStudents = New TextBox()
        txtNumTeachers = New TextBox()
        btnClear = New Button()
        btnReport = New Button()
        lstDisplay = New ListBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(40, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(299, 32)
        Label2.TabIndex = 1
        Label2.Text = "Number of student tickets:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(42, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(297, 32)
        Label3.TabIndex = 2
        Label3.Text = "Number of teacher tickets:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        Label1.Font = New Font("Sans Serif Collection", 7.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(82, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(512, 52)
        Label1.TabIndex = 3
        Label1.Text = "SCHOOL FORMAL MANGER"
        ' 
        ' txtNumStudents
        ' 
        txtNumStudents.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNumStudents.Location = New Point(357, 145)
        txtNumStudents.Name = "txtNumStudents"
        txtNumStudents.Size = New Size(265, 39)
        txtNumStudents.TabIndex = 4
        ' 
        ' txtNumTeachers
        ' 
        txtNumTeachers.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNumTeachers.Location = New Point(357, 208)
        txtNumTeachers.Name = "txtNumTeachers"
        txtNumTeachers.Size = New Size(265, 39)
        txtNumTeachers.TabIndex = 5
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnClear.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(357, 270)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(265, 46)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnReport.BackgroundImageLayout = ImageLayout.Center
        btnReport.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReport.ForeColor = Color.Black
        btnReport.Location = New Point(42, 270)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(297, 46)
        btnReport.TabIndex = 7
        btnReport.Text = "TICKET REPORT"
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' lstDisplay
        ' 
        lstDisplay.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(42, 401)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(580, 228)
        lstDisplay.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(206), CByte(0))
        PictureBox1.Location = New Point(22, 126)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(620, 230)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(255), CByte(206), CByte(0))
        PictureBox2.Location = New Point(22, 386)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(620, 258)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        PictureBox3.Location = New Point(25, 129)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(614, 223)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        PictureBox4.Location = New Point(25, 32)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(614, 60)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(255), CByte(206), CByte(0))
        PictureBox5.Location = New Point(22, 28)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(620, 68)
        PictureBox5.TabIndex = 12
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        PictureBox6.Location = New Point(25, 389)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(614, 252)
        PictureBox6.TabIndex = 13
        PictureBox6.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(45), CByte(3), CByte(82))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(115, 319)
        Label4.Name = "Label4"
        Label4.Size = New Size(466, 32)
        Label4.TabIndex = 14
        Label4.Text = "* 5% Off For Orders Over 150 Total Tickets"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(658, 653)
        Controls.Add(Label4)
        Controls.Add(lstDisplay)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox2)
        Controls.Add(btnReport)
        Controls.Add(btnClear)
        Controls.Add(txtNumTeachers)
        Controls.Add(txtNumStudents)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Shool Formal Management"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumStudents As TextBox
    Friend WithEvents txtNumTeachers As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label

End Class

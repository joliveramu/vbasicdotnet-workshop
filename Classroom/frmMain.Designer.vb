<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        Label1 = New Label()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        Label2 = New Label()
        txtLastName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtID = New TextBox()
        Label6 = New Label()
        dgv = New DataGridView()
        cmbGender = New ComboBox()
        cmbYear = New ComboBox()
        Panel1 = New Panel()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(9, 15)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(147, 53)
        btnAdd.TabIndex = 0
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(176, 15)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(147, 53)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(341, 15)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(147, 53)
        btnDelete.TabIndex = 2
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(982, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(147, 53)
        btnExit.TabIndex = 3
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 5
        Label1.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(24, 238)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(291, 31)
        txtFirstName.TabIndex = 6
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(24, 310)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(291, 31)
        txtMiddleName.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 25)
        Label2.TabIndex = 7
        Label2.Text = "Middle Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(24, 380)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(291, 31)
        txtLastName.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 25)
        Label3.TabIndex = 9
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 411)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 11
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 476)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 25)
        Label5.TabIndex = 13
        Label5.Text = "Year"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(24, 176)
        txtID.Name = "txtID"
        txtID.Size = New Size(291, 31)
        txtID.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 25)
        Label6.TabIndex = 15
        Label6.Text = "ID"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(344, 148)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersVisible = False
        dgv.RowHeadersWidth = 62
        dgv.Size = New Size(773, 387)
        dgv.TabIndex = 17
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(24, 439)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(291, 33)
        cmbGender.TabIndex = 18
        ' 
        ' cmbYear
        ' 
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year", "Others"})
        cmbYear.Location = New Point(24, 504)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(291, 33)
        cmbYear.TabIndex = 19
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Location = New Point(3, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1132, 103)
        Panel1.TabIndex = 20
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 575)
        Controls.Add(cmbYear)
        Controls.Add(cmbGender)
        Controls.Add(dgv)
        Controls.Add(txtID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtLastName)
        Controls.Add(Label3)
        Controls.Add(txtMiddleName)
        Controls.Add(Label2)
        Controls.Add(txtFirstName)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Classroom Form"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Panel1 As Panel

End Class

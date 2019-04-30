<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentCourse = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtStudentDOB = New System.Windows.Forms.TextBox()
        Me.cmbStudentCourse = New System.Windows.Forms.ComboBox()
        Me.btnDetailsDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(148, 57)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(79, 30)
        Me.lblDetails.TabIndex = 7
        Me.lblDetails.Text = "Details"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(48, 104)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(81, 13)
        Me.lblStudentName.TabIndex = 9
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(48, 138)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(64, 13)
        Me.lblStudentID.TabIndex = 10
        Me.lblStudentID.Text = "Student ID: "
        '
        'lblStudentCourse
        '
        Me.lblStudentCourse.AutoSize = True
        Me.lblStudentCourse.Location = New System.Drawing.Point(48, 168)
        Me.lblStudentCourse.Name = "lblStudentCourse"
        Me.lblStudentCourse.Size = New System.Drawing.Size(86, 13)
        Me.lblStudentCourse.TabIndex = 11
        Me.lblStudentCourse.Text = "Student Course: "
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(48, 201)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(74, 13)
        Me.lblDOB.TabIndex = 12
        Me.lblDOB.Text = "Date Of Birth: "
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(136, 104)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(112, 20)
        Me.txtStudentName.TabIndex = 13
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(136, 135)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(112, 20)
        Me.txtStudentID.TabIndex = 14
        '
        'txtStudentDOB
        '
        Me.txtStudentDOB.Location = New System.Drawing.Point(136, 198)
        Me.txtStudentDOB.Name = "txtStudentDOB"
        Me.txtStudentDOB.Size = New System.Drawing.Size(112, 20)
        Me.txtStudentDOB.TabIndex = 15
        '
        'cmbStudentCourse
        '
        Me.cmbStudentCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudentCourse.FormattingEnabled = True
        Me.cmbStudentCourse.Items.AddRange(New Object() {"BTEC Level 3 SD", "BTEC Level 3 90 D", "BTEC Level 3 D", "BTEC Level 3 ED"})
        Me.cmbStudentCourse.Location = New System.Drawing.Point(136, 165)
        Me.cmbStudentCourse.Name = "cmbStudentCourse"
        Me.cmbStudentCourse.Size = New System.Drawing.Size(112, 21)
        Me.cmbStudentCourse.TabIndex = 16
        '
        'btnDetailsDone
        '
        Me.btnDetailsDone.Location = New System.Drawing.Point(291, 317)
        Me.btnDetailsDone.Name = "btnDetailsDone"
        Me.btnDetailsDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDetailsDone.TabIndex = 17
        Me.btnDetailsDone.Text = "Done"
        Me.btnDetailsDone.UseVisualStyleBackColor = True
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDetailsDone)
        Me.Controls.Add(Me.cmbStudentCourse)
        Me.Controls.Add(Me.txtStudentDOB)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblStudentCourse)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 390)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(394, 390)
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents lblStudentCourse As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentDOB As System.Windows.Forms.TextBox
    Friend WithEvents cmbStudentCourse As System.Windows.Forms.ComboBox
    Friend WithEvents btnDetailsDone As System.Windows.Forms.Button
End Class

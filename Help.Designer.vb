<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblHelpInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(109, 227)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(115, 9)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(56, 30)
        Me.lblHelp.TabIndex = 7
        Me.lblHelp.Text = "Help"
        '
        'lblHelpInfo
        '
        Me.lblHelpInfo.AutoSize = True
        Me.lblHelpInfo.Location = New System.Drawing.Point(22, 51)
        Me.lblHelpInfo.MaximumSize = New System.Drawing.Size(250, 250)
        Me.lblHelpInfo.Name = "lblHelpInfo"
        Me.lblHelpInfo.Size = New System.Drawing.Size(239, 91)
        Me.lblHelpInfo.TabIndex = 8
        Me.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text")
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHelpInfo)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents lblHelpInfo As System.Windows.Forms.Label
End Class

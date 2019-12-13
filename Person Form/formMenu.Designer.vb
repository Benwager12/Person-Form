<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        Me.btnAddUsers = New System.Windows.Forms.Button()
        Me.btnViewUsers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddUsers
        '
        Me.btnAddUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUsers.Location = New System.Drawing.Point(12, 12)
        Me.btnAddUsers.Name = "btnAddUsers"
        Me.btnAddUsers.Size = New System.Drawing.Size(388, 93)
        Me.btnAddUsers.TabIndex = 0
        Me.btnAddUsers.Text = "Add User"
        Me.btnAddUsers.UseVisualStyleBackColor = True
        '
        'btnViewUsers
        '
        Me.btnViewUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUsers.Location = New System.Drawing.Point(12, 111)
        Me.btnViewUsers.Name = "btnViewUsers"
        Me.btnViewUsers.Size = New System.Drawing.Size(388, 93)
        Me.btnViewUsers.TabIndex = 1
        Me.btnViewUsers.Text = "View Users"
        Me.btnViewUsers.UseVisualStyleBackColor = True
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 212)
        Me.Controls.Add(Me.btnViewUsers)
        Me.Controls.Add(Me.btnAddUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddUsers As Button
    Friend WithEvents btnViewUsers As Button
End Class

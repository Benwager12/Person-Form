<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdd
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.lblHairColour = New System.Windows.Forms.Label()
        Me.pnlHairColour = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.clrHairColour = New System.Windows.Forms.ColorDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.numUserID = New System.Windows.Forms.NumericUpDown()
        CType(Me.numUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(40, 53)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 20)
        Me.lblUserID.TabIndex = 2
        Me.lblUserID.Text = "User ID"
        '
        'txtForename
        '
        Me.txtForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForename.Location = New System.Drawing.Point(110, 81)
        Me.txtForename.MaxLength = 30
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(229, 22)
        Me.txtForename.TabIndex = 5
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(22, 81)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(82, 20)
        Me.lblForename.TabIndex = 4
        Me.lblForename.Text = "Forename"
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(110, 109)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(229, 22)
        Me.txtSurname.TabIndex = 7
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(30, 109)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(74, 20)
        Me.lblSurname.TabIndex = 6
        Me.lblSurname.Text = "Surname"
        '
        'txtStreetName
        '
        Me.txtStreetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetName.Location = New System.Drawing.Point(110, 137)
        Me.txtStreetName.MaxLength = 60
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(229, 22)
        Me.txtStreetName.TabIndex = 9
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetName.Location = New System.Drawing.Point(5, 137)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(99, 20)
        Me.lblStreetName.TabIndex = 8
        Me.lblStreetName.Text = "Street Name"
        '
        'lblHairColour
        '
        Me.lblHairColour.AutoSize = True
        Me.lblHairColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHairColour.Location = New System.Drawing.Point(16, 165)
        Me.lblHairColour.Name = "lblHairColour"
        Me.lblHairColour.Size = New System.Drawing.Size(88, 20)
        Me.lblHairColour.TabIndex = 10
        Me.lblHairColour.Text = "Hair Colour"
        '
        'pnlHairColour
        '
        Me.pnlHairColour.BackColor = System.Drawing.Color.White
        Me.pnlHairColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHairColour.Location = New System.Drawing.Point(110, 165)
        Me.pnlHairColour.Name = "pnlHairColour"
        Me.pnlHairColour.Size = New System.Drawing.Size(229, 20)
        Me.pnlHairColour.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(327, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "User"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(9, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(155, 39)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(184, 200)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(155, 39)
        Me.btnCount.TabIndex = 13
        Me.btnCount.Text = "Count Records"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'numUserID
        '
        Me.numUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUserID.Location = New System.Drawing.Point(110, 53)
        Me.numUserID.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numUserID.Name = "numUserID"
        Me.numUserID.Size = New System.Drawing.Size(229, 22)
        Me.numUserID.TabIndex = 14
        Me.numUserID.ThousandsSeparator = True
        Me.numUserID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'formAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 251)
        Me.Controls.Add(Me.numUserID)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlHairColour)
        Me.Controls.Add(Me.lblHairColour)
        Me.Controls.Add(Me.txtStreetName)
        Me.Controls.Add(Me.lblStreetName)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.lblUserID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formAdd"
        Me.Text = "Add User"
        CType(Me.numUserID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserID As Label
    Friend WithEvents txtForename As TextBox
    Friend WithEvents lblForename As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtStreetName As TextBox
    Friend WithEvents lblStreetName As Label
    Friend WithEvents lblHairColour As Label
    Friend WithEvents pnlHairColour As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents clrHairColour As ColorDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents numUserID As NumericUpDown
End Class

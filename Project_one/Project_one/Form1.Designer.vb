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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtregno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbounits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbother = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcat = New System.Windows.Forms.TextBox()
        Me.txtassign = New System.Windows.Forms.TextBox()
        Me.txtexam = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lstoutput = New System.Windows.Forms.ListBox()
        Me.Cbostudy = New System.Windows.Forms.ComboBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Reg No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 194)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year of study"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(435, 76)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(148, 28)
        Me.txtname.TabIndex = 3
        '
        'txtregno
        '
        Me.txtregno.Location = New System.Drawing.Point(435, 130)
        Me.txtregno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtregno.Multiline = True
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(148, 31)
        Me.txtregno.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Units"
        '
        'Cbounits
        '
        Me.Cbounits.FormattingEnabled = True
        Me.Cbounits.Location = New System.Drawing.Point(435, 249)
        Me.Cbounits.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbounits.Name = "Cbounits"
        Me.Cbounits.Size = New System.Drawing.Size(132, 24)
        Me.Cbounits.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(346, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(450, 301)
        Me.rbmale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(56, 20)
        Me.rbmale.TabIndex = 9
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(450, 330)
        Me.rbfemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(72, 20)
        Me.rbfemale.TabIndex = 10
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbother
        '
        Me.rbother.AutoSize = True
        Me.rbother.Location = New System.Drawing.Point(450, 358)
        Me.rbother.Margin = New System.Windows.Forms.Padding(4)
        Me.rbother.Name = "rbother"
        Me.rbother.Size = New System.Drawing.Size(58, 20)
        Me.rbother.TabIndex = 11
        Me.rbother.TabStop = True
        Me.rbother.Text = "Other"
        Me.rbother.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 412)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 415)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Assignment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(723, 415)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Exam"
        '
        'txtcat
        '
        Me.txtcat.Location = New System.Drawing.Point(196, 415)
        Me.txtcat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcat.Name = "txtcat"
        Me.txtcat.Size = New System.Drawing.Size(132, 22)
        Me.txtcat.TabIndex = 15
        '
        'txtassign
        '
        Me.txtassign.Location = New System.Drawing.Point(524, 412)
        Me.txtassign.Margin = New System.Windows.Forms.Padding(4)
        Me.txtassign.Name = "txtassign"
        Me.txtassign.Size = New System.Drawing.Size(132, 22)
        Me.txtassign.TabIndex = 16
        '
        'txtexam
        '
        Me.txtexam.Location = New System.Drawing.Point(785, 417)
        Me.txtexam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexam.Name = "txtexam"
        Me.txtexam.Size = New System.Drawing.Size(132, 22)
        Me.txtexam.TabIndex = 17
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsave.Location = New System.Drawing.Point(196, 481)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(133, 43)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lstoutput
        '
        Me.lstoutput.FormattingEnabled = True
        Me.lstoutput.ItemHeight = 16
        Me.lstoutput.Location = New System.Drawing.Point(374, 540)
        Me.lstoutput.Margin = New System.Windows.Forms.Padding(4)
        Me.lstoutput.Name = "lstoutput"
        Me.lstoutput.Size = New System.Drawing.Size(238, 196)
        Me.lstoutput.TabIndex = 19
        '
        'Cbostudy
        '
        Me.Cbostudy.FormattingEnabled = True
        Me.Cbostudy.Location = New System.Drawing.Point(435, 194)
        Me.Cbostudy.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbostudy.Name = "Cbostudy"
        Me.Cbostudy.Size = New System.Drawing.Size(132, 24)
        Me.Cbostudy.TabIndex = 20
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnupdate.Location = New System.Drawing.Point(435, 481)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(128, 44)
        Me.btnupdate.TabIndex = 21
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndelete.Location = New System.Drawing.Point(679, 480)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(135, 44)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(400, 27)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "STUDENT DETAILS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(991, 749)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Cbostudy)
        Me.Controls.Add(Me.lstoutput)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtexam)
        Me.Controls.Add(Me.txtassign)
        Me.Controls.Add(Me.txtcat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbother)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cbounits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtregno)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtregno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbounits As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbother As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcat As TextBox
    Friend WithEvents txtassign As TextBox
    Friend WithEvents txtexam As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents lstoutput As ListBox
    Friend WithEvents Cbostudy As ComboBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Label10 As Label
End Class

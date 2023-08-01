<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmstudent_reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstudent_reg))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiofemale = New System.Windows.Forms.RadioButton()
        Me.radiomale = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnphoto = New System.Windows.Forms.Button()
        Me.txtphoto = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrollno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfaculty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsemester = New System.Windows.Forms.TextBox()
        Me.cmbdistrict = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstudentlname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtstudentfname = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.radiofemale)
        Me.GroupBox1.Controls.Add(Me.radiomale)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtrollno)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtfaculty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtsemester)
        Me.GroupBox1.Controls.Add(Me.cmbdistrict)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtstudentlname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.txtstudentfname)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 349)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Student Entry"
        '
        'radiofemale
        '
        Me.radiofemale.AutoSize = True
        Me.radiofemale.Location = New System.Drawing.Point(199, 74)
        Me.radiofemale.Name = "radiofemale"
        Me.radiofemale.Size = New System.Drawing.Size(59, 17)
        Me.radiofemale.TabIndex = 19
        Me.radiofemale.Text = "Female"
        Me.radiofemale.UseVisualStyleBackColor = True
        '
        'radiomale
        '
        Me.radiomale.AutoSize = True
        Me.radiomale.Checked = True
        Me.radiomale.Location = New System.Drawing.Point(139, 75)
        Me.radiomale.Name = "radiomale"
        Me.radiomale.Size = New System.Drawing.Size(48, 17)
        Me.radiomale.TabIndex = 18
        Me.radiomale.TabStop = True
        Me.radiomale.Text = "Male"
        Me.radiomale.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Gender"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnphoto)
        Me.GroupBox3.Controls.Add(Me.txtphoto)
        Me.GroupBox3.Location = New System.Drawing.Point(603, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 135)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Photo Upload"
        '
        'btnphoto
        '
        Me.btnphoto.Location = New System.Drawing.Point(205, 27)
        Me.btnphoto.Name = "btnphoto"
        Me.btnphoto.Size = New System.Drawing.Size(110, 23)
        Me.btnphoto.TabIndex = 1
        Me.btnphoto.Text = "Upload Photo"
        Me.btnphoto.UseVisualStyleBackColor = True
        '
        'txtphoto
        '
        Me.txtphoto.Location = New System.Drawing.Point(6, 27)
        Me.txtphoto.Name = "txtphoto"
        Me.txtphoto.Size = New System.Drawing.Size(193, 20)
        Me.txtphoto.TabIndex = 0
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(137, 265)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(200, 20)
        Me.txtdob.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Roll No."
        '
        'txtrollno
        '
        Me.txtrollno.Location = New System.Drawing.Point(137, 233)
        Me.txtrollno.Name = "txtrollno"
        Me.txtrollno.Size = New System.Drawing.Size(121, 20)
        Me.txtrollno.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(139, 104)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(121, 20)
        Me.txtaddress.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Faculty"
        '
        'txtfaculty
        '
        Me.txtfaculty.Location = New System.Drawing.Point(139, 165)
        Me.txtfaculty.Name = "txtfaculty"
        Me.txtfaculty.Size = New System.Drawing.Size(121, 20)
        Me.txtfaculty.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Semester"
        '
        'txtsemester
        '
        Me.txtsemester.Location = New System.Drawing.Point(137, 200)
        Me.txtsemester.Name = "txtsemester"
        Me.txtsemester.Size = New System.Drawing.Size(121, 20)
        Me.txtsemester.TabIndex = 5
        '
        'cmbdistrict
        '
        Me.cmbdistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdistrict.FormattingEnabled = True
        Me.cmbdistrict.Location = New System.Drawing.Point(139, 130)
        Me.cmbdistrict.Name = "cmbdistrict"
        Me.cmbdistrict.Size = New System.Drawing.Size(121, 21)
        Me.cmbdistrict.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address District"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'txtstudentlname
        '
        Me.txtstudentlname.Location = New System.Drawing.Point(137, 48)
        Me.txtstudentlname.Name = "txtstudentlname"
        Me.txtstudentlname.Size = New System.Drawing.Size(121, 20)
        Me.txtstudentlname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(218, 310)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtstudentfname
        '
        Me.txtstudentfname.Location = New System.Drawing.Point(137, 19)
        Me.txtstudentfname.Name = "txtstudentfname"
        Me.txtstudentfname.Size = New System.Drawing.Size(121, 20)
        Me.txtstudentfname.TabIndex = 0
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(137, 310)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 196)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(962, 171)
        Me.DataGridView1.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Images Only(*.jpg)|.jpg"
        Me.OpenFileDialog1.Title = "Upload Single jpg File"
        '
        'frmstudent_reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 584)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmstudent_reg"
        Me.Text = "frmstudent_reg"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbdistrict As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtstudentlname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents txtstudentfname As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents txtdob As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrollno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfaculty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsemester As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnphoto As Button
    Friend WithEvents txtphoto As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents radiofemale As RadioButton
    Friend WithEvents radiomale As RadioButton
    Friend WithEvents Label9 As Label
End Class

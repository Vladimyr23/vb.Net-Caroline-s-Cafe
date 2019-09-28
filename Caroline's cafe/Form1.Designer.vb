<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cafe
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
        Me.btnMainCourse = New System.Windows.Forms.Button()
        Me.btnBurgers = New System.Windows.Forms.Button()
        Me.btnSalads = New System.Windows.Forms.Button()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMainCourse
        '
        Me.btnMainCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainCourse.Location = New System.Drawing.Point(8, 24)
        Me.btnMainCourse.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnMainCourse.Name = "btnMainCourse"
        Me.btnMainCourse.Size = New System.Drawing.Size(125, 32)
        Me.btnMainCourse.TabIndex = 0
        Me.btnMainCourse.Text = "Main Course"
        Me.btnMainCourse.UseVisualStyleBackColor = True
        '
        'btnBurgers
        '
        Me.btnBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurgers.Location = New System.Drawing.Point(8, 65)
        Me.btnBurgers.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(125, 32)
        Me.btnBurgers.TabIndex = 1
        Me.btnBurgers.Text = "Burgers"
        Me.btnBurgers.UseVisualStyleBackColor = True
        '
        'btnSalads
        '
        Me.btnSalads.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalads.Location = New System.Drawing.Point(8, 105)
        Me.btnSalads.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSalads.Name = "btnSalads"
        Me.btnSalads.Size = New System.Drawing.Size(125, 32)
        Me.btnSalads.TabIndex = 2
        Me.btnSalads.Text = "Salads"
        Me.btnSalads.UseVisualStyleBackColor = True
        '
        'btnDesserts
        '
        Me.btnDesserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesserts.Location = New System.Drawing.Point(8, 145)
        Me.btnDesserts.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(125, 32)
        Me.btnDesserts.TabIndex = 3
        Me.btnDesserts.Text = "Desserts"
        Me.btnDesserts.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.Location = New System.Drawing.Point(6, 185)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(125, 32)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(576, 297)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(179, 57)
        Me.btnProceed.TabIndex = 6
        Me.btnProceed.Text = "Proceed to pay"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(157, 25)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(294, 329)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.Location = New System.Drawing.Point(461, 25)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(294, 221)
        Me.ListView2.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView2.TabIndex = 8
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(461, 297)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 57)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Order"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(461, 260)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 18)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(6, 298)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnMainCourse)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnBurgers)
        Me.GroupBox1.Controls.Add(Me.btnSalads)
        Me.GroupBox1.Controls.Add(Me.btnDesserts)
        Me.GroupBox1.Controls.Add(Me.btnDrinks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 343)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Cafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 367)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnProceed)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Cafe"
        Me.ShowIcon = False
        Me.Text = "Cafe main"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMainCourse As Button
    Friend WithEvents btnBurgers As Button
    Friend WithEvents btnSalads As Button
    Friend WithEvents btnDesserts As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class

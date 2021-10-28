<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza101
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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.txtStList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkThincrust = New System.Windows.Forms.RadioButton()
        Me.chkThickcrust = New System.Windows.Forms.RadioButton()
        Me.chkCheesecrust = New System.Windows.Forms.RadioButton()
        Me.chkMushroom = New System.Windows.Forms.CheckBox()
        Me.chkPineapple = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkOlives = New System.Windows.Forms.CheckBox()
        Me.chkBasil = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.dateDeldate = New System.Windows.Forms.DateTimePicker()
        Me.txtDeltime = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhoneno = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCrustcost = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtToppingscost = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalcost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(41, 60)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(132, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter order details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(182, 60)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(132, 22)
        Me.txtLastName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(364, 115)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(56, 22)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.Text = "1"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(305, 167)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(116, 25)
        Me.btnAddOrder.TabIndex = 17
        Me.btnAddOrder.Text = "Add order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'txtStList
        '
        Me.txtStList.FormattingEnabled = True
        Me.txtStList.ItemHeight = 16
        Me.txtStList.Location = New System.Drawing.Point(48, 249)
        Me.txtStList.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStList.Name = "txtStList"
        Me.txtStList.Size = New System.Drawing.Size(710, 196)
        Me.txtStList.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 226)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of entered orders (for testing)"
        '
        'chkThincrust
        '
        Me.chkThincrust.AutoSize = True
        Me.chkThincrust.Checked = True
        Me.chkThincrust.Location = New System.Drawing.Point(472, 62)
        Me.chkThincrust.Name = "chkThincrust"
        Me.chkThincrust.Size = New System.Drawing.Size(92, 21)
        Me.chkThincrust.TabIndex = 8
        Me.chkThincrust.TabStop = True
        Me.chkThincrust.Text = "Thin crust"
        Me.chkThincrust.UseVisualStyleBackColor = True
        '
        'chkThickcrust
        '
        Me.chkThickcrust.AutoSize = True
        Me.chkThickcrust.Location = New System.Drawing.Point(472, 88)
        Me.chkThickcrust.Name = "chkThickcrust"
        Me.chkThickcrust.Size = New System.Drawing.Size(98, 21)
        Me.chkThickcrust.TabIndex = 9
        Me.chkThickcrust.Text = "Thick crust"
        Me.chkThickcrust.UseVisualStyleBackColor = True
        '
        'chkCheesecrust
        '
        Me.chkCheesecrust.AutoSize = True
        Me.chkCheesecrust.Location = New System.Drawing.Point(472, 115)
        Me.chkCheesecrust.Name = "chkCheesecrust"
        Me.chkCheesecrust.Size = New System.Drawing.Size(111, 21)
        Me.chkCheesecrust.TabIndex = 10
        Me.chkCheesecrust.Text = "Cheesy crust"
        Me.chkCheesecrust.UseVisualStyleBackColor = True
        '
        'chkMushroom
        '
        Me.chkMushroom.AutoSize = True
        Me.chkMushroom.Location = New System.Drawing.Point(592, 61)
        Me.chkMushroom.Name = "chkMushroom"
        Me.chkMushroom.Size = New System.Drawing.Size(96, 21)
        Me.chkMushroom.TabIndex = 11
        Me.chkMushroom.Text = "Mushroom"
        Me.chkMushroom.UseVisualStyleBackColor = True
        '
        'chkPineapple
        '
        Me.chkPineapple.AutoSize = True
        Me.chkPineapple.Location = New System.Drawing.Point(592, 88)
        Me.chkPineapple.Name = "chkPineapple"
        Me.chkPineapple.Size = New System.Drawing.Size(93, 21)
        Me.chkPineapple.TabIndex = 12
        Me.chkPineapple.Text = "Pineapple"
        Me.chkPineapple.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(592, 115)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(95, 21)
        Me.chkPepperoni.TabIndex = 13
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkOlives
        '
        Me.chkOlives.AutoSize = True
        Me.chkOlives.Location = New System.Drawing.Point(698, 115)
        Me.chkOlives.Name = "chkOlives"
        Me.chkOlives.Size = New System.Drawing.Size(69, 21)
        Me.chkOlives.TabIndex = 16
        Me.chkOlives.Text = "Olives"
        Me.chkOlives.UseVisualStyleBackColor = True
        '
        'chkBasil
        '
        Me.chkBasil.AutoSize = True
        Me.chkBasil.Location = New System.Drawing.Point(698, 88)
        Me.chkBasil.Name = "chkBasil"
        Me.chkBasil.Size = New System.Drawing.Size(60, 21)
        Me.chkBasil.TabIndex = 15
        Me.chkBasil.Text = "Basil"
        Me.chkBasil.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(698, 61)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(59, 21)
        Me.chkHam.TabIndex = 14
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'dateDeldate
        '
        Me.dateDeldate.Location = New System.Drawing.Point(41, 169)
        Me.dateDeldate.Name = "dateDeldate"
        Me.dateDeldate.Size = New System.Drawing.Size(200, 22)
        Me.dateDeldate.TabIndex = 6
        '
        'txtDeltime
        '
        Me.txtDeltime.Location = New System.Drawing.Point(253, 169)
        Me.txtDeltime.Mask = "00:00"
        Me.txtDeltime.Name = "txtDeltime"
        Me.txtDeltime.Size = New System.Drawing.Size(41, 22)
        Me.txtDeltime.TabIndex = 7
        Me.txtDeltime.ValidatingType = GetType(Date)
        '
        'txtPhoneno
        '
        Me.txtPhoneno.Location = New System.Drawing.Point(321, 60)
        Me.txtPhoneno.Mask = "(999) 000-0000"
        Me.txtPhoneno.Name = "txtPhoneno"
        Me.txtPhoneno.Size = New System.Drawing.Size(100, 22)
        Me.txtPhoneno.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Phone number"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(298, 115)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(56, 22)
        Me.txtPostcode.TabIndex = 4
        Me.txtPostcode.Text = "1"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(41, 115)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(249, 22)
        Me.txtAddress.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Street address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(469, 36)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Crust"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(589, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Toppings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 149)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Delivery date and time (24h)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(469, 149)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Crust cost"
        '
        'txtCrustcost
        '
        Me.txtCrustcost.Location = New System.Drawing.Point(472, 169)
        Me.txtCrustcost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCrustcost.Name = "txtCrustcost"
        Me.txtCrustcost.ReadOnly = True
        Me.txtCrustcost.Size = New System.Drawing.Size(92, 22)
        Me.txtCrustcost.TabIndex = 100
        Me.txtCrustcost.TabStop = False
        Me.txtCrustcost.Text = "$0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(576, 149)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Toppings cost"
        '
        'txtToppingscost
        '
        Me.txtToppingscost.Location = New System.Drawing.Point(579, 169)
        Me.txtToppingscost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtToppingscost.Name = "txtToppingscost"
        Me.txtToppingscost.ReadOnly = True
        Me.txtToppingscost.Size = New System.Drawing.Size(92, 22)
        Me.txtToppingscost.TabIndex = 100
        Me.txtToppingscost.TabStop = False
        Me.txtToppingscost.Text = "$0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(681, 149)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Total"
        '
        'txtTotalcost
        '
        Me.txtTotalcost.Location = New System.Drawing.Point(684, 169)
        Me.txtTotalcost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalcost.Name = "txtTotalcost"
        Me.txtTotalcost.ReadOnly = True
        Me.txtTotalcost.Size = New System.Drawing.Size(92, 22)
        Me.txtTotalcost.TabIndex = 100
        Me.txtTotalcost.TabStop = False
        Me.txtTotalcost.Text = "$0"
        '
        'Pizza101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 482)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalcost)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtToppingscost)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCrustcost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneno)
        Me.Controls.Add(Me.dateDeldate)
        Me.Controls.Add(Me.txtDeltime)
        Me.Controls.Add(Me.chkOlives)
        Me.Controls.Add(Me.chkBasil)
        Me.Controls.Add(Me.chkHam)
        Me.Controls.Add(Me.chkPepperoni)
        Me.Controls.Add(Me.chkPineapple)
        Me.Controls.Add(Me.chkMushroom)
        Me.Controls.Add(Me.chkCheesecrust)
        Me.Controls.Add(Me.chkThickcrust)
        Me.Controls.Add(Me.chkThincrust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStList)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pizza101"
        Me.Text = "v1.01 PizzaApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAddOrder As Button


    Friend WithEvents txtStList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkThincrust As RadioButton
    Friend WithEvents chkThickcrust As RadioButton
    Friend WithEvents chkCheesecrust As RadioButton
    Friend WithEvents chkMushroom As CheckBox
    Friend WithEvents chkPineapple As CheckBox
    Friend WithEvents chkPepperoni As CheckBox
    Friend WithEvents chkOlives As CheckBox
    Friend WithEvents chkBasil As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents dateDeldate As DateTimePicker
    Friend WithEvents txtDeltime As MaskedTextBox
    Friend WithEvents txtPhoneno As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCrustcost As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtToppingscost As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalcost As TextBox
End Class

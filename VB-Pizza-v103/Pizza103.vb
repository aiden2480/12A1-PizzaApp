Imports System.Text.RegularExpressions

Public Class Pizza103
    ' Set up a class for each order
    Class PizzaOrder
        Public orderID As Short
        Public firstName As String
        Public lastName As String
        Public phoneNo As String
        Public address As String
        Public postcode As String
        Public quantity As Byte             ' Max 255 pizzas
        Public crustType As Char            ' r for regular / t for thick / c for cheese
        Public toppings As List(Of String)
        Public deliveryDate As Date
        Public deliveryTime As String

        Public Sub New(firstName As String, lastName As String, phoneNo As String, address As String,
                       postcode As String, quantity As Byte, crustType As Char, toppings As List(Of String),
                       deliveryDate As Date, deliveryTime As String)
            Me.orderID = orders.Count() + 1
            Me.firstName = firstName
            Me.lastName = lastName
            Me.phoneNo = phoneNo
            Me.address = address
            Me.postcode = postcode
            Me.quantity = quantity
            Me.crustType = crustType
            Me.toppings = toppings
            Me.deliveryDate = deliveryDate
            Me.deliveryTime = deliveryTime
        End Sub
    End Class

    ' Establish variables
    Shared ReadOnly orders As New List(Of PizzaOrder)
    Dim crustCost As Double
    Dim toppingsCost As Double
    Dim resetting As Boolean = False

    Private Sub PizzaApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load test orders
        orders.Add(New PizzaOrder("Johnny", "Depp", "0431-994-732", "1 Kale Ave, Hollywood", "90027", 2, "c",
                                  New List(Of String) From {"mus", "pep", "ham"}, "9/6/63", "21:30"))
        orders.Add(New PizzaOrder("George", "Clooney", "0472-883-930", "480 Harvest Lane, Kansas City", "64106", 1, "r",
                                  New List(Of String) From {"pin", "pep", "oli"}, "26/10/21", "12:15"))
        orders.Add(New PizzaOrder("Jennifer", "Lawrence", "0482-774-012", "34 Strother Street, Ryde", "2112", 3, "t",
                                  New List(Of String) From {"pep", "anc"}, "8/8/21", "10:20"))
        orders.Add(New PizzaOrder("Scarlett", "Johansson", "0482-771-824", "1 Taylor Street, Glebe", "2037", 5, "t",
                                  New List(Of String) From {"mus", "pin", "ham", "anc"}, "9/10/21", "12:45"))

        ' Apply tooltips
        tipHelp.SetToolTip(txtFirstName, "Enter your first name")
        tipHelp.SetToolTip(txtLastName, "Enter your last name")
        tipHelp.SetToolTip(txtPhoneno, "Enter your phone number")
        tipHelp.SetToolTip(txtAddress, "Enter your street address (e.g. 23 Taylor street, Ryde)")
        tipHelp.SetToolTip(txtPostcode, "Enter your postcode (e.g. 2000, 4 digits max)")
        tipHelp.SetToolTip(txtQuantity, "Enter the number of pizzas you wish to order (3 digits max)")
        tipHelp.SetToolTip(dateDeldate, "Enter the desired delivery date")
        tipHelp.SetToolTip(txtDeltime, "Enter the desired delivery time in 24h (e.g. 1700)")

        tipHelp.SetToolTip(chkRegularcrust, "Standard crust size [$0.00]")
        tipHelp.SetToolTip(chkThickcrust, "Double size crust [$2.00]")
        tipHelp.SetToolTip(chkCheesecrust, "Cheese infused crust [$3.50]")

        tipHelp.SetToolTip(chkMushroom, "Add mushrooms [$0.50]")
        tipHelp.SetToolTip(chkPineapple, "Add pineapples for cheap because they belong on pizza [$0.15]")
        tipHelp.SetToolTip(chkPepperoni, "Add pepperoni [$1.00]")
        tipHelp.SetToolTip(chkHam, "Add ham [$1.00]")
        tipHelp.SetToolTip(chkAnchovies, "Add anchovies for extra because they're gross [$2.00]")
        tipHelp.SetToolTip(chkOlives, "Add olives [$0.75]")

        tipHelp.SetToolTip(txtCrustcost, "The cost of the selected crust")
        tipHelp.SetToolTip(txtToppingscost, "The cost of the selected toppings")
        tipHelp.SetToolTip(txtTotalcost, "The total cost of your pizza, $11 base plus crust and toppings. A $3 delivery fee is added too")

        ' Set the minimum date to today so we don't have to validate date
        dateDeldate.MinDate = Date.Today()

        ' Render all orders in the form box
        DisplayList()
    End Sub

    Private Sub AddOrderButtonClicked(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        ' First and last name validation
        If txtFirstName.Text = "" Then
            txtFirstName.Focus()
            MsgBox("Please enter your firstname")
            Return
        End If

        If txtLastName.Text = "" Then
            txtLastName.Focus()
            MsgBox("Please enter your lastname")
            Return
        End If

        ' Validate phone number
        ' The mask already does a decent amount for us
        If txtPhoneno.Text.Contains(" ") Then
            txtPhoneno.Focus()
            MsgBox("Please enter a valid Australian mobile phone number")
            Return
        End If

        ' Validate address
        If txtAddress.Text = "" Then
            txtAddress.Focus()
            MsgBox("Please enter the delivery address")
            Return
        End If

        ' Validate postcode
        Dim postcodeRegex = New Regex("\d{4}")
        Dim postcodeMatch = postcodeRegex.Match(txtPostcode.Text)

        If txtPostcode.Text = "" Then
            txtPostcode.Focus()
            MsgBox("Please enter a valid Australian postcode (4 digits)")
            Return
        End If

        If Not postcodeMatch.Success Then
            txtPostcode.Focus()
            MsgBox("Postcode couldn't be validated as four digits. Please recheck before submitting")
            Return
        End If

        ' Validate quantity (No more than 30 pizzas?)
        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            txtQuantity.Focus()
            MsgBox("Couldn't convert '" + txtQuantity.Text + "' to a valid non-zero integer")
            Return
        End If

        If quantity < 1 Then
            txtQuantity.Focus()
            MsgBox("You have to order at least one pizza")
            Return
        End If

        If quantity > 30 Then
            Select Case MsgBox("That's a lot of pizza, are you sure you want to order " + txtQuantity.Text + " pizzas?", MsgBoxStyle.OkCancel)
                Case MsgBoxResult.Cancel
                    txtQuantity.Focus()
                    Return
            End Select
        End If

        ' Validate order date and time
        Dim selectedDate = Date.Parse(dateDeldate.Value.ToShortDateString())
        Dim todayShort = Date.Today().ToShortDateString()
        Dim selectedTime As Date

        ' Field was blank, this is the default for some reason
        If txtDeltime.Text = "  :" Then
            txtDeltime.Focus()
            MsgBox("Please enter a delivery time for more than 20 mins from now")
            Return
        End If

        ' Try and parse the time into a valid object
        If Not Date.TryParse(todayShort + " " + txtDeltime.Text, selectedTime) Then
            txtDeltime.Focus()
            MsgBox("Couldn't convert '" + txtDeltime.Text + "' to a valid 24h time")
            Return
        End If

        ' First check if selected date is tomorrow or later, in which case we don't need to check time
        ' If it isn't we check that the time is greater than 20 mins from now
        If Not selectedDate > Date.Today() AndAlso Not selectedTime >= Date.Now().AddMinutes(19) Then
            Select Case MsgBox("Order needs to be at least 20 mins from now. Update field?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    txtDeltime.Text = Date.Now().AddMinutes(20).ToString("HH:mm")
                Case MsgBoxResult.No
                    txtDeltime.Focus()
                    Return
            End Select
        End If

        ' Check if no toppings are selected
        If ExpandToppings(CalculateToppingsCost()) = "No toppings" Then
            Select Case MsgBox("A bare cheese pizza isn't very tasty, are you sure you want to proceed with no toppings?", MsgBoxStyle.OkCancel)
                Case MsgBoxResult.Cancel
                    Return ' Stop validating to let the user change options
            End Select
        End If

        orders.Add(New PizzaOrder(txtFirstName.Text, txtLastName.Text, txtPhoneno.Text,
                                  txtAddress.Text, txtPostcode.Text, txtQuantity.Text,
                                  CalculateCrustCost(), CalculateToppingsCost(),
                                  dateDeldate.Value, txtDeltime.Text))

        ' Clear textboxes and load records
        ResetFields()
        DisplayList()

        ' Reset the cost fields
        CalculateCrustCost()
        CalculateToppingsCost()
        CalculateTotalCost()
    End Sub

    Private Sub DisplayList()
        txtStList.Items.Clear()
        Dim whitespace As New String(" ", 8)

        ' Loop through the array to print all rows
        For Each order In orders
            txtStList.Items.Add(order.orderID & " • " & order.firstName & " " & UCase(order.lastName) & " • " &
                                order.deliveryDate & " " & order.deliveryTime)
            txtStList.Items.Add(whitespace & order.address & " " & order.postcode & " • " & order.phoneNo)
            txtStList.Items.Add(whitespace & order.quantity & "x " & ExpandPizzaCode(order.crustType) & " crust • " & ExpandToppings(order.toppings))
        Next
    End Sub

    Private Sub ResetFields()
        resetting = True

        txtFirstName.ResetText()
        txtLastName.ResetText()
        txtPhoneno.ResetText()
        txtAddress.ResetText()
        txtPostcode.ResetText()
        txtQuantity.Text = "1"
        dateDeldate.ResetText()
        txtDeltime.ResetText()

        chkRegularcrust.Checked = True
        chkMushroom.Checked = False
        chkPineapple.Checked = False
        chkPepperoni.Checked = False
        chkHam.Checked = False
        chkAnchovies.Checked = False
        chkOlives.Checked = False

        resetting = False
    End Sub

    ' These functions can be used in two different contexts:
    '  1. Update cost text fields as the user changes checkboxes (from event changes)
    '  2. Concatenate text fields as required and return their values for processing 
    Private Function CalculateCrustCost() As Char
        Dim cost As Double
        Dim code As Char

        Select Case True
            Case chkRegularcrust.Checked
                code = "r"
                cost = 0
            Case chkThickcrust.Checked
                code = "t"
                cost = 2
            Case chkCheesecrust.Checked
                code = "c"
                cost = 3.5
        End Select

        crustCost = cost
        txtCrustcost.Text = FormatCurrency(cost)

        Return code
    End Function

    Private Function CalculateToppingsCost() As List(Of String)
        Dim codes As New List(Of String)
        Dim cost As Double = 0

        If chkMushroom.Checked Then
            codes.Add("mus")
            cost += 0.5
        End If
        If chkPineapple.Checked Then
            codes.Add("pin")
            cost += 0.15 ' Pineapple is cheap because it belongs on pizza
        End If
        If chkPepperoni.Checked Then
            codes.Add("pep")
            cost += 1
        End If
        If chkHam.Checked Then
            codes.Add("ham")
            cost += 1
        End If
        If chkAnchovies.Checked Then
            codes.Add("anc")
            cost += 2   ' Anchovies are gross and don't belong on pizza
        End If
        If chkOlives.Checked Then
            codes.Add("oli")
            cost += 0.75
        End If

        toppingsCost = cost
        txtToppingscost.Text = FormatCurrency(cost)

        Return codes
    End Function

    Private Function CalculateTotalCost() As Double
        Dim cost As Double = 8 ' $8 base rate for a pizza
        Dim quantity As Integer

        If Not Integer.TryParse(txtQuantity.Text, quantity) Or quantity < 1 Then
            Return 0 ' Invalid quantity field
        End If

        cost += crustCost + toppingsCost
        cost *= quantity                             ' Multiply cost by the number of pizzas
        txtTotalcost.Text = FormatCurrency(cost + 3) ' Add on delivery fees

        Return cost
    End Function

    ' Convert crust and toppings codes to their proper form
    Private Function ExpandPizzaCode(code As Char)
        Return New Dictionary(Of Char, String) From {
            {"r", "Regular"},
            {"t", "Thick"},
            {"c", "Cheesy"}
        }(code)
    End Function

    Private Function ExpandToppings(toppings As List(Of String)) As String
        Dim concat As String = ""
        Dim conv As New Dictionary(Of String, String) From {
            {"mus", "mushroom"},
            {"pin", "pineapple"},
            {"pep", "pepperoni"},
            {"ham", "ham"},
            {"anc", "anchovies"},
            {"oli", "olives"}
        }

        For Each topping In toppings
            concat += conv(topping) + ", "
        Next

        ' Deal with an edge case where the string might be empty because
        ' no toppings were selected, in which case splicing the string
        ' would break the program, so we check that the string isn't empty
        If concat <> "" Then
            concat = concat.Substring(0, concat.Length() - 2)
        End If

        Return If(concat <> "", concat, "No toppings")
    End Function

    ' Event listeners
    Private Sub CrustRadioboxChanged() Handles chkRegularcrust.CheckedChanged, chkThickcrust.CheckedChanged, chkCheesecrust.CheckedChanged
        If Not resetting Then
            CalculateCrustCost()
        End If
    End Sub

    Private Sub MushroomPineapple(sender As Object, e As EventArgs) Handles chkMushroom.CheckedChanged, chkPineapple.CheckedChanged
        If Not resetting Then
            CalculateToppingsCost()
        End If
    End Sub

    Private Sub PepperoniHam(sender As Object, e As EventArgs) Handles chkPepperoni.CheckedChanged, chkHam.CheckedChanged
        If Not resetting Then
            CalculateToppingsCost()
        End If
    End Sub

    Private Sub AnchoviesOlives(sender As Object, e As EventArgs) Handles chkAnchovies.CheckedChanged, chkOlives.CheckedChanged
        If Not resetting Then
            CalculateToppingsCost()
        End If
    End Sub

    Private Sub SubtotalChanged(sender As Object, e As EventArgs) Handles txtCrustcost.TextChanged, txtToppingscost.TextChanged
        If Not resetting Then
            CalculateTotalCost()
        End If
    End Sub

    Private Sub QuantityChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        If Not resetting Then
            CalculateTotalCost()
        End If
    End Sub
End Class

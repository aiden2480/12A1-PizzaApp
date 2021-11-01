Public Class Pizza102
    ' Set up a class for each order
    Class PizzaOrder
        Public orderID As Short
        Public firstName As String
        Public lastName As String
        Public phoneNo As String
        Public address As String
        Public postcode As String
        Public quantity As Byte             ' Max 255 pizzas
        Public crustType As Char            ' t for thin / T for thick / c for cheese
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
    Shared orders As New List(Of PizzaOrder)
    Dim crustCost As Decimal
    Dim toppingsCost As Decimal

    Private Sub PizzaApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load test orders
        orders.Add(New PizzaOrder("Johnny", "Depp", "0431994732", "1 Kale Ave, Hollywood", "90027", 2, "c",
                                  New List(Of String) From {"mus", "pep", "ham"}, "9/6/63", "21:30"))
        orders.Add(New PizzaOrder("George", "Clooney", "0472883930", "480 Harvest Lane, Kansas City", "64106", 1, "T",
                                  New List(Of String) From {"pin", "pep", "oli"}, "26/10/21", "12:15"))
        orders.Add(New PizzaOrder("Jennifer", "Lawrence", "0482774012", "34 Strother Street, Ryde", "2112", 3, "t",
                                  New List(Of String) From {"pep", "anc"}, "8/8/21", "10:20"))
        orders.Add(New PizzaOrder("Scarlett", "Johansson", "0482771824", "1 Taylor Street, Glebe", "2037", 5, "t",
                                  New List(Of String) From {"mus", "pin", "ham", "anc"}, "9/10/21", "12:45"))

        ' Apply tooltips
        tipHelp.SetToolTip(txtFirstName, "Enter your first name")
        tipHelp.SetToolTip(txtLastName, "Enter your last name")
        tipHelp.SetToolTip(txtPhoneno, "Enter your phone number") ' TODO fix phone number mask
        tipHelp.SetToolTip(txtAddress, "Enter your street address (e.g. 23 Taylor street, Ryde)")
        tipHelp.SetToolTip(txtPostcode, "Enter your postcode (e.g. 2000)")
        tipHelp.SetToolTip(txtQuantity, "Enter the number of pizzas you wish to order")
        tipHelp.SetToolTip(dateDeldate, "Enter the desired delivery date")
        tipHelp.SetToolTip(txtDeltime, "Enter the desired delivery time in 24h (e.g. 1700)")

        tipHelp.SetToolTip(chkRegularcrust, "Standard crust size [$0.00]")
        tipHelp.SetToolTip(chkThickcrust, "Double size crust [$2.00]")
        tipHelp.SetToolTip(chkCheesecrust, "Cheese infused crust [$3.50]")

        tipHelp.SetToolTip(chkMushroom, "Add mushrooms [$0.50]")
        tipHelp.SetToolTip(chkPineapple, "Add pineapples free of charge because they belong on pizza [$0.00]")
        tipHelp.SetToolTip(chkPepperoni, "Add pepperoni [$1.00]")
        tipHelp.SetToolTip(chkHam, "Add ham [$1.00]")
        tipHelp.SetToolTip(chkAnchovies, "Add anchovies for extra because they're gross [$2.00]")
        tipHelp.SetToolTip(chkOlives, "Add olives [$0.75]")

        tipHelp.SetToolTip(txtCrustcost, "The cost of the selected crust")
        tipHelp.SetToolTip(txtToppingscost, "The cost of the selected toppings")
        tipHelp.SetToolTip(txtTotalcost, "The total cost of your pizza, $11 base plus crust and toppings. A $3 delivery fee is added too")

        ' Render all orders in the form box
        DisplayList()
    End Sub

    Private Sub AddOrderButtonClicked(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        ' TODO Grab crust type and toppings
        orders.Add(New PizzaOrder(txtFirstName.Text, txtLastName.Text, txtPhoneno.Text,
                                  txtAddress.Text, txtPostcode.Text, txtQuantity.Text,
                                  "t", New List(Of String) From {"mus", "pep", "pan"},
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

        ' Loop through the array to print all rows
        For i = 0 To orders.Count() - 1
            txtStList.Items.Add(orders(i).orderID & " - " & orders(i).firstName & " - " &
                                UCase(orders(i).lastName) & " - " & orders(i).deliveryDate & " - " &
                                orders(i).postcode & " - " & orders(i).quantity)
        Next
    End Sub

    Private Sub ResetFields()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhoneno.Text = ""
        txtAddress.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = ""
        dateDeldate.Text = ""
        txtDeltime.Text = ""

        chkRegularcrust.Checked = True
        chkMushroom.Checked = False
        chkPineapple.Checked = False
        chkPepperoni.Checked = False
        chkHam.Checked = False
        chkAnchovies.Checked = False
        chkOlives.Checked = False
    End Sub

    ' Events fire from checkboxes and radio buttons being updated
    Private Sub CalculateCrustCost() Handles chkRegularcrust.CheckedChanged, chkThickcrust.CheckedChanged, chkCheesecrust.CheckedChanged
        Dim cost As Decimal

        Select Case True
            Case chkRegularcrust.Checked
                cost = 0
            Case chkThickcrust.Checked
                cost = 2
            Case chkCheesecrust.Checked
                cost = 3.5
        End Select

        crustCost = cost
        txtCrustcost.Text = FormatCurrency(cost)
    End Sub

    Private Sub CalculateToppingsCost()
        Dim cost As Decimal = 0

        If chkMushroom.Checked Then
            cost += 0.5
        End If
        If chkPineapple.Checked Then
            cost += 0   ' Pineapple is free because it belongs on pizza
        End If
        If chkPepperoni.Checked Then
            cost += 1
        End If
        If chkHam.Checked Then
            cost += 1
        End If
        If chkAnchovies.Checked Then
            cost += 2   ' Anchovies are gross and don't belong on pizza
        End If
        If chkOlives.Checked Then
            cost += 0.75
        End If

        toppingsCost = cost
        txtToppingscost.Text = FormatCurrency(cost)
    End Sub

    Private Sub CalculateTotalCost()
        Dim cost As Decimal = 8 ' $8 base rate for a pizza

        cost += crustCost + toppingsCost
        cost *= Convert.ToDecimal(If(IsNumeric(txtQuantity.Text), txtQuantity.Text, 0)) ' Multiply cost by the number of pizzas
        txtTotalcost.Text = FormatCurrency(cost + 3) ' Add on delivery fees
    End Sub

    ' Event listeners
    Private Sub MushroomChecked(sender As Object, e As EventArgs) Handles chkMushroom.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub PineappleChecked(sender As Object, e As EventArgs) Handles chkPineapple.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub PepperoniChecked(sender As Object, e As EventArgs) Handles chkPepperoni.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub HamChecked(sender As Object, e As EventArgs) Handles chkHam.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub AnchoviesChecked(sender As Object, e As EventArgs) Handles chkAnchovies.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub OlivesChecked(sender As Object, e As EventArgs) Handles chkOlives.CheckedChanged
        CalculateToppingsCost()
    End Sub

    Private Sub CrustCostChanged(sender As Object, e As EventArgs) Handles txtCrustcost.TextChanged
        CalculateTotalCost()
    End Sub

    Private Sub ToppingsCostChanged(sender As Object, e As EventArgs) Handles txtToppingscost.TextChanged
        CalculateTotalCost()
    End Sub

    Private Sub QuantityChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        If IsNumeric(txtQuantity.Text) Then
            CalculateTotalCost()
        End If
    End Sub
End Class

Public Class Pizza101
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

        ' Render all orders in the form box
        displayList()
    End Sub

    Private Sub addOrderButtonClicked(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        ' TODO Grab crust type and toppings
        orders.Add(New PizzaOrder(txtFirstName.Text, txtLastName.Text, txtPhoneno.Text,
                                  txtAddress.Text, txtPostcode.Text, txtQuantity.Text,
                                  "t", New List(Of String) From {"mus", "pep", "pan"},
                                  dateDeldate.Value, txtDeltime.Text))

        ' Clear textboxes and load records
        resetFields()
        displayList()
    End Sub

    Private Sub displayList()
        txtStList.Items.Clear()

        ' Loop through the array to print all rows
        For i = 0 To orders.Count() - 1
            txtStList.Items.Add(orders(i).orderID & " - " & orders(i).firstName & " - " &
                                UCase(orders(i).lastName) & " - " & orders(i).deliveryDate & " - " &
                                orders(i).postcode & " - " & orders(i).quantity)
        Next
    End Sub

    Private Sub resetFields()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhoneno.Text = ""
        txtAddress.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = ""
        dateDeldate.Text = ""
        txtDeltime.Text = ""

        chkThincrust.Checked = True
        chkMushroom.Checked = False
        chkPineapple.Checked = False
        chkPepperoni.Checked = False
        chkHam.Checked = False
        chkAnchovies.Checked = False
        chkOlives.Checked = False
    End Sub
End Class

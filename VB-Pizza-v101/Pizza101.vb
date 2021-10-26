Public Class Pizza101
    ' Set up a class for each order
    Class PizzaOrder
        Public orderID As Short
        Public firstName As String
        Public lastName As String
        Public deliveryDate As Date
        Public deliveryTime As String
        Public postcode As String
        Public quantity As Byte       ' Max 255 pizzas
    End Class

    Dim orders(9) As PizzaOrder
    Dim orderCount As Integer = 0

    Private Sub PizzaApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Allocate memory
        For i = 0 To 9
            orders(i) = New PizzaOrder
        Next

        ' Load 4 test records
        orders(0).orderID = 1
        orders(0).firstName = "Johnny"
        orders(0).lastName = "Depp"
        orders(0).deliveryDate = "9/6/63"
        orders(0).postcode = "m"
        orders(0).quantity = 78.2

        orders(1).orderID = 2
        orders(1).firstName = "Jennifer"
        orders(1).lastName = "Lawrence"
        orders(1).deliveryDate = "15/8/90"
        orders(1).postcode = "f"
        orders(1).quantity = 88.2

        orders(2).orderID = 3
        orders(2).firstName = "George"
        orders(2).lastName = "Clooney"
        orders(2).deliveryDate = "6/5/61"
        orders(2).postcode = "m"
        orders(2).quantity = 68.2

        orders(3).orderID = 4
        orders(3).firstName = "Scarlett"
        orders(3).lastName = "Johansson"
        orders(3).deliveryDate = "22/11/84"
        orders(3).postcode = "f"
        orders(3).quantity = 72.2

        ' Set the order count to the number of orders which have been entered
        orderCount = 4
        displayList()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        orders(orderCount).orderID = orderCount + 1 ' Allocate the new order ID to an incremented value

        ' Place text from text boxes into the array - first orders(0), then orders(1), orders(2) etc
        orders(orderCount).firstName = txtFirstName.Text
        orders(orderCount).lastName = txtLastName.Text
        orders(orderCount).deliveryDate = dateDeldate.Text
        orders(orderCount).deliveryTime = txtDeltime.Text
        orders(orderCount).postcode = txtPostcode.Text
        orders(orderCount).quantity = txtQuantity.Text
        orderCount += 1

        ' Clear textboxes
        txtFirstName.Text = ""
        txtLastName.Text = ""
        dateDeldate.Text = ""
        txtDeltime.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = ""

        ' Load all records
        displayList()
    End Sub

    Private Sub displayList()
        txtStList.Items.Clear()

        ' Loop through the array to print all rows
        For i = 0 To orderCount - 1
            txtStList.Items.Add(orders(i).orderID & " - " & orders(i).firstName & " - " &
                                UCase(orders(i).lastName) & " - " & orders(i).deliveryDate & " - " &
                                orders(i).postcode & " - " & orders(i).quantity)
        Next
    End Sub
End Class

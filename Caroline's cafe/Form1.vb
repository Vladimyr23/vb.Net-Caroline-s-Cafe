Public Class Cafe
    'global variable
    Dim total As Decimal

    'Initial Listview's settings
    Private Sub Cafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total = 0
        With ListView1
            .View = View.Details
            .CheckBoxes = False
            .GridLines = True
            .Columns.Add("Item", 240, HorizontalAlignment.Left)
            .Columns.Add("Price", 48, HorizontalAlignment.Center)
            .FullRowSelect = True
        End With

        With ListView2
            .View = View.Details
            .CheckBoxes = False
            .GridLines = True
            .Columns.Add("Item", 240, HorizontalAlignment.Left)
            .Columns.Add("Price", 48, HorizontalAlignment.Center)
            .FullRowSelect = True
        End With

    End Sub

    'Button to display Main Course selection
    Private Sub btnMainCourse_Click(sender As Object, e As EventArgs) Handles btnMainCourse.Click

        ListView1.Items.Clear()
        Dim mainDishList() As String = New String() {"Egg & Bacon", "Ribeye Steak & Potato",
            "Meatballs & Mashed Potatoes", "Chicken Chilli & Rice", "Chicken Korma & Rice",
            "Cottage Pie"}
        Dim mainDishPrice() As String = New String() {"2.09", "3.09",
            "2.59", "1.49", "1.49", "1.89"}
        Dim count As Integer
        For count = 0 To mainDishList.Length - 1
            Dim listItem As New ListViewItem(mainDishList(count))
            listItem.SubItems.Add(mainDishPrice(count))
            ListView1.Items.Add(listItem)
        Next
        Controls.Add(ListView1)
    End Sub

    'Button to display Burgers selection
    Private Sub btnBurgers_Click(sender As Object, e As EventArgs) Handles btnBurgers.Click

        ListView1.Items.Clear()
        Dim burgersList() As String = New String() {"Beef Burger", "Chicken Burger",
            "Coronation Chicken Burger", "Egg & Bacon Burger", "Salad & Ham Burger",
            "Cheese Burger", "Salad & Smoked Salmon Burger"}
        Dim burgersPrice() As String = New String() {"2.09", "1.59",
            "1.59", "1.49", "1.49", "1.49", "2.49"}
        Dim count As Integer
        For count = 0 To burgersList.Length - 1
            Dim listItem As New ListViewItem(burgersList(count))
            listItem.SubItems.Add(burgersPrice(count))
            ListView1.Items.Add(listItem)
        Next
        Controls.Add(ListView1)
    End Sub

    'Button to display Salads selection
    Private Sub btnSalads_Click(sender As Object, e As EventArgs) Handles btnSalads.Click

        ListView1.Items.Clear()
        Dim saladList() As String = New String() {"Caesar Salad", "Crisp & Leaf Salad",
            "Lettuce Salad", "Crispy Salad", "Coleslow Salad",
            "Potato Salad"}
        Dim saladPrice() As String = New String() {"1.59", "1.09",
            "1.09", "1.09", "1.09", "1.09", "1.09"}
        Dim count As Integer
        For count = 0 To saladList.Length - 1
            Dim listItem As New ListViewItem(saladList(count))
            listItem.SubItems.Add(saladPrice(count))
            ListView1.Items.Add(listItem)
        Next
        Controls.Add(ListView1)
    End Sub

    'Button to display Desserts selection
    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click

        ListView1.Items.Clear()
        Dim dessertsList() As String = New String() {"New York Cheesecake", "Strawberry Trifle",
            "Apple Pie", "Eclaire", "Ice-cream",
            "Cupcake"}
        Dim dessertsPrice() As String = New String() {"1.39", "1.39",
            "1.39", "1.39", "1.39", "1.39"}
        Dim count As Integer
        For count = 0 To dessertsList.Length - 1
            Dim listItem As New ListViewItem(dessertsList(count))
            listItem.SubItems.Add(dessertsPrice(count))
            ListView1.Items.Add(listItem)
        Next
        Controls.Add(ListView1)
    End Sub

    'Button to display drinks selection
    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click

        ListView1.Items.Clear()
        Dim drinksList() As String = New String() {"Cola", "Diet Cola",
            "Black Coffee", "Coffee Capuchino", "Coffee Espresso",
            "Tea"}
        Dim drinksPrice() As String = New String() {"1.00", "1.00",
            "1.39", "1.59", "1.59", "1.19"}
        Dim count As Integer
        For count = 0 To drinksList.Length - 1
            Dim listItem As New ListViewItem(drinksList(count))
            listItem.SubItems.Add(drinksPrice(count))
            ListView1.Items.Add(listItem)
        Next
        Controls.Add(ListView1)
    End Sub

    'Subprogram to add item into the second list and calculate the total price
    Private Sub AddItemToSecondList(ByVal item As ListViewItem)
        ' NOTE: We separate this part into its own method so that 
        ' items can be added to the second list by other means 
        ' (such as an "Add to Purchase" button)

        ' ALSO NOTE: Depending on your requirements, you may want to 
        ' add a check in your code here or elsewhere to prevent 
        ' adding an item more than once.
        Me.ListView2.Items.Add(item.Clone())
        total += Double.Parse(item.SubItems(1).Text)
        lblTotal.Text = "Total: £" & total

    End Sub

    'Double click item check and adding it into the order list
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick

        ' Use the HitTest method to grab a reference to the item which was
        ' double-clicked. Note that if the user double-clicks in an empty
        ' area of the list, the HitTestInfo.Item will be Nothing (which is what 
        ' what we would want to happen):
        Dim info As ListViewHitTestInfo = Me.ListView1.HitTest(e.X, e.Y)

        'Get a reference to the item:
        Dim item As ListViewItem = info.Item

        ' Make sure an item was the trget of the double-click:
        If Not item Is Nothing Then
            Me.AddItemToSecondList(item)
        End If
    End Sub

    'Button to clear the order list
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListView2.Items.Clear()
        total = 0
        lblTotal.Text = "Total:"
    End Sub

    'Button to Exit the app
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        MsgBox("Thank you!", MsgBoxStyle.OkOnly, "Bon Appetite")
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        total = 0
        lblTotal.Text = "Total:"
    End Sub
End Class

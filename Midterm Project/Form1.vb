' Hector Mojica
' 15 October 2020
' Midterm Project

Public Class Form1
    ' Declare global variables
    Dim Clicked = False
    Dim dblTotalPrice As Double = 0
    Const dblDiscount As Double = 0.05
    Dim qtyBags As Integer = 0
    Dim cstBags As Double = 0.0

    ' Declares the items for each category with arrays and their prices in a separate array
    Public Milk() As String = {"Whole Milk - $3.29",
                                "Nonfat Milk - $2.19",
                                "1% Milk - $3.19",
                                "2% Milk - $3.19",
                                "Almond Milk - $5.19",
                                "Cashew Milk - $3.89",
                                "Chocolate Milk - $6.29"}
    Dim MilkPrices() As Double = {3.29, 2.19, 3.19, 3.19, 5.19, 3.89, 6.29}

    Public Eggs() As String = {"Vital Farms Pasture Raised(12 count) - $6.29",
                                "SB Grade AA Large Eggs(18 count) - $4.19",
                                "SB Grade AA Large Eggs(12 count) - $3.19",
                                "SB Cage Free Large Brown Eggs(12 count) - $3.69",
                                "Valu Time Large White Eggs(60 count) - $13.59"}
    Dim EggPrices() As Double = {6.29, 4.19, 3.19, 3.69, 13.59}

    Public Vegetables() As String = {"White Onion (1lb) - $0.99",
                                      "Roma Tomato (1lb) - $0.99",
                                      "Jalapeño Pepper (1lb) - $0.99",
                                      "Iceberg Lettuce - $1.69",
                                      "Russet Potato (1lb) - $0.99",
                                      "Cucumber (1lb) - $0.99",
                                      "White Sweet Corn - $0.69",
                                      "Carrot (1lb) - $0.99"}
    Dim VegetablePrices = {0.99, 0.99, 0.99, 1.69, 0.99, 0.99, 0.69, 0.99}

    Public Fruits() As String = {"Bananas (1lb) - $0.69",
                                  "Strawberries(1lb container) - $3.69",
                                  "Granny Smith Apple (1lb) - $0.99",
                                  "Avocado - $0.99",
                                  "Lemon - $0.79",
                                  "Red Mango - $1.25",
                                  "Navel Oranges (1lb) - $1.29"}
    Dim FruitPrices() As Double = {0.69, 3.69, 0.99, 0.99, 0.79, 1.25, 1.29}

    Public Meat() As String = {"80% Lean 20% Fat Ground Beef (1lb) - $6.29",
                               "85% Lean 15% Fat Ground Beef (1lb) - $6.79",
                               "93% Lean 7% Fat Ground Beef (1lb) - $7.29"}
    Dim MeatPrices() As Double = {6.29, 6.79, 7.29}

    Public Water() As String = {"Stater Bros. Pure Water (24 x 16.9 fl oz) - $3.19",
                                "Stater Bros. Pure Water (28 x 20 fl oz) - $4.19",
                                "Stater Bros. Pure Water (35 x 16.9 fl oz) - $4.19",
                                "Arrowhead 100% Natural Spring Water (24 x 16.9 fl oz) - $4.69",
                                "Crystal Geyser Water (35 x 16.9 fl oz) - $5.69"}
    Dim WaterPrices() As Double = {3.19, 4.19, 4.19, 4.69, 5.69}

    Public Bread() As String = {"Stater Bros. Wheat Bread (24 oz) - $1.99",
                                "Stater Bros. White Bread (24 oz) - $1.99",
                                "Stater Bros. Artisan Bread (22 oz) - $1.99"}
    Dim BreadPrices() As Double = {1.99, 1.99, 1.99}

    'SubProcedure that when called will fill the CheckedListBox that was passed to it, using the respective array
    Public Sub PopulateComboBox(ByRef cmbBox As CheckedListBox, ByRef strItem() As String)
        For Each i As String In strItem
            cmbBox.Items.Add(i)
        Next
    End Sub

    ' Subprocedure that when called will incrementally step through each check box to search for any checked boxes and will then pass its respective price to dblprice
    ' and will also write the item to Receipt.txt
    Public Sub CheckBoxes(ByVal CheckedListBox As CheckedListBox, ByVal Prices() As Double, ByRef dblTotal As Double, ByRef outFile As IO.StreamWriter)
        For j As Integer = 0 To CheckedListBox.Items.Count - 1
            Dim Item As String = CheckedListBox.Items(j)
            If CheckedListBox.GetItemChecked(j) Then
                dblTotalPrice += Prices(j)
                outFile.WriteLine(CheckedListBox.Items(j))
            End If
        Next
    End Sub

    ' Code for closing the program when File->Exit is selected
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Dim i as counter and open the Receipt.txt file for outputting
        Dim outFile As IO.StreamWriter
        Dim i As Integer = 0


        ' If btnSave is clicked again, this If clause will reset dblTotalPrice, delete any past Receipt.txt, and set Clicked to False
        If Clicked = True Then
            dblTotalPrice *= 0
            IO.File.Delete("Receipt.txt")
            Clicked = False

        End If

        outFile = IO.File.CreateText("Receipt.txt")

        ' If clause that will trigger a dialog box that remind the user to completely fill out the form
        ' if txtFirstName Or txtLastName are empty
        If txtFirstName.Text.Trim <> String.Empty AndAlso txtLastName.Text.Trim <> String.Empty Then

            ' Writes the First and Last names to Receipt, uses .Trim to eliminate any surrounding spaces
            outFile.WriteLine(txtFirstName.Text.Trim & " " & txtLastName.Text.ToString.Trim & vbNewLine)

            ' Calls the CheckBoxes Subprocedure to check which items the user selected and writes them to Receipt.txt
            ' While also adding the prices To dblTotalPrice
            CheckBoxes(cboMilk, MilkPrices, dblTotalPrice, outFile)
            CheckBoxes(cboEggs, EggPrices, dblTotalPrice, outFile)
            CheckBoxes(cboVegetables, VegetablePrices, dblTotalPrice, outFile)
            CheckBoxes(cboFruits, FruitPrices, dblTotalPrice, outFile)
            CheckBoxes(cboMeat, MeatPrices, dblTotalPrice, outFile)
            CheckBoxes(cboWater, WaterPrices, dblTotalPrice, outFile)
            CheckBoxes(cboBread, BreadPrices, dblTotalPrice, outFile)

            ' If clause that either writes 0 bags to Receipt.txt
            If rdbNone.Checked Or txtBags.Text = "0" Then

                outFile.WriteLine("0 Bags" & vbNewLine)

                ' Else it will add the cost of the bags to dblTotalPrice and write how many bags and cost to Receipt.txt
            Else

                Integer.TryParse(txtBags.Text, qtyBags)
                cstBags = qtyBags * 0.1
                outFile.WriteLine(txtBags.Text & " Bags - " & cstBags.ToString("C2") & vbNewLine)

                Do Until i = qtyBags
                    dblTotalPrice += 0.1
                    i += 1
                Loop

            End If

            ' Will either discount dblTotalPrice by 5% and show "Discount Appleid." if rdbPickup is checked or do nothing if rdbInstacart is checked
            If rdbPickup.Checked Then
                dblTotalPrice -= (dblTotalPrice * dblDiscount)
                lblDiscountApplied.Visible = True
            Else
                dblTotalPrice = dblTotalPrice
                lblDiscountApplied.Visible = False
            End If

            ' Outputs dblTotalPrice to txtTotal, using Currency format to 2 decimal places
            txtTotal.Text = dblTotalPrice.ToString("C2")

            ' Writes txtTotal.Text to Receipt.txt
            outFile.WriteLine("Your total is: " & txtTotal.Text)

            ' If rdbInstaCard is checked then receipt will say "Instacart"
            If rdbInstaCart.Checked Then
                outFile.WriteLine("               Instacart" & vbNewLine)

                ' Else it will display "Pickup: -5% Discount"
            Else
                outFile.WriteLine("       Pickup: -5% Discount" & vbNewLine)
            End If

            ' Writes thank you message to Receipt.txt
            outFile.WriteLine("Thank you for shopping at Stater Bros. Markets.")

            MessageBox.Show("Your receipt has been saved to your files" & vbNewLine & "(Midterm Project\bin\Debug)",
                            "Stater Bros. Markets", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            ' Message box reminding user to completely fill all fields
            MessageBox.Show("Please complete all of the fields.", "Stater Bros. Markets",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Closes output file
        outFile.Close()

        ' Sets Clicked flag to True
        Clicked = True
    End Sub

    ' Closes program when btnExit is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'Selects all text in txtFirstName when the text box is clicked
    Private Sub txtFirstName_Click(sender As Object, e As EventArgs) Handles txtFirstName.Click
        txtFirstName.SelectAll()
    End Sub

    'Selects all text in txtLasttName when the text box is clicked
    Private Sub txtLastName_Click(sender As Object, e As EventArgs) Handles txtLastName.Click
        txtLastName.SelectAll()
    End Sub

    'Populates all of the Checked List Boxes when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateComboBox(cboMilk, Milk)
        PopulateComboBox(cboEggs, Eggs)
        PopulateComboBox(cboVegetables, Vegetables)
        PopulateComboBox(cboFruits, Fruits)
        PopulateComboBox(cboMeat, Meat)
        PopulateComboBox(cboWater, Water)
        PopulateComboBox(cboBread, Bread)
    End Sub

    ' Allows only Letters, spaces, backspaces, and hyphens to be entered into txtFirstName
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    ' Allows only Letters, spaces, backspaces, and hyphens to be entered into txtLastName
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class

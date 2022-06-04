Public Class Form1

    Dim buttoncheck As Boolean 'Variable to perform buttons check If it is X or O.
    Dim addpoint As Integer 'Variable to store score count.
    Dim row As Integer = 0 'Variable to indicate the row of the text to save and load using .txt file.
    Dim details(2, 3) As String 'Variable to indicate the details of the text to be saved and loaded from .txt file.
    Dim countclicks As Integer = 0 'Variable to store number of the clicks which will help define the draw
    Dim addtie As Integer 'Variable to store the number of draws.





    Private Sub Enable_False()
        Bt1.Enabled = False
        Bt2.Enabled = False
        Bt3.Enabled = False
        Bt4.Enabled = False
        Bt5.Enabled = False
        Bt6.Enabled = False
        Bt7.Enabled = False
        Bt8.Enabled = False
        Bt9.Enabled = False
        ' This function will prevent all of the buttons to be used in case of winning 

    End Sub


    Private Sub Score()


        'This function will display image "YOUR MOVE" in appropriate pictrue box and clear the pictrue box of the opponent 
        If buttoncheck = True Then
            OPicBox.Image = Bitmap.FromFile("your move.png")
            XPicBox.Image = Nothing
        Else
            XPicBox.Image = Bitmap.FromFile("your move.png")
            OPicBox.Image = Nothing
            ' 
        End If

        'Player "X" win function for every possible combination. In the event of winning, the buttons will change the colour. After the wiininf oposite player
        'move image will be displayed in the poctrue box
        If (Bt1.Text = "X" And Bt2.Text = "X" And Bt3.Text = "X") Then
            Bt1.BackColor = System.Drawing.Color.DarkRed
            Bt2.BackColor = System.Drawing.Color.DarkRed
            Bt3.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text) 'Function to convert integer to 64 bit system
            Xlbl.Text = Convert.ToString(addpoint + 1) 'Funciton to convert it ot string and add point in the case of winning 
            Enable_False() 'Function recall


        ElseIf (Bt4.Text = "X" And Bt5.Text = "X" And Bt6.Text = "X") Then
            Bt4.BackColor = System.Drawing.Color.DarkRed
            Bt5.BackColor = System.Drawing.Color.DarkRed
            Bt6.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt7.Text = "X" And Bt8.Text = "X" And Bt9.Text = "X") Then
            Bt7.BackColor = System.Drawing.Color.DarkRed
            Bt8.BackColor = System.Drawing.Color.DarkRed
            Bt9.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt1.Text = "X" And Bt4.Text = "X" And Bt7.Text = "X") Then
            Bt1.BackColor = System.Drawing.Color.DarkRed
            Bt4.BackColor = System.Drawing.Color.DarkRed
            Bt7.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt2.Text = "X" And Bt5.Text = "X" And Bt8.Text = "X") Then
            Bt2.BackColor = System.Drawing.Color.DarkRed
            Bt5.BackColor = System.Drawing.Color.DarkRed
            Bt8.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt3.Text = "X" And Bt6.Text = "X" And Bt9.Text = "X") Then
            Bt3.BackColor = System.Drawing.Color.DarkRed
            Bt6.BackColor = System.Drawing.Color.DarkRed
            Bt9.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt7.Text = "X" And Bt5.Text = "X" And Bt3.Text = "X") Then
            Bt7.BackColor = System.Drawing.Color.DarkRed
            Bt5.BackColor = System.Drawing.Color.DarkRed
            Bt3.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt1.Text = "X" And Bt5.Text = "X" And Bt9.Text = "X") Then
            Bt1.BackColor = System.Drawing.Color.DarkRed
            Bt5.BackColor = System.Drawing.Color.DarkRed
            Bt9.BackColor = System.Drawing.Color.DarkRed
            XPicBox.Image = Bitmap.FromFile("you win.png")
            OPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Xlbl.Text)
            Xlbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


            'Player "O"
        ElseIf (Bt1.Text = "O" And Bt2.Text = "O" And Bt3.Text = "O") Then
            Bt1.BackColor = System.Drawing.Color.NavajoWhite
            Bt2.BackColor = System.Drawing.Color.NavajoWhite
            Bt3.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt4.Text = "O" And Bt5.Text = "O" And Bt6.Text = "O") Then
            Bt4.BackColor = System.Drawing.Color.NavajoWhite
            Bt5.BackColor = System.Drawing.Color.NavajoWhite
            Bt6.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt7.Text = "O" And Bt8.Text = "O" And Bt9.Text = "O") Then
            Bt7.BackColor = System.Drawing.Color.NavajoWhite
            Bt8.BackColor = System.Drawing.Color.NavajoWhite
            Bt9.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt1.Text = "O" And Bt4.Text = "O" And Bt7.Text = "O") Then
            Bt1.BackColor = System.Drawing.Color.NavajoWhite
            Bt4.BackColor = System.Drawing.Color.NavajoWhite
            Bt7.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt2.Text = "O" And Bt5.Text = "O" And Bt8.Text = "O") Then
            Bt2.BackColor = System.Drawing.Color.NavajoWhite
            Bt5.BackColor = System.Drawing.Color.NavajoWhite
            Bt8.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt3.Text = "O" And Bt6.Text = "O" And Bt9.Text = "O") Then
            Bt3.BackColor = System.Drawing.Color.NavajoWhite
            Bt6.BackColor = System.Drawing.Color.NavajoWhite
            Bt9.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt7.Text = "O" And Bt5.Text = "O" And Bt3.Text = "O") Then
            Bt7.BackColor = System.Drawing.Color.NavajoWhite
            Bt5.BackColor = System.Drawing.Color.NavajoWhite
            Bt3.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()


        ElseIf (Bt1.Text = "O" And Bt5.Text = "O" And Bt9.Text = "O") Then
            Bt1.BackColor = System.Drawing.Color.NavajoWhite
            Bt5.BackColor = System.Drawing.Color.NavajoWhite
            Bt9.BackColor = System.Drawing.Color.NavajoWhite
            OPicBox.Image = Bitmap.FromFile("you win.png")
            XPicBox.Image = Nothing
            addpoint = Convert.ToInt64(Olbl.Text)
            Olbl.Text = Convert.ToString(addpoint + 1)
            Enable_False()

        Else
            'If above conditions are not filled then Tie will be added to the score board and "TIE" image will be displayed in both picture boxes
            If countclicks = 9 Then
                OPicBox.Image = Image.FromFile("tie.png")
                XPicBox.Image = Image.FromFile("tie.png")

                addtie = Convert.ToInt64(TieCount.Text)
                TieCount.Text = Convert.ToString(addtie + 1)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '"YOUR MOVE" will be displayed at the begining of the first game in the player X pictrue box
        XPicBox.Image = Bitmap.FromFile("your move.png")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ResetBt.Click
        'Reset button will erase all of the buttons, enable them, erase score boards, erase the clicks counter, bring the original colour to the buttons,
        'and display which player turn is next.
        Bt1.Enabled = True
        Bt2.Enabled = True
        Bt2.Enabled = True
        Bt3.Enabled = True
        Bt4.Enabled = True
        Bt5.Enabled = True
        Bt6.Enabled = True
        Bt7.Enabled = True
        Bt8.Enabled = True
        Bt9.Enabled = True

        Bt1.Text = ""
        Bt2.Text = ""
        Bt3.Text = ""
        Bt4.Text = ""
        Bt5.Text = ""
        Bt6.Text = ""
        Bt7.Text = ""
        Bt8.Text = ""
        Bt9.Text = ""

        Xlbl.Text = "0"
        Olbl.Text = "0"
        TieCount.Text = "0"

        Bt1.BackColor = Color.LemonChiffon
        Bt2.BackColor = Color.LemonChiffon
        Bt3.BackColor = Color.LemonChiffon
        Bt4.BackColor = Color.LemonChiffon
        Bt5.BackColor = Color.LemonChiffon
        Bt6.BackColor = Color.LemonChiffon
        Bt7.BackColor = Color.LemonChiffon
        Bt8.BackColor = Color.LemonChiffon
        Bt9.BackColor = Color.LemonChiffon

        XPicBox.Image = Nothing
        OPicBox.Image = Nothing

        If buttoncheck = True Then
            OPicBox.Image = Bitmap.FromFile("your move.png")
        Else
            XPicBox.Image = Bitmap.FromFile("your move.png")
        End If

        countclicks = 0

    End Sub

    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click
        'Function for each button to check if button is enabled, call the click counter function and add click, 
        'check for win and disable button after the click
        If (buttoncheck = False) Then
            Bt1.Text = "X"
            buttoncheck = True
        Else
            Bt1.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt1.Enabled = False
    End Sub

    Private Sub Bt2_Click(sender As Object, e As EventArgs) Handles Bt2.Click
        If (buttoncheck = False) Then
            Bt2.Text = "X"
            buttoncheck = True
        Else
            Bt2.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt2.Enabled = False
    End Sub

    Private Sub Bt3_Click(sender As Object, e As EventArgs) Handles Bt3.Click
        If (buttoncheck = False) Then
            Bt3.Text = "X"
            buttoncheck = True
        Else
            Bt3.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt3.Enabled = False
    End Sub

    Private Sub Bt4_Click(sender As Object, e As EventArgs) Handles Bt4.Click
        If (buttoncheck = False) Then
            Bt4.Text = "X"
            buttoncheck = True
        Else
            Bt4.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt4.Enabled = False
    End Sub

    Private Sub Bt5_Click(sender As Object, e As EventArgs) Handles Bt5.Click
        If (buttoncheck = False) Then
            Bt5.Text = "X"
            buttoncheck = True
        Else
            Bt5.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt5.Enabled = False
    End Sub

    Private Sub Bt6_Click(sender As Object, e As EventArgs) Handles Bt6.Click
        If (buttoncheck = False) Then
            Bt6.Text = "X"
            buttoncheck = True
        Else
            Bt6.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt6.Enabled = False
    End Sub

    Private Sub Bt7_Click(sender As Object, e As EventArgs) Handles Bt7.Click
        If (buttoncheck = False) Then
            Bt7.Text = "X"
            buttoncheck = True
        Else
            Bt7.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt7.Enabled = False
    End Sub

    Private Sub Bt8_Click(sender As Object, e As EventArgs) Handles Bt8.Click
        If (buttoncheck = False) Then
            Bt8.Text = "X"
            buttoncheck = True
        Else
            Bt8.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt8.Enabled = False
    End Sub

    Private Sub Bt9_Click(sender As Object, e As EventArgs) Handles Bt9.Click
        If (buttoncheck = False) Then
            Bt9.Text = "X"
            buttoncheck = True
        Else
            Bt9.Text = "O"
            buttoncheck = False
        End If
        countclicks += 1
        Score()
        Bt9.Enabled = False
    End Sub

    Private Sub NewGameBt_Click(sender As Object, e As EventArgs) Handles NewGameBt.Click
        'New Game button will enable all of the buttons, erase them, change the button colour nack to original colour, erase the pictrue boxes
        ' reset the click counter and display the "YOUE MOVE" image in the right pictrue box
        Bt1.Enabled = True
        Bt2.Enabled = True
        Bt2.Enabled = True
        Bt3.Enabled = True
        Bt4.Enabled = True
        Bt5.Enabled = True
        Bt6.Enabled = True
        Bt7.Enabled = True
        Bt8.Enabled = True
        Bt9.Enabled = True

        Bt1.Text = ""
        Bt2.Text = ""
        Bt3.Text = ""
        Bt4.Text = ""
        Bt5.Text = ""
        Bt6.Text = ""
        Bt7.Text = ""
        Bt8.Text = ""
        Bt9.Text = ""

        NewGameBt.Enabled = True

        Bt1.BackColor = Color.LemonChiffon
        Bt2.BackColor = Color.LemonChiffon
        Bt3.BackColor = Color.LemonChiffon
        Bt4.BackColor = Color.LemonChiffon
        Bt5.BackColor = Color.LemonChiffon
        Bt6.BackColor = Color.LemonChiffon
        Bt7.BackColor = Color.LemonChiffon
        Bt8.BackColor = Color.LemonChiffon
        Bt9.BackColor = Color.LemonChiffon

        XPicBox.Image = Nothing
        OPicBox.Image = Nothing

        If buttoncheck = True Then
            OPicBox.Image = Bitmap.FromFile("your move.png")
        Else
            XPicBox.Image = Bitmap.FromFile("your move.png")
        End If
        countclicks = 0


    End Sub

    Private Sub ExitBt_Click(sender As Object, e As EventArgs) Handles ExitBt.Click
        'Whe exit button is clicked, assurance message box will be displayed. When "Yes" clicked game will close
        Dim result = MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub LoadBt_Click(sender As Object, e As EventArgs) Handles LoadBt.Click

        'Loading saved game from the .txt file stored in the project folder (X score, O score and Ties number)
        Dim sr As System.IO.StreamReader = New IO.StreamReader("game.txt")
        Dim x As Integer = 0
        Dim o As Integer = 0
        While Not sr.EndOfStream
            For x = 0 To 1
                For o = 0 To 2
                    details(x, o) = sr.ReadLine
                Next
            Next

        End While

        Xlbl.Text = details(row, 0)
        Olbl.Text = details(row, 1)
        TieCount.Text = details(row, 2)
        sr.Close()

    End Sub

    Private Sub SaveBt_Click(sender As Object, e As EventArgs) Handles SaveBt.Click
        'Saving games into the .txt files (X score, O score and Ties number)
        Dim save As New IO.StreamWriter("game.txt", False)
        save.WriteLine(Xlbl.Text)
        save.WriteLine(Olbl.Text)
        save.WriteLine(TieCount.Text)
        save.Close()
    End Sub


End Class

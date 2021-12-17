Imports VB = Microsoft.VisualBasic
Public Class Form1
    'Below are all the variables which will be used within my program, some of these variables will control the score while others will'
    'control how many cards a player can have in their hand at any given time.'
    Dim organizedDeck As Stack(Of Card.Card)
    Dim deck As Deck
    Dim PlayerVal As Integer = 0
    Dim CompVal As Integer = 0
    Dim PlayerCards(4) As Card.Card
    Dim CompCards(4) As Card.Card
    Dim PlayerHand As Integer = 0
    Dim CompHand As Integer = 0
    Dim Reset As Integer = 0
    Dim Pcard(4) As String
    Dim Psuit(4) As String


    Public Sub Form1_Onload() Handles Me.Load
        'On form load, all the buttons will be disabled except for the reset button which is also known as the shuffle button'
        btnReset.Enabled = True
        btnHit.Enabled = False
        btnStand.Enabled = False
        btnDeal.Enabled = False
    End Sub

    Public Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
        'This section of code will clear the users score whenever the deal button is clicked and will then assign two cards to the player and one to the dealer'
        'It will then calculate the value of the cards and assign them to the text label.'
        'This section also checks to see if the player has 21 and if so then they instantly win, same with the computer.'
        'the last bit of code will check how many cards are left in the deck and if there is 10 or below then it will be required to be reshuffled before'
        'the next hand can be dealt.
        txtCompScore.Clear()
        txtPlayerScore.Clear()
        PlayerCards(0) = organizedDeck.Peek
        organizedDeck.Pop()
        PlayerCards(1) = organizedDeck.Peek
        organizedDeck.Pop()
        CompCards(0) = organizedDeck.Peek
        organizedDeck.Pop()
        txtCompScore.Text = CompCards(0).cardVal
        txtPlayerScore.Text = PlayerCards(0).cardVal + PlayerCards(1).cardVal
        Console.WriteLine("{0}{1}", PlayerCards(0).cardValString, PlayerCards(0).cardSuits)
        btnDeal.Enabled = False
        btnHit.Enabled = True
        btnStand.Enabled = True
        CompVal = txtCompScore.Text
        PlayerVal = txtPlayerScore.Text
        If PlayerVal = 21 Then
            MsgBox("Blackjack! You win!")
            btnHit.Enabled = False
            btnStand.Enabled = False
            btnDeal.Enabled = True
            btnReset.Enabled = False
        End If
        If CompVal = 21 Then
            MsgBox("Computer has blackjack, you lose!")
            btnHit.Enabled = False
            btnStand.Enabled = False
            btnDeal.Enabled = True
            btnReset.Enabled = False
        End If
        CompHand = 1
        PlayerHand = 2
        If organizedDeck.Count <= 10 Then
            Reset = 1
            btnStand.Enabled = True
            btnHit.Enabled = True
            MsgBox("Deck is nearing empty, need to reshuffle after following hand")
            deck.makeDeck()
            btnReset.Enabled = True
            btnDeal.Enabled = False
        End If
    End Sub

    Public Sub btnReset_Click1(sender As Object, e As EventArgs) Handles btnReset.Click
        'This section will reset score of the player and computer whenever the reset button is clicked and will also create a new deck and shuffle them.
        deck = New Deck 'This is setting the variable deck as a new deck'
        organizedDeck = deck.getOrganizedDeck 'this is returning the organized deck from the Deck class.
        btnReset.Enabled = False
        btnHit.Enabled = False
        btnStand.Enabled = False
        For i As Integer = 0 To 4
            PlayerCards(i) = New Card.Card
            CompCards(i) = New Card.Card
        Next
        btnDeal.Enabled = True
        btnReset.Enabled = False
        btnHit.Enabled = False
        btnStand.Enabled = False
        PlayerHand = 0
        CompHand = 0
        PlayerVal = 0
        Reset = 0
    End Sub

    Public Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        'This section will trigger whenever the button is clicked and will assign another card to the player while reducing their total by 1.'
        'It will also check to see if the players total is over 21 and if so then it will tell the player that they have gone bust and will disable the irrelivant buttons, therefor ending the game.'
        PlayerHand += 1
        If PlayerHand <= 5 Then
            PlayerCards(PlayerHand - 1) = organizedDeck.Peek
            organizedDeck.Pop()
            txtPlayerScore.Text = txtPlayerScore.Text + (PlayerCards(PlayerHand - 1).cardVal)
            PlayerVal = txtPlayerScore.Text
        End If
        If PlayerVal > 21 Then
            MsgBox("You went bust, try again")
            btnHit.Enabled = False
            btnStand.Enabled = False
            btnDeal.Enabled = True
            txtCompScore.Clear()
            txtPlayerScore.Clear()
        End If
        If PlayerHand = 5 Then
            btnHit.Enabled = False
        End If
    End Sub

    Private Sub btnStand_Click(sender As Object, e As EventArgs) Handles btnStand.Click
        'This section will stand the player disabiling the buttons and checking if the computers value is less than 17 and if so then it will add another card to the computer until
        'they reach atleast 17, hit over 21 or have 5 cards in their hands and will then announce the winner depending on who has the higher score'
        If txtCompScore.Text < 17 Then
            Do
                CompHand += 1
                CompCards(CompHand - 1) = organizedDeck.Peek
                organizedDeck.Pop()
                txtCompScore.Text = txtCompScore.Text + (CompCards(CompHand - 1).cardVal)
                CompVal = txtCompScore.Text
                If CompVal > 21 Then
                    MsgBox("Dealer Bust, You win!")
                End If

            Loop Until CompVal >= 17 Or CompHand = 4
            If PlayerVal > CompVal And PlayerVal <= 21 Then
                MsgBox("Congratulations you win!")
            ElseIf CompVal = PlayerVal Then
                MsgBox("Push, nobody wins")
            ElseIf CompVal > PlayerVal And CompVal <= 21 Then
                MsgBox("Computer has higher score, computer wins.")
            End If
            txtCompScore.Clear()
            txtPlayerScore.Clear()
            If Reset = 1 Then
                btnHit.Enabled = False
                btnDeal.Enabled = False
                btnStand.Enabled = False
                btnReset.Enabled = True
            Else
                btnStand.Enabled = False
                btnHit.Enabled = False
                btnDeal.Enabled = True
                btnReset.Enabled = False
            End If
        End If
    End Sub
End Class

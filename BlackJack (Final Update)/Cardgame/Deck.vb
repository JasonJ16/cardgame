Public Class Deck
    Inherits Card
    Dim cardDeck(51) As Card
    Dim organizedDeck As Stack(Of Card)
    'This section is declaring variables as well as inheriting properties from the Card class'
    Public Sub New()
        'This will get the unorganized stack of cards and then proceeds onto the makeDeck sub below'
        organizedDeck = New Stack(Of Card)
        makeDeck()
    End Sub
    Public ReadOnly Property getOrganizedDeck() As Stack(Of Card)
        Get
            Return organizedDeck
        End Get
    End Property
    Public Sub makeDeck()
        'This will first assign the variable i to a number between 0-12 while variable j will be between 0 - 3
        'After that this will then convert the value which has been multiplied into a value and suit which will be used'
        For i As Integer = 0 To 12
            For j As Integer = 0 To 3
                Dim index As Integer = i * 4 + j
                cardDeck(index) = New Card()
                cardDeck(index).cardVal = i + 2
                cardDeck(index).cardValString = cardSuits(i + 2)

                If cardDeck(index).cardVal > 10 And cardDeck(index).cardVal < 14 Then
                    cardDeck(index).cardVal = 10
                ElseIf cardDeck(index).cardVal = 14 Then
                    cardDeck(index).cardVal = 11
                End If

                cardDeck(index).cardSuits = j
            Next
        Next

        organizeDeck()
    End Sub
    Private Function cardSuits(cardSuit As Integer) As String
        'This function will just make a case of the four different cards above 10 which will equal 10.'
        Select Case (cardSuit)
            Case 11
                Return "Jack"
            Case 12
                Return "Queen"
            Case 13
                Return "King"
            Case 14
                Return "Ace"
            Case Else
                Return cardSuit.ToString
        End Select

    End Function
    Private Sub organizeDeck()
        Dim rand As New Random()
        Dim cardNo As Integer

        For i As Integer = 0 To 10000
            For j As Integer = 0 To 51
                cardNo = rand.Next(0, 52)
                If (j <> cardNo) Then
                    tradeCard(j, cardNo)
                End If
            Next
        Next

        organizedDeckofCards()
    End Sub
    Private Sub tradeCard(j As Integer, cardsNo As Integer)
        Dim tradedCard As Card

        tradedCard = cardDeck(j)
        cardDeck(j) = cardDeck(cardsNo)
        cardDeck(cardsNo) = tradedCard
    End Sub
    Private Sub organizedDeckofCards()

        For i As Integer = 0 To 51
            organizedDeck.Push(cardDeck(51 - i))
        Next
    End Sub
End Class

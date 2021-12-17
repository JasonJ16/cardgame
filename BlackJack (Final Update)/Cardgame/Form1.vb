Public Class Form1
    Public deck As New Deck
    Public Player As New Hand(270, 340, "Player", deck)
    Public Dealer As New Hand(270, 150, "Dealer", deck)
    Public pb As New PictureBox
End Class
Public Class Deck
    Private deck(51) As Card
    Private shuffleDeck As New Stack()
End Class
Public Class Card
    Public CardVal As Integer
    Public CardPic As Image

End Class

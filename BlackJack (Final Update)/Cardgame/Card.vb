Public Class Card
    Enum Suits
        'This defines the suits which will be used within the game'
        Hearts
        Diamonds
        Spades
        Clubs
    End Enum
    Public Structure Card
        'These define the structure of Card and what variables will be included within the structure which will then be referenced by other classes and sub classes'
        Dim cardVal As Integer
        Dim cardValString As String
        Dim cardSuits As Suits
    End Structure
End Class

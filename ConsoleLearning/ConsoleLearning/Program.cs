int cardNumber = 12;
string suit = "spades";
string cardName = (cardNumber, suit) switch
{
    (12, "spades") => "12 spades",
    (12, "clubs") => "12 clubs",
    _ => "Pip card"
};
Console.WriteLine($"Card name: {cardName}");
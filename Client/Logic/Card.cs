using System;

[Serializable]
public class Card
{
    public string Name { get; set; }
    public CardType Type { get; set; }
    public int ResourceScore { get; set; }    
}
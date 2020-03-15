using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    private IDictionary<CardType, Stack<Card>> Cards;

    public Deck()
    {
        Cards = new Dictionary<CardType, Stack<Card>>();
        foreach (int cardType in Enum.GetValues(typeof(CardType)))
        {
            Cards.Add((CardType)cardType, new Stack<Card>());

            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                var cardResourceScore = random.Next(1, 20);

                var card = new Card()
                {
                    Name = $"{(CardType)cardType}",
                    Type = (CardType)cardType,
                    ResourceScore = cardResourceScore
                };
                Cards[(CardType)cardType].Push(card);
            }

        }

    }

    public Card GetTypedCard(CardType type)
    {        
        return this.Cards[type].Pop();
    }

    public int GetDeckSize(CardType type){
        return this.Cards[type].Count;
    }

}
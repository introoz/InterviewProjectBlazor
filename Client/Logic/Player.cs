

public class Player{
    private int _CurrentWins;
    private int _CurrentLoss;

    public string Name;
    
    public int CurrentWins{
        get{
            return _CurrentWins;
        }
    }

    public int CurrentLoss{
        get{
            return _CurrentLoss;
        }
    }
    
    public Player(string name){
        Name = name;

        _CurrentWins = 0;
        _CurrentLoss = 0;
    }

    public void RoundResult(bool won){
        if(won)
            _CurrentWins += 1;
        else
            _CurrentLoss += 1;
    }
    

}
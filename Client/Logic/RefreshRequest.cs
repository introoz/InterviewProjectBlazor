using System;

public class RefreshRequest : IEventService{
    public event Action Request;

    public void CallRequest(){
        Request.Invoke();
    }
}
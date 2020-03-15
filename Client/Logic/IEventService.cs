using System;

public interface IEventService{
    event Action Request;
    void CallRequest();
}
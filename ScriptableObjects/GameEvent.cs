using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Generic/GameEvent")]
public class GameEvent : ScriptableObject
{
    HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

    public void Invoke()
    {
        foreach (var listener in _listeners)
            listener.RaiseEvent();
    }

    public void Register(GameEventListener ge) => _listeners.Add(ge);
    public void Deregister(GameEventListener ge) => _listeners.Remove(ge);
}
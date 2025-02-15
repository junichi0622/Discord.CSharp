using System;
using System.Collections.Generic;

namespace Discord.CSharp.Services
{
    public class EventDispatcher
    {
        private readonly Dictionary<string, List<Action<object?>>> _eventListeners = new();

        public void AddListener(string eventName, Action<object?> listener)
        {
            if (!_eventListeners.ContainsKey(eventName))
            {
                _eventListeners[eventName] = new List<Action<object?>>();
            }
            _eventListeners[eventName].Add(listener);
        }

        public void RemoveListener(string eventName, Action<object?> listener)
        {
            if (_eventListeners.ContainsKey(eventName))
            {
                _eventListeners[eventName].Remove(listener);
                if (_eventListeners[eventName].Count == 0)
                {
                    _eventListeners.Remove(eventName);
                }
            }
        }
        
        public void Dispatch(string eventName, object? eventData = null)
        {
            if (_eventListeners.ContainsKey(eventName))
            {
                foreach (var listener in _eventListeners[eventName])
                {
                    listener.Invoke(eventData);
                }
            }
        }
    }

    public class Listener
    {
        
    }
}
using System;
using System.Collections.Generic;

namespace Discord.CSharp.Services
{
    public class EventEmitter
    {
        private readonly Dictionary<string, List<Action>> _events = new();

        public void On(string eventName, Action listener)
        {
            if (!_events.ContainsKey(eventName))
            {
                _events[eventName] = new List<Action>();
            }
            _events[eventName].Add(listener);
        }

        public void Emit(string eventName)
        {
            if (_events.ContainsKey(eventName))
            {
                foreach (var listener in _events[eventName])
                {
                    listener.Invoke();
                }
            }
        }
    }
}
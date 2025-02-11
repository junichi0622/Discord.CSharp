using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Discord.CSharp.Services
{
    public class EventEmitter
    {
        private readonly Dictionary<string, List<Action<object?>>> _eventHandlers = new();

        public void On(string eventName, Action<object?> handler)
        {
            if (!_eventHandlers.ContainsKey(eventName))
            {
                _eventHandlers[eventName] = new List<Action<object?>>();
            }
            _eventHandlers[eventName].Add(handler);
        }

        public void Once(string eventName, Action<object?> handler)
        {
            Action<object?> wrappedHandler = null!;
            wrappedHandler = (data) =>
            {
                Off(eventName, wrappedHandler);
                handler(data);
            };
            On(eventName, wrappedHandler);
        }

        public void Off(string eventName, Action<object?> handler)
        {
            if (_eventHandlers.ContainsKey(eventName))
            {
                _eventHandlers[eventName].Remove(handler);
                if (_eventHandlers[eventName].Count == 0)
                {
                    _eventHandlers.Remove(eventName);
                }
            }
        }

        public void Emit(string eventName, object? data = null)
        {
            if (_eventHandlers.ContainsKey(eventName))
            {
                foreach (var handler in _eventHandlers[eventName])
                {
                    handler.Invoke(data);
                }
            }
        }

        public int ListenerCount(string eventName)
        {
            return _eventHandlers.ContainsKey(eventName) ? _eventHandlers[eventName].Count : 0;
        }

        public List<Action<object?>>? Listeners(string eventName)
        {
            return _eventHandlers.ContainsKey(eventName) ? new (_eventHandlers[eventName]) : null;
        }

        public void RemoveAllListeners(string? eventName = null)
        {
            if (eventName == null)
            {
                _eventHandlers.Clear();
            }
            else
            {
                _eventHandlers.Remove(eventName);
            }
        }

        public List<string> EventNames()
        {
            return new List<string>(_eventHandlers.Keys);
        }

        public void PrependListener(string eventName, Action<object?> handler)
        {
            if (!_eventHandlers.ContainsKey(eventName))
            {
                _eventHandlers[eventName] = new List<Action<object?>>();
            }
            _eventHandlers[eventName].Insert(0, handler);
        }

        public void PrependOnceListener(string eventName, Action<object?> handler)
        {
            Action<object?> wrappedHandler = null!;
            wrappedHandler = (data) =>
            {
                Off(eventName, wrappedHandler);
                handler(data);
            };
            
            if (!_eventHandlers.ContainsKey(eventName))
            {
                _eventHandlers[eventName] = new List<Action<object?>>();
            }
            _eventHandlers[eventName].Insert(0, wrappedHandler);
        }
    }
}
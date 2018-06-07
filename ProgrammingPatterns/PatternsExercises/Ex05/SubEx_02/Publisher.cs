using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_02
{
    class Publisher
    {
        List<ISaveListener> listeners = new List<ISaveListener>();

        public void Subscribe(ISaveListener listener)
        {
            listeners.Add(listener);
        }

        public void Unsubscribe(ISaveListener listener)
        {
            var index = listeners.IndexOf(listener);
            listeners.RemoveAt(index);

        }

        public void Notify()
        {
            listeners.ForEach(subscriber =>
            {
                subscriber.Update();
            });
        }

    }
}

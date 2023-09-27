using System;
using System.Runtime.Remoting;

namespace Ass_Agg_Com
{
    class Manager
    {
        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }
        public string GetManagerName
    }

    class SwipeCard
    {
        public void Swipe(Manager obj)
    {
        // goes and swipes the manager
    }
    }
}
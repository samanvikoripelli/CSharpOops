using System;

namespace CSharp1
{
    class Button
    {
        public delegate void Clickhandler();
        public event Clickhandler OnClick;
        public void Click()
        {
            Console.WriteLine("Button clicked");
            OnClick.Invoke();
        }
    }
}






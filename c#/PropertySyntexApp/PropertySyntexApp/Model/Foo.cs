using System;


namespace PropertySyntexApp.Model
{
    class Foo
    {
        private int _bar;

        private int _baz;

        public Foo()
        {
            Random random = new Random();
            _baz = random.Next(0, 2);
        }
        public int Baz
        {
            get
            {                
                return _baz;
            }
        }

        public int Bar
        {
            set
            {
                if (value > 0)
                {
                    _bar = value;
                }
                else
                {
                    _bar = 0;
                }
            }
            get
            {
                return _bar;
            }
        }
    }
}

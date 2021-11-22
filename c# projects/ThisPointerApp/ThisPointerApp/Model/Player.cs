using System;


namespace ThisPointerApp.Model
{//diff between in local ans instance variable...
    class Player
    {
        private string _name;
        private int _age;
        private GenderType _gender;

        public Player(string _name) : this(_name,18,GenderType.Male)
        {
        }
        public Player(string _name, int _age, GenderType _gender) 
        {
            this._name = _name;
            this._age = _age;
            this._gender = _gender;
        }

        public Player WhoIsElder(Player p)
        {
            if (this._age > p._age)
            {
                return this;
            }
            else
            {
                return p;
            }
        }

        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
        public GenderType GetGender()
        {
            return _gender;
        }
    }

}

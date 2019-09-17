using System;

namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private int newhp;
        private int attackNumber;
        private int _hp;
        private bool _dead;
        #endregion

        #region Constructor
        public Warrior(string name, int hp)
        {
            _name = name;
            _hp = hp;
            _level = 1;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int HP
        {
            get { return _hp; }
        }

        public bool Dead
        {
            get { return _dead; }
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }

        public int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public int attackNum()
        {
            attackNumber = randomNumber(2 + _level, 10 + _level);
            return attackNumber;
        }

        public int decreaseHP()
        {
            newhp = _hp - attackNumber;
            _hp = newhp;
            if (_hp <= 0)
            {
                _dead = true;
            }
            return _hp;
        }
        #endregion
    }
}
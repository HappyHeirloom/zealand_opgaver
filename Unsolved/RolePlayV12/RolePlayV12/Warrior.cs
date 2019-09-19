using System;

namespace RolePlayV12
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _hitPoints;
        private Sword _starterSword;
        private Sword _starterShortSword;
        //private Random _generator;
        private Sword _weaponMainHand;
        private Sword _weaponOffHand;
        private Sword _gmSword;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints)
        {
            _name = name;
            _hitPoints = hitPoints;
            //_generator = new Random(Guid.NewGuid().GetHashCode());
            _starterSword = new Sword("starter sword", 1, 1);
            _weaponMainHand = _starterSword;
            _starterShortSword = new Sword("Starter short sword", 1, 1);
            _weaponOffHand = _starterShortSword;
            _gmSword = new Sword("Gm Sword", 1, 240);

            //_WieldedMainWeaponName = _swordNameMainHand;
            //_WieldedMainWeapon = _weaponMainHand;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        public string WeaponName
        {
            get { return _weaponMainHand.Name; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }


        #endregion

        #region Methods

        public void changeWeapon()
        {
            _weaponMainHand = _gmSword;
        }
        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
        }

        public int DealDamage()
        {
            return _weaponMainHand.DealDamage() + _weaponOffHand.DealDamage();
        }

        public string GetInfo()
        {
            return $"{Name} has {HitPoints} hit points, and is wielding {_weaponMainHand.Name} and {_weaponOffHand.Name} " +
                    $"({(Dead ? "dead" : "alive")})";
        }
        #endregion
    }
}
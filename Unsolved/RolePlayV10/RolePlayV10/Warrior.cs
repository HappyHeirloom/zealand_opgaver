namespace RolePlayV10
{
    public class Warrior
    {
        private double _level;
        private string _name;


        public Warrior(string name)
        {
            _name = name;
            _level = 1;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Level
        {
            get { return _level; }
        }

        public void lvlup()
        {
            _level++;
        }
    }
}
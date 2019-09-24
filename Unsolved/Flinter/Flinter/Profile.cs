namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {

        public enum gender {Man, Woman}
        public enum eC {Blue, Red, Green, Brown}
        public enum hC {Black, Blue, Blond, Brown, Green, Red, Orange, Yellow }
        public enum hCategory {VeryShort, Short, Medium, Tall, VeryTall }

        #region Instance fields
        private gender _gender;
        private eC _eyeColor;
        private hC _hairColor;
        private hCategory _heightCategory;
        #endregion

        #region Constructor
        public Profile(gender gender, hC hairColor, eC eyeColor, hCategory heightCategory)
        {
            _gender = gender;
            _hairColor = hairColor;
            _eyeColor = eyeColor;
            _heightCategory = heightCategory;
        }
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {_gender} with {_eyeColor} eyes and {_hairColor} hair, who is {_heightCategory}";
            }
        }
        #endregion
    }
}
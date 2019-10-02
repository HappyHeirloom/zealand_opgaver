using System;

public class Person
{
    #region Instance field
    string _name;
    int _age;
    int _TelephoneNumber;
    #endregion

    #region Constructor
    public Person(string name, int age, int number)
    {
        _name = name;
        _age = age;
        _TelephoneNumber = number;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public int TelephoneNumber
    {
        get { return _TelephoneNumber; }
        set { _TelephoneNumber = value; }
    }
    #endregion

    #region Methods
    public void increaseAge()
    {
        _age++;
        Console.WriteLine($"\n{_name} congratulations you're now {_age} years old");
    }

    public void PrintAll()
    {
       Console.WriteLine($"\nHi {_name}, you are {_age} year old right? Can i give you a call on {_TelephoneNumber}");
    }

    #endregion

}

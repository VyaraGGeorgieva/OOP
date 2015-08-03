using System;

class Dog //името започва с главна буква
{
    //properties -> полета Инстанцират се от конструктора
    public string Name { get; set; }

    public string Breed { get; set; }

    public Dog() //a constructor with no values, calling the second constructor
        //извиква параметър в класа, който има две незададени стойности. Public е модификатор за достъп. Всеки клас трябва да има поне един публичен модификатор. В противен случай ставам видими само за библиотеката и за никой отвън.
        :this (null, null) //извиква друк констр с 2 параметъра
    {

    }

    public Dog(string name, string breed) //constructor with parameters Има структурата на метод, но създава обект, не връща стойности
    {
        this.Name = name;
        this.Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine("{0} ({1}) says Bauuuu!",
            this.Name ?? "[unnamed dog]", 
            this.Breed ?? "[undefined breed]");
    }

   
}


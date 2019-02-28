public class Shape{
    public string GetName() {return "shape";}
}

public class Ball : Shape {
    public new string GetName() {return "ball";}
}

public class Pet{
    public virtual string GetName(){return "pet";}
}

public class Cat: Pet{
    public override string GetName(){return "cat";}
}
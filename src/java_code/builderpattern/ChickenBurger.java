package builderpattern;

public class ChickenBurger extends Burger{
    @Override
    public String name(){
        return "ChickenBurger";
    }

    @Override
    public float price(){
        return 51.0f;
    }
}
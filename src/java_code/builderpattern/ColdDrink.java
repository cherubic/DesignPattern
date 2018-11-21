package builderpattern;

public abstract class ColdDrink implements Item{

    @Override
    public abstract String name();

    @Override
    public abstract float price();

    @Override
    public Packing pack(){
        return new Bottle();
    }
}
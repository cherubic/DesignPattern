package builderpattern;

public abstract class Burger implements Item{
    
    @Override
    public abstract String name();

    @Override
    public abstract float price();

    @Override
    public Packing pack(){
        return new Wrapper();
    }
}
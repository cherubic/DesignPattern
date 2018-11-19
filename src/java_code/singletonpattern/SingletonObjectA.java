package singletonpattern;

public class SingletonObjectA{
    private static SingletonObjectA singletonObjectA = new SingletonObjectA();

    private SingletonObjectA(){}

    public SingletonObjectA getSingletonObjectInstance(){
        return singletonObjectA;
    }
}
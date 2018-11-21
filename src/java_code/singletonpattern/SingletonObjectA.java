package singletonpattern;

public class SingletonObjectA{
    private static SingletonObjectA singletonObjectA = new SingletonObjectA();

    private SingletonObjectA(){}

    public static SingletonObjectA getSingletonObjectA(){
        return singletonObjectA;
    }
}
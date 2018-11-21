package singletonpattern;

public class SingletonObjectB{
    private static SingletonObjectB singletonObjectBInstance;

    private SingletonObjectB(){
    }

    public static SingletonObjectB getSingletonObjectB(){
        if(singletonObjectBInstance == null){
            singletonObjectBInstance = new SingletonObjectB();
        }

        return singletonObjectBInstance;
    }    
}
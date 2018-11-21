package singletonpattern;

public class SingletonObjectE{
    private static class SingletonObjectEHolder{
        public static SingletonObjectE singletonObjectE = new SingletonObjectE();
    }

    private SingletonObjectE(){}

    public static SingletonObjectE getSingletonObjectE(){
        return SingletonObjectEHolder.singletonObjectE;
    }
}
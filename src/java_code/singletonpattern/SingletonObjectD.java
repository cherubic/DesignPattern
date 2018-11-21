package singletonpattern;

public class SingletonObjectD{
    private static SingletonObjectD singletonObjectD;

    private SingletonObjectD(){}

    public static SingletonObjectD getSingletonObjectD(){
        if(singletonObjectD == null){
            synchronized(SingletonObjectD.class){
                if(singletonObjectD == null){
                    singletonObjectD = new SingletonObjectD();
                }
            }
        }

        return singletonObjectD;
    }
}
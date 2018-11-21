package singletonpattern;

public class SingletonObjectC{
    private static SingletonObjectC singletonObjcetC;
    
    private SingletonObjectC(){}

    public static synchronized  SingletonObjectC getSingletonObjectC(){
        if(singletonObjcetC == null){
            singletonObjcetC = new SingletonObjectC();
        }

        return singletonObjcetC;
    }
}
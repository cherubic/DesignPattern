package singletonpattern;

public class SingletonPatternDemo{
    public static void main(String[] args){
        SingletonObjectA singletonObjectA = SingletonObjectA.getSingletonObjectA();

        SingletonObjectB singletonObjectB = SingletonObjectB.getSingletonObjectB();

        SingletonObjectC singletonObjectC = SingletonObjectC.getSingletonObjectC();

        SingletonObjectD singletonObjectD = SingletonObjectD.getSingletonObjectD();

        SingletonObjectE singletonObjectE = SingletonObjectE.getSingletonObjectE();

        SingletonObjectF singletonObjectF = SingletonObjectF.INSTANCE;
    }
}
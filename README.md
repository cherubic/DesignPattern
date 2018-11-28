# DesignPattern
design pattern explain and demo code. 

## 创建型设计模式
### Factory Pattern
创建型设计模式，用于创建具有相同方法的类。

我将它使用于：
1、多个类属于一种类型，并且有多个相同方法的情况下。
2、在其他代码中可能选择上述类中的一种类，并且大多数情况下使用的方法都是几个类中的相同方法。

我认为它的优点在于：
1、可以将这种类中的代码抽象出来，几个子类关心具体实现，而使用的代码则不需要关心，解耦合。
2、当你需要增加这种类的实现方法并且使用它，只需要增加一个子类，并且在需要使用的地方之前从工厂中获取到这个类即可，这方面而言是易修改。

我认为它的缺点在于：
1、当你想为你的其中一个类增加方法并且在由工厂创建的类中能使用，那么你需要在每个子类中增加一个方法名相同的无用的类。

### Abstract Factory Pattern
创建型设计模式，用于创建几个子类别，并且子类别又有相互关联关系的类。

我将它使用于：
1、类分别属于几个子类别。
2、子类别之间又有逻辑上的关系。

我认为它的有点在于：
1、当多个子类别分别集合成工厂，再由抽象工厂对几个工厂进行集合，这样就能保证抽象工厂对外提供的对象都将会包含所有的工厂的特性。

我认为它的缺点在于：
1、当你想要增加新的工厂时，则需要在抽象工厂中添加代码，也需要自己工厂的具体实现提供。

### Singleton Pattern
创建型设计模式，用于创建一个类型，这个类型只能存在一个实例。

我将它使用于：
1、只需要一个实例进行一些操作的时候（比如操作多线程）。
2、创建对象太浪费资源也可采用此设计模式。

我认为它的优点在于：
1、内存中只有一个实例，减少类内存开销。
2、避免了对于资源的多重占用。

我认为它的缺点在于：
1、没有接口，不能继承。

注意事项：
有多种实现单例模式的方法，应该注意在何种情况下使用何种实现方式。

### Builder Pattern
创建型设计模式，用于创建多种有逻辑关系的类别功能需要组合使用的情况中。

我将它使用于：
1、实现的产品中有复杂的内部结构，并且有逻辑关系。

我认为它的优点在于：
1、建造者是独立的，比工厂模式更加易于扩展。

我认为它的缺点在于：
1、由于是由各个功能组合在一起，则内部逻辑相对复杂。

### Prototype Pattern
创建型模式，当需要对象时，是将原对象复制得到。

我将它使用于：
1、当一个实例的初始化复杂且耗费资源时，则可以由初始对象进行复刻。
2、当一个对象有多个修改者时，可以将原对象复刻后，各自修改其值。

我认为它的优点在于：
1、提高性能。

我认为它的缺点在于：
1、克隆方法需要对类功能进行通盘考虑。
2、Java中必须实现Cloneable接口。

## 结构型模式
### Adapter Pattern
结合了两个相互独立并不兼容的功能。

我将它使用于：
1、当有旧的对象/代码需要修改时，并且需要增加新的功能，但增加功能并不想修改当前已有代码。

我认为它的优点在于：
1、提高了类的复用，增加了类的透明度，灵活。

我认为它的缺点在于：
1、过多使用则会造成类功能的不明确，混乱。

### Bridge
使得抽象化和实现化的功能可以独立变化，更加自由。

我将它使用于：
频繁变化的实现与比较固定的抽象处可以用。或者用于想要更加易于扩展功能的部分。

我认为它的优点在于：
1、将抽象和实现分离，
2、更加容易扩展。
3、实现对于用户透明。

我认为它的缺点在于：
1、你可能要将对象抽象的更好，让他实现能够恰到好处的频繁变化，而抽象出来的部分更加固定。

### Filter/Criteria Pattern
使用不同标准来过滤/操作一组对象，并且将其解耦后连接。

我将它使用于：
当对象有许多操作，但最后还是需要返回操作后的对象，则可以使用。

我认为它的优点在于：
1、可转换成链式操作。

我认为它的缺点在于：
1、使用场景不广，目前我只能想到使用在过滤一组对象中能使用。

### Composite Pattern
将一组相似的对象看成一个对象。

我将它使用于：
忽略单个对象与一组的对象的区别的场景。树形结构的对象中也可使用。

我认为它的优点在于：
1、外部调用更加简单。

我认为它的缺点在于：
1、单独与整体对象都是实现类，耦合度高。

### Decorator Pattern
可以向现有的对象添加新的功能。但不是使用继承/依赖的方式。

我将它使用于：
当需要不改变结构的对对象的功能进行添加，则可以使用这种方式。它与接下来说到的代码模式比较相似，但注重的方面不同，装饰模式更加注重功能的灵活性。

我认为它的优点在于：
1、装饰类更加自由，可独立发展。
2、在不增加子类的情况下动态增加功能，撤销功能，让结构更清晰，让功能更灵活。

我认为它的缺点在于：
1、装饰多层会让系统更加复杂。

### Facade Pattern
隐藏系统复杂性，对客户提供一个可访问的接口。

我将它使用于：
当需要隐藏类中代码细节，或者实现部分对上层透明，则应该使用外观模式。

我认为它的优点在于：
1、提高了代码的安全性。
2、提高了灵活性。
3、解耦。

我认为它的缺点在于：
1、修改接口比较麻烦。

### Flyweight Pattern
减少创建对象的数量。

我将它使用于：
当你需要考虑减少对象对内存的占用与提高其利用率，则可以考虑使用此模式。它与创建型模式中的原型模式比较相似。

我认为它的优点在于：
1、减小对象的创建，降低系统内存，效率提高。

我认为它的缺点在于：
1、提高了系统的复杂度，并且需要考虑内外状态的变化将会导致的后果。

### Proxy Pattern
一个类能够代理另一个类中的功能。与装饰类有所区别，代理类更加注重对于类的权限/访问等等控制问题。

我将它使用于：
若是一个类需要增加一些安全方面的控制，则可以考虑使用代理模式。

我认为它的优点在于：
1、更容易扩展。
2、功能划分更加清晰。

我认为它的缺点在于：
1、增加代理对象会使得处理请求速度变慢。
2、使得系统更加复杂。

##  行为型模式
### Chain of Responsibility Pattern
为请求创建了一个接收对象的链。

我将它使用于：
如果需要将请求或者某一个对象经过多重不相关的处理，则可以使用责任链模式来处理这个请求或者对象。

我认为它的优点在于：
1、将请求和处理解耦。
2、让处理更加灵活，可以随意增添处理方式。
3、对于请求而言隐藏了处理实现，更容易调用。
4、对于处理方式可以有序也可以无序，有序也可改变次序。

我认为它的缺点在于：
1、请求的异常情况更加难处理，如请求是否可以接收，每一处理方式中的错误情况不同。

### Command Pattern
数据驱动的设计模式，直接将命令包裹在对象中交由其他对象处理，执行命令。

我将它使用于：
当存在多种行为请求与一种行为实现的情况下，则可以使用命令模式，通过改变其中的命令让实现对其进行请求的执行。

我认为它的优点在于：
1、降低了系统的耦合。
2、添加请求更加容易。

我认为它的缺点在于：
1、可能会有过多具体请求的产生。

### Interpreter Pattern
提供了评估语言的语法和表达式的方法。

我将它使用于：
当需要解释一些估计的表达式时可以使用此模式。

我认为它的优点在于：
1、可扩展性好。

我认为它的缺点在于：
1、应用场景少。

### Iterator Pattern
顺序访问集合对象。

我将它使用于：
当你需要顺序访问集合对象时，可以使用此模式。

我认为它的优点在于：
1、支持以不同的方式遍历一个聚合对象。
2、迭代器让聚合类只需要关注本身功能，而不需要加入迭代部分的功能。

我认为它的缺点在于：
1、当你需要加入新的可迭代的聚合类则需要增加新的迭代器。

### Mediator Pattern
降低多个对象与类之间的通信。

我将它使用于：
当多个类与对象需要进行互相通信时，则可以采用中介者模式，让原本的结构从网状型改成星型。中介类作为中央节点。其余类的通信都通过中介类来进行。

我认为它的优点在于：
1、降低了结构的复杂度，将原本的多对多转换成一对一。

我认为它的缺点在于：
1、中介者会越来越庞大，而变得越来越难维护。

### Memento Pattern
保存对象的某个状态，以便于恢复对象。

我将它使用于：
当你需要对某个时刻的对象进行存储并且后续可能进行恢复操作时，可以使用备忘录模式。

我认为它的优点在于：
1、提供一个可以恢复的机制。

我认为它的缺点在于：
1、消耗资源。

### Observer Pattern
当一个对象修改时，则通知那些关注这个对象的对象。

我将它使用于：
一个对象的改变则需要引起另外对象的改变。这种情况可以考虑使用观察者模式。

我认为它的优点在于：
1、发布者与订阅者是抽象耦合的。

我认为它的缺点在于：
1、可能会导致循环调用。

### State Pattern
类的行为是基于它的状态改变的。

我将它使用于：
某一些状态的改变（主要是内部的状态）会导致类行为的改变，这种场景则需要使用状态模式。

我认为它的优点在于：
1、将条件语句转换成状态与对象行为。对于修改状态更加方便。

我认为它的缺点在于：
1、状态模式的结构与实现比较复杂。

### Null Object Pattern
一个空对象取代null对象实例的检查。

我将它使用于：
对于默认值有默认的处理方式，这种情况中则可以使用空对象模式。

我认为它的优点在于：
1、对于异常处理更加完善。

### Strategy Pattern
根据运行时的情况修改其行为与算法。

我将它使用于：
当有多种算法和策略可选择的情况下，使用if else 使代码更为复杂和难以维护。

我认为它的优点在于：
1、扩展性良好。

我认为它的缺点在于：
1、策略类会增多。
2、所有策略类都需要向外暴露。

### Template Pattern
公开定义执行方法的模版。

我将它使用于：
有多种乃至全部的对象运行方式相同时，只是内部实现不同，则可以使用模版模式。

我认为它的优点在于：
1、封装不变的部分，扩展可变的部分。

我认为它的缺点在于：
1、有一点不同的实现，则需要增加子类来支持实现。

### Visitor Pattern
使用访问类，用来改变元素的执行算法。

我将它使用于：
需要对对象结构中的对象进行不同并且不相关的操作时，需要避免这些操作印象对象的类，则可以使用访问模式。

我认为它的优点在于：
1、优秀的扩展性，灵活性

我认为它的缺点在于：
1、元素对访问者公开细节。
2、依赖具体类，而不是依赖抽象类。


## Design Pattern Principle

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();

h1.Successor = h2;
h2.Successor = h3;
h1.HandleRequest(1);
h2.HandleRequest(2);
h3.HandleRequest(3);

Receiver receiver = new Receiver(); // receiver - ни что иное, как целевая точка для команды
Command command = new ConcreteCommand(receiver);    // передали команде целевую точку!
Invoker invoker = new Invoker();    // инвокер - начало цепи

invoker.StoreCommand(command);  // инвокеру присваивается команда (часть цепи)
invoker.ExecuteCommand();   // инвокер запускает цепь
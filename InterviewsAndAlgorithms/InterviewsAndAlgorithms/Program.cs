﻿// See https://aka.ms/new-console-template for more information


using InterviewsAndAlgorithms.Adapter;
using InterviewsAndAlgorithms.Adapter.DataProccessor;
using InterviewsAndAlgorithms.Adapter.Network;
using InterviewsAndAlgorithms.ChainOfResponsibility;
using InterviewsAndAlgorithms.Facade;
using InterviewsAndAlgorithms.Proxy;
using InterviewsAndAlgorithms.Singleton;
using InterviewsAndAlgorithms.Strategy;

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// 1 Singleton Pattern 
//We want to create one object and use it everywhere

// 2 Facade Pattern
//Tworzymy jedną klasę fasadę która odpowiada za wszystkie zadania.
//We create one class of facade that is responsible for all tasks.

// 3 AdapterPattern

//Converts interface of class into another interface a class expects 

//4  Proxy Pattern

//The Proxy class implements the interface so that it can act as substitute for Subject objects
//The Client object works through a Proxy object that controls the access to a RealSubject object.

//6  Strategy Pattern  Enables algorithms behavior to be selected at runtime

//4  Proxy Pattern
ISuperSecretDatabase database = new SuperSecretDatabaseProxy("textdb","Password");
database.DisplayDatabaseName();

//5 Chain Of Responsibility
IChain ob1 = new SendSSH();
IChain ob2 = new SendPing();
IChain ob3 = new SendARP();
ob1.SetNext(ob2);
ob2.SetNext(ob3);
NetworkModel request = new NetworkModel("8.8.8.8", false);
ob1.SendRequest(request);


//6  Strategy Pattern  Enables algorithms behavior to be selected at runtime
Context context = new Context(new ARP());
Context contextTwo = new Context(new Ping());
Context contextThree = new Context(new DNS());
context.ExecuteStrategy();
contextTwo.ExecuteStrategy();
contextThree.ExecuteStrategy();

// 2 Facade Pattern

INetworkClient network = new NetworkClient();
network.SendRequest("9.6.6.6");
IDataProccessor dataPro = new DataProcessor();
dataPro.SendNetworkRequest("8.8.7","1234");
// 3 AdapterPattern
NetworkAdapter adapter = new NetworkAdapter(dataPro);
adapter.SendRequest("8.8.7");

// 1 Singleton Pattern 
Singleton object1 = Singleton.GetInstance();
Singleton object2 = Singleton.GetInstance();


NetworkFacade networkFacade = new NetworkFacade("1.1.1.1.","UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPAcketOverNetwork();
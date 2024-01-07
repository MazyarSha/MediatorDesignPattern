// See https://aka.ms/new-console-template for more information
using MediatorDesignPattern;

Console.WriteLine("Hello, World!");


Chatroom chatroom = new Chatroom();

Participant George = new Beatle("George");
Participant Paul = new Beatle("Paul");
Participant Ringo = new Beatle("Ringo");
Participant John = new Beatle("John");
Participant Yoko = new NonBeatle("Yoko");

chatroom.Register(George);
chatroom.Register(Paul);
chatroom.Register(Ringo);
chatroom.Register(John);
chatroom.Register(Yoko);

Yoko.Send(John,"Hi John!");
Paul.Send(Ringo, "All you need is love");
Ringo.Send(George, "My sweet lord");
Paul.Send(John, "Can't buy me love");
John.Send(Yoko, "My sweet love");


Console.ReadKey ();





using PatronObserver.ConcreteSubscribers;
using PatronObserver.Interfaces;
using PatronObserver.Publisher;

Canal canal = new Canal();

ISuscriptor s1 = new Suscriptor("Sergio Machista");
ISuscriptor s2 = new Suscriptor("Isita");
ISuscriptor s3 = new Suscriptor("Maya");

canal.Suscribir(s1);
canal.Suscribir(s2);
canal.Suscribir(s3);
canal.PublicarVideo("Planeta Vegetta");
canal.PublicarVideo("Mas Chorizo");

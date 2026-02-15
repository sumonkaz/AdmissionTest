// See https://aka.ms/new-console-template for more information
using Task2;

 

Bulb bulb = new Bulb();

// Subscribe to events
bulb.On += (sender, e) => Console.WriteLine("Bulb is turned ON.");
bulb.Off += (sender, e) => Console.WriteLine("Bulb is turned OFF.");

// Call the events
bulb.TurnOn();
bulb.TurnOff();

using System;
using System.Reflection.PortableExecutable;
class mashina
{
    private int speed;
    private string model;
    private string color;

    public mashina()
    {
        speed = 240;
        model = "mazda";
        color = "red";
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Модель: {model}, Цвет: {color}, Скорость: {speed} км/ч");
    }

    static void Main(string[] args)
    {
        mashina obj = new mashina();  
        Console.WriteLine("Объект:"); 
        obj.PrintInfo(); 

        Console.ReadLine(); 
    }

}
 
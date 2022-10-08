using System;
namespace Lab002;

//1
class ClassRoom
{
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
        Console.WriteLine("1.");
        p1.Study();
        p1.Read();
        p1.Write();
        p1.Relax();
        Console.WriteLine("2.");
        p2.Study();
        p2.Read();
        p2.Write();
        p2.Relax();
        Console.WriteLine("3.");
        p3.Study();
        p3.Read();
        p3.Write();
        p3.Relax();
        Console.WriteLine("4.");
        p4.Study();
        p4.Read();
        p4.Write();
        p4.Relax();
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        Console.WriteLine("1.");
        p1.Study();
        p1.Read();
        p1.Write();
        p1.Relax();
        Console.WriteLine("2.");
        p2.Study();
        p2.Read();
        p2.Write();
        p2.Relax();
        Console.WriteLine("3.");
        p3.Study();
        p3.Read();
        p3.Write();
        p3.Relax();
    }
    public ClassRoom(Pupil p1, Pupil p2)
    {
        Console.WriteLine("1.");
        p1.Study();
        p1.Read();
        p1.Write();
        p1.Relax();
        Console.WriteLine("2.");
        p2.Study();
        p2.Read();
        p2.Write();
        p2.Relax();
    }
}
class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Study: 0");
    }
    public virtual void Read()
    {
        Console.WriteLine("Read: 0");
    }
    public virtual void Write()
    {
        Console.WriteLine("Write: 0");
    }
    public virtual void Relax()
    {
        Console.WriteLine("Relax: 0");
    }
}
class ExcelentPupil: Pupil
{
    public override void Study()
    {
        Console.WriteLine("Study: 5");
    }
    public override void Read()
    {
        Console.WriteLine("Read: 5");
    }
    public override void Write()
    {
        Console.WriteLine("Write: 5");
    }
    public override void Relax()
    {
        Console.WriteLine("Relax: 5");
    }
}
class GoodPupil: Pupil
{
    public override void Study()
    {
        Console.WriteLine("Study: 4");
    }
    public override void Read()
    {
        Console.WriteLine("Read: 4");
    }
    public override void Write()
    {
        Console.WriteLine("Write: 4");
    }
    public override void Relax()
    {
        Console.WriteLine("Relax: 4");
    }
}
class BadPupil: Pupil
{
    public override void Study()
    {
        Console.WriteLine("Study: 3");
    }
    public override void Read()
    {
        Console.WriteLine("Read: 3");
    }
    public override void Write()
    {
        Console.WriteLine("Write: 3");
    }
    public override void Relax()
    {
        Console.WriteLine("Relax: 3");
    }
}

//2

class Vehical
{
    protected double x, y;
    protected int cost;
    protected int speed;
    protected int year;
    public Vehical(double x, double y, int cost, int speed, int year)
    {
        this.x = x;
        this.y = y;
        this.cost = cost;
        this.speed = speed;
        this.year = year;
    }
    public virtual void GiveInformation()
    {
        Console.WriteLine("x: " + this.x);
        Console.WriteLine("y: " + this.y);
        Console.WriteLine("cost: " + this.cost);
        Console.WriteLine("speed:" + this.speed);
        Console.WriteLine("year: " + this.year);
    }
}
class Plane: Vehical
{
    double z;
    int number;
    public Plane(double x, double y, int cost, int speed, int year, double z, int number) : base(x, y, cost, speed, year)
    {
        this.z = z;
        this.number = number;
    }
    public override void GiveInformation()
    {
        base.GiveInformation();
        Console.WriteLine("z: " + this.z);
        Console.WriteLine("number: " + this.number);
    }
}
class Car: Vehical
{
    public Car(double x, double y, int cost, int speed, int year): base(x, y, cost, speed, year)
    {
        this.x = x;
        this.y = y;
        this.cost = cost;
        this.speed = speed;
        this.year = year;
    }
}
class Ship: Vehical
{
    int number;
    string? port;
    public Ship(double x, double y, int cost, int speed, int year, int number, string? port) : base(x, y, cost, speed, year)
    {
        this.number = number;
        this.port = port;
    }
    public override void GiveInformation()
    {
        base.GiveInformation();
        Console.WriteLine("number: " + this.number);
        Console.WriteLine("port: " + this.port);
    }
}

//3

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}
class ProDocumentWorker: DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}
class ExpertDocumentWorker: ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в новом формате");
    }
}

class Program
{
    static void Main(string[] args)
    {

        //1

        Console.WriteLine("1 task");
        Pupil pupil = new Pupil();
        ExcelentPupil excelentPupil = new ExcelentPupil();
        GoodPupil goodPupil = new GoodPupil();
        BadPupil badPupil = new BadPupil();
        Console.WriteLine("Class of 4 people:");
        ClassRoom classRoom4 = new ClassRoom(pupil, excelentPupil, goodPupil, badPupil);
        Console.WriteLine("\nClass of 3 people:");
        ClassRoom classRoom3 = new ClassRoom(goodPupil, excelentPupil, badPupil);
        Console.WriteLine("\nClass of 2 people:");
        ClassRoom classRoom2 = new ClassRoom(goodPupil, excelentPupil);

        //2

        Console.WriteLine("\n2 task");
        Plane plane1 = new Plane(57.92875, 77.87368, 10500000, 563, 2009, 10253, 74);
        Car car1 = new Car(54.87664, 73.98463, 3333000, 175, 2010);
        Ship ship1 = new Ship(47.84672, 65.27947, 3450000, 66, 2013, 44, "Viborg");
        Console.WriteLine("\nPlane:");
        plane1.GiveInformation();
        Console.WriteLine("\nCar:");
        car1.GiveInformation();
        Console.WriteLine("\nShip:");
        ship1.GiveInformation();

        //3

        Console.WriteLine("\n3 task");
        Console.WriteLine("Введите ключ доступа pro или exp");
        string? key = Console.ReadLine();
        DocumentWorker documentWorker;
        if (key == "exp")
        {
            documentWorker = new ExpertDocumentWorker();
        } else if (key == "pro")
        {
            documentWorker = new ProDocumentWorker();
        } else
        {
            documentWorker = new DocumentWorker();
        }
        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}
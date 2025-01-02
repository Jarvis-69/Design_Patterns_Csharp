# Abstract Factory

Permet de créer des objets liés entre eux sans dire exactement comment les créer.

Cas d'utilisation réel : Dans une application de gestion de véhicules, l'Abstract Factory peut être utilisée pour produire différents types de véhicules (électriques, essence) tout en conservant une interface commune.

```Csharp
// Abstract Factory
// Interface définissant une "usine" qui peut créer des voitures.
public interface ICarFactory {
    string CreateCar(); // Méthode pour créer une voiture.
}

public class ElectricCarFactory : ICarFactory {
    public string CreateCar() => "Electric Car Created";
}

class Program {
    static void Main() {
        ICarFactory factory = new ElectricCarFactory();
        Console.WriteLine(factory.CreateCar());
    }
}
```
# Builder

Construit un objet compliqué étape par étape.

Cas d'utilisation réel : Lors de la création de rapports ou de contrats PDF dans une application d'entreprise, le Builder peut être utilisé pour assembler les sections du document progressivement.

```Csharp
// Builder
public class Car {
    public string Parts { get; private set; } = "";
    public void AddPart(string part) => Parts += part + ", ";
}

public class CarBuilder {
    private Car _car = new Car();
    public void AddEngine() => _car.AddPart("Engine");
    public void AddWheels() => _car.AddPart("Wheels");
    public Car GetCar() => _car;
}

class Program {
    static void Main() {
        var builder = new CarBuilder();
        builder.AddEngine();
        builder.AddWheels();
        Console.WriteLine(builder.GetCar().Parts);
    }
}
```

# Prototype

Copie un objet existant pour en créer un nouveau.

Cas d'utilisation réel : Dans un logiciel de conception graphique, on peut utiliser Prototype pour dupliquer des formes géométriques ou des modèles avec leurs propriétés intactes.

```Csharp
// Prototype
public class Document {
    public string Content { get; set; }
    public Document Clone() => (Document)MemberwiseClone();
}

class Program {
    static void Main() {
        var doc = new Document { Content = "Original Content" };
        var copy = doc.Clone();
        Console.WriteLine(copy.Content);
    }
}
```

# Singleton

Assure qu’il n’y ait qu’un seul exemplaire d’une classe.

Cas d'utilisation réel : Gestion de paramètres globaux, connexion unique à une base de données, ou gestionnaire de logs.

```Csharp
// Singleton
public class Configuration {
    private static Configuration _instance;
    private Configuration() {}
    public static Configuration Instance => _instance ??= new Configuration();
}

class Program {
    static void Main() {
        var config = Configuration.Instance;
        Console.WriteLine("Singleton Instance");
    }
}
```

# Adapter

Change l’interface d’une classe pour qu’elle soit compatible avec une autre.

Cas d'utilisation réel : Intégrer une bibliothèque externe ou un ancien système dans une application moderne.

```Csharp
// Adapter
public interface IDocument {
    void Print();
}

public class PdfDocument {
    public void PrintToPdf() => Console.WriteLine("Printing PDF");
}

public class PdfAdapter : IDocument {
    private PdfDocument _pdfDocument = new PdfDocument();
    public void Print() => _pdfDocument.PrintToPdf();
}

class Program {
    static void Main() {
        IDocument doc = new PdfAdapter();
        doc.Print();
    }
}
```

# Bridge

Sépare ce que fait un objet de comment il le fait.

Cas d'utilisation réel : Dans une application de génération de documents, Bridge peut séparer les types de documents (rapports, formulaires) des formats de sortie (PDF, HTML).

```Csharp
// Bridge
public interface IPrinter {
    void Print(string content);
}

public class PdfPrinter : IPrinter {
    public void Print(string content) => Console.WriteLine("PDF: " + content);
}

public class Document {
    private IPrinter _printer;
    public Document(IPrinter printer) => _printer = printer;
    public void Print() => _printer.Print("Document Content");
}

class Program {
    static void Main() {
        var doc = new Document(new PdfPrinter());
        doc.Print();
    }
}
```

# Decorator

Ajoute des fonctionnalités à un objet sans le modifier directement.

Cas d'utilisation réel : Ajout de fonctionnalités dynamiques à une interface utilisateur ou personnalisation d'objets, comme des options supplémentaires pour un produit e-commerce.

```Csharp
// Decorator
public interface ICar {
    string GetDetails();
}

public class BasicCar : ICar {
    public string GetDetails() => "Basic Car";
}

public class SunroofDecorator : ICar {
    private ICar _car;
    public SunroofDecorator(ICar car) => _car = car;
    public string GetDetails() => _car.GetDetails() + ", Sunroof";
}

class Program {
    static void Main() {
        ICar car = new BasicCar();
        car = new SunroofDecorator(car);
        Console.WriteLine(car.GetDetails());
    }
}
```

# Chain of Responsibility

Passe une requête à travers une chaîne d’objets jusqu’à ce qu’un objet puisse la traiter.

Cas d'utilisation réel : Gestion des permissions ou validation de données dans une application.

```csharp
// Handler Interface
public abstract class Handler {
    protected Handler NextHandler;
    public void SetNext(Handler next) => NextHandler = next;
    public abstract void HandleRequest(string request);
}

// Concrete Handlers
public class LowPriorityHandler : Handler {
    public override void HandleRequest(string request) {
        if (request == "Low") {
            Console.WriteLine("Handled by LowPriorityHandler");
        } else {
            NextHandler?.HandleRequest(request);
        }
    }
}

public class HighPriorityHandler : Handler {
    public override void HandleRequest(string request) {
        if (request == "High") {
            Console.WriteLine("Handled by HighPriorityHandler");
        } else {
            NextHandler?.HandleRequest(request);
        }
    }
}

// Client
class Program {
    static void Main() {
        var low = new LowPriorityHandler();
        var high = new HighPriorityHandler();

        low.SetNext(high);

        low.HandleRequest("High"); // Output: Handled by HighPriorityHandler
    }
}
```

# Command

Transforme une requête en objet, facilitant les annulations, la mise en file d’attente, et les logs.

Cas d'utilisation réel : Dans une interface utilisateur, chaque action utilisateur (comme copier/coller) peut être encapsulée dans une commande pour faciliter les actions annulables.

```csharp
// Command Interface
public interface ICommand {
    void Execute();
}

// Concrete Command
public class LightOnCommand : ICommand {
    public void Execute() => Console.WriteLine("Light is ON");
}

// Invoker
public class RemoteControl {
    private ICommand _command;
    public void SetCommand(ICommand command) => _command = command;
    public void PressButton() => _command.Execute();
}

// Client
class Program {
    static void Main() {
        var lightOn = new LightOnCommand();
        var remote = new RemoteControl();

        remote.SetCommand(lightOn);
        remote.PressButton(); // Output: Light is ON
    }
}
```
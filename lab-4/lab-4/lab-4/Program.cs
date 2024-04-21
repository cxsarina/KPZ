using System;
using System.Text;
using ClassLibraryForTask1;
using ClassLibraryForTask2;
using ClassLibraryForTask3_4;
using ClassLibraryForTask5;
using ClassLibraryForTask5_6;
class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        SupportSystem supportSystem = new SupportSystem();
        Console.WriteLine("TASK 1:");
        while (true)
        {
            Console.WriteLine("Введіть рівень підтримки (Basic, Intermediate, Advanced):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out SupportLevel level))
            {
                SupportRequest request = new SupportRequest { RequestedLevel = level };
                supportSystem.ProcessRequest(request);
                break; 
            }
            else
            {
                Console.WriteLine("Невірне введення. Введіть рівень підтримки Basic, Intermediate, or Advanced.");
            }
        }
        Console.WriteLine("TASK 2:");
        CommandCentre commandCentre = new CommandCentre();

        Runway runway1 = new Runway();
        Runway runway2 = new Runway();
        commandCentre.RegisterRunway(runway1);
        commandCentre.RegisterRunway(runway2);

        Aircraft aircraft1 = new Aircraft("Boeing");
        Aircraft aircraft2 = new Aircraft("Airbus");
        commandCentre.RegisterAircraft(aircraft1);
        commandCentre.RegisterAircraft(aircraft2);

        commandCentre.RequestLanding(aircraft1);
        commandCentre.RequestLanding(aircraft2);
        commandCentre.RequestTakeoff(aircraft1);
        Console.WriteLine("TASK 3:");
        LightElementNode element = new LightElementNode("div", "block", "normal", new List<LightNode>());
        element.AddEventListener("click", OnElementClick);
        Console.WriteLine(element.OuterHtml);
        Console.WriteLine("TASK 4:");
        IImageLoadingStrategy fileSystemStrategy = new FileSystemImageLoadingStrategy();
        IImageLoadingStrategy networkStrategy = new NetworkImageLoadingStrategy();
        LightImageNode imageFromFile = new LightImageNode("path/to/image.jpg", fileSystemStrategy);
        Console.WriteLine(imageFromFile.OuterHtml);
        LightImageNode imageFromNetwork = new LightImageNode("https://example.com/image.jpg", networkStrategy);
        Console.WriteLine(imageFromNetwork.OuterHtml);
        Console.WriteLine("TASK 5:");
        TextEditor editor = new TextEditor();
        editor.SetText("Hello, world!");
        Console.WriteLine("Current document text:");
        Console.WriteLine(editor.GetText());
        editor.SetText("Hello, universe!");
        Console.WriteLine("Updated document text:");
        Console.WriteLine(editor.GetText());
        editor.Undo();
        Console.WriteLine("Document text after undo:");
        Console.WriteLine(editor.GetText());
        editor.Save();
        Console.WriteLine("Current document text:");
        Console.WriteLine(editor.GetText());
        Console.ReadLine();
    }
    static void OnElementClick(object sender, string message)
    {
        Console.WriteLine("Element clicked!");
    }
}
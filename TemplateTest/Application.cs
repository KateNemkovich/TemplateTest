using Nice3point.Revit.Toolkit.External;
using TemplateTest.Commands;

namespace TemplateTest;

[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        CreateRibbon();
    }

    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Panel name", "TemplateTest");

        var showButton = panel.AddPushButton<Command>("Button text");
        showButton.SetImage("/TemplateTest;component/Resources/Icons/RibbonIcon16.png");
        showButton.SetLargeImage("/TemplateTest;component/Resources/Icons/RibbonIcon32.png");
    }
}
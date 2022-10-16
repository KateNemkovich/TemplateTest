using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using TemplateTest.ViewModels;
using TemplateTest.Views;

namespace TemplateTest.Commands;

[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class Command : ExternalCommand
{
    public override void Execute()
    {
        var viewModel = new TemplateTestViewModel();
        var view = new TemplateTestView(viewModel);
        view.ShowDialog();
    }
}
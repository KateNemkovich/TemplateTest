using TemplateTest.ViewModels;

namespace TemplateTest.Views;

public partial class TemplateTestView
{
    public TemplateTestView(TemplateTestViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
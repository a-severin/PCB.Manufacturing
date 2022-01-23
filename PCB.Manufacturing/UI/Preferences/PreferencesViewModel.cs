using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public class PreferencesViewModel : BindableBase
{
    private ImportantBoardPreferencesViewModel _importantBoardPreferencesViewModel;

    private ProjectBasicsViewModel _projectBasicsViewModel;

    private SpecialBoardPreferencesViewModel _specialBoardPreferencesViewModel;

    public PreferencesViewModel(Model.Order order)
    {
        ProjectBasicsViewModel = new ProjectBasicsViewModel(order.ProjectInfo);
        ImportantBoardPreferencesViewModel = new ImportantBoardPreferencesViewModel();
        SpecialBoardPreferencesViewModel = new SpecialBoardPreferencesViewModel();
    }

    public ImportantBoardPreferencesViewModel ImportantBoardPreferencesViewModel
    {
        get => _importantBoardPreferencesViewModel;
        set => SetProperty(ref _importantBoardPreferencesViewModel, value);
    }

    public ProjectBasicsViewModel ProjectBasicsViewModel
    {
        get => _projectBasicsViewModel;
        set => SetProperty(ref _projectBasicsViewModel, value);
    }

    public SpecialBoardPreferencesViewModel SpecialBoardPreferencesViewModel
    {
        get => _specialBoardPreferencesViewModel;
        set => SetProperty(ref _specialBoardPreferencesViewModel, value);
    }
}
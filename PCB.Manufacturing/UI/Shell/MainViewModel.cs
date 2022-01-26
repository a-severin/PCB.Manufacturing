using System.Collections.ObjectModel;
using System.Windows.Input;
using PCB.Manufacturing.UI.Preferences;
using PCB.Manufacturing.UI.Quote;
using Prism.Commands;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Shell;

public class MainViewModel : BindableBase
{
    private OrderPresenter _orderPresenter;

    public MainViewModel()
    {
        OrderPresenter = new OrderPresenter(new Model.Order());

        AddOrderCommand = new DelegateCommand(
            () =>
            {
                MadeOrders.Add(OrderPresenter);
                OrderPresenter = new OrderPresenter(new Model.Order());
            }
        );

        DiscardToDefaultCommand = new DelegateCommand(
            () =>
            {
                MadeOrders.Clear();
                OrderPresenter = new OrderPresenter(new Model.Order());
            }
        );
    }

    public ICommand AddOrderCommand { get; set; }

    public ICommand DiscardToDefaultCommand { get; set; }

    public ObservableCollection<OrderPresenter> MadeOrders { get; } = new();

    public OrderPresenter OrderPresenter
    {
        get => _orderPresenter;
        set => SetProperty(ref _orderPresenter, value);
    }
}

public sealed class OrderPresenter : BindableBase
{
    public readonly Model.Order Order;

    private PreferencesViewModel _preferencesViewModel;
    private QuoteViewModel _quoteViewModel;

    public OrderPresenter(Model.Order order)
    {
        Order = order;

        PreferencesViewModel = new PreferencesViewModel(order);

        QuoteViewModel = new QuoteViewModel(order);
        PreferencesViewModel.ProjectBasicsViewModel.PropertyChanged +=
            (sender, args) => QuoteViewModel.Update();
        PreferencesViewModel.ImportantBoardPreferencesViewModel.PropertyChanged +=
            (sender, args) => QuoteViewModel.Update();
        PreferencesViewModel.SpecialBoardPreferencesViewModel.PropertyChanged +=
            (sender, args) => QuoteViewModel.Update();
    }

    public PreferencesViewModel PreferencesViewModel
    {
        get => _preferencesViewModel;
        set => SetProperty(ref _preferencesViewModel, value);
    }

    public QuoteViewModel QuoteViewModel
    {
        get => _quoteViewModel;
        set => SetProperty(ref _quoteViewModel, value);
    }
}
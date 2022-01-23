using System.Windows.Input;
using PCB.Manufacturing.Model;
using PCB.Manufacturing.UI.Preferences;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Shell;

public class MainViewModel : BindableBase
{
    private OrderPresenter _orderPresenter;

    public MainViewModel()
    {
        OrderPresenter = new OrderPresenter(new Model.Order());
    }

    public OrderPresenter OrderPresenter
    {
        get => _orderPresenter;
        set => SetProperty(ref _orderPresenter, value);
    }

    public ICommand AddOrderCommand { get; set; }
}

public sealed class OrderPresenter : BindableBase
{
    public readonly Model.Order Order;

    private PreferencesViewModel _preferencesViewModel;

    public OrderPresenter(Model.Order order)
    {
        Order = order;

        PreferencesViewModel = new PreferencesViewModel(order);
    }

    public PreferencesViewModel PreferencesViewModel
    {
        get => _preferencesViewModel;
        set => SetProperty(ref _preferencesViewModel, value);
    }
}
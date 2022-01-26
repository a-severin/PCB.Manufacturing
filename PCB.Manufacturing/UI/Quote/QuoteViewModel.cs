using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Quote;

public class QuoteViewModel : BindableBase
{
    private readonly Model.Order _order;
    private SummaryPreferenceCollection _summaryPreferenceCollection;

    public QuoteViewModel(Model.Order order)
    {
        _order = order;
        SummaryPreferenceCollection = new SummaryPreferenceCollection(order);
    }

    public SummaryPreferenceCollection SummaryPreferenceCollection
    {
        get => _summaryPreferenceCollection;
        private set => SetProperty(ref _summaryPreferenceCollection, value);
    }

    public void Update()
    {
        SummaryPreferenceCollection = new SummaryPreferenceCollection(_order);
    }
}

public sealed class SummaryPreferenceCollection : ObservableCollection<SummaryPreferencePresenter>
{
    private readonly Model.Order _order;

    public SummaryPreferenceCollection(Model.Order order)
    {
        _order = order;

        _load();

        CollectionView = CollectionViewSource.GetDefaultView(this);
        CollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SummaryPreferencePresenter.Category)));
    }

    public ICollectionView CollectionView { get; set; }

    private void _load()
    {
        Clear();

        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Base Fabrication",
                Value = $"{(_order.BoardSpec.IpcClass == IPC.Class1 ? "10" : "20")} layers",
                TimeImpact = (_order.BoardSpec.IpcClass == IPC.Class1 ? 1 : 2) + _order.BoardInfo.Material.ExtraTime,
                TimeImpactRate = _order.BoardSpec.IpcClass == IPC.Class1 ? 1 : 2,
                CostImpact = (_order.BoardSpec.IpcClass == IPC.Class1 ? 1_000 : 1_500)
                             + _order.BoardInfo.Material.ExtraMoney,
                CostImpactRate = _order.BoardSpec.IpcClass == IPC.Class1 ? 2 : 3,
                Category = "Fabrication"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Boards Quantity",
                Value = _order.ProjectInfo.BoardsQuantity.ToString(),
                TimeImpact = 0,
                TimeImpactRate = 0,
                CostImpact = _order.ProjectInfo.BoardsQuantity * 130,
                CostImpactRate = 3,
                Category = "Fabrication"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Surface Finish",
                Value = _order.BoardInfo.Surface.Name,
                TimeImpact = _order.BoardInfo.Surface.ExtraTime,
                TimeImpactRate = _order.BoardInfo.Surface.Id,
                CostImpact = _order.BoardInfo.Surface.ExtraMoney,
                CostImpactRate = _order.BoardInfo.Surface.Id,
                Category = "Fabrication"
            }
        );

        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Packages",
                Value = "Package on Packages",
                TimeImpact = 2,
                TimeImpactRate = 3,
                CostImpact = 2_500,
                CostImpactRate = 2,
                Category = "Assembly"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Processes",
                Value = "Split Assembly",
                TimeImpact = 0,
                TimeImpactRate = 0,
                CostImpact = 720,
                CostImpactRate = 1,
                Category = "Assembly"
            }
        );

        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Microchip 20SU",
                Value = "2",
                TimeImpact = 0,
                TimeImpactRate = 0,
                CostImpact = 480,
                CostImpactRate = 1,
                Category = "Components"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Microchip 18PC",
                Value = "1",
                TimeImpact = 0,
                TimeImpactRate = 0,
                CostImpact = 220,
                CostImpactRate = 1,
                Category = "Components"
            }
        );
    }
}

public class SummaryPreferencePresenter : BindableBase
{
    public string Category { get; set; }
    public decimal CostImpact { get; set; }
    public int CostImpactRate { get; set; }
    public string Parameter { get; set; }
    public int TimeImpact { get; set; }
    public int TimeImpactRate { get; set; }
    public string Value { get; set; }
}
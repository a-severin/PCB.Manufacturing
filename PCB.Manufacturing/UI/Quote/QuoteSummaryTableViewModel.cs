using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Quote;

public class QuoteSummaryTableViewModel : BindableBase
{
    public SummaryPreferenceCollection SummaryPreferenceCollection { get; } = new();
}

public sealed class SummaryPreferenceCollection : ObservableCollection<SummaryPreferencePresenter>
{
    public SummaryPreferenceCollection()
    {
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Base Fabrication",
                Value = "10 layers",
                TimeImpact = 1,
                TimeImpactRate = 1,
                CostImpact = 1_000,
                CostImpactRate = 3,
                Category = "Fabrication",
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Boards Quantity",
                Value = "20",
                TimeImpact = null,
                TimeImpactRate = 0,
                CostImpact = 500,
                CostImpactRate = 1,
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
                TimeImpact = null,
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
                TimeImpact = null,
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
                TimeImpact = null,
                TimeImpactRate = 0,
                CostImpact = 220,
                CostImpactRate = 1,
                Category = "Components"
            }
        );

        CollectionView = CollectionViewSource.GetDefaultView(this);
        CollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SummaryPreferencePresenter.Category)));
    }

    public ICollectionView CollectionView { get; set; }
}

public class SummaryPreferencePresenter : BindableBase
{
    public string Parameter { get; set; }
    public string Value { get; set; }
    public int? TimeImpact { get; set; }
    public decimal CostImpact { get; set; }
    public string Category { get; set; }
    public int TimeImpactRate { get; set; }
    public int CostImpactRate { get; set; }
}
using System.Collections.ObjectModel;
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
                CostImpact = 1_000,
                Category = "Fabrication"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Boards Quantity",
                Value = "20",
                TimeImpact = null,
                CostImpact = 500,
                Category = "Fabrication"
            }
        );

        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Packages",
                Value = "Package on Packages",
                TimeImpact = 1,
                CostImpact = 2_500,
                Category = "Assembly"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Processes",
                Value = "Split Assembly",
                TimeImpact = null,
                CostImpact = 720,
                Category = "Assembly"
            }
        );

        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Microchip 20SU",
                Value = "2",
                TimeImpact = null,
                CostImpact = 48,
                Category = "Components"
            }
        );
        Add(
            new SummaryPreferencePresenter
            {
                Parameter = "Microchip 18PC",
                Value = "1",
                TimeImpact = null,
                CostImpact = 22,
                Category = "Components"
            }
        );

        var collectionView = CollectionViewSource.GetDefaultView(this);
        collectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(SummaryPreferencePresenter.Category)));
    }
}

public class SummaryPreferencePresenter : BindableBase
{
    public string Parameter { get; set; }
    public string Value { get; set; }
    public int? TimeImpact { get; set; }
    public decimal CostImpact { get; set; }
    public string Category { get; set; }
}
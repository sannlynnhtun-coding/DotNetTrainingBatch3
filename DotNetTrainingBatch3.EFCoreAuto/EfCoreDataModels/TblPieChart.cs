using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.EFCoreAuto.EfCoreDataModels;

public partial class TblPieChart
{
    public int PieChartId { get; set; }

    public string PieChartLabel { get; set; } = null!;

    public int PieChartSeries { get; set; }
}

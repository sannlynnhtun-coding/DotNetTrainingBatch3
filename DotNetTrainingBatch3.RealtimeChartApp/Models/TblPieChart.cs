using System;
using System.Collections.Generic;

namespace DotNetTrainingBatch3.RealtimeChartApp.Models;

public partial class TblPieChart
{
    public int PieChartId { get; set; }

    public string PieChartLabel { get; set; } = null!;

    public int PieChartSeries { get; set; }
}

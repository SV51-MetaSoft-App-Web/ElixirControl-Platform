﻿namespace ElixirControlPlatform.API.WinemakingProcess.Domain.Model.Entities;

public class Pressing
{
    public int Id { get;  set; }
    
    //========================== Fermentation Pressing ==========================
    public int BatchId { get; private set; }
    public DateTime? PressingDate { get; private set; }
    public double MustVolume { get; private set; }
    public string PressType { get; private set; }
    public double AppliedPressure { get; private set; }
    //======================== end Fermentation Pressing ========================

    public Pressing()
    {
        this.BatchId = 0;
        this.PressingDate = null;
        this.MustVolume = 0;
        this.PressType = string.Empty;
        this.AppliedPressure = 0;
    }
    
    public Pressing(int batchId, string pressingDate, double mustVolume, string pressType, double appliedPressure) : this()
    {
        BatchId = batchId;
        PressingDate = ConvertToDate(pressingDate);
        MustVolume = mustVolume;
        PressType = pressType;
        AppliedPressure = appliedPressure;
    }
    
    private static DateTime? ConvertToDate(string date)
    {
        if (DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            return parsedDate;
        }
        return null;
    }

}
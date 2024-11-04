﻿namespace ElixirControlPlatform.API.WinemakingProcess.Interfaces.REST.Resources;

public record UpdateFermentationByBatchResource(
    string StartDate, 
    string EndDate, 
    double AverageTemperature, 
    double InitialDensity, 
    double InitialPh, 
    double FinalDensity, 
    double FinalPh, 
    double ResidualSugar);
namespace Avangardum.LifeArena.Shared;

public record GameStateResponse(List<string> LivingCells, int Generation, TimeSpan TimeUntilNextGeneration, 
    int CellsLeft, int MaxCellsPerPlayerPerGeneration);
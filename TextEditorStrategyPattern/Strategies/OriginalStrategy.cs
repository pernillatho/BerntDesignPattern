using TextEditorStrategyPattern.Interfaces;

namespace TextEditorStrategyPattern.Services;

public class OriginalStrategy : IStrategy
{
    public string? TextFormatting(string a)
    {
        return a;
    }
}
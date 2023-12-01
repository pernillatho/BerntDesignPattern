using TextEditorStrategyPattern.Interfaces;

namespace TextEditorStrategyPattern.Services;

public class LowerCaseStrategy : IStrategy
{
    public string? TextFormatting(string a)
    {
        return a.ToLower();
    }
}
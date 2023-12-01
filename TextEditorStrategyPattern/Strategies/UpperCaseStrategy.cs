using TextEditorStrategyPattern.Interfaces;

namespace TextEditorStrategyPattern.Services;

public class UpperCaseStrategy : IStrategy
{
    public string? TextFormatting(string a)
    {
        return a.ToUpper();
    }
}
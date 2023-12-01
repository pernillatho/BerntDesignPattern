using TextEditorStrategyPattern.Interfaces;

namespace TextEditorStrategyPattern.Services;

public class ReplaceStrategy : IStrategy
{
    public string? TextFormatting(string a)
    {
        return a.Replace('e', 'a');
    }
}
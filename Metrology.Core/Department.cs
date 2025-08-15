namespace Metrology.Core;

/// <summary>
/// Подразделение организации
/// </summary>
public class Department
{
    /// <summary>
    /// Уникальный идентификатор подразделения
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Полное наименование подразделения
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Краткое наименование подразделения (аббревиатура)
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Физическое расположение подразделения
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// Дополнительные сведения о подразделении
    /// </summary>
    public string Notes { get; set; }
}
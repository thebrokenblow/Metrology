namespace Metrology.Core;

/// <summary>
/// Должность сотрудника
/// </summary>
public class Position
{
    /// <summary>
    /// Уникальный идентификатор должности
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название должности
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Код должности (например, "MGR" для менеджера)
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Описание должностных обязанностей
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Признак руководящей должности
    /// </summary>
    public bool IsManagement { get; set; }
}
namespace Metrology.Core;

/// <summary>
/// Представляет статус плановой проверки оборудования
/// </summary>
public class InspectionStatus
{
    /// <summary>
    /// Уникальный идентификатор статуса проверки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Код статуса проверки
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Наименование статуса проверки
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание статуса проверки
    /// </summary>
    public string Description { get; set; }
}
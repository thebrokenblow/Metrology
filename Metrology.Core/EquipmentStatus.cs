namespace Metrology.Core;

/// <summary>
///  Статус измерительного оборудования
/// </summary>
public class EquipmentStatus
{
    /// <summary>
    /// Уникальный идентификатор статуса
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Код статуса (например, "IN_USE", "DECOMMISSIONED")
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Наименование статуса
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Подробное описание статуса
    /// </summary>
    public string Description { get; set; }
}
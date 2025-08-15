namespace Metrology.Core;

/// <summary>
/// Тип измерительного оборудования
/// </summary>
public class EquipmentType
{
    /// <summary>
    /// Уникальный идентификатор типа оборудования
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Наименование типа оборудования
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Подробное описание типа оборудования
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Единица измерения для данного типа оборудования
    /// </summary>
    public string MeasurementUnit { get; set; }

    /// <summary>
    /// Рекомендуемый межповерочный интервал в месяцах
    /// </summary>
    public int? VerificationPeriodMonths { get; set; }
}
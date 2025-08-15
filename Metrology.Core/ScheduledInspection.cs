namespace Metrology.Core;

/// <summary>
/// Запись о плановой проверке оборудования
/// </summary>
public class ScheduledInspection
{
    /// <summary>
    /// Уникальный идентификатор проверки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор проверяемого оборудования
    /// </summary>
    public int EquipmentId { get; set; }

    /// <summary>
    /// Тип проверки (например, "ежедневная", "ежемесячная")
    /// </summary>
    public string InspectionType { get; set; }

    /// <summary>
    /// Плановая дата проведения проверки
    /// </summary>
    public DateTime ScheduledDate { get; set; }

    /// <summary>
    /// Фактическая дата проведения проверки
    /// </summary>
    public DateTime? ActualDate { get; set; }

    /// <summary>
    /// Идентификатор статуса проверки
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Идентификатор ответственного за проверку сотрудника
    /// </summary>
    public int? ResponsibleEmployeeId { get; set; }

    /// <summary>
    /// Результат проверки
    /// </summary>
    public string Result { get; set; }

    /// <summary>
    /// Дополнительные примечания
    /// </summary>
    public string Notes { get; set; }
}
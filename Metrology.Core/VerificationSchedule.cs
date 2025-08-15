namespace Metrology.Core;

/// <summary>
/// Запись в графике поверок оборудования
/// </summary>
public class VerificationSchedule
{
    /// <summary>
    /// Уникальный идентификатор записи
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор оборудования
    /// </summary>
    public int EquipmentId { get; set; }

    /// <summary>
    /// Дата последней проведенной поверки
    /// </summary>
    public DateTime? LastVerificationDate { get; set; }

    /// <summary>
    /// Плановая дата следующей поверки
    /// </summary>
    public DateTime NextVerificationDate { get; set; }

    /// <summary>
    /// Межповерочный интервал в месяцах
    /// </summary>
    public int? VerificationPeriodMonths { get; set; }

    /// <summary>
    /// Идентификатор текущего статуса поверки
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Идентификатор ответственного сотрудника
    /// </summary>
    public int? ResponsibleEmployeeId { get; set; }

    /// <summary>
    /// Дополнительные примечания
    /// </summary>
    public string Notes { get; set; }
}
namespace Metrology.Core;

/// <summary>
/// Акт (свидетельство) о поверке оборудования
/// </summary>
public class VerificationCertificate
{
    /// <summary>
    /// Уникальный идентификатор акта поверки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор записи в графике поверок
    /// </summary>
    public int? ScheduleId { get; set; }

    /// <summary>
    /// Номер свидетельства о поверке
    /// </summary>
    public string CertificateNumber { get; set; }

    /// <summary>
    /// Дата проведения поверки
    /// </summary>
    public DateTime VerificationDate { get; set; }

    /// <summary>
    /// Срок действия поверки
    /// </summary>
    public DateTime ExpirationDate { get; set; }

    /// <summary>
    /// Результат поверки (passed - пройдена, failed - не пройдена, conditional - условно пройдена)
    /// </summary>
    public string VerificationResult { get; set; }

    /// <summary>
    /// Наименование организации, проводившей поверку
    /// </summary>
    public string VerificationOrganization { get; set; }

    /// <summary>
    /// Путь к файлу с электронной копией свидетельства
    /// </summary>
    public string FilePath { get; set; }

    /// <summary>
    /// Дополнительные примечания
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// Дата и время создания записи
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
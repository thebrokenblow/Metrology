namespace Metrology.Core;

/// <summary>
/// Статус процедуры поверки оборудования
/// </summary>
public class VerificationStatus
{
    /// <summary>
    /// Уникальный идентификатор статуса поверки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Код статуса поверки
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Наименование статуса поверки
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание статуса поверки
    /// </summary>
    public string Description { get; set; }
}
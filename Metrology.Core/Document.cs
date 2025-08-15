namespace Metrology.Core;

/// <summary>
/// Документ, связанный с оборудованием
/// </summary>
public class Document
{
    /// <summary>
    /// Уникальный идентификатор документа
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Тип документа (паспорт, руководство по эксплуатации и т.д.)
    /// </summary>
    public string DocumentType { get; set; }

    /// <summary>
    /// Номер документа
    /// </summary>
    public string DocumentNumber { get; set; }

    /// <summary>
    /// Дата выдачи документа
    /// </summary>
    public DateTime IssueDate { get; set; }

    /// <summary>
    /// Срок действия документа (если применимо)
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Идентификатор связанного оборудования
    /// </summary>
    public int? EquipmentId { get; set; }

    /// <summary>
    /// Путь к файлу документа в системе хранения
    /// </summary>
    public string FilePath { get; set; }

    /// <summary>
    /// Идентификатор сотрудника, загрузившего документ
    /// </summary>
    public int UploadedBy { get; set; }

    /// <summary>
    /// Дополнительные примечания
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// Дата и время загрузки документа
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
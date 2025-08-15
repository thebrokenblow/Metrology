namespace Metrology.Core;

/// <summary>
/// Представляет информацию о сотруднике
/// </summary>
public class Employee
{
    /// <summary>
    /// Уникальный идентификатор сотрудника
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя сотрудника
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия сотрудника
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Отчество сотрудника (может отсутствовать)
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// Идентификатор должности сотрудника
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Идентификатор подразделения сотрудника
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Идентификатор руководителя сотрудника
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Электронная почта сотрудника
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Контактный телефон сотрудника
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Зашифрованный пароль для доступа в систему
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Признак, может ли сотрудник быть ответственным за оборудование
    /// </summary>
    public bool IsResponsible { get; set; }
}
﻿// Monitoring.Application/Interfaces/ILoginService.cs

namespace Monitoring.Application.Interfaces
{
    internal interface ILoginService
    /// <summary>
    /// Интерфейс для логики авторизации/аутентификации.
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Возвращает список всех активных пользователей (smallName).
        /// </summary>
        Task<List<string>> GetAllUsersAsync();

        /// <summary>
        /// Возвращает список пользователей, отфильтрованных по строке query.
        /// </summary>
        Task<List<string>> FilterUsersAsync(string query);

        /// <summary>
        /// Проверяет логин/пароль пользователя.
        /// Возвращает (divisionId, успех) или (null, false).
        /// </summary>
        Task<(int? divisionId, bool isValid)> CheckUserCredentialsAsync(
            string selectedUser,
            string password
        );
    }
}

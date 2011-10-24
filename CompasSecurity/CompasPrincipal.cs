using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

using Compas.Logic.Security;
using Compas.Logic;
using Compas.Model;

namespace Compas.Security
{
    public class CompasPrincipal:IPrincipal
    {
        /// <summary>
        /// Класс CompasPrincipal, описывающий роль, наследует от класса IPrincipal
        /// </summary>
        
            private CompasIdentity _indentity;
            private string _role;
            /// <summary>
            /// Конструктор.
            /// </summary>
            /// <param name="identity">Определяем личность пользователя.</param>
            public CompasPrincipal(CompasIdentity identity)
            {
                // Инициализируем личность
                this._indentity = identity;
                // Инициализируем переменную только один раз. Если роль изменится в процессе выполнения приложения, то
                // изменения вступят в силу только после перезагрузки приложения.
                this._role = this.GetUserRoles();
            }
            #region IPrincipal Members
            /// <summary>
            /// Свойство личности пользователя.
            /// </summary>
            public IIdentity Identity
            {
                get
                {
                    // Реализуем свойство интерфейса.
                    return (IIdentity)this._indentity;
                }
            }
            /// <summary>
            /// Проверяем, прнадлежит ли пользователь к заданной роли.
            /// </summary>
            /// <param name="role">Роль.</param>
            /// <returns></returns>
            public bool IsInRole(string role)
            {
                // Реализуем метод интерфейса.
                return role == this._role;


                // Если необходимо реагировать на изменение роли без перезагрузки приложения, то это можно сделать так:
                //return role == this.GetUserRole();
            }

            /// <summary>
            /// Перевіряємо чи дія дозволена
            /// </summary>
            /// <param name="role">Дія.</param>
            /// <returns></returns>
            public bool OpperationAllowed(string ActionCode)
            {
                // Реализуем метод интерфейса.
                ContextManager manager = new ContextManager();
                SecurityUsersLogic user = new SecurityUsersLogic(manager);

                return user.CheckAction(this._indentity.ID, ActionCode);
            }

            #endregion
            /// <summary>
            /// Возвращаем  роль пользователя.
            /// </summary>
            /// <returns></returns>
            private string GetUserRoles()
            {
                // Считываем и сравниваем имя пользователя.
                
                string role = "";
                return role;
                // Если роль пользователя не найдена, генерируем исключение.
                throw new System.Security.SecurityException(String.Format("Роль пользователя {0} не найдена в базе данных.",
                        this._indentity.Name));
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compas.Logic;
using Compas.Logic.Security;
using Compas.Model;

namespace Compas.Security
{
    public class CompasIdentity
    {
         //Вводим переменные  аутентификации
                private bool _isAuth;
                private string _name;
                private string _authType;
                private int _id;
                /// <summary>
                /// Конструктор.
                /// </summary>
                public CompasIdentity()
                {
                        this._isAuth = false;
                        this._authType = String.Empty;
                        this._name = String.Empty;
                        this._id = -1;
                }
                /// <summary>
                ///Создаем конструктор, принимающий имя пользователя.
                /// </summary>
                /// <param name="userName">Имя пользователя.</param>
                public CompasIdentity(string userName, string Hash)
                {
                        this._id = this.AuthUser(userName, Hash);
                        this._name = userName;

                        //this._isAuth = true;
                        this._authType = "Частный тип аутентификации.";
                }
                /// <summary>
                /// Определяем уникальный идентификатор пользователя.
                /// </summary>
                public int ID
                {
                        get { return this._id; }
                }
                #region IIdentity Members
                /// <summary>
                /// Проверка аутентификации пользователя.
                /// </summary>
                public bool IsAuthenticated
                {
                        get
                        {
                                // Реализуем свойство интерфейса.
                                return this._isAuth;
                        }
                }
                /// <summary>
                /// Определяем имя пользователя.
                /// </summary>
                public string Name
                {
                        get
                        {
                                // Реализуем свойство интерфейса.
                                return this._name;
                        }
                }
                /// <summary>
                /// Определяем тип аутентификации.
                /// </summary>
                public string AuthenticationType
                {
                        get
                        {
                                // Реализуем свойство интерфейса.
                                return this._authType;
                        }
                }

                #endregion
                /// <summary>
                /// Проверяем, существует ли имя пользователя  в  базе данных — файле XML.
                /// </summary>
                /// <param name="name">Имя пользователя.</param>
                /// <returns>ID пользователя.</returns>
                private int AuthUser(string name, string Hash)
                {
                    // Считываем и сравниваем имя пользователя.
                    

                    ContextManager manager = new ContextManager();
                    SecurityUsersLogic users = new SecurityUsersLogic(manager);
                    int userId = users.Get(name, Hash);
                    if (userId >= 0)
                    {
                        this._isAuth = true;
                    }
                    else
                    {
                        this._isAuth = false;
                    }
                    
                    manager.CloseContext();
                    return userId;
                    // Если пользователь не найден, генерируем исключение.
                    throw new System.Security.SecurityException(String.Format("Пользователь {0} не найден в базе  данных.", name));
                }
    }
}

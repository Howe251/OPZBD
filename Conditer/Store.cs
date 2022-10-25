// <copyright file="Store.cs" company="Howe251">
// Copyright (c) https://github.com/Howe251. All rights reserved.
// </copyright>

namespace Conditer
{
    public class Store
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/>.
        /// </summary>
        /// <param name="store_name">Имя магазина. </param>
        /// <param name="adress">Адрес магазина. </param>
        public Store(
            string store_name,
            string adress)
        {
            if (string.IsNullOrWhiteSpace(store_name))
            {
                throw new ArgumentNullException(nameof(store_name));
            }
            if (string.IsNullOrWhiteSpace(adress))
            {
                throw new ArgumentNullException(nameof(adress));
            }
            this.Id = Guid.NewGuid();
            this.Store_name = store_name;
            this.Adress = adress;
        }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Наименование магазина
        /// </summary>
        public string Store_name { get; }
        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string Adress { get; }
    }
}

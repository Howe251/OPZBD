// <copyright file="Suplier.cs" company="Howe251">
// Copyright (c) https://github.com/Howe251. All rights reserved.
// </copyright>

namespace Conditer
{
    /// <summary>
    /// Поставщик
    /// </summary>
    public class Suplier
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Suplier"/>.
        /// </summary>
        /// <param name="company_name">Название компании. </param>
        /// <param name="item">Поставляемый продукт. </param>
        public Suplier(
            string company_name,
            string item)
        {
            if (string.IsNullOrWhiteSpace(company_name))
            {
                throw new ArgumentNullException(nameof(company_name));
            }
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.Id = Guid.NewGuid();
            this.Company_name = company_name;
            this.Item = item;
            
        }
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Название компании.
        /// </summary>
        public string Company_name { get; }
        /// <summary>
        /// Название поставляемого товара.
        /// </summary>
        public string Item { get; }

    }
}

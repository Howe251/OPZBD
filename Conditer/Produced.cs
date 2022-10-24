// <copyright file="Produced.cs" company="Howe251">
// Copyright (c) https://github.com/Howe251. All rights reserved.
// </copyright>

namespace Conditer
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Produced"/>.
    /// </summary>
    /// <param name="date">Дата производства. </param>
    /// <param name="count">Количество. </param>
    public class Produced
    {
        public Produced(
            DateOnly date,
            int count)
        {
            this.Id = Guid.NewGuid();
            this.Date = date;
            this.Count = count;
        }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Дата производства
        /// </summary>
        public DateOnly Date { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        
    }
}

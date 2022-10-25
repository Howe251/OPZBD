// <copyright file="Menu.cs" company="Howe251">
// Copyright (c) https://github.com/Howe251. All rights reserved.
// </copyright>

namespace Conditer
{
    public class Menu
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Menu"/>.
        /// </summary>
        /// <param name="name">Имя. </param>
        /// <param name="cost">Стоимость. </param>
        public Menu(
            string name, 
            int cost)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Cost = cost;
        }
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public int Cost { get; }

    }
}

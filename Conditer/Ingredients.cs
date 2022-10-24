// <copyright file="Ingredients.cs" company="Howe251">
// Copyright (c) https://github.com/Howe251. All rights reserved.
// </copyright>

namespace Conditer
{
    /// <summary>
    /// ингредиенты.
    /// </summary>
    public class Ingredients
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Ingredients"/>.
        /// </summary>
        /// <param name="name"> Наименование товара. </param>
        /// <param name="count"> Количество. </param>
        
        public Ingredients(
            string name,
            int count)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Count = count;
            //this.delivery_id = 
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// Наименование ингредиента.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Количество.
        /// </summary>
        public int Count { get; }
    }
}
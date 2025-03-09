using AutoSystem_KingMe.Models.Common.Attributes;
using System.Reflection;

namespace AutoSystem_KingMe.Models.Common
{
    public abstract class EntityBase
    {
        /// <summary>
        /// Preenche as propriedades da classe com base no atributo "Position"
        /// </summary>
        /// <param name="input"></param>
        public void FillReponse(string input)
        {
            var values = input.Split(',');

            // Obtendo as propriedades que implementam o attributo "Position"
            var properties = GetType().GetProperties()
                .Where(x => x.GetCustomAttribute<PositionAttribute>() is not null);

            // Iterando as propriedades e preenchendo o valor de acordo com a posição configurada
            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<PositionAttribute>();
                if (attribute is null) continue;

                int position = attribute.Position;
                string? value = values.ElementAtOrDefault(position);
                if (value is null) continue;

                property.SetValue(this, value);
            }
        }
    }
}

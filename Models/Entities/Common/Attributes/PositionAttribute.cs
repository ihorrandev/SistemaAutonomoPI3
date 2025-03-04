namespace AutoSystem_KingMe.Models.Entities.Common.Attributes
{
    /// <summary>
    /// Atributo para identificar a propriedade correspondente ao valor retornado na posição informada.
    /// </summary>
    public class PositionAttribute : Attribute
    {
        public int Position { get; set; }

        /// <summary>
        /// Define a posição da propriedade no retorno dos métodos da DLL.
        /// </summary>
        /// <param name="position">Posição do valor que será vinculado com a propriedade. Iniciando por zero.</param>
        /// <exception cref="ArgumentOutOfRangeException">Exceção lançada caso valor da posição seja negativo.</exception>
        public PositionAttribute(int position) 
        {
            if (position < 0)
                throw new ArgumentOutOfRangeException(nameof(position));

            Position = position;
        }
    }
}

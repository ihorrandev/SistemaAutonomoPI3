using AutoSystem_KingMe.Models.Entities.Common;

namespace AutoSystem_KingMe.Helper
{
    public static class ResponseUtils
    {
        public static List<TEntity>? HandleReponse<TEntity>(this string input) where TEntity : EntityBase, new()
        {
            if (input.StartsWith("ERRO")) return default;

            var response = new List<TEntity>();
            var values = input.Split("\r\n");

            foreach (var value in values) {
                var entity = new TEntity();
                entity.FillReponse(value);

                response.Add(entity);
            }

            return response;
        }
    }
}

using AutoSystem_KingMe.Models.Common;

namespace AutoSystem_KingMe.Helper
{
    public static class ResponseUtils
    {
        public static GameResponse<TEntity> HandleReponse<TEntity>(this string input) where TEntity : EntityBase, new()
        {
            var response = new GameResponse<TEntity>();
            if (input.StartsWith("ERRO"))
            {
                response.ErrorMessage = input.Substring(4);
                return response;
            }

            var values = input.Split("\r\n");
            foreach (var value in values) {
                var entity = new TEntity();
                entity.FillReponse(value);

                response.Entities.Add(entity);
            }

            return response;
        }
    }
}

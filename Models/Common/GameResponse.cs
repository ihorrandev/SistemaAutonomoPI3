namespace AutoSystem_KingMe.Models.Common
{
    public class GameResponse<TEntity>
    {
        public bool IsSuccess { get => string.IsNullOrWhiteSpace(ErrorMessage); }
        public string? ErrorMessage { get; set; }
        public List<TEntity> Entities { get; set; } = new List<TEntity>();
    }
}

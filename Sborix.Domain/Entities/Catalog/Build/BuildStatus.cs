namespace Entities.Catalog
{
    /// <summary>Статус публикации сборки.</summary>
    public enum BuildStatus
    {
        Draft = 0,      // черновик
        Published = 1,  // опубликована
        Suspended = 2   // снята с публикации
    }
}
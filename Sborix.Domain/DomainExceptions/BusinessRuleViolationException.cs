namespace Entities.DomainExceptions
{
    /// <summary>Нарушено бизнес-правило (например, нельзя отменить активную бронь).</summary>
    public class BusinessRuleViolationException : DomainException
    {
        public BusinessRuleViolationException(string ruleCode, string message)
            : base(message)
        {
            RuleCode = ruleCode;
        }

        /// <summary>Код правила — удобно для поиска в логах и маппинга на HTTP-коды.</summary>
        public string RuleCode { get; }
    }
}
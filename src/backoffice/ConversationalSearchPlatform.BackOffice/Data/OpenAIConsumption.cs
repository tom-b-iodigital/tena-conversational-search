namespace ConversationalSearchPlatform.BackOffice.Data;

public class OpenAIConsumption
{
    public OpenAIConsumption(
        Guid correlationId,
        string tenantId,
        ExecutionType callType,
        ConsumptionModel callModel,
        ConsumptionType usageType,
        int completionTokens,
        int promptTokens,
        DateTimeOffset executedAt, decimal thousandUnitsPromptCost, decimal thousandUnitsCompletionCost, decimal promptTokenCost, decimal completionTokenCost)
    {
        CorrelationId = correlationId;
        TenantId = tenantId;
        CallType = callType;
        CallModel = callModel;
        UsageType = usageType;
        CompletionTokens = completionTokens;
        PromptTokens = promptTokens;
        ExecutedAt = executedAt;
        ThousandUnitsPromptCost = thousandUnitsPromptCost;
        ThousandUnitsCompletionCost = thousandUnitsCompletionCost;
        PromptTokenCost = promptTokenCost;
        CompletionTokenCost = completionTokenCost;
    }

    public Guid Id { get; set; }
    public Guid CorrelationId { get; set; }
    public string TenantId { get; set; }
    public ExecutionType CallType { get; set; }
    public ConsumptionModel CallModel { get; set; }
    public ConsumptionType UsageType { get; set; }
    public int CompletionTokens { get; set; }
    public int PromptTokens { get; set; }

    public decimal ThousandUnitsPromptCost { get; set; }
    public decimal ThousandUnitsCompletionCost { get; set; }
    public decimal PromptTokenCost { get; set; }
    public decimal CompletionTokenCost { get; set; }

    public DateTimeOffset ExecutedAt { get; set; }
}

public enum ExecutionType
{
    GPT,
    Embedding
}

public enum ConsumptionModel
{
    Gpt35Turbo = 350,
    Gpt35Turbo_16K = 352,
    Gpt4 = 400,
    Gpt4_32K = 402,
    Gpt4_turbo = 401,
    AdaTextEmbedding = 002
}

public enum ConsumptionType
{
    Conversation,
    Indexing
}
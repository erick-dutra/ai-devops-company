using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Core.Models.Agents.Tasks;
using AIDevOpsCompany.Core.Services;
using AIDevOpsCompany.Infrastructure.AI;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;

namespace AIDevOpsCompany.Agents.Finance
{
    /// <summary>
    /// Agent responsible for handling finance-related tasks such as invoice generation, expense tracking, payment processing, and financial reporting.
    /// </summary>
    public class FinanceAgent : BaseAgent
    {
        /// <summary>
        /// Service for AI-powered financial data processing.
        /// </summary>
        private readonly IAIService _aiService;

        /// <summary>
        /// Gets the unique identifier for the finance agent.
        /// </summary>
        public override string AgentId => "finance-agent";

        /// <summary>
        /// Gets the role of the agent (Finance).
        /// </summary>
        public override string AgentRole => "Finance";

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceAgent"/> class.
        /// </summary>
        /// <param name="kernel">The semantic kernel for AI operations.</param>
        /// <param name="promptRepository">The prompt repository.</param>
        /// <param name="messageBroker">The message broker for communication.</param>
        /// <param name="logger">The logger instance.</param>
        /// <param name="aiService">The AI service for financial data processing.</param>
        public FinanceAgent(
            Kernel kernel,
            IPromptRepository promptRepository,
            IMessageBroker messageBroker,
            ILogger<FinanceAgent> logger,
            IAIService aiService) : base(kernel, promptRepository, messageBroker, logger)
        {
            _aiService = aiService;
        }

        /// <summary>
        /// Processes a finance task, such as invoice generation, expense tracking, or payment processing.
        /// </summary>
        /// <param name="task">The finance task to process.</param>
        /// <returns>True if the task was processed successfully; otherwise, false.</returns>
        public override async Task<bool> ProcessTaskAsync(AgentTask task)
        {
            var result = await ExecuteTaskAsync(task);
            return result.Success;
        }

        /// <summary>
        /// Executes a finance task and returns the result.
        /// </summary>
        /// <param name="task">The finance task to execute.</param>
        /// <returns>The result of the task execution.</returns>
        public async Task<AgentTaskResult> ExecuteTaskAsync(AgentTask task)
        {
            try
            {
                _logger.LogInformation($"FinanceAgent executando task: {task.TaskType}");
                switch (task.TaskType)
                {
                    case TaskType.GenerateInvoice:
                        return await GenerateInvoiceAsync(task);
                    case TaskType.TrackExpenses:
                        return await TrackExpensesAsync(task);
                    case TaskType.ProcessPayment:
                        return await ProcessPaymentAsync(task);
                    case TaskType.GenerateFinancialReport:
                        return await GenerateFinancialReportAsync(task);
                    case TaskType.ManageBudget:
                        return await ManageBudgetAsync(task);
                    default:
                        throw new NotSupportedException($"Task type {task.TaskType} not supported by FinanceAgent");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro executando task {task.TaskId}");
                return new AgentTaskResult
                {
                    Success = false,
                    Message = $"Erro: {ex.Message}",
                    Data = new Dictionary<string, object> { { "Exception", ex.ToString() } }
                };
            }
        }

        private async Task<AgentTaskResult> GenerateInvoiceAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "finance_generate_invoice");
            var invoicePrompt = $"{prompt?.PromptContent}\n\nInvoice Details:\n{task.Description}";
            var response = await _aiService.ProcessFinancialDataAsync(invoicePrompt, "GenerateInvoice");
            var invoice = ParseInvoice(response);
            var generationResult = await ExecuteInvoiceGenerationAsync(invoice);
            return new AgentTaskResult
            {
                Success = generationResult.Success,
                Message = $"Invoice generated: {invoice.InvoiceNumber}",
                Data = new Dictionary<string, object> { { "Result", generationResult } }
            };
        }

        private async Task<AgentTaskResult> TrackExpensesAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "finance_track_expenses");
            var expensePrompt = $"{prompt?.PromptContent}\n\nExpense Details:\n{task.Description}";
            var response = await _aiService.ProcessFinancialDataAsync(expensePrompt, "TrackExpenses");
            var expenseReport = ParseExpenseReport(response);
            var trackingResult = await ExecuteExpenseTrackingAsync(expenseReport);
            return new AgentTaskResult
            {
                Success = trackingResult.Success,
                Message = $"Expenses tracked: {expenseReport.TotalExpenses} total",
                Data = new Dictionary<string, object> { { "Result", trackingResult } }
            };
        }

        private async Task<AgentTaskResult> ProcessPaymentAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "finance_process_payment");
            var paymentPrompt = $"{prompt?.PromptContent}\n\nPayment Details:\n{task.Description}";
            var response = await _aiService.ProcessFinancialDataAsync(paymentPrompt, "ProcessPayment");
            var paymentDetails = ParsePaymentDetails(response);
            var processingResult = await ExecutePaymentProcessingAsync(paymentDetails);
            return new AgentTaskResult
            {
                Success = processingResult.Success,
                Message = $"Payment processed: {processingResult.TransactionId}",
                Data = new Dictionary<string, object> { { "Result", processingResult } }
            };
        }

        private async Task<AgentTaskResult> GenerateFinancialReportAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "finance_generate_financial_report");
            var reportPrompt = $"{prompt?.PromptContent}\n\nReport Requirements:\n{task.Description}";
            var response = await _aiService.ProcessFinancialDataAsync(reportPrompt, "GenerateFinancialReport");
            var financialReport = ParseFinancialReport(response);
            var reportResult = await ExecuteFinancialReportGenerationAsync(financialReport);
            return new AgentTaskResult
            {
                Success = reportResult.Success,
                Message = $"Financial report generated: {financialReport.ReportType}",
                Data = new Dictionary<string, object> { { "Result", reportResult } }
            };
        }

        private async Task<AgentTaskResult> ManageBudgetAsync(AgentTask task)
        {
            var prompt = await _promptRepository.GetPromptAsync(AgentRole, "finance_manage_budget");
            var budgetPrompt = $"{prompt?.PromptContent}\n\nBudget Details:\n{task.Description}";
            var response = await _aiService.ProcessFinancialDataAsync(budgetPrompt, "ManageBudget");
            var budgetPlan = ParseBudgetPlan(response);
            var budgetResult = await ExecuteBudgetManagementAsync(budgetPlan);
            return new AgentTaskResult
            {
                Success = budgetResult.Success,
                Message = $"Budget management completed: {budgetResult.Status}",
                Data = new Dictionary<string, object> { { "Result", budgetResult } }
            };
        }

        // Helper methods for parsing and execution (simulated)
        private Invoice ParseInvoice(string response)
        {
            return new Invoice
            {
                InvoiceNumber = Guid.NewGuid().ToString(),
                AmountDue = Random.Shared.Next(100, 10000),
                CustomerName = "Simulated Customer"
            };
        }

        private ExpenseReport ParseExpenseReport(string response)
        {
            return new ExpenseReport
            {
                TotalExpenses = Random.Shared.Next(500, 5000),
                Categories = new Dictionary<string, double> { { "Software", 1000 }, { "Cloud Services", 500 } }
            };
        }

        private PaymentDetails ParsePaymentDetails(string response)
        {
            return new PaymentDetails
            {
                TransactionId = Guid.NewGuid().ToString(),
                Amount = Random.Shared.Next(100, 10000)
            };
        }

        private FinancialReport ParseFinancialReport(string response)
        {
            return new FinancialReport
            {
                ReportType = "Quarterly P&L",
                Content = "Simulated financial report content."
            };
        }

        private BudgetPlan ParseBudgetPlan(string response)
        {
            return new BudgetPlan
            {
                Status = "Managed",
                AllocatedAmount = Random.Shared.Next(10000, 100000)
            };
        }

        private async Task<InvoiceGenerationResult> ExecuteInvoiceGenerationAsync(Invoice invoice)
        {
            await Task.Delay(1000);
            return new InvoiceGenerationResult
            {
                Success = true,
                InvoiceNumber = invoice.InvoiceNumber,
                GeneratedAt = DateTime.UtcNow
            };
        }

        private async Task<ExpenseTrackingResult> ExecuteExpenseTrackingAsync(ExpenseReport report)
        {
            await Task.Delay(800);
            return new ExpenseTrackingResult
            {
                Success = true,
                TotalExpenses = report.TotalExpenses,
                TrackedAt = DateTime.UtcNow
            };
        }

        private async Task<PaymentProcessingResult> ExecutePaymentProcessingAsync(PaymentDetails payment)
        {
            await Task.Delay(1200);
            return new PaymentProcessingResult
            {
                Success = true,
                TransactionId = payment.TransactionId,
                ProcessedAt = DateTime.UtcNow
            };
        }

        private async Task<FinancialReportGenerationResult> ExecuteFinancialReportGenerationAsync(FinancialReport report)
        {
            await Task.Delay(2000);
            return new FinancialReportGenerationResult
            {
                Success = true,
                ReportType = report.ReportType,
                GeneratedAt = DateTime.UtcNow
            };
        }

        private async Task<BudgetManagementResult> ExecuteBudgetManagementAsync(BudgetPlan plan)
        {
            await Task.Delay(1500);
            return new BudgetManagementResult
            {
                Success = true,
                Status = plan.Status,
                ManagedAt = DateTime.UtcNow
            };
        }
    }

    // Supporting classes for Finance Agent
    public class Invoice
    {
        public string InvoiceNumber { get; set; } = string.Empty;
        public double AmountDue { get; set; }
        public string CustomerName { get; set; } = string.Empty;
    }

    public class ExpenseReport
    {
        public double TotalExpenses { get; set; }
        public Dictionary<string, double> Categories { get; set; } = new();
    }

    public class PaymentDetails
    {
        public string TransactionId { get; set; } = string.Empty;
        public double Amount { get; set; }
    }

    public class FinancialReport
    {
        public string ReportType { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }

    public class BudgetPlan
    {
        public string Status { get; set; } = string.Empty;
        public double AllocatedAmount { get; set; }
    }

    // Result classes
    public class InvoiceGenerationResult
    {
        public bool Success { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime GeneratedAt { get; set; }
    }

    public class ExpenseTrackingResult
    {
        public bool Success { get; set; }
        public double TotalExpenses { get; set; }
        public DateTime TrackedAt { get; set; }
    }

    public class PaymentProcessingResult
    {
        public bool Success { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public DateTime ProcessedAt { get; set; }
    }

    public class FinancialReportGenerationResult
    {
        public bool Success { get; set; }
        public string ReportType { get; set; } = string.Empty;
        public DateTime GeneratedAt { get; set; }
    }

    public class BudgetManagementResult
    {
        public bool Success { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime ManagedAt { get; set; }
    }
}


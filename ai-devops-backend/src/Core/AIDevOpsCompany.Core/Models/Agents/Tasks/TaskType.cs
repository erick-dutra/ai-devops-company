namespace AIDevOpsCompany.Core.Models.Agents.Tasks
{
    /// <summary>
    /// Types of tasks that can be assigned to agents.
    /// </summary>
    public enum TaskType
    {
        /// <summary>Create a new project.</summary>
        CreateProject,
        /// <summary>Update an existing project.</summary>
        UpdateProject,
        /// <summary>Analyze a project.</summary>
        AnalyzeProject,
        /// <summary>Generate a project plan.</summary>
        GenerateProjectPlan,
        /// <summary>Track project progress.</summary>
        TrackProgress,
        /// <summary>Generate a report.</summary>
        GenerateReport,
        /// <summary>Generate code for a project.</summary>
        GenerateCode,
        /// <summary>Review code for quality and correctness.</summary>
        ReviewCode,
        /// <summary>Refactor code to improve structure.</summary>
        RefactorCode,
        /// <summary>Generate tests for code.</summary>
        GenerateTests,
        /// <summary>Analyze code complexity.</summary>
        AnalyzeComplexity,
        /// <summary>Optimize code performance.</summary>
        OptimizePerformance,
        // FinanceAgent
        /// <summary>Generate an invoice.</summary>
        GenerateInvoice,
        /// <summary>Track project expenses.</summary>
        TrackExpenses,
        /// <summary>Process a payment.</summary>
        ProcessPayment,
        /// <summary>Generate a financial report.</summary>
        GenerateFinancialReport,
        /// <summary>Manage project budget.</summary>
        ManageBudget,
        // QualityAssuranceAgent
        /// <summary>Generate a test plan.</summary>
        GenerateTestPlan,
        /// <summary>Create unit tests.</summary>
        CreateUnitTests,
        /// <summary>Create integration tests.</summary>
        CreateIntegrationTests,
        /// <summary>Execute tests.</summary>
        ExecuteTests,
        /// <summary>Run performance tests.</summary>
        PerformanceTest,
        /// <summary>Run security tests.</summary>
        SecurityTest,
        /// <summary>Perform code review.</summary>
        CodeReview,
        // DevOpsAgent
        /// <summary>Build the application.</summary>
        BuildApplication,
        /// <summary>Deploy the application.</summary>
        DeployApplication,
        /// <summary>Run CI/CD pipeline.</summary>
        RunCICDPipeline,
        /// <summary>Automate tests.</summary>
        AutomateTests,
        /// <summary>Manage configuration.</summary>
        ManageConfiguration,
        /// <summary>Monitor deployment.</summary>
        MonitorDeployment,
        // SecurityAgent
        /// <summary>Analyze vulnerabilities.</summary>
        AnalyzeVulnerabilities,
        /// <summary>Perform security audit.</summary>
        PerformSecurityAudit,
        /// <summary>Manage compliance.</summary>
        ManageCompliance,
        /// <summary>Respond to security incident.</summary>
        RespondToIncident,
        /// <summary>Implement security measures.</summary>
        ImplementSecurityMeasures,
        // HumanResourcesAgent
        /// <summary>Onboard a new agent.</summary>
        OnboardAgent,
        /// <summary>Evaluate agent performance.</summary>
        EvaluatePerformance,
        /// <summary>Provide training to agent.</summary>
        ProvideTraining,
        /// <summary>Manage agent wellbeing.</summary>
        ManageAgentWellbeing,
        /// <summary>Handle disputes involving agents.</summary>
        HandleDisputes,
        // RequirementsAnalysisAgent
        /// <summary>Analyze requirements for a project.</summary>
        AnalyzeRequirements,
        /// <summary>Create user stories based on requirements.</summary>
        CreateUserStories,
        /// <summary>Validate requirements for completeness and clarity.</summary>
        ValidateRequirements,
        /// <summary>Generate acceptance criteria for requirements.</summary>
        GenerateAcceptanceCriteria
    }
}

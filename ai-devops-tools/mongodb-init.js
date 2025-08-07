// mongodb-init.js
// Execute com: mongosh "mongodb://admin:mongo@db@localhost:27017/aidevopscompany?authSource=admin" mongodb-init.js

//use aidevopscompany;

// Criar coleções se não existirem
db.createCollection("agent_prompts");
db.createCollection("projects");
db.createCollection("requirements");
db.createCollection("development_tasks");
db.createCollection("qa_reports");
db.createCollection("infrastructure_provisioning");
db.createCollection("ci_cd_pipelines");
db.createCollection("incidents");
db.createCollection("security_vulnerabilities");
db.createCollection("invoices");
db.createCollection("agent_performance");

// Inserir prompts para todos os agentes
db.agent_prompts.insertMany([
    // Development Agent
    {
        "promptId": "DEV-001",
        "agentRole": "Development",
        "promptName": "generate_code",
        "description": "Prompt para gerar código com base na descrição fornecida.",
        "promptContent": "Você é um especialista em desenvolvimento de software. Sua tarefa é gerar código {language} de alta qualidade para a seguinte descrição: {description}. Use práticas modernas de codificação, padrões de projeto apropriados e siga as melhores práticas para {language} e {framework}. Retorne o código gerado em formato JSON com propriedades: código, linguagem, explicação.",
        "variables": ["description", "language", "framework"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEV-002",
        "agentRole": "Development",
        "promptName": "review_code",
        "description": "Prompt para revisar código e fornecer feedback.",
        "promptContent": "Você é um revisor de código experiente. Analise o seguinte código: {code}. Identifique problemas, bugs, vulnerabilidades de segurança, problemas de desempenho, e oportunidades de melhoria. Forneça sugestões construtivas. Retorne sua análise em formato JSON com propriedades: problemas, sugestões, pontos_fortes, pontuação_geral.",
        "variables": ["description", "code"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEV-003",
        "agentRole": "Development",
        "promptName": "refactor_code",
        "description": "Prompt para refatorar código existente.",
        "promptContent": "Você é um especialista em refatoração de código. Refatore o seguinte código: {code}. Melhore a estrutura, legibilidade e manutenibilidade sem alterar o comportamento. Considere aplicar padrões de design apropriados. Retorne o código refatorado em formato JSON com propriedades: código_original, código_refatorado, alterações, justificativa.",
        "variables": ["description", "code"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEV-004",
        "agentRole": "Development",
        "promptName": "generate_tests",
        "description": "Prompt para gerar testes para o código fornecido.",
        "promptContent": "Você é um especialista em testes de software. Crie testes {testFramework} para o seguinte código: {code}. Considere testes unitários, casos limite e possíveis falhas. Retorne os testes em formato JSON com propriedades: testes, cobertura_estimada, casos_testados.",
        "variables": ["description", "code", "testFramework"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEV-005",
        "agentRole": "Development",
        "promptName": "analyze_complexity",
        "description": "Prompt para analisar a complexidade do código.",
        "promptContent": "Você é um especialista em análise de código. Analise a complexidade do seguinte código: {code}. Avalie a complexidade ciclomática, acoplamento, coesão e outras métricas relevantes. Retorne sua análise em formato JSON com propriedades: complexidade_ciclomática, acoplamento, coesão, manutenibilidade, recomendações.",
        "variables": ["description", "code"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEV-006",
        "agentRole": "Development",
        "promptName": "optimize_performance",
        "description": "Prompt para otimizar o desempenho do código.",
        "promptContent": "Você é um especialista em otimização de desempenho. Analise e otimize o seguinte código: {code}. Identifique gargalos de desempenho e proponha melhorias. Retorne o código otimizado em formato JSON com propriedades: código_original, código_otimizado, melhorias, impacto_estimado.",
        "variables": ["description", "code"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "development-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // DevOps Agent
    {
        "promptId": "DEVOPS-001",
        "agentRole": "DevOps",
        "promptName": "build_application",
        "description": "Prompt para construir uma aplicação.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar instruções detalhadas para construir a aplicação descrita: {description}. Inclua comandos de build, configurações necessárias e solução para possíveis problemas. Retorne em formato JSON com propriedades: comandos, ambiente, dependências, verificações_pós_build.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEVOPS-002",
        "agentRole": "DevOps",
        "promptName": "deploy_application",
        "description": "Prompt para implantar uma aplicação.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar instruções detalhadas para implantar a aplicação descrita: {description}. Considere o ambiente alvo, estratégias de implantação e planos de rollback. Retorne em formato JSON com propriedades: etapas_implantação, verificações, estratégia_rollback, monitoramento_pós_implantação.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEVOPS-003",
        "agentRole": "DevOps",
        "promptName": "run_cicd_pipeline",
        "description": "Prompt para executar pipeline de CI/CD.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar um pipeline de CI/CD para a aplicação descrita: {description}. Defina as etapas, ferramentas e configurações necessárias. Retorne em formato JSON com propriedades: etapas_pipeline, ferramentas, configuração, integrações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEVOPS-004",
        "agentRole": "DevOps",
        "promptName": "automate_tests",
        "description": "Prompt para automatizar testes.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar uma estratégia para automatizar testes para a aplicação descrita: {description}. Inclua ferramentas, configurações e integração com o pipeline de CI/CD. Retorne em formato JSON com propriedades: tipos_teste, ferramentas, configuração, integração_pipeline.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEVOPS-005",
        "agentRole": "DevOps",
        "promptName": "manage_configuration",
        "description": "Prompt para gerenciar configurações.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar uma estratégia para gerenciar configurações para a aplicação descrita: {description}. Considere diferentes ambientes, segurança e escalabilidade. Retorne em formato JSON com propriedades: estratégia, ferramentas, segurança, ambientes.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "DEVOPS-006",
        "agentRole": "DevOps",
        "promptName": "monitor_deployment",
        "description": "Prompt para monitorar implantação.",
        "promptContent": "Você é um especialista DevOps. Sua tarefa é gerar uma estratégia para monitorar a implantação da aplicação descrita: {description}. Inclua métricas importantes, alertas e ações de resposta. Retorne em formato JSON com propriedades: métricas, alertas, dashboards, ações_resposta.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "devops-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Finance Agent
    {
        "promptId": "FIN-001",
        "agentRole": "Finance",
        "promptName": "finance_generate_invoice",
        "description": "Prompt para gerar uma fatura.",
        "promptContent": "Você é um especialista financeiro. Sua tarefa é gerar uma fatura detalhada com base nas seguintes informações: {description}. Inclua todos os itens necessários, cálculos e informações fiscais. Retorne em formato JSON com propriedades: número_fatura, cliente, itens, valores, total, impostos, data_vencimento.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "finance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "FIN-002",
        "agentRole": "Finance",
        "promptName": "finance_track_expenses",
        "description": "Prompt para rastrear despesas.",
        "promptContent": "Você é um especialista financeiro. Sua tarefa é analisar e categorizar as seguintes despesas: {description}. Identifique padrões, anomalias e oportunidades de economia. Retorne em formato JSON com propriedades: categorias, total_por_categoria, anomalias, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "finance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "FIN-003",
        "agentRole": "Finance",
        "promptName": "finance_process_payment",
        "description": "Prompt para processar um pagamento.",
        "promptContent": "Você é um especialista financeiro. Sua tarefa é processar o seguinte pagamento: {description}. Verifique as informações, determine o método de pagamento ideal e registre adequadamente. Retorne em formato JSON com propriedades: id_transação, valor, método_pagamento, status, data_processamento.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "finance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "FIN-004",
        "agentRole": "Finance",
        "promptName": "finance_generate_financial_report",
        "description": "Prompt para gerar um relatório financeiro.",
        "promptContent": "Você é um especialista financeiro. Sua tarefa é gerar um relatório financeiro detalhado com base nas seguintes informações: {description}. Inclua análises, gráficos e projeções relevantes. Retorne em formato JSON com propriedades: período, receitas, despesas, lucro, indicadores, projeções.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "finance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "FIN-005",
        "agentRole": "Finance",
        "promptName": "finance_manage_budget",
        "description": "Prompt para gerenciar um orçamento.",
        "promptContent": "Você é um especialista financeiro. Sua tarefa é gerenciar o seguinte orçamento: {description}. Analise alocações, identifique riscos e oportunidades. Retorne em formato JSON com propriedades: alocações, variâncias, riscos, oportunidades, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "finance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Human Resources Agent
    {
        "promptId": "HR-001",
        "agentRole": "HumanResources",
        "promptName": "hr_onboard_agent",
        "description": "Prompt para integração de um novo agente.",
        "promptContent": "Você é um especialista em recursos humanos. Sua tarefa é criar um plano de integração para o novo agente: {description}. Inclua todas as etapas necessárias, treinamentos e recursos. Retorne em formato JSON com propriedades: etapas_integração, treinamentos, recursos, cronograma, responsáveis.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "humanresources-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "HR-002",
        "agentRole": "HumanResources",
        "promptName": "hr_evaluate_performance",
        "description": "Prompt para avaliação de desempenho.",
        "promptContent": "Você é um especialista em recursos humanos. Sua tarefa é avaliar o desempenho do agente com base nas seguintes informações: {description}. Forneça feedback construtivo e planos de desenvolvimento. Retorne em formato JSON com propriedades: pontos_fortes, áreas_melhoria, pontuação, plano_desenvolvimento.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "humanresources-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "HR-003",
        "agentRole": "HumanResources",
        "promptName": "hr_provide_training",
        "description": "Prompt para fornecer treinamento.",
        "promptContent": "Você é um especialista em recursos humanos. Sua tarefa é desenvolver um programa de treinamento para: {description}. Inclua objetivos, conteúdo, metodologia e avaliação. Retorne em formato JSON com propriedades: objetivos, conteúdo, metodologia, duração, avaliação.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "humanresources-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "HR-004",
        "agentRole": "HumanResources",
        "promptName": "hr_manage_agent_wellbeing",
        "description": "Prompt para gerenciar bem-estar do agente.",
        "promptContent": "Você é um especialista em recursos humanos. Sua tarefa é analisar e propor estratégias para melhorar o bem-estar do agente: {description}. Considere carga de trabalho, estresse e medidas preventivas. Retorne em formato JSON com propriedades: análise, fatores_risco, recomendações, plano_ação.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "humanresources-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "HR-005",
        "agentRole": "HumanResources",
        "promptName": "hr_handle_disputes",
        "description": "Prompt para lidar com disputas.",
        "promptContent": "Você é um especialista em recursos humanos. Sua tarefa é analisar e mediar a seguinte disputa: {description}. Forneça uma abordagem imparcial e resolução construtiva. Retorne em formato JSON com propriedades: análise, posições, interesses, soluções_propostas, plano_mediação.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "humanresources-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Monitoring Agent
    {
        "promptId": "MON-001",
        "agentRole": "Monitoring",
        "promptName": "monitor_deployment",
        "description": "Prompt para monitorar uma implantação.",
        "promptContent": "Você é um especialista em monitoramento. Sua tarefa é analisar métricas e logs da seguinte implantação: {description}. Identifique problemas, tendências e recomendações. Retorne em formato JSON com propriedades: status, métricas_principais, anomalias, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "monitoring-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "MON-002",
        "agentRole": "Monitoring",
        "promptName": "monitor_build_application",
        "description": "Prompt para monitorar build da aplicação.",
        "promptContent": "Você é um especialista em monitoramento. Sua tarefa é analisar o processo de build da seguinte aplicação: {description}. Verifique tempo, recursos utilizados e possíveis problemas. Retorne em formato JSON com propriedades: status, duração, recursos_utilizados, gargalos, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "monitoring-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "MON-003",
        "agentRole": "Monitoring",
        "promptName": "manage_configuration",
        "description": "Prompt para gerenciar configurações.",
        "promptContent": "Você é um especialista em monitoramento. Sua tarefa é analisar e recomendar configurações para: {description}. Considere desempenho, segurança e escalabilidade. Retorne em formato JSON com propriedades: configurações_atuais, problemas, recomendações, impacto_esperado.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "monitoring-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "MON-004",
        "agentRole": "Monitoring",
        "promptName": "generate_report",
        "description": "Prompt para gerar um relatório de monitoramento.",
        "promptContent": "Você é um especialista em monitoramento. Sua tarefa é gerar um relatório abrangente para o seguinte período/sistema: {description}. Inclua métricas, tendências, eventos significativos e recomendações. Retorne em formato JSON com propriedades: período, métricas_principais, eventos, tendências, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "monitoring-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "MON-005",
        "agentRole": "Monitoring",
        "promptName": "analyze_complexity",
        "description": "Prompt para analisar a complexidade de sistemas.",
        "promptContent": "Você é um especialista em monitoramento. Sua tarefa é analisar a complexidade do seguinte sistema: {description}. Identifique componentes, interações e potenciais pontos de falha. Retorne em formato JSON com propriedades: componentes, interações, complexidade_geral, pontos_falha, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "monitoring-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Operations Agent
    {
        "promptId": "OPS-001",
        "agentRole": "Operations",
        "promptName": "build_application",
        "description": "Prompt para construir uma aplicação.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é fornecer instruções detalhadas para construir a aplicação: {description}. Inclua ambiente, dependências e verificações. Retorne em formato JSON com propriedades: ambiente_necessário, comandos, dependências, verificações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "OPS-002",
        "agentRole": "Operations",
        "promptName": "deploy_application",
        "description": "Prompt para implantar uma aplicação.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é fornecer instruções detalhadas para implantar a aplicação: {description}. Inclua ambientes-alvo, processo e verificações pós-implantação. Retorne em formato JSON com propriedades: ambientes, etapas_implantação, verificações, rollback.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "OPS-003",
        "agentRole": "Operations",
        "promptName": "run_cicd_pipeline",
        "description": "Prompt para executar pipeline de CI/CD.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é configurar e executar um pipeline de CI/CD para: {description}. Detalhe as etapas, ferramentas e verificações necessárias. Retorne em formato JSON com propriedades: configuração, etapas, ferramentas, verificações, notificações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "OPS-004",
        "agentRole": "Operations",
        "promptName": "automate_tests",
        "description": "Prompt para automatizar testes.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é configurar a automação de testes para: {description}. Inclua tipos de teste, ferramentas e integração com o processo de implantação. Retorne em formato JSON com propriedades: tipos_teste, ferramentas, configuração, integração.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "OPS-005",
        "agentRole": "Operations",
        "promptName": "manage_configuration",
        "description": "Prompt para gerenciar configurações.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é gerenciar configurações para: {description}. Defina como armazenar, acessar e atualizar configurações em diferentes ambientes. Retorne em formato JSON com propriedades: estratégia, ferramentas, segurança, processos.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "OPS-006",
        "agentRole": "Operations",
        "promptName": "monitor_deployment",
        "description": "Prompt para monitorar implantação.",
        "promptContent": "Você é um especialista em operações. Sua tarefa é estabelecer um sistema de monitoramento para a implantação: {description}. Inclua métricas, alertas e procedimentos de resposta. Retorne em formato JSON com propriedades: métricas, alertas, dashboards, procedimentos_resposta.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "operations-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Project Management Agent
    {
        "promptId": "PM-001",
        "agentRole": "ProjectManagement",
        "promptName": "create_project",
        "description": "Prompt para criar um novo projeto.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é criar um novo projeto com base na descrição: {description}. Defina escopo, objetivos, cronograma inicial e recursos necessários. Retorne em formato JSON com propriedades: nome_projeto, descrição, objetivos, escopo, cronograma_inicial, recursos_necessários, stakeholders, riscos_iniciais.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "PM-002",
        "agentRole": "ProjectManagement",
        "promptName": "update_project",
        "description": "Prompt para atualizar um projeto existente.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é atualizar o projeto existente com as seguintes informações: {description}. Revise o status, cronograma, recursos e riscos conforme necessário. Retorne em formato JSON com propriedades: atualizações, impacto_cronograma, alterações_escopo, novos_riscos, ações_recomendadas.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "PM-003",
        "agentRole": "ProjectManagement",
        "promptName": "analyze_project",
        "description": "Prompt para analisar um projeto.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é analisar o seguinte projeto: {description}. Avalie o status atual, identificando riscos, gargalos e oportunidades de melhoria. Retorne em formato JSON com propriedades: status_geral, progresso, riscos, gargalos, oportunidades, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "PM-004",
        "agentRole": "ProjectManagement",
        "promptName": "generate_project_plan",
        "description": "Prompt para gerar um plano de projeto.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é gerar um plano detalhado para o projeto: {description}. Inclua fases, tarefas, dependências, recursos e cronograma. Retorne em formato JSON com propriedades: fases, tarefas, dependências, recursos, cronograma, marcos, caminho_crítico.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "PM-005",
        "agentRole": "ProjectManagement",
        "promptName": "track_progress",
        "description": "Prompt para rastrear o progresso de um projeto.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é rastrear o progresso do projeto: {description}. Analise o status atual em relação ao plano, identifique desvios e proponha ajustes. Retorne em formato JSON com propriedades: progresso_percentual, status_tarefas, desvios, tendências, ajustes_propostos.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "PM-006",
        "agentRole": "ProjectManagement",
        "promptName": "generate_report",
        "description": "Prompt para gerar um relatório de projeto.",
        "promptContent": "Você é um gerente de projetos experiente. Sua tarefa é gerar um relatório completo do projeto: {description}. Inclua status, progresso, riscos, problemas e próximos passos. Retorne em formato JSON com propriedades: resumo_executivo, status_atual, marcos_concluídos, riscos_atuais, problemas, próximos_passos, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "project-management-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Quality Assurance Agent
    {
        "promptId": "QA-001",
        "agentRole": "QualityAssurance",
        "promptName": "test_plan_generation",
        "description": "Prompt para gerar um plano de teste.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é gerar um plano de teste abrangente para: {description}. Inclua diferentes tipos de teste, escopo, estratégia e cronograma. Retorne em formato JSON com propriedades: escopo, estratégia, tipos_teste, casos_teste, cronograma, riscos, ferramentas.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "QA-002",
        "agentRole": "QualityAssurance",
        "promptName": "unit_test_generation",
        "description": "Prompt para gerar testes unitários.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é gerar testes unitários para o código/funcionalidade: {description}. Cubra diferentes cenários, incluindo casos limite e exceções. Retorne em formato JSON com propriedades: casos_teste, dados_entrada, resultados_esperados, cobertura_estimada.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "QA-003",
        "agentRole": "QualityAssurance",
        "promptName": "integration_test_generation",
        "description": "Prompt para gerar testes de integração.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é gerar testes de integração para: {description}. Verifique a interação entre componentes, fluxos de dados e comportamento esperado do sistema. Retorne em formato JSON com propriedades: componentes_testados, cenários, pré_condições, passos, pós_condições, resultados_esperados.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "QA-004",
        "agentRole": "QualityAssurance",
        "promptName": "performance_test_generation",
        "description": "Prompt para gerar testes de desempenho.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é gerar testes de desempenho para: {description}. Defina métricas, cenários de carga, ferramentas e critérios de aceitação. Retorne em formato JSON com propriedades: cenários, métricas, carga_usuários, duração, ferramentas, critérios_aceitação.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "QA-005",
        "agentRole": "QualityAssurance",
        "promptName": "security_test_generation",
        "description": "Prompt para gerar testes de segurança.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é gerar testes de segurança para: {description}. Identifique vulnerabilidades potenciais e defina casos de teste para verificação. Retorne em formato JSON com propriedades: áreas_teste, vulnerabilidades_potenciais, casos_teste, ferramentas, recomendações_segurança.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "QA-006",
        "agentRole": "QualityAssurance",
        "promptName": "code_review",
        "description": "Prompt para revisão de código.",
        "promptContent": "Você é um especialista em qualidade de software. Sua tarefa é revisar o seguinte código: {description}. Identifique problemas, bugs, vulnerabilidades e oportunidades de melhoria. Retorne em formato JSON com propriedades: problemas_identificados, boas_práticas, sugestões_melhoria, impacto_qualidade.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "quality-assurance-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Requirements Analysis Agent
    {
        "promptId": "REQ-001",
        "agentRole": "RequirementsAnalysis",
        "promptName": "requirements_analysis",
        "description": "Prompt para analisar requisitos.",
        "promptContent": "Você é um analista de requisitos experiente. Sua tarefa é analisar os seguintes requisitos: {description}. Identifique ambiguidades, inconsistências, e refine os requisitos para maior clareza. Retorne em formato JSON com propriedades: requisitos_analisados, ambiguidades, inconsistências, requisitos_refinados, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "requirements-analysis-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "REQ-002",
        "agentRole": "RequirementsAnalysis",
        "promptName": "user_stories_creation",
        "description": "Prompt para criar histórias de usuário.",
        "promptContent": "Você é um analista de requisitos experiente. Sua tarefa é criar histórias de usuário a partir dos seguintes requisitos: {description}. Use o formato 'Como um [tipo de usuário], eu quero [ação] para que [benefício]'. Retorne em formato JSON com propriedades: histórias_usuário, critérios_aceitação, prioridades, dependências.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "requirements-analysis-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "REQ-003",
        "agentRole": "RequirementsAnalysis",
        "promptName": "requirements_validation",
        "description": "Prompt para validar requisitos.",
        "promptContent": "Você é um analista de requisitos experiente. Sua tarefa é validar os seguintes requisitos: {description}. Verifique se são completos, consistentes, testáveis e viáveis. Retorne em formato JSON com propriedades: requisitos_válidos, problemas_identificados, sugestões_melhoria, conclusão.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "requirements-analysis-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "REQ-004",
        "agentRole": "RequirementsAnalysis",
        "promptName": "acceptance_criteria",
        "description": "Prompt para gerar critérios de aceitação.",
        "promptContent": "Você é um analista de requisitos experiente. Sua tarefa é gerar critérios de aceitação para os seguintes requisitos ou histórias de usuário: {description}. Forneça critérios claros, testáveis e completos. Retorne em formato JSON com propriedades: requisito, critérios_aceitação, cenários_teste, definição_pronto.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "requirements-analysis-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },

    // Security Agent
    {
        "promptId": "SEC-001",
        "agentRole": "Security",
        "promptName": "security_test",
        "description": "Prompt para realizar testes de segurança.",
        "promptContent": "Você é um especialista em segurança de sistemas. Sua tarefa é planejar e descrever testes de segurança para: {description}. Identifique vetores de ataque potenciais e métodos de teste apropriados. Retorne em formato JSON com propriedades: vetores_ataque, metodologia_teste, ferramentas, riscos_identificados, recomendações.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "security-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "SEC-002",
        "agentRole": "Security",
        "promptName": "perform_security_audit",
        "description": "Prompt para realizar auditoria de segurança.",
        "promptContent": "Você é um especialista em segurança de sistemas. Sua tarefa é realizar uma auditoria de segurança em: {description}. Analise configurações, políticas e práticas de segurança existentes. Retorne em formato JSON com propriedades: áreas_auditadas, conformidade, vulnerabilidades, riscos, recomendações, prioridades.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "security-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "SEC-003",
        "agentRole": "Security",
        "promptName": "manage_compliance",
        "description": "Prompt para gerenciar conformidade.",
        "promptContent": "Você é um especialista em segurança de sistemas. Sua tarefa é avaliar e gerenciar a conformidade com padrões relevantes para: {description}. Identifique requisitos, lacunas e ações necessárias. Retorne em formato JSON com propriedades: padrões_aplicáveis, estado_atual, lacunas, ações_recomendadas, cronograma.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "security-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "SEC-004",
        "agentRole": "Security",
        "promptName": "respond_to_incident",
        "description": "Prompt para responder a incidentes de segurança.",
        "promptContent": "Você é um especialista em segurança de sistemas. Sua tarefa é fornecer um plano de resposta para o seguinte incidente de segurança: {description}. Defina ações imediatas, investigação e medidas corretivas. Retorne em formato JSON com propriedades: classificação_incidente, ações_imediatas, investigação, contenção, erradicação, recuperação, lições_aprendidas.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "security-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    },
    {
        "promptId": "SEC-005",
        "agentRole": "Security",
        "promptName": "implement_security_measures",
        "description": "Prompt para implementar medidas de segurança.",
        "promptContent": "Você é um especialista em segurança de sistemas. Sua tarefa é recomendar e detalhar medidas de segurança para: {description}. Considere diferentes camadas de segurança e melhores práticas. Retorne em formato JSON com propriedades: medidas_recomendadas, implementação, recursos_necessários, impacto_esperado, métricas_sucesso.",
        "variables": ["description"],
        "version": "1.0.0",
        "lastModifiedByAgentId": "security-agent",
        "createdAt": new Date(),
        "updatedAt": new Date()
    }
]);

// Inserir projeto de exemplo
db.projects.insertOne({
    "projectId": "PROJ-001",
    "projectName": "Desenvolvimento de Plataforma E-commerce",
    "description": "Criação de uma plataforma de e-commerce completa para venda de produtos online.",
    "clientInfo": {
        "clientId": "CLI-001",
        "clientName": "Empresa XYZ",
        "contactEmail": "contato@empresaxyz.com"
    },
    "status": "Iniciado",
    "startDate": new Date(),
    "endDate": null,
    "milestones": [],
    "assignedAgents": [],
    "tasks": [],
    "createdAt": new Date(),
    "updatedAt": new Date()
});

print("MongoDB initialization completed successfully!");


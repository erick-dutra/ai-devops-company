# AI DevOps API Documentation

This document provides structured, tabular documentation for all controllers and endpoints in the API layer of the AI DevOps backend project.

---

## PromptsController

| Route | HTTP Verb | Action | Parameters | Returns | Description |
|-------|-----------|--------|------------|---------|-------------|
| `/api/prompts/{agentRole}` | GET | GetPromptsForAgent | `agentRole: string` | `List<AgentPrompt>` | Gets all prompts for a specific agent role. |
| `/api/prompts/{agentRole}/{promptName}` | GET | GetPrompt | `agentRole: string`, `promptName: string` | `AgentPrompt` | Gets a specific prompt for an agent role by prompt name. |
| `/api/prompts` | POST | CreatePrompt | `prompt: AgentPrompt` (body) | `ActionResult` | Creates a new prompt. |
| `/api/prompts/{promptId}` | PUT | UpdatePrompt | `promptId: string`, `prompt: AgentPrompt` (body) | `ActionResult` | Updates an existing prompt by its ID. |

---

*Last updated: 2025-06-19*

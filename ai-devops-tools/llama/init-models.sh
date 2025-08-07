#!/bin/bash

# Script to initialize LLAMA models for AI DevOps Company
# This script should be run after the LLAMA container is up and running

echo "Initializing LLAMA models for AI DevOps Company..."

# Wait for LLAMA service to be ready
echo "Waiting for LLAMA service to be ready..."
until curl -f http://localhost:11434/api/tags > /dev/null 2>&1; do
    echo "LLAMA service not ready yet, waiting..."
    sleep 10
done

echo "LLAMA service is ready!"

# Pull required models
echo "Pulling required models..."

# Code generation model
echo "Pulling CodeLlama model for code generation..."
curl -X POST http://localhost:11434/api/pull -d '{"name": "codellama:7b"}'

# General purpose model
echo "Pulling Llama2 model for general tasks..."
curl -X POST http://localhost:11434/api/pull -d '{"name": "llama2:7b"}'

# Smaller model for quick responses
echo "Pulling Llama2 13B model for complex reasoning..."
curl -X POST http://localhost:11434/api/pull -d '{"name": "llama2:13b"}'

# Specialized models
echo "Pulling Mistral model for advanced reasoning..."
curl -X POST http://localhost:11434/api/pull -d '{"name": "mistral:7b"}'

echo "All models have been pulled successfully!"

# Create model configurations
echo "Creating model configurations..."

# Configuration for different agent types
cat > /models/agent-configs.json << EOF
{
  "project-management": {
    "model": "llama2:7b",
    "temperature": 0.3,
    "max_tokens": 2048,
    "system_prompt": "You are a project management AI agent specialized in software development projects."
  },
  "requirements-analysis": {
    "model": "llama2:13b",
    "temperature": 0.2,
    "max_tokens": 4096,
    "system_prompt": "You are a requirements analysis AI agent specialized in understanding and documenting software requirements."
  },
  "development": {
    "model": "codellama:7b",
    "temperature": 0.1,
    "max_tokens": 8192,
    "system_prompt": "You are a software development AI agent specialized in writing high-quality code."
  },
  "qa": {
    "model": "llama2:7b",
    "temperature": 0.2,
    "max_tokens": 4096,
    "system_prompt": "You are a quality assurance AI agent specialized in testing and quality control."
  },
  "operations": {
    "model": "mistral:7b",
    "temperature": 0.3,
    "max_tokens": 2048,
    "system_prompt": "You are an operations AI agent specialized in system administration and infrastructure management."
  },
  "devops": {
    "model": "mistral:7b",
    "temperature": 0.2,
    "max_tokens": 4096,
    "system_prompt": "You are a DevOps AI agent specialized in CI/CD, automation, and deployment."
  },
  "monitoring": {
    "model": "llama2:7b",
    "temperature": 0.3,
    "max_tokens": 2048,
    "system_prompt": "You are a monitoring AI agent specialized in system monitoring and alerting."
  },
  "security": {
    "model": "llama2:13b",
    "temperature": 0.1,
    "max_tokens": 4096,
    "system_prompt": "You are a security AI agent specialized in cybersecurity and vulnerability assessment."
  },
  "finance": {
    "model": "llama2:7b",
    "temperature": 0.2,
    "max_tokens": 2048,
    "system_prompt": "You are a finance AI agent specialized in financial management and billing."
  },
  "hr": {
    "model": "llama2:7b",
    "temperature": 0.3,
    "max_tokens": 2048,
    "system_prompt": "You are an HR AI agent specialized in human resources and performance management."
  }
}
EOF

echo "Model configurations created successfully!"
echo "LLAMA initialization complete!"


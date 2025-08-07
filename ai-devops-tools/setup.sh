#!/bin/bash

# AI DevOps Company - Environment Setup Script
# This script initializes the complete development environment

set -e

echo "🚀 Starting AI DevOps Company Environment Setup..."

# Check if Docker and Docker Compose are installed
if ! command -v docker &> /dev/null; then
    echo "❌ Docker is not installed. Please install Docker first."
    exit 1
fi

if ! command -v docker-compose &> /dev/null; then
    echo "❌ Docker Compose is not installed. Please install Docker Compose first."
    exit 1
fi

# Load environment variables
if [ -f .env ]; then
    echo "📋 Loading environment variables from .env file..."
    export $(cat .env | grep -v '^#' | xargs)
else
    echo "⚠️  No .env file found. Using default values."
fi

# Create necessary directories
echo "📁 Creating necessary directories..."
mkdir -p logs data/mongodb data/rabbitmq data/redis data/elasticsearch data/prometheus data/grafana

# Set proper permissions
echo "🔐 Setting proper permissions..."
chmod -R 755 logs data
chmod +x llama/init-models.sh

# Pull latest images
echo "📥 Pulling latest Docker images..."
docker-compose pull

# Start infrastructure services first
echo "🏗️  Starting infrastructure services..."
docker-compose up -d mongodb rabbitmq redis elasticsearch

# Wait for services to be ready
echo "⏳ Waiting for infrastructure services to be ready..."
sleep 30

# Check MongoDB
echo "🔍 Checking MongoDB connection..."
until docker-compose exec -T mongodb mongosh --eval "db.adminCommand('ping')" > /dev/null 2>&1; do
    echo "   MongoDB not ready yet, waiting..."
    sleep 5
done
echo "✅ MongoDB is ready!"

# Check RabbitMQ
echo "🔍 Checking RabbitMQ connection..."
until docker-compose exec -T rabbitmq rabbitmq-diagnostics ping > /dev/null 2>&1; do
    echo "   RabbitMQ not ready yet, waiting..."
    sleep 5
done
echo "✅ RabbitMQ is ready!"

# Start monitoring services
echo "📊 Starting monitoring services..."
docker-compose up -d prometheus grafana kibana

# Start LLAMA service
echo "🦙 Starting LLAMA service..."
docker-compose up -d llama

# Wait for LLAMA to be ready
echo "⏳ Waiting for LLAMA service to be ready..."
sleep 60

# Initialize LLAMA models
echo "🤖 Initializing LLAMA models..."
docker-compose exec -T llama /bin/bash -c "cd /models && /models/init-models.sh" || echo "⚠️  LLAMA model initialization failed, but continuing..."

# Build and start the API
echo "🔨 Building and starting the API..."
docker-compose up -d --build aidevops-api

# Wait for API to be ready
echo "⏳ Waiting for API to be ready..."
sleep 30

# Health check
echo "🏥 Performing health checks..."

# Check API health
if curl -f http://localhost:8080/health > /dev/null 2>&1; then
    echo "✅ API is healthy!"
else
    echo "⚠️  API health check failed, but continuing..."
fi

# Display service URLs
echo ""
echo "🎉 AI DevOps Company Environment is ready!"
echo ""
echo "📋 Service URLs:"
echo "   🌐 API:              http://localhost:8080"
echo "   📊 Grafana:          http://localhost:3000 (admin/aidevops123)"
echo "   🐰 RabbitMQ:         http://localhost:15672 (admin/aidevops123)"
echo "   📈 Prometheus:       http://localhost:9090"
echo "   🔍 Kibana:           http://localhost:5601"
echo "   🦙 LLAMA:            http://localhost:11434"
echo "   🗄️  MongoDB:          mongodb://admin:aidevops123@localhost:27017/aidevopscompany"
echo "   🔴 Redis:            redis://localhost:6379"
echo ""
echo "📚 Documentation:"
echo "   📖 API Docs:         http://localhost:8080/swagger"
echo "   📋 Health Check:     http://localhost:8080/health"
echo ""
echo "🔧 Management Commands:"
echo "   docker-compose logs [service]     - View logs"
echo "   docker-compose stop               - Stop all services"
echo "   docker-compose down               - Stop and remove containers"
echo "   docker-compose down -v            - Stop, remove containers and volumes"
echo ""
echo "✨ Happy coding with AI DevOps Company!"


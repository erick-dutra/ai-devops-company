import { useState, useEffect } from 'react'
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card'
import { Badge } from '@/components/ui/badge'
import { Progress } from '@/components/ui/progress'
import { 
  LineChart, 
  Line, 
  AreaChart, 
  Area, 
  BarChart, 
  Bar, 
  PieChart, 
  Pie, 
  Cell,
  XAxis, 
  YAxis, 
  CartesianGrid, 
  Tooltip, 
  Legend, 
  ResponsiveContainer 
} from 'recharts'
import {
  Activity,
  Bot,
  Code,
  DollarSign,
  Server,
  Shield,
  TrendingUp,
  Users,
  AlertTriangle,
  CheckCircle,
  Clock,
  Zap
} from 'lucide-react'

export function Dashboard() {
  const [metrics, setMetrics] = useState({
    activeAgents: 10,
    completedTasks: 1247,
    activeProjects: 23,
    systemUptime: 99.8,
    monthlyRevenue: 125000,
    securityIncidents: 2,
    codeQuality: 94,
    deploymentSuccess: 98.5
  })

  // Mock data for charts
  const performanceData = [
    { name: 'Jan', tasks: 400, revenue: 24000, quality: 92 },
    { name: 'Fev', tasks: 300, revenue: 13980, quality: 94 },
    { name: 'Mar', tasks: 200, revenue: 98000, quality: 91 },
    { name: 'Abr', tasks: 278, revenue: 39080, quality: 95 },
    { name: 'Mai', tasks: 189, revenue: 48000, quality: 93 },
    { name: 'Jun', tasks: 239, revenue: 38000, quality: 96 },
  ]

  const agentActivityData = [
    { name: 'Gestão de Projetos', value: 15, color: '#8884d8' },
    { name: 'Desenvolvimento', value: 25, color: '#82ca9d' },
    { name: 'QA', value: 20, color: '#ffc658' },
    { name: 'DevOps', value: 18, color: '#ff7300' },
    { name: 'Segurança', value: 12, color: '#00ff88' },
    { name: 'Outros', value: 10, color: '#ff0088' },
  ]

  const systemHealthData = [
    { name: '00:00', cpu: 45, memory: 62, network: 23 },
    { name: '04:00', cpu: 52, memory: 58, network: 31 },
    { name: '08:00', cpu: 78, memory: 71, network: 45 },
    { name: '12:00', cpu: 85, memory: 79, network: 52 },
    { name: '16:00', cpu: 92, memory: 83, network: 48 },
    { name: '20:00', cpu: 67, memory: 65, network: 35 },
  ]

  const recentActivities = [
    { id: 1, type: 'success', message: 'Agente de Desenvolvimento completou geração de código', time: '2 min atrás', icon: Code },
    { id: 2, type: 'info', message: 'Novo projeto criado: E-commerce Platform', time: '5 min atrás', icon: Bot },
    { id: 3, type: 'warning', message: 'Alto uso de CPU detectado no servidor de produção', time: '8 min atrás', icon: Server },
    { id: 4, type: 'success', message: 'Deploy realizado com sucesso na aplicação principal', time: '12 min atrás', icon: CheckCircle },
    { id: 5, type: 'info', message: 'Análise de segurança iniciada pelo agente de Security', time: '15 min atrás', icon: Shield },
  ]

  const getActivityIcon = (type) => {
    switch (type) {
      case 'success': return <CheckCircle className="h-4 w-4 text-green-500" />
      case 'warning': return <AlertTriangle className="h-4 w-4 text-yellow-500" />
      case 'error': return <AlertTriangle className="h-4 w-4 text-red-500" />
      default: return <Activity className="h-4 w-4 text-blue-500" />
    }
  }

  return (
    <div className="space-y-6">
      {/* Header */}
      <div>
        <h2 className="text-3xl font-bold tracking-tight">Dashboard</h2>
        <p className="text-muted-foreground">
          Visão geral do sistema e métricas em tempo real
        </p>
      </div>

      {/* Key Metrics */}
      <div className="grid gap-4 md:grid-cols-2 lg:grid-cols-4">
        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Agentes Ativos</CardTitle>
            <Bot className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.activeAgents}</div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">+2</span> desde ontem
            </p>
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Tarefas Completadas</CardTitle>
            <CheckCircle className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.completedTasks.toLocaleString()}</div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">+12%</span> desde o mês passado
            </p>
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Projetos Ativos</CardTitle>
            <Activity className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.activeProjects}</div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">+3</span> novos esta semana
            </p>
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Receita Mensal</CardTitle>
            <DollarSign className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">
              R$ {metrics.monthlyRevenue.toLocaleString()}
            </div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">+8%</span> desde o mês passado
            </p>
          </CardContent>
        </Card>
      </div>

      {/* Charts Row */}
      <div className="grid gap-4 md:grid-cols-2 lg:grid-cols-7">
        {/* Performance Overview */}
        <Card className="col-span-4">
          <CardHeader>
            <CardTitle>Performance Geral</CardTitle>
            <CardDescription>
              Tarefas completadas, receita e qualidade do código ao longo do tempo
            </CardDescription>
          </CardHeader>
          <CardContent className="pl-2">
            <ResponsiveContainer width="100%" height={350}>
              <LineChart data={performanceData}>
                <CartesianGrid strokeDasharray="3 3" />
                <XAxis dataKey="name" />
                <YAxis />
                <Tooltip />
                <Legend />
                <Line 
                  type="monotone" 
                  dataKey="tasks" 
                  stroke="#8884d8" 
                  strokeWidth={2}
                  name="Tarefas"
                />
                <Line 
                  type="monotone" 
                  dataKey="quality" 
                  stroke="#82ca9d" 
                  strokeWidth={2}
                  name="Qualidade (%)"
                />
              </LineChart>
            </ResponsiveContainer>
          </CardContent>
        </Card>

        {/* Agent Activity Distribution */}
        <Card className="col-span-3">
          <CardHeader>
            <CardTitle>Atividade dos Agentes</CardTitle>
            <CardDescription>
              Distribuição de tarefas por tipo de agente
            </CardDescription>
          </CardHeader>
          <CardContent>
            <ResponsiveContainer width="100%" height={350}>
              <PieChart>
                <Pie
                  data={agentActivityData}
                  cx="50%"
                  cy="50%"
                  labelLine={false}
                  label={({ name, percent }) => `${name} ${(percent * 100).toFixed(0)}%`}
                  outerRadius={80}
                  fill="#8884d8"
                  dataKey="value"
                >
                  {agentActivityData.map((entry, index) => (
                    <Cell key={`cell-${index}`} fill={entry.color} />
                  ))}
                </Pie>
                <Tooltip />
              </PieChart>
            </ResponsiveContainer>
          </CardContent>
        </Card>
      </div>

      {/* System Health and Recent Activity */}
      <div className="grid gap-4 md:grid-cols-2">
        {/* System Health */}
        <Card>
          <CardHeader>
            <CardTitle>Saúde do Sistema</CardTitle>
            <CardDescription>
              Monitoramento de recursos em tempo real
            </CardDescription>
          </CardHeader>
          <CardContent>
            <div className="space-y-4">
              <div className="space-y-2">
                <div className="flex items-center justify-between">
                  <span className="text-sm font-medium">CPU</span>
                  <span className="text-sm text-muted-foreground">67%</span>
                </div>
                <Progress value={67} className="w-full" />
              </div>
              
              <div className="space-y-2">
                <div className="flex items-center justify-between">
                  <span className="text-sm font-medium">Memória</span>
                  <span className="text-sm text-muted-foreground">65%</span>
                </div>
                <Progress value={65} className="w-full" />
              </div>
              
              <div className="space-y-2">
                <div className="flex items-center justify-between">
                  <span className="text-sm font-medium">Rede</span>
                  <span className="text-sm text-muted-foreground">35%</span>
                </div>
                <Progress value={35} className="w-full" />
              </div>

              <div className="space-y-2">
                <div className="flex items-center justify-between">
                  <span className="text-sm font-medium">Uptime</span>
                  <Badge variant="secondary">{metrics.systemUptime}%</Badge>
                </div>
              </div>
            </div>
          </CardContent>
        </Card>

        {/* Recent Activity */}
        <Card>
          <CardHeader>
            <CardTitle>Atividade Recente</CardTitle>
            <CardDescription>
              Últimas ações dos agentes no sistema
            </CardDescription>
          </CardHeader>
          <CardContent>
            <div className="space-y-4">
              {recentActivities.map((activity) => (
                <div key={activity.id} className="flex items-start space-x-3">
                  {getActivityIcon(activity.type)}
                  <div className="flex-1 space-y-1">
                    <p className="text-sm">{activity.message}</p>
                    <p className="text-xs text-muted-foreground">{activity.time}</p>
                  </div>
                </div>
              ))}
            </div>
          </CardContent>
        </Card>
      </div>

      {/* Quick Stats */}
      <div className="grid gap-4 md:grid-cols-4">
        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Qualidade do Código</CardTitle>
            <Code className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.codeQuality}%</div>
            <Progress value={metrics.codeQuality} className="mt-2" />
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Sucesso em Deploys</CardTitle>
            <Zap className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.deploymentSuccess}%</div>
            <Progress value={metrics.deploymentSuccess} className="mt-2" />
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Incidentes de Segurança</CardTitle>
            <Shield className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">{metrics.securityIncidents}</div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">-50%</span> desde o mês passado
            </p>
          </CardContent>
        </Card>

        <Card>
          <CardHeader className="flex flex-row items-center justify-between space-y-0 pb-2">
            <CardTitle className="text-sm font-medium">Tempo Médio de Resposta</CardTitle>
            <Clock className="h-4 w-4 text-muted-foreground" />
          </CardHeader>
          <CardContent>
            <div className="text-2xl font-bold">1.2s</div>
            <p className="text-xs text-muted-foreground">
              <span className="text-green-600">-15%</span> melhoria
            </p>
          </CardContent>
        </Card>
      </div>
    </div>
  )
}

